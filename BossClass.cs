namespace PPMedeErikOnsdag
{
    internal class BossClass : FighterClass
    {

        public BossClass(string name, int a, int b, int c, int d) : base(name, a, b, c)
        {
            _wins = d;
        }
    }
}
