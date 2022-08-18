using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InMemoryWebApi.Models
{
	[Table("posts")]
	public class Post
	{
		[JsonPropertyName("userId")]
		public int UserId { get; set; }

		[Key]
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("Title")]
		public string Title { get; set; }

		[JsonPropertyName("body")]
		public string Body { get; set; }
	}
}