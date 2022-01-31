using System.Text.Json.Serialization;

namespace MediaBot.DTO.Video;

 public class Tiny
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("size")]
        public int Size { get; set; }
    }
    