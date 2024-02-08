using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnet_M1_A2.Models
{
    public class Vote
    {
        [Key]
        public int VoteSerialID { get; set; }
        public string NomineeName { get; set; }

        public DateTime Date_Time { get; set; }

        [ForeignKey("positionTbl")]
        public int PositionID { get; set; }
        public virtual Position positionTbl { get; set; }

        [ForeignKey("studentTbl")]
        public int StudentID { get; set; }
        public virtual Student studentTbl { get; set; }

    }
}
