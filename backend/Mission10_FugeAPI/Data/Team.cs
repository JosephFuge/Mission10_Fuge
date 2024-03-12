using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Mission10_FugeAPI
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }

        [Required]
        public string TeamName { get; set; } = "";
        
        [Required]
        [ForeignKey("Captain")]
        public int? CaptainID { get; set; }

        // JsonIgnore annotation stops JSON serializer from infinitely looping on the Captain Bowler and his or her team
        [Required]
        [JsonIgnore]
        public Bowler? Captain { get; set; }

    }
}
