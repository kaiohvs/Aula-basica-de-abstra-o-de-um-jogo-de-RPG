namespace DOTNET_POO.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public override string Attack()
        {
            return this.Name + " Usou a shuriken";
        }
    }
}