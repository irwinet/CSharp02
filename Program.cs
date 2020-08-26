using System;

namespace CSharp02
{
    class Program
    {
        static void Main(string[] args)
        {
            int pUnits = 0;
            int nEmployees = 0;
            float pTotal = 0;
            float pAverage = 0;
            string gIncentivo = "No";

            Console.WriteLine("Numbers of Employees: ");
            nEmployees = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Productions for Units:");
            pUnits = Convert.ToInt32(Console.ReadLine());

            pTotal = pUnits * nEmployees * 7;
            pAverage = pTotal / nEmployees;

            if(pTotal>=100){
                gIncentivo = "Si";
            }

            Console.WriteLine($"Productions Total: {pTotal}");
            Console.WriteLine($"Productions Average: {pAverage}");
            Console.WriteLine($"Incentivo : {gIncentivo}");

        }
    }
}
