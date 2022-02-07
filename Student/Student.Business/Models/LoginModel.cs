﻿using Student.Models.Admin;
using Student.Models.Student;
using Student.Student.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Student.Business.Models
{
    public class LoginModel
    {
        public int Id { get; set; }
        public StudentViewModel StudentLogin { get; set; }
        public AdminViewModel AdminLogin { get; set; }
        public DataEnums LoginData { get; set; }
    }
}