using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prakt9Fix
{
    struct worldc
    {
        public string Country { get; set; }
        public string Сapital { get; set; }
        public string Monetaryu { get; set; }
        public int Population { get; set; }
        public worldc (string country, int population, string capital, string monetaryu)
        {
            Country = country;
            Сapital = capital;
            Monetaryu = monetaryu;
            Population = population;
        }
    }
}

