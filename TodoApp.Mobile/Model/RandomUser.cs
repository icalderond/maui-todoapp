using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TodoApp.Mobile.Model;

public class RandomUser
{
    [JsonPropertyName("gender")] public string Gender { get; set; }

    [JsonPropertyName("name")] public Name Name { get; set; }

    [JsonPropertyName("email")] public string Email { get; set; }

    [JsonPropertyName("phone")] public string Phone { get; set; }

    [JsonPropertyName("cell")] public string Cell { get; set; }

    [JsonPropertyName("picture")] public Picture Picture { get; set; }

    [JsonPropertyName("nat")] public string Nat { get; set; }
}

public class RandomUserResult
{
    [JsonPropertyName("results")] public List<RandomUser> Results { get; set; }
}

public class Name
{
    [JsonPropertyName("title")] public string Title { get; set; }

    [JsonPropertyName("first")] public string First { get; set; }

    [JsonPropertyName("last")] public string Last { get; set; }
}

public class Picture
{
    [JsonPropertyName("large")] public string Large { get; set; }

    [JsonPropertyName("medium")] public string Medium { get; set; }

    [JsonPropertyName("thumbnail")] public string Thumbnail { get; set; }
}
