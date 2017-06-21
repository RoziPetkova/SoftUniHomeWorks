using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace _03.ImuneSystem
{
   public class Virus
    {
        public string vName { get; set; }
        public int vCount { get; set; }


        public int Lenght()
        {
            int br = vName.ToCharArray().Count();
            return br;
        }
    }
}
