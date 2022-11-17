namespace PPMedeErikOnsdag
{
    internal class FighterClass
    {
        protected string _name;
        protected int _HP;
        protected int _dmg;
        protected int _stamina;
        protected int _wins = 0;
        protected bool _alive = true;
        public bool Alive
        {
            get => _alive;
        }


        public FighterClass(string name, int hp, int dmg, int stamina)
        {
            _name = name;
            _HP = hp;
            _dmg = dmg;
            _stamina = stamina;

        }

        public int getHP()
        {
            return _HP;
        }

        public void fight(FighterClass opponent)
        {

            bool hpCheck = (this._HP > 0) && (opponent._HP > 0);
            if (hpCheck)
            {
                if (this._stamina > 0)
                {
                    var staminaDMG = 10;
                    //var ogStamina = this._stamina.Deep

                    opponent._HP -= this._dmg;
                    this._stamina -= staminaDMG;
                    Dividers();
                    Console.WriteLine($"{opponent._name} lost: {this._dmg} hp, and now has: {opponent._HP} hp left.\n{this._name} did {this._dmg} dmg. Lost {staminaDMG} stamina and has {this._stamina} stamina left");
                    Dividers();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(this._name + " recharges stamina");
                    Recharge();
                }
            }
            else
            {
                if (this._HP <= 0) { _alive = false; Console.WriteLine(this._name + " HERO DEAD"); }
                if (opponent._HP <= 0) { Console.WriteLine(opponent._name + " OPPONENT DEAD"); }
                return;
            }

        }

        private static void Dividers()
        {
            Console.WriteLine("************************************************************************************************");
        }

        public void Recharge()
        {
            this._stamina = 60;
        }

        public void SayName()
        {
            Console.WriteLine(_name);
        }





    }
}
