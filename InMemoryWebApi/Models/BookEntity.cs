using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InMemoryWebApi.Models
{
	[Table("book_entity")]
	public class BookEntity : BaseEnity
	{
		[JsonPropertyName("author")]
		public string Author { get; set; }

		[JsonPropertyName("country")]
		public string Country { get; set; }

		[JsonPropertyName("imageLink")]
		public string ImageLink { get; set; }

		[JsonPropertyName("language")]
		public string Language { get; set; }

		[JsonPropertyName("link")]
		public string Link { get; set; }

		[JsonPropertyName("pages")]
		public int Pages { get; set; }

		[JsonPropertyName("title")]
		public string Title { get; set; }

		[JsonPropertyName("year")]
		public int Year { get; set; }
	}
}