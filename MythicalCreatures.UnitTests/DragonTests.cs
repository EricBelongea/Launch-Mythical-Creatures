//using System.Drawing;
//using MythicalCreatures.Creatures;

//namespace MythicalCreatures.UnitTests
//{
//    public class DragonTests
//    {
//        [Fact(Skip = "Remove to run this test")]
//        public void Dragon_Constructor_SetsProperties()
//        {
//            var ramoth = new Dragon("Ramoth", Color.Gold, "Lessa");
//            var mnementh = new Dragon("Mnementh", Color.Brown, "Flar");

//            Assert.Equal("Ramoth", ramoth.Name);
//            Assert.Equal(Color.Gold, ramoth.Color);
//            Assert.Equal("Lessa", ramoth.Rider);
//            Assert.Equal("Mnementh", mnementh.Name);
//            Assert.Equal(Color.Brown, mnementh.Color);
//            Assert.Equal("Flar", mnementh.Rider);
//        }

//        [Fact(Skip = "Remove to run this test")]
//        public void Dragon_Hungry_TrueAtBirth()
//        {
//            var mnementh = new Dragon("Mnementh", Color.Brown, "Flar");
//            Assert.True(mnementh.Hungry());
//        }

//        [Fact(Skip = "Remove to run this test")]
//        public void Dragon_Eat_HungerDecreasesThreeTimesToZero()
//        {
//            var mnementh = new Dragon("Mnementh", Color.Brown, "Flar");
//            Assert.True(mnementh.Hungry());
//            mnementh.Eat(); // 1
//            Assert.True(mnementh.Hungry());
//            mnementh.Eat(); // 2
//            Assert.True(mnementh.Hungry());
//            mnementh.Eat(); // 3
//            Assert.False(mnementh.Hungry());
//        }
//    }
//}
