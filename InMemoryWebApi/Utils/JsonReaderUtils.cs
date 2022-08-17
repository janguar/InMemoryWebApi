using Bogus;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace InMemoryWebApi.Utils
{
	public class JsonReaderUtils
	{
		public string FilePath { get; set; }


		public static void ReadJson()
		{
			var options = new JsonSerializerOptions
			{
				NumberHandling = JsonNumberHandling.AllowReadingFromString
			};
			var personObject = JsonSerializer.Deserialize<object>("", options);
		}

		private static async Task SerializeToFile()
		{
			//var pets = new List<Pet>
			//{
			//	new Pet { Type = "Cat", Name = "MooMoo", Age = 3.4 },
			//	new Pet { Type = "Squirrel", Name = "Sandy", Age = 7 }
			//};
			//var person = new Person
			//{
			//	Name = "John",
			//	Age = 34,
			//	StateOfOrigin = "England",
			//	Pets = pets
			//};
			//var fileName = "Person.json";
			//using var stream = File.Create(fileName);
			//await JsonSerializer.SerializeAsync(stream, person);
			//await stream.DisposeAsync();
			//Console.WriteLine(File.ReadAllText(fileName));
		}
	}
}
