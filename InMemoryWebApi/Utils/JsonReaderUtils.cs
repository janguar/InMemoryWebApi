using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InMemoryWebApi.Utils
{
	public class JsonReaderUtils
	{
		public static List<T> ReadJson<T>(string filename)
		{
			var assembly = Assembly.GetExecutingAssembly();
			var resourceName = $"InMemoryWebApi.Mocks.{filename}.json";
			string result = "";

			using (Stream stream = assembly.GetManifestResourceStream(resourceName))
			using (StreamReader reader = new StreamReader(stream))
			{
				result = reader.ReadToEnd();
			}

			var options = new JsonSerializerOptions
			{
				NumberHandling = JsonNumberHandling.AllowReadingFromString
			};
			return JsonSerializer.Deserialize<List<T>>(result, options);
		}

		public List<T> SerializeToFile<T>(string filename) where T : new()
		{
			var options = new JsonSerializerOptions
			{
				NumberHandling = JsonNumberHandling.AllowReadingFromString
			};

			var res = JsonSerializer.Deserialize<List<T>>(filename, options);
			return res;
		}
	}
}