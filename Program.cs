using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("------------Question 1-----------");
            //Console.WriteLine("Enter a Sentence");
            //string input = Console.ReadLine();
            //Console.WriteLine("Enter position");
            //int position = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter char to pass");
            //char charToPass = Convert.ToChar(Console.ReadLine());
            //string res = Utility.LastWord(position, input, charToPass);
            //Console.WriteLine(res);
            //Console.WriteLine("------------Question 2-----------");



            //Utility utility = new Utility();
            //Console.WriteLine("Enter words separated by comma");
            //string input2 = Console.ReadLine();
            //string[] inputArr = input2.Split(',');  
            
            

            //List<String> res2 = utility.GetPallindromes(inputArr);
            //foreach (String output in res2)
            //{
            //    Console.Write(output + " ");
            //}


            Console.WriteLine("------------Question 3-----------");
            Console.WriteLine("Enter temp in fahrenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(TemperatureConverter.ToCelcius(fahrenheit) + "C");
            Console.WriteLine("Enter temp in Celsius");
            double celcius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(TemperatureConverter.ToFahrenheit(celcius));
            Console.ReadLine();
        }

    }
}
