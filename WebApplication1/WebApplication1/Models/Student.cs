using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{   [Table("info")]
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Cnic { get; set; }
    }
}