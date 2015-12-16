using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedWithC_Sharp
{
    class Competitor
    {
        static int numberOfCompetitors = 0; //class variable
        //class properties
        private String name;
        private int id;

        //default constructor
        public Competitor()
        {
            name = "No Name";
            id = 0;
            numberOfCompetitors++;
        }
        //2nd constructor with parameters
        public Competitor(String myName, int myId)
        {
            name = myName;
            id = myId;
            numberOfCompetitors++;
        }
        //Getters/Setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        //Class Methods
        public int GetNumberOfCompetitors()
        {
            return numberOfCompetitors;
        }
        //ToString overload
        public override string ToString()
        {
            return "Competitor: name - " + name + ", id - " + id;
        }
    }
}
