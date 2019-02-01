using System;

namespace C0732134_Week04
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
            Alst.villageName = "Alst";

            Maeland = new Village();
            Maeland.villageName = "Maeland";
            Schenig = new Village();
            Schenig.villageName = "Schenig";


            Alst.NextVillage = Maeland;
            Maeland.NextVillage = Schenig;
            Schenig.NextVillage = Alst;

        }

        public void FindAstrilda()
        {
            Village CurrentVillage = Maeland;
            while (CurrentVillage.isAstrlidHere)
            {
                if (!CurrentVillage.isAstrlidHere)
                    Console.WriteLine("Yay! Hugi found Astrilda. XOXO");
                else
                    Village NextVillage = CurrentVillage.NextVillage;
            }

        }

    }


}
