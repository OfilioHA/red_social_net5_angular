using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Practica_2.Models;

namespace Services
{
    public class UserServices
    {
        public HttpClient client = new HttpClient();
        public async Task<List<UserModel>> getlistUsers()
        {
            List<UserModel> userList = new List<UserModel>();
            try
            {
                HttpResponseMessage response = await this.client.GetAsync("https://jsonplaceholder.typicode.com/users");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                userList = JsonConvert.DeserializeObject<List<UserModel>>(responseBody);
            }
            catch (HttpRequestException error)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", error.Message);
            }
            return userList;
        }

        public async Task<UserModel> getAUser(int id){
            UserModel user = null;
            try
            {
                HttpResponseMessage response = await this.client.GetAsync($"https://jsonplaceholder.typicode.com/users?id={id}");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                user = JsonConvert.DeserializeObject<List<UserModel>>(responseBody)[0];
            }
            catch (HttpRequestException error)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", error.Message);
            }
            return user;
        }
    }
}
