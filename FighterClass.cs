namespace PPMedeErikOnsdag
{
    internal class FighterClass : IFighterClass
    {
        protected string _name;
        protected int _HP;
        protected int _dmg;
        protected int _stamina;

        //public FighterClass()
        //{
        //}

        public FighterClass(string name, int hp, int dmg, int stamina)
        {
            _name = name;
            _HP = hp;
            _dmg = dmg;
            _stamina = stamina;

        }

        public void fight()
        {

        }
        public void SayName()
        {
            Console.WriteLine(_name);
        }




    }
}
