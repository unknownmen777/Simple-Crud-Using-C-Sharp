﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Login_Form.Models
{
    public class StudentConlrol: DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}