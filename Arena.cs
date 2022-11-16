namespace PPMedeErikOnsdag
{
    internal class Arena : IFighterClass
    {
        private List<IFighterClass> Fighters;
        private List<IFighterClass> Slåsskjemper;


        public Arena()
        {
            Fighters = new List<IFighterClass>();
            Fighters.Add(new BossClass("Thomas The Daddy", 1234, 1234, 12));
            Fighters.Add(new HeroClass("Erik", 2, 2, 1));

            Slåsskjemper = new List<IFighterClass>();
            Slåsskjemper.Add(new BossClass("Thomas The Daddy", 1234, 1234, 12));
            Slåsskjemper.Add(new HeroClass("Tobias", 2, 2, 1));


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
            return;
        }
    }
}
