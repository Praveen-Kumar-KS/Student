using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Student.Data.Enums
{
    public enum DataEnums
    {
        [Description("Admin")]
        AdminLogin = 0,
        [Description("Student")]
        StudentLogin = 1
    }
}
