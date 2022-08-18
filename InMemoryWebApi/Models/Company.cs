using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InMemoryWebApi.Models
{
	[Table("companies")]
	public class Company : BaseEnity
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("catchPhrase")]
		public string CatchPhrase { get; set; }

		[JsonPropertyName("bs")]
		public string Bs { get; set; }
	}
}