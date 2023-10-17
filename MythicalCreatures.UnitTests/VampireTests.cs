using MythicalCreatures.Creatures;

namespace MythicalCreatures.UnitTests
{
    public class VampireTests
    {
        [Fact]
        public void Vampire_Constructor_SetsName()
        {
            var dracula = new Vampire("Dracula");
            var vlad = new Vampire("Vladimir");

            Assert.Equal("Dracula", dracula.Name);
            Assert.Equal("Vladimir", vlad.Name);
        }

        [Fact(Skip = "Remove to run this test")]
        public void Vampire_Constructor_SetsPet()
        {
            var ruth = new Vampire("Ruthven");
            Assert.Equal("bat", ruth.Pet);
        }

        [Fact(Skip = "Remove to run this test")]
        public void Vampire_Constructor_SetsDifferentPet()
        { 
            var varney = new Vampire("Varney", "fox");
            Assert.Equal("fox", varney.Pet);
        }

        [Fact(Skip = "Remove to run this test")]
        public void Vampire_Constructor_IsThirstyByDefault()
        {
            var theCount = new Vampire("The Count");
            Assert.True(theCount.IsThirsty);
        }

        [Fact(Skip = "Remove to run this test")]
        public void Vampire_Drink_IsNoLongerThirsty()
        {
            var liz = new Vampire("Elizabeth Bathory");
            liz.Drink();
            Assert.False(liz.IsThirsty);
        }
    }
}
