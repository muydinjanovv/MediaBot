using System.Text.Json;
using MediaBot.DTO.Photo;
using MediaBot.DTO.Video;

namespace MediaBot.Services;

public class PixabayClient
{
    private readonly HttpClient _client;
    private readonly ILogger<PixabayClient> _logger;

    public PixabayClient(HttpClient client, ILogger<PixabayClient> logger)
    {
        _client = client;
        _logger = logger;
    }

    public async Task<(Video video, bool isSuccess, Exception e)> GetVideoAsync(string theme)
    {
        theme = theme.Replace(" ", "+");
        var query = $"videos/?key=25468185-dd423ea20696475f5d1922b78&q={theme}&pretty=true";
        using var httpResponse = await _client.GetAsync(query);
        if(httpResponse.IsSuccessStatusCode)
        {
            var json = await httpResponse.Content.ReadAsStringAsync();
            var data = JsonSerializer.Deserialize<Video>(json);
            return (data, true, null);
        }
        return (null, false, new Exception(httpResponse.ReasonPhrase));
    }
    public async Task<(Photo photo, bool isSuccess, Exception e)> GetPhotoAsync(string theme)
    {
        theme = theme.Replace(" ", "+");
        var query = $"videos/?key=25468185-dd423ea20696475f5d1922b78&q={theme}&image_type=photo&pretty=true";
        using var httpResponse = await _client.GetAsync(query);
        if(httpResponse.IsSuccessStatusCode)
        {
            var json = await httpResponse.Content.ReadAsStringAsync();
            var data = JsonSerializer.Deserialize<Photo>(json);
            return (data, true, null);
        }
        return (null, false, new Exception(httpResponse.ReasonPhrase));
    }
    
}