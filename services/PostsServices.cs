using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Practica_2.Models;

namespace Services
{
    public class PostsServices
    {
        public HttpClient client = new HttpClient();
        public async Task<List<PostModel>> getlistPosts()
        {
            List<PostModel> postList = new List<PostModel>();
            try
            {
                HttpResponseMessage response = await this.client.GetAsync("https://jsonplaceholder.typicode.com/posts");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                postList = JsonConvert.DeserializeObject<List<PostModel>>(responseBody);
            }
            catch (HttpRequestException error)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", error.Message);
            }
            return postList;
        }

        public async Task<List<PostModel>> getPostsFromUser(int id){
            List<PostModel> postList = new List<PostModel>();
            try{
                HttpResponseMessage response = await this.client.GetAsync($"https://jsonplaceholder.typicode.com/posts?userId={id}");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                postList = JsonConvert.DeserializeObject<List<PostModel>>(responseBody);
            }
            catch (HttpRequestException error)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", error.Message);
            }
            return postList;
        }
    }
}
