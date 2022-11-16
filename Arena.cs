namespace PPMedeErikOnsdag
{
    internal class Arena //: IFighterClass
    {
        private List<IFighterClass> Fighters;



        public Arena()
        {
            Fighters = new List<IFighterClass>();
            Fighters.Add(new BossClass("Thomas The Daddy", 500, 20, 60, 32));
            Fighters.Add(new HeroClass("Erik", 250, 65, 60, 0));




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
            Console.WriteLine(Fighters.Count);
            for (var i = 0; i < Fighters.Count - 1; i++)
            {
                var second = (FighterClass)Fighters[i + 1];
                Fighters[i].fight(second);
            }
        }
    }
}
