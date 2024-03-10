using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Async_Await_Tasks
{
    internal class Get_Post_API_Eg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Read Post Get-Post from jsonPlaceHolder");

            using (var httpClient = new HttpClient())
            {
                var endPoint = new Uri("https://jsonplaceholder.typicode.com/posts");

                var apiRequest = httpClient.GetAsync(endPoint);
                var getJSONData = apiRequest.Result.Content.ReadAsStringAsync().Result;
                Console.WriteLine("\n Posts Data : \n " + getJSONData);

                var newPost = new Post_Data_Object
                {
                    title = "Sample Text Post",
                    body = "Sample Body - Hello, World!",
                    userID = Guid.NewGuid().ToString()
                };

                Console.WriteLine( "\n Object Values :\n \t" + newPost.title + "\t" + newPost.body + "\t" + newPost.userID);

                var newPostJSON = JsonConvert.SerializeObject(newPost);
                Console.WriteLine("\n JSON: " + newPostJSON);

                var requestPayLoad = new StringContent( newPostJSON, Encoding.UTF8, "application/json" );

                var postRequest = httpClient.PostAsync( endPoint, requestPayLoad );
                
                var postReqResponse = postRequest.Result.Content.ReadAsStringAsync().Result;
                Console.WriteLine("\n postReqResponse:\n" + postReqResponse);
            }
        }
    }
}
