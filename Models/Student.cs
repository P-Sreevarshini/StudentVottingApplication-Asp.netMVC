using System.ComponentModel.DataAnnotations;

namespace Dotnet_M1_A2.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }
}
