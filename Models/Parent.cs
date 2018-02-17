using System;

namespace netdbdemo.Models {

    public class Parent {

        [Column]
        public int id { get; set; }

        [Column]
        public string FirstName { get; set; }

        [Column]
        public string LastName { get; set; }

        [Column]
        public int Age { get; set; }
    }
}