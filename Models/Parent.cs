using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace netdbdemo.Models {

    [Table("parents")]
    public class Parent {

        [Column]
        public int id { get; set; }

        [Column("firstname")]
        public string FirstName { get; set; }

        [Column("lastname")]
        public string LastName { get; set; }

        [Column("age")]
        public int Age { get; set; }
    }
}