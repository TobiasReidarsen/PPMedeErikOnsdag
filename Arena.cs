namespace PPMedeErikOnsdag
{
    internal class Arena //: IFighterClass
    {
        private List<IFighterClass> Fighters;
        private List<IFighterClass> Slåsskjemper;


        public Arena()
        {
            Fighters = new List<IFighterClass>();
            Fighters.Add(new BossClass("Thomas The Daddy", 1234, 1234, 12, 32));
            Fighters.Add(new HeroClass("Erik", 2, 2, 1, 0));

            Slåsskjemper = new List<IFighterClass>();
            Slåsskjemper.Add(new BossClass("Thomas The Daddy", 1234, 1234, 12, 32));
            Slåsskjemper.Add(new HeroClass("Tobias", 2, 2, 1, 13));


        }
        public void SayName()
        {
            foreach (var fighter in Fighters)
            {
                fighter.SayName();

            }
            foreach (var fighter in Slåsskjemper)
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
