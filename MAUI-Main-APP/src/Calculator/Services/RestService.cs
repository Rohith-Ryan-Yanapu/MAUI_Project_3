using System.Diagnostics;
using System.Text;
using System.Text.Json;
using Calculator.Models;

namespace Calculator.Services
{
    public class RestService
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;

        public List<QuizItem> Items { get; private set; }

        public RestService()
        {
            Debug.WriteLine("In Rest Service");

            _client = new HttpClient();

            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public async Task<List<QuizItem>> RefreshDataAsync()
        {
            Items = new List<QuizItem>();

            string localhostUrl = DeviceInfo.Platform == DevicePlatform.Android ? "10.0.2.2" : "localhost";

            Uri uri = new Uri(string.Format($"http://{localhostUrl}:5000/api/todoitems/", string.Empty));
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Items = JsonSerializer.Deserialize<List<QuizItem>>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Items;
        }
    }
}