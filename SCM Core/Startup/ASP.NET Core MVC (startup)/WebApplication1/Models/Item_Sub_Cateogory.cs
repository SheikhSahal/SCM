using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Item_Sub_Cateogory
    {
        public int Isubcate_id { get; set; }
        public int Icate_id { get; set; }
        public string Description { get; set; }
        public string Remarks  { get; set; }

        public bool Status { get; set; }
    }
}
