using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publicLibrary
{
    class Lend : BaseItem
    {
        public int SUbscriberId { get; set; }
        public int WorkerId { get; set; }
        public int ItemId { get; set; }
        public int ItemQuantity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Lend () { }
    }
}
