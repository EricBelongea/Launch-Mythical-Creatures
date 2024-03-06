namespace MythicalCreatures.Creatures
{
	public class Vampire
	{
		public string Name { get; private set; }
		public string Pet { get; private set; }
		public bool IsThirsty { get; private set; }

		public Vampire(string name, string pet = "bat")
		{
			Name = name;
			Pet = pet;
			IsThirsty = true;
		}

		public void Drink()
		{
			IsThirsty = false;
		}
	}
}

