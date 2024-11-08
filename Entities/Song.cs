using System.ComponentModel.DataAnnotations;

namespace ZeneStreamingAPI.Entities
{
    public class Song
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        public string Genre { get; set; }
        
    }
}
