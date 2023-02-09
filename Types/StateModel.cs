namespace Types;

[GenerateSerializer]
[Immutable]
public sealed record StateModel
{
    [Id(0)] public string Value { get; init; } = "";
}