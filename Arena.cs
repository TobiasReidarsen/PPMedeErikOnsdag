namespace PPMedeErikOnsdag
{
    internal class Arena
    {
        private List<FighterClass> Fighters;



        public Arena()
        {
            Fighters = new List<FighterClass>();
            Fighters.Add(new BossClass("Thomas The Daddy", 500, 20, 20, 30));
            Fighters.Add(new HeroClass("Truls", 251, 65, 60));
            Fighters.Add(new HeroClass("Tobias", 250, 65, 60));





        }
        public void SayName()
        {
            foreach (var fighter in Fighters)
            {
                fighter.SayName();

            }

        }

        public void fight()
        {
            int alivePlayers = Fighters.Count;
            bool run = true;
            while (run)
            {

                int i = 0;
                for (i = 0; i < Fighters.Count - 1; i++)
                {
                    var second = (FighterClass)Fighters[i + 1];
                    if ((second.Alive == true) && (Fighters[i].Alive == true))
                    {
                        Fighters[i].fight(second);
                        if (Fighters[i].Alive == false) { alivePlayers--; }
                        Console.WriteLine(alivePlayers);
                        //if (second.Alive == false) { alivePlayers--; }

                        //if (alivePlayers != 1)
                        //{
                        //    Fighters[i].fight(second);
                        //}
                        //if (second.Alive == true)
                        //{
                        //    Fighters[i + 1].fight(Fighters[i]);
                        //}
                        //if (second.Alive == false)
                        //{
                        //    alivePlayers--;
                        //}
                    }
                    if (second.Alive == false) { alivePlayers -= 1; }




                    //if (Fighters[i].Alive == false)
                    //{
                    //    alivePlayers--;
                    //}

                    Console.WriteLine(alivePlayers);
                    if (alivePlayers == 1) { run = false; }

                }
                if (alivePlayers == 1) { run = false; }
            }
            Console.WriteLine("Found a winner");
            Console.ReadKey(true);

            foreach (var ele in Fighters)
            {
                Console.WriteLine($"{ele.Alive} {ele.getHP}");
            }

        }


    }
}
