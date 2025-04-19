using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace learn
{
    class Start
    {
        enum Day  //this is enum  :An enum gives meaningful names to numeric values** so your code is easier to read and maintain.
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            //constant  :The const keyword is used to declare a constant value that cannot be changed after it's assigned.
            const String messege = "Choose a Number [1/2]. 1 for alive 2 for dead!! and anything else  for exit. ";
            Console.WriteLine(messege);
            int x;

            do
            {

                x = Convert.ToInt32(Console.ReadLine());

                if (x == 1)
                {
                    //enum  
                    Day today = Day.Sunday;
                    Console.WriteLine("Today is " + today);

                    Console.WriteLine("I love my life!!!");
                    Human one = new Human();
                    one.Name = "Rion";
                    one.Age = 20;
                    one.show();
                    Console.WriteLine(" ");
                }
                else if (x == 2)
                {   //enum   
                    Day today = Day.Friday;
                    Console.WriteLine("Today is " + today);

                    Console.WriteLine("Amar beche thakar kisui nai!!!");
                    Student One = new Student();
                    One.Name = "Student_Rion";
                    One.Age = 20;
                    One.show();

                    String[] Subjects = { "Algorithm", "C#", "Math-5", "DLC", "DLC_LAB" };//array

                    //random number block (not in syllebus)
                    Random random = new Random();
                    int[] number = { random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100),random.Next(0, 100) };

                    for (int sub=0; sub<Subjects.Length; sub++)  //for loop
                    {
                        if (number[sub] > 50)
                        {
                            Console.WriteLine("In " + Subjects[sub] + " I got " + number[sub] +" I wanna Treat myself");
                        }
                        else
                        {
                            Console.WriteLine("In " + Subjects[sub] + " I got " + number[sub] +" I wanna KILL myself");
                        }
                          
                    }
                    Console.WriteLine(" ");
                }


                else
                {
                    Console.WriteLine("Bhai Apne ki Bolod???");
                }

            }
            while (x == 1 || x == 2);





            //jagged array :A jagged array is an array of arrays, where each inner array can have a different size or length.
            char[][] smiley = new char[][]
       {
    new char[] { ' ', '@', ' ', ' ', ' ', '@', ' ' },
    new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
    new char[] { ' ', ' ', '\\', '_', '/', ' ', ' ' },
       };

            // Print the smiley face
            foreach (char[] row in smiley) //foreach loop
            {
                foreach (char c in row)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}
