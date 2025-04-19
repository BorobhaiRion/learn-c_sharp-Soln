using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace learn
{
    class Human ////class :A class is a blueprint for creating objects.We can use 'abstruct' class Human'when we dont want to create any child of this class.

    {
      
      //this is the initialization block!
        protected string name; //Protected method are accessible within the class and by derived class instances. that means we can also use thease in the Child classed . We cannot use private in child classes.
        protected int age;
        //This is the static block : Static methods are called without creating an instance of the class. Static methods can access static data members and static methods directly. Static methods can be called without creating an object of the class. We can call it by class name not by object name. and the value will update as More object gets created.
        protected static  int Count = 0;

        //this is the constructor block!
        public Human() 
        {
            Introduce_Speech();
            Count++;
        }
        //Virtuasl method : A virtual method is a method that can be overridden in derived classes. It allows you to provide a default implementation in the base class while allowing derived classes to provide their own specific implementation.


        public virtual void Introduce_Speech()
        {
            Console.WriteLine("Ami ekjon Manusher Baccha Manush ");
        }

        public string Name //this is the name inputting block! : Get set are the Struct method to provide more secure and defined data as input. like we can put conditon to get an input.
        {
            get { return name; }
            set
            {
                if (Regex.IsMatch(value, @"^[A-Za-z]+$")) //Regex.IsMatch(value, @"^[A-Za-z]+$") this means take only Strings from A to Z and a to z.
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
      

       
        public virtual void show() {
            Console.WriteLine("Amar serial "+Count);
            Console.WriteLine("Amar nam Jante chao?  " + name +" Amar nam.");
            Console.WriteLine("Boyosh Beshi na, Bolte gelee Juan.Matro"+ age+" bosor boyosh. Sudhui Sex Korte monchai....");
        }
       
    }
}
