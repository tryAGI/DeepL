# Combining Search + Translation Tools

One of the key advantages of the MEAI `AIFunction` pattern is that tools from different SDKs can be combined in a single `ChatOptions.Tools` list. This lets an AI model search the web and translate results in one conversation.

## Search + Translate with Exa

```csharp
using Microsoft.Extensions.AI;
using DeepL;
using Exa;

var deepLClient = new DeepLClient(
    apiKey: Environment.GetEnvironmentVariable("DEEPL_API_KEY")!);
var exaClient = new ExaClient(
    apiKey: Environment.GetEnvironmentVariable("EXA_API_KEY")!);

IChatClient chatClient = /* your chat client (OpenAI, Anthropic, etc.) */;

var options = new ChatOptions
{
    Tools =
    [
        // Exa search tools
        exaClient.AsSearchTool(numResults: 3),
        exaClient.AsGetContentsTool(),

        // DeepL translation tool
        deepLClient.AsTranslateTool(),
    ],
};

var messages = new List<ChatMessage>
{
    new(ChatRole.User,
        "Search for recent news about renewable energy in Germany, then translate the key findings to English."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```

## News Search + Translation with Serper

```csharp
using Microsoft.Extensions.AI;
using DeepL;
using Serper;

var deepLClient = new DeepLClient(
    apiKey: Environment.GetEnvironmentVariable("DEEPL_API_KEY")!);
var serperClient = new SerperClient(
    apiKey: Environment.GetEnvironmentVariable("SERPER_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        // Serper search + news tools
        serperClient.AsSearchTool(numResults: 5),
        serperClient.AsNewsTool(numResults: 5),

        // DeepL translation + rephrasing tools
        deepLClient.AsTranslateTool(),
        deepLClient.AsRephraseTool(),
    ],
};
```

## Full Research Pipeline

Combine all available tools for a complete multilingual research workflow:

```csharp
var options = new ChatOptions
{
    Tools =
    [
        // Search (pick one or more)
        exaClient.AsSearchTool(numResults: 5),
        exaClient.AsGetContentsTool(),
        exaClient.AsAnswerTool(),
        serperClient.AsNewsTool(numResults: 5),

        // Translation & writing
        deepLClient.AsTranslateTool(formality: Formality.More),
        deepLClient.AsRephraseTool(
            writingStyle: WritingStyle.Business,
            tone: WritingTone.Confident),
    ],
};

var response = await chatClient.GetResponseAsync(
    "Find the latest EU regulations on AI, translate the key points to Japanese, " +
    "and rephrase them in a business-friendly tone.",
    options);
```

## Installation

To use all three SDKs together:

```bash
dotnet add package DeepL
dotnet add package Exa
dotnet add package Serper
```

Each SDK is independent — add only the ones you need. All tools implement `AIFunction` from `Microsoft.Extensions.AI` and work with any `IChatClient`.
