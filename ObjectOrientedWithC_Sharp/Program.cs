using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedWithC_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Player 1
            Competitor one = new Competitor("Mart Red", 1234);

            //Player 2
            Competitor two = new Competitor("John Doe", 48151623);

            //Player 3
            Competitor three = new Competitor("Perdo Sanchez", 144545);

            //Player 4
            Competitor four = new Competitor("Koru Satu", 2414134);

            //Team Barcelona initialization - adding players with methods
            Team barcelona = new Team("Barcelona");
            barcelona.addPlayer(one);
            barcelona.addPlayer(two);

            //Team Zenit initialization - adding playrs with Setters
            Team zenit = new Team("Zenit");
            zenit.Players.Add(three);
            zenit.Players.Add(four);

            Console.Write(barcelona.ToString() + "\n");
            Console.Write(zenit.ToString());


            Console.ReadLine();
        }
    }
}
