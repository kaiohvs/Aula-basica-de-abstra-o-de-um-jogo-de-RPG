namespace DOTNET_POO.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string herotype)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = herotype;
        }
    }
}