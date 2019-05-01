using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Back.Models
{
    public class Vote
    {
        public int Id{ get; set; }
        public Cat Voted { get; set; }
        public Cat Against { get; set; }
        public DateTime VotedOn { get; set; }
    }
}