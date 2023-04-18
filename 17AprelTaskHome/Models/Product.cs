using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17AprelTaskHome.Models
{
    internal class Product
    {
        public string Name{ get; set; }

    public    List<Catagory> Catagories { get; set;}=new List<Catagory>();
    }
}
