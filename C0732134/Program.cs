using System;

namespace C0732134
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }

    class Village
    {
        public Village PreviousVillage;                       // Nodes
        public Village NextVillage;
        public string villageName;
        public bool isAstrlidHere = false;

    }

    public class Countryside
    {
        Village Alst, Maeland, Schenig;

        public void InitializeMap()
        {
             Alst = new Village();
            Maeland = new Village();
            Schenig = new Village();


            Alst.NextVillage = Maeland;
            Maeland.NextVillage = Schenig;
            Schenig.NextVillage = Alst;

        }

        public void WalkAround()
        {
            Village InitialVillage = Maeland;
        }

    }


}
