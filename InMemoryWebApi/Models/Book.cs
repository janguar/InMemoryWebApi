using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InMemoryWebApi.Models
{
	[Table("books")]
    public class Book
    {
		[JsonPropertyName("id")]
		public long Id { get; set; }
		[JsonPropertyName("name")]
		public string Name { get; set; }

    }
}
