using System;
namespace MythicalCreatures.Creatures
{
	public class Hobbit
	{
		public string Name { get; private set; }
		public string Disposition { get; private set; }
		public int Age { get; private set; }

		public Hobbit(string name, string disposition = "homebody")
		{
			Name = name;
			Disposition = disposition;
			Age = 0;
		}

		public void CelebrateBirthday()
		{
			Age += 1;
		}

		public bool ReachedAdulthood()
		{
			return Age > 32;
		}

		public bool IsOld()
		{
			return Age > 100;
		}

		public bool HasRing()
		{
			return Name.ToLower() == "frodo";
		}

		public bool IsShort()
		{
			return true;
		}
	}
}

