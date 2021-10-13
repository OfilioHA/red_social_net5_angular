using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Practica_2.Models;

namespace Services
{
    public class ToDoServices
    {
        public HttpClient client = new HttpClient();

        public async Task<List<ToDoModel>> getUserToDos(int id){
            List<ToDoModel> toDoList = null;
            try{
                HttpResponseMessage response = await this.client.GetAsync($"https://jsonplaceholder.typicode.com/todos?userId={id}");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                toDoList = JsonConvert.DeserializeObject<List<ToDoModel>>(responseBody);
            }
            catch (HttpRequestException error)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", error.Message);
            }
            return toDoList;
        }
    }
}
