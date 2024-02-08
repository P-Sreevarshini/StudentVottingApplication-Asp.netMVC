using System.ComponentModel.DataAnnotations;

namespace Dotnet_M1_A2.Models
{
    public class Position
    {

        [Key]
        public int PositionID { get; set; }

        public string PositionName { get; set; }
        public string Nominee1 { get; set; }
        public string Nominee2 { get; set; }
        public string Nominee3 { get; set; }
        public string Nominee4 { get; set; }
    }
}
