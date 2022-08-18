using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InMemoryWebApi.Models
{
	[Table("todos")]
	public class Todo
	{
		[JsonPropertyName("userId")]
		public int UserId { get; set; }

		[Key]
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("title")]
		public string Title { get; set; }

		[JsonPropertyName("completed")]
		public bool Completed { get; set; }
	}
}