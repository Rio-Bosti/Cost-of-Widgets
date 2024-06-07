using System;

namespace WidgetCost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of widgets ordered: ");
            int numWidgets = Convert.ToInt32(Console.ReadLine());

            double cost;
            if (numWidgets < 100)
            {
                cost = numWidgets * 0.25;
            }
            else
            {
                cost = numWidgets * 0.20;
            }

            Console.WriteLine($"The total cost is: {cost:C}");
        }
    }
}

