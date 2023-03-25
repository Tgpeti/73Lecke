using Visszaszamlalas;

namespace VisszaszamlaloNetCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 04, 09);
            Visszaszamlalo v = new Visszaszamlalo(dt);
            v.MennyiMeg();
            Console.WriteLine("ennyi meg egy bambi");
            Console.ReadLine();
            
        }
    }
}