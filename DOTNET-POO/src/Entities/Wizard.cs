namespace DOTNET_POO.src.Entities
{
    public class Wizard : Hero
    {

        public Wizard(string name, int level, string herotype)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = herotype;
        }

        public override string Attack()
        {
            return this.Name + " lançou magia";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " lançou magia super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " lançou magia com força fraca com bonus de  " + Bonus;
            }
        }
    }
}