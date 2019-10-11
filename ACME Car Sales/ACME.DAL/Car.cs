using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.DAL
{
    public class Car
    {
        public string Modell { get; set; }
        public string RegNum { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Modell, RegNum);
        }
    }
}
