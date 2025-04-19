using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace learn
{
    class Student:Human
    {

        //Override block

      
        public override void Introduce_Speech()
        {
            Console.WriteLine("Ami ekjon Manusher Baccha Student ");
        }
        public override void show()
        {
            Console.WriteLine("Amar serial " + Count);
            Console.WriteLine("Amar nam Jante chao?  " + name + " Amar nam.");
            Console.WriteLine("Boyosh Beshi na, Bolte gelee Juan. matro " + age + " bosor boyosh Sudhui Porashona Korte monchai....");
        }
    }
}
