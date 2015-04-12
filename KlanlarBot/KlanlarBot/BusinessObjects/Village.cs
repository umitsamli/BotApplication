using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KlanlarBot.BusinessObjects
{
    public class Village
    {
        public Village() { }

        public int VillageID { get; set; }
        public Point Location { get; set; } 

    }
}
