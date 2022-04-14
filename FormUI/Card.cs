using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Card
    {
        public int id { get; set; }

        public int PersonID { get; set; }

        public string CardNumber { get; set; }

        public int ExpMonth { get; set; }

        public int ExpYear  { get; set; }

        public int SecurityCode { get; set; }

        public int Pin { get; set; }

        public float Balance { get; set; }
    }
}
