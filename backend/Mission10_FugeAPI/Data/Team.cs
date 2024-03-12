using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mission10_FugeAPI
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        
        [Required]
        [ForeignKey("CaptainID")]
        public int CaptainID { get; set; }

        [Required]
        public Bowler? Captain { get; set; }

    }
}
