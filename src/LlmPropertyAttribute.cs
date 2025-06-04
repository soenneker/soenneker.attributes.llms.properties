using System;

namespace Soenneker.Attributes.Llms.Properties;

/// <summary>
/// An attribute for describing properties to LLMs
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public sealed class LlmPropertyAttribute : Attribute
{
    public string Description { get; }

    public LlmPropertyAttribute(string description)
    {
        Description = description;
    }
}