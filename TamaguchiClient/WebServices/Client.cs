using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using TamaguchiClient.DTO;
using System.Text.Json;

namespace TamaguchiClient.WebServices
{
    class Client
    {

        private string baseUrl;
        private HttpClient client;

        public Client(string baseUrl)
        {
            this.baseUrl = baseUrl;
            //Set client handler to support cookies!!
            HttpClientHandler handler = new HttpClientHandler();
            handler.CookieContainer = new System.Net.CookieContainer();

            //Create client with the handler!
            this.client = new HttpClient(handler, true);
        }


        public async Task<PlayerDTO> Login(UserDTO user)
        {
            string url = this.baseUrl + "/Login";
            try
            {
                string json = JsonSerializer.Serialize(user);
                StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, stringContent);
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<PlayerDTO>(content, options);
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public async Task<bool> Logout()
        {

            string url = this.baseUrl + "/Logout";
            try
            {
                
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
