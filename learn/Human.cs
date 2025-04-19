using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace learn
{
    class Human
    {
      
      //this is the initialization block!
        protected string name;
        protected int age;
        //This is the static block
        protected static  int Count = 0;

        //this is the constructor block!
        public Human() 
        {
            Introduce_Speech();
            Count++;
        }
        //Virtuasl method
       
       
        public virtual void Introduce_Speech()
        {
            Console.WriteLine("Ami ekjon Manusher Baccha Manush ");
        }

        public string Name //this is the name inputting block!
        {
            get { return name; }
            set
            {
                if (Regex.IsMatch(value, @"^[A-Za-z]+$"))
                {
                    name = value;
            }
                    else
                    {
                Console.WriteLine("Dhet madarchod print korte paros na???");
            }
        }
        }

        public int Age //this is the age inputting block!
        {
            get { return age; }
            set
            {
                if (value > 0 && value < 120)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Dhet madarchod print korte paros na???");
                }
            }
        }
      

       //this is the array block!
        public virtual void show() {
            Console.WriteLine("Amar serial "+Count);
            Console.WriteLine("Amar nam Jante chao?  " + name +" Amar nam.");
            Console.WriteLine("Boyosh Beshi na, Bolte gelee Juan.Matro"+ age+" bosor boyosh. Sudhui Sex Korte monchai....");
        }
       
    }
}
