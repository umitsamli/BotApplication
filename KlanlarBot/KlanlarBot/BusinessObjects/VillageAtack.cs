using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlanlarBot.BusinessObjects
{
    public class VillageAtack
    {
        public int VillageAtackID { get; set; }
        public Village MyVillage { get; set; } 
        public ICollection<Village> AtackVillages { get; set; }

    }
}
