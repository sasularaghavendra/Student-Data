using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Student_Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        public int Class { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public string Subject  { get; set; }
        [Required]
        public int Marks { get; set; }
    }
}
