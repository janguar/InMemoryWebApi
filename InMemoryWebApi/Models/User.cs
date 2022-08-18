using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InMemoryWebApi.Models
{
	[Table("users")]
	public class User
	{
		[Key]
		[JsonPropertyName("id")]
		public int id { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("username")]
		public string Username { get; set; }

		[JsonPropertyName("email")]
		public string Email { get; set; }

		[JsonPropertyName("address")]
		public Address Address { get; set; }

		[JsonPropertyName("phone")]
		public string Phone { get; set; }

		[JsonPropertyName("website")]
		public string Website { get; set; }

		[JsonPropertyName("company")]
		public Company Company { get; set; }
	}
}