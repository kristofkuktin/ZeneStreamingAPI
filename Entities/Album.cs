using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ZeneStreamingAPI.Entities
{
    public class Album
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Genre { get; set; }

        [JsonIgnore]
        public virtual Singer Singer { get; set; }
        public virtual Song Song { get; set; }
    }
}
