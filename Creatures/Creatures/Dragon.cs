using System.Drawing;
namespace MythicalCreatures.Creatures
{
	public class Dragon
	{
		public string Name { get; private set; }
		public string Rider { get; private set; }
		public Color  Color { get; set; }
		public int IsHungry { get; private set; }

		public Dragon(string name, Color color, string rider)
		{
			Name = name;
			Rider = rider;
			Color = color;
			IsHungry = 0;
		}

		public bool Hungry()
		{
			return IsHungry < 3;
		}

		public void Eat()
		{
			IsHungry += 1;
		}
	}
}

