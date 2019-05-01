using System.Collections.Concurrent;
using Microsoft.Ajax.Utilities;

namespace Back.Models
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set;}
        public int Elo { get; set; }

    }
}