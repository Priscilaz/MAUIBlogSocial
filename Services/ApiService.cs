// Services/ApiService.cs
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BLOGSOCIALUDLA.Models;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    // Métodos para posts
    public async Task<List<Post>> GetPostsAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Post>>("api/BlogPost");
    }

    public async Task<Post> GetPostByIdAsync(Guid id)
    {
        return await _httpClient.GetFromJsonAsync<Post>($"api/BlogPost/{id}");
    }

    public async Task<bool> AddPostAsync(Post post)
    {
        var response = await _httpClient.PostAsJsonAsync("api/BlogPost", post);
        return response.IsSuccessStatusCode;
    }

    // Métodos para usuarios
    public async Task<List<User>> GetUsersAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<User>>("api/Usuario");
    }

    public async Task<User> GetUserByIdAsync(Guid id)
    {
        return await _httpClient.GetFromJsonAsync<User>($"api/Usuario/{id}");
    }

    public async Task<bool> AddUserAsync(User user)
    {
        var response = await _httpClient.PostAsJsonAsync("api/Usuario", user);
        return response.IsSuccessStatusCode;
    }

    public async Task<User> GetUserByUsernamePasswordAsync(string username, string password)
    {
        var response = await _httpClient.GetAsync($"api/Usuario?username={username}&password={password}");
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<User>();
        }
        return null;
    }
}
