using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary1
{
    public class AddressModel
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; } // 00852-2154

        public string AddressDisplayValue => $"{StreetAddress}, {City}, {State}, {ZipCode}";
    }
}
