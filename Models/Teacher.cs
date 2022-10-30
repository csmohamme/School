using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Teacher
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string? teacherName { get; set; }

        [Required]
        public string? Address { get; set; }

        public bool Gender { get; set; }

        [Required]
        public double Salary { get; set; }

        [Required]
        public string? Phone { get; set; }

        public string? Profile_image { get; set; }

        [Required]
        public string? Email { get; private set; }

        public int Subject_id { get; set; }




    }
}