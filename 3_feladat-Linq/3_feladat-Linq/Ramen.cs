using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_feladat_Linq
{
    internal class Ramen
    {
        public int RamenId { get; set; }
        public string Brand { get; set; }   
        public string RamenName { get; set; }
        public int CountryFK { get; set; }  
        public Country Country { get; set; }
        public double Stars { get; set; }  

    }
}
