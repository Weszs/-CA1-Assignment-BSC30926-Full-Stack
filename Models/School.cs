using System.Text.Json.Serialization;

namespace EdutotsSchools.Models;

public sealed class School
{
    [JsonPropertyName("schoolId")]
    public int SchoolId { get; init; }

    [JsonPropertyName("schoolName")]
    public string? SchoolName { get; init; }

    [JsonPropertyName("address")]
    public string? Address { get; init; }

    [JsonPropertyName("phoneNo")]
    public string? PhoneNo { get; init; }

    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; init; }

    [JsonPropertyName("proprietorFullName")]
    public string? ProprietorFullName { get; init; }

    [JsonPropertyName("headFullName")]
    public string? HeadFullName { get; init; }
}