using System.Net.Http.Headers;
using System.Text;
using Levent.JsonSerializeMachine;

namespace RestAPIExample
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            await ProcessRepositories();
        }

        private static async Task ProcessRepositories()
        {
            //* creating client
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //* with "http GET" json data converting to object (cascade)
            //* the converted object is printing to console
            var stringTask = client.GetStringAsync("https://jsonplaceholder.typicode.com/users");
            var msg = await stringTask;
            var user = SerializationJson.fromJsonList<User>(msg);

            foreach (var item in user)
            {
                Console.Write($"name: {item.name}\n"
                + $"username: {item.username}\n"
                + $"mail: {item.email}\n"
                + $"street: {item.address.street} suite:{item.address.suite}\n\n");
            }
            
            //* the object converting to json and with "http POST" it posting and getting response
            var post = new Post(101, 1, "BAŞLIK", "İÇERİK");

            var json = SerializationJson.toJson(post);
            var cont = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync("https://jsonplaceholder.typicode.com/posts", cont);
            var responseObject = await response.Result.Content.ReadAsStringAsync();


            Console.WriteLine("result: " + responseObject);
        }


    }
}
