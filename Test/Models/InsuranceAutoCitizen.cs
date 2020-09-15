using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class InsuranceAutoCitizen
    {

        public int Id { get; set; }

        public string NSF { get; set; }
        public string Engine { get; set; }

        public DateTime Date { get; set; }

        public string City { get; set; }

        public string Franchise { get; set; }

        public string RoadAccident { get; set; }
    }
}
