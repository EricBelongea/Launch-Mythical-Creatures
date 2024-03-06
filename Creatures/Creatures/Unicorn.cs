namespace MythicalCreatures.Creatures
{
    public class Unicorn
    {
        public string Name { get; private set; }
        public string Color { get; private set; }

        public Unicorn(string name)
        {
            Name = name;
            Color = "silver";
        }

        public bool CheckSilver()
        {
            return Color.ToLower() == "silver";
        }

        public void SetColor(string color)
        {
            Color = color;
        }

        public string SaySparkly(string phrase)
        {
            return $"**;* {phrase} **;*";
        }
    }
}
