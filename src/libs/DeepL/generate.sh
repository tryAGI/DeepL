#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://raw.githubusercontent.com/DeepLcom/openapi/main/openapi.yaml
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error -L -o openapi.yaml https://raw.githubusercontent.com/DeepLcom/openapi/main/openapi.yaml

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

# Auth: --security-scheme overrides the spec's apiKey auth with HTTP bearer.
# DeepL uses 'Authorization: DeepL-Auth-Key <key>' — DeepLClient.Auth.cs rewrites Bearer → DeepL-Auth-Key.
autosdk generate openapi.yaml \
  --namespace DeepL \
  --clientClassName DeepLClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
