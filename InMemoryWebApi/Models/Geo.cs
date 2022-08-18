using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InMemoryWebApi.Models
{
	[Table("geo")]
	public class Geo : BaseEnity
	{
		[JsonPropertyName("lat")]
		public string Lat { get; set; }

		[JsonPropertyName("lng")]
		public string Lng { get; set; }
	}
}