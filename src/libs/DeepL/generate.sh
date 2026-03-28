#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://raw.githubusercontent.com/DeepLcom/openapi/main/openapi.yaml

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://raw.githubusercontent.com/DeepLcom/openapi/main/openapi.yaml

# Fix codegen: replace allOf-wrapping-string schemas with plain string type
# (AutoSDK generates `string` as a C# property name which is a reserved keyword)
yq -i '
  .components.schemas.SplittingTagCommaSeparatedList = {"type": "string", "description": "Comma-separated list of XML tags which always cause splits."} |
  .components.schemas.NonSplittingTagCommaSeparatedList = {"type": "string", "description": "Comma-separated list of XML tags which never cause splits."} |
  .components.schemas.IgnoreTagCommaSeparatedList = {"type": "string", "description": "Comma-separated list of XML tags that indicate text not to be translated."} |
  .components.schemas.SplittingTagList = {"type": "array", "items": {"type": "string"}, "description": "List of XML tags which always cause splits."} |
  .components.schemas.NonSplittingTagList = {"type": "array", "items": {"type": "string"}, "description": "List of XML tags which never cause splits."} |
  .components.schemas.IgnoreTagList = {"type": "array", "items": {"type": "string"}, "description": "List of XML tags that indicate text not to be translated."}
' openapi.yaml

# Fix codegen: rename enum values that produce case-insensitive PascalCase collisions (CS3005)
# "per_cento" vs "percento" both become "PerCento"/"Percento" (differ only in case)
# "per_cent" vs "percent" both become "PerCent"/"Percent" (differ only in case)
# Rename the single-word variants to include "single_word" disambiguator
sed \
  -e 's/italian_word_percento/italian_single_word_percento/g' \
  -e 's/spell_out_percent/spell_out_single_word_percent/g' \
  openapi.yaml > openapi.yaml.tmp && mv openapi.yaml.tmp openapi.yaml

# Auth: --security-scheme overrides the spec's apiKey auth with HTTP bearer.
# DeepL uses 'Authorization: DeepL-Auth-Key <key>' — DeepLClient.Auth.cs rewrites Bearer → DeepL-Auth-Key.
autosdk generate openapi.yaml \
  --namespace DeepL \
  --clientClassName DeepLClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
