﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using TamaguchiClient.DTO;
using System.Text.Json;
using TamaguchiClient.UI;

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
                throw new Exception("The server has fallen by the Holonim");
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
                    MainUI.currentPlayer = null;
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


        public async Task<List<ActivityDTO>> GetActivityHistory()
        {
            string url = this.baseUrl + "/GetActivityHistory";
            try
            {

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {

                    JsonSerializerOptions options = new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<List<ActivityDTO>>(content, options);
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }



        public async Task<string> Lucas()
        {
            string url = this.baseUrl + "/Lucas";
            HttpResponseMessage response = await this.client.GetAsync(url);
            
            if(response.IsSuccessStatusCode)
            {
                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                };
                return  await response.Content.ReadAsStringAsync();
                
                
            }
            else
            {
                return "ariel is gay";
                
            }
            
        }
       


        public async Task<bool> IsLoggedin()
        {
            string url = this.baseUrl + "/IsLoggedin";
            try
            {
                HttpResponseMessage response = await this.client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    string content = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<bool>(content, options);

                }
                else
                    return false;
            }
            catch(Exception)
            {
                return false;
            }
        }



        public async Task<bool> IsEmailExists(string email)
        {

            string url = this.baseUrl + "/IsEmailExists";
            try
            {
                string json = JsonSerializer.Serialize(email);
                StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, stringContent);
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<bool>(content, options);
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }

        }



        public async Task<bool> IsUserNameExists(string userName)
        {

            string url = this.baseUrl + "/IsUserNameExists";
            try
            {
                string json = JsonSerializer.Serialize(userName);
                StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, stringContent);
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<bool>(content, options);
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }

        }


        public async Task<PlayerDTO> AddPlayer(Player p)
        {
            string url = this.baseUrl + "/AddPlayer";
            try
            {
                string json = JsonSerializer.Serialize(p);
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


    }
}
