using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333 - 32 - 3332", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();
            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932 - 22 - 6538", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();
            //Employee employee = new Employee(); - abstract class bans this action
            Console.WriteLine();

            object[] things = new object[4];
            things[0] = new Hexagon();
            things[1] = 3.4;
            things[2] = new Manager();
            things[3] = "Last thing";
            foreach(object ob in things)
            {
                Hexagon h = ob as Hexagon;
                if (h == null)
                    Console.WriteLine("Item is not a Hexagon");
                else
                {
                    h.Draw();
                }
            }
            GivePromoution(chucky);
            Console.ReadKey();
        }
        static void CastingExamples()
        {
            object frank = new Manager("Frank Zapp", 9, 3000, 40000, "111 - 11 - 1111", 5);
            GivePromoution((Manager)frank);
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 200001, "101 - 11 - 1321", 11);
            GivePromoution(moonUnit);
            SalesPerson jill = new PTSalesPerson("Jill", 364, 1000, 466829, "302 - 12 - 8402", 90);
            GivePromoution(jill);
        }
        static void GivePromoution(Employee emp)
        {
            Console.WriteLine();
            Console.WriteLine("{0} is promovted", emp.Name);
            if (emp is SalesPerson)
                Console.WriteLine("{0} made {1} sale(s)", emp.Name, ((SalesPerson)emp).SalesNumber);
            Console.WriteLine();
            if (emp is Manager)
                Console.WriteLine("{0} made {1} stock options", emp.Name, ((Manager)emp).StockOptions);
            Console.WriteLine();
        }
    }
}
