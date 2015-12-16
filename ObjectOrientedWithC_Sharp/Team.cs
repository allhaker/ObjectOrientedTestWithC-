using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedWithC_Sharp
{
    class Team
    {
        //instance variables
        private List<Competitor> players = new List<Competitor>(); //this is a dynamic array of objects Competitor
        private String name;

        //Constuctors
        public Team()
        {
            name = "This team is undefined";

        }
        public Team(String myName)
        {
            name = myName;
        }
        //Getters/Setters
        internal List<Competitor> Players
        {
            get { return players; }
            set { players = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        //Methods
        public void addPlayer(Competitor player)
        {
            players.Add(player);
        }

        //ToString() override
        public override string ToString()
        {
            String data = "";
            foreach (Competitor i in players)
            {
                data += i.ToString() + "\n";
            }
            return "Team " + name + "\n" + data;
        }
    }
}
