using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visszaszamlalas;

namespace VisszaszamlaloFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime dt = new DateTime(2023, 04, 09);
            Visszaszamlalo v = new Visszaszamlalo(dt);
            v.MennyiMeg();
            Console.WriteLine("csak nem megy");
            Console.ReadLine();
          


        }
    }
}
