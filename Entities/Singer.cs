using System.ComponentModel.DataAnnotations;

namespace ZeneStreamingAPI.Entities
{
    public class Singer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public string Genre { get; set; }

    }
}
