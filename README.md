[![](https://img.shields.io/nuget/v/soenneker.attributes.llms.properties.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.llms.properties/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.llms.properties/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.llms.properties/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.attributes.llms.properties.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.llms.properties/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.llms.properties/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.llms.properties/actions/workflows/codeql.yml)

# Soenneker.Attributes.Llms.Properties

An attribute for describing properties to LLMs.

## Install

```bash
dotnet add package Soenneker.Attributes.Llms.Properties
```

## Quick start

```csharp
using Soenneker.Attributes.Llms.Properties;

public sealed class Request
{
    [LlmProperty]
    public string? Value { get; init; }
}
```

An attribute for describing properties to LLMs.

## What you get

- `LlmPropertyAttribute` — An attribute for describing properties to LLMs.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `LlmPropertyAttribute.Description` | Gets description. | Gets description. |
