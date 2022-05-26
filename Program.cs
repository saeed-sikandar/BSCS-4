using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            Char b = 'f';


            ///Console.WriteLine("This is Integer = "+i+ "\n");
            ///Console.WriteLine("This is Double = " + d + "\n");
            //Console.WriteLine("This is Integer = " + i + "\n");
            //Console.WriteLine("This is Boolean = " + b + "\n");
            // Console.WriteLine("This is String = " + s + "\n");

            //Double percentage = Convert.ToDouble(Console.ReadLine());
            Double percentage = Convert.ToDouble(Console.ReadLine());

            //for(Int32 )

            if(percentage >= 80 ) Console.Write("A+ G2rade" );
            
            else if (percentage >= 70 && percentage < 80) Console.Write("\n A Grade");

            else if (percentage >= 60 && percentage < 70) Console.Write("\n B Grade");

            else if (percentage >= 50 && percentage < 60) Console.Write("\n C Grade");
                
            else Console.Write("\n Fail");

            Console.WriteLine("\n Would you like to add more results! Type Y for Yes and N for No");

            b = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("bb"+b);
                


           Console.ReadKey();

        }

    }
}
