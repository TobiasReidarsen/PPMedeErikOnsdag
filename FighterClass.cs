namespace PPMedeErikOnsdag
{
    internal class FighterClass : IFighterClass
    {
        protected string _name;
        protected int _HP;
        protected int _dmg;
        protected int _stamina;
        protected int _wins;

        //public FighterClass()
        //{
        //}

        public FighterClass(string name, int hp, int dmg, int stamina, int wins)
        {
            _name = name;
            _HP = hp;
            _dmg = dmg;
            _stamina = stamina;
            _wins = wins;

        }

        public void fight(FighterClass opponent)
        {
            opponent._HP -= this._dmg;
            Console.WriteLine("lost: " + opponent._HP + " hp" + " fighter did " + this._dmg);
        }
        public void SayName()
        {
            Console.WriteLine(_name);
        }




    }
}
