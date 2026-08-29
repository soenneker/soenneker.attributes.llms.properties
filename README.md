[![](https://img.shields.io/nuget/v/soenneker.attributes.llms.properties.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.llms.properties/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.llms.properties/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.llms.properties/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.attributes.llms.properties.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.llms.properties/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.llms.properties/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.llms.properties/actions/workflows/codeql.yml)

# Soenneker.Attributes.Llms.Properties

A small property attribute for attaching an LLM-oriented description to a .NET model.

## Installation

```bash
dotnet add package Soenneker.Attributes.Llms.Properties
```

## Usage

```csharp
using Soenneker.Attributes.Llms.Properties;

public sealed class WeatherRequest
{
    [LlmProperty("City and country, for example: Austin, US")]
    public required string Location { get; init; }
}
```

Read the description with normal reflection:

```csharp
using System.Reflection;

PropertyInfo property = typeof(WeatherRequest).GetProperty(
    nameof(WeatherRequest.Location))!;

string? description = property
    .GetCustomAttribute<LlmPropertyAttribute>()?
    .Description;
```

## Important behavior

- The attribute can be applied to properties only.
- `Description` is exactly the constructor value; the package does not normalize or validate it.
- The attribute is metadata only. It does not alter serialization, schema generation, or prompts unless another component reads it.
- The attribute is not declared as repeatable, so a property can have only one description.
