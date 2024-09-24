using Pam_Study.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pam_Study.Services
{
    public class MonitorService
    {
        private HttpClient _httpClient;
        private Models.Monitor monitor;
        private List<Models.Monitor> monitors;
        private JsonSerializerOptions _serializerOptions;

        public MonitorService()
        {
            _httpClient = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }
        public async Task<ObservableCollection<Models.Monitor>> getPostAsync()
        {

            Uri uri = new Uri("https://jsonplaceholder.typicode.com/posts");
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    monitors = JsonSerializer.Deserialize<ObservableCollection<Models.Monitor>>(content, serializerOptions);
                }
            }
            catch (Exception ex)
            {
               Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return monitors;
        }
    }
}
