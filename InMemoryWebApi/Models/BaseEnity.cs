using System.ComponentModel.DataAnnotations;

namespace InMemoryWebApi.Models
{
	public class BaseEnity
	{
		[Key]
		public int Id { get; set; }
	}
}