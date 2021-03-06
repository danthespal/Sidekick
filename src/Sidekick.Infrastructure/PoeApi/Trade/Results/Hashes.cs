using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sidekick.Infrastructure.PoeApi.Trade.Results
{
    public class Hashes
  {
    [JsonPropertyName("implicit")]
    public List<List<JsonElement>> Implicit { get; set; }

    [JsonPropertyName("explicit")]
    public List<List<JsonElement>> Explicit { get; set; }

    [JsonPropertyName("crafted")]
    public List<List<JsonElement>> Crafted { get; set; }

    [JsonPropertyName("enchant")]
    public List<List<JsonElement>> Enchant { get; set; }

    [JsonPropertyName("pseudo")]
    public List<List<JsonElement>> Pseudo { get; set; }

    [JsonPropertyName("fractured")]
    public List<List<JsonElement>> Fractured { get; set; }
  }
}
