using Student.Models.Admin;
using Student.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Models
{
    public class LoginViewModel
    {
        public StudentViewModel Student { get; set; }
        public AdminViewModel Admin { get; set; }
    }
}
