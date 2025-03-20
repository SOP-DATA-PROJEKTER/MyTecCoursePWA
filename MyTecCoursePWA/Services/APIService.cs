using System.Net.Http.Json;

namespace MyTecCoursePWA.Services
{
    public class APIService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseEndpoint = "/api";

        public APIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // This method is used to fetch data from the API
        // it required the endpoint to fetch data from
        // base root is /api/
        // example endpoint: "education"
        public async Task<List<T>> GetAllAsync<T>(string endpoint)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<T>>($"{_baseEndpoint}/{endpoint}") ?? new List<T>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching data from {endpoint}: {ex.Message}");
                return new List<T>();
            }
        }

        public async Task<T?> GetByIdAsync<T>(string endpoint, string id)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<T>($"{_baseEndpoint}/{endpoint}/{id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching data from {endpoint}: {ex.Message}");
                return default; // default value for T, can't use null since T can be non-nullable
            }
        }

        public async Task<T?> PostAsync<T>(string endpoint, T data)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync($"{_baseEndpoint}/{endpoint}", data);
                return await response.Content.ReadFromJsonAsync<T>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error posting data to {endpoint}: {ex.Message}");
                return default;
            }
        }


    }
}
