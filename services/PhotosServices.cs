using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Practica_2.Models;

namespace Services
{
    public class PhotosServices
    {
        public HttpClient client = new HttpClient();
        public async Task<Int32> getUserAlbum(int id)
        {
            AlbumModel postList = null;
            try
            {
                HttpResponseMessage response = await this.client.GetAsync($"https://jsonplaceholder.typicode.com/albums?userId={id}");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                postList = JsonConvert.DeserializeObject<List<AlbumModel>>(responseBody)[0];
            }
            catch (HttpRequestException error)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", error.Message);
            }
            return postList.Id;
        }

        public async Task<List<PhotoModel>> getUserPhotos(int id){
            List<PhotoModel> photostList = null;
            try{
                HttpResponseMessage response = await this.client.GetAsync($"https://jsonplaceholder.typicode.com/photos?albumId={id}");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                photostList = JsonConvert.DeserializeObject<List<PhotoModel>>(responseBody);
            }
            catch (HttpRequestException error)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", error.Message);
            }
            return photostList;
        }
    }
}
