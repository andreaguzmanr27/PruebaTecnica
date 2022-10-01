using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace apiRequest {
	public static class Test5 {
		public static void Main(string[] args)
		{
			using(var client = new HttpClient())
			{
				var endpoint = new Uri("https://rickandmortyapi.com/api/character");
				var result = client.GetAsync(endpoint).Result;
				var json = result.Content.ReadAsStringAsync().Result;
				string data = json;
				dynamic data_json  = JsonConvert.DeserializeObject(data);
				for (int i = 0; i < data_json.results.Count; i++)
				{
				  Console.WriteLine(data_json.results[i]["name"]);
				}

			}
		}
	}
}
