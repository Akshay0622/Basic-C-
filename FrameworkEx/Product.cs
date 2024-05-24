using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkEx
{
    
    internal class Product
    {
        [Key]
        public int pid { set; get; }
        public string name { set; get; }
        public int price { set; get; }


        public override string ToString()
        {
            return "pid=" + pid + " price="+price + " name=" + name;
        }

    }
}
