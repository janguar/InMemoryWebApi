using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InMemoryWebApi.Models
{
	[Table("photos")]
	public class Photo
	{
		[JsonPropertyName("labumId")]
		public int AlbumId { get; set; }

		[Key]
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("title")]
		public string Title { get; set; }

		[JsonPropertyName("url")]
		public string Url { get; set; }

		[JsonPropertyName("thumbnailUrl")]
		public string ThumbnailUrl { get; set; }
	}
}