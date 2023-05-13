using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookBookApp.Models
{
    public class Receipes
    {
        public int Id { get; set; }
        public string ReceipeTitle { get; set; }
        public string ReceipeText { get; set; }

        public Receipes()
        {

        }
    }
}
