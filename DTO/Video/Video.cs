using System.Text.Json.Serialization;

namespace MediaBot.DTO.Video;
public class Video
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("totalHits")]
        public int TotalHits { get; set; }

        [JsonPropertyName("hits")]
        public List<Hit> Hits { get; set; }
    }