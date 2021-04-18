using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentProfileMvc.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Education { get; set; }
        public string Ug { get; set; }
        public bool Singing { get; set; }
        public bool Dancing { get; set; }
        public bool Hobbies { get; set; }
    }
}