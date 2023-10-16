using MythicalCreatures;

namespace MythicalCreatures.UnitTests
{
    public class UnicornTests
    {
        [Fact]
        public void Constructor_WhenInstantiated_SetsPropertyValues()
        {
            var unicorn = new Unicorn("Richard");
            Assert.Equal("Richard", unicorn.Name);
            Assert.Equal("silver", unicorn.Color);
        }

        [Fact(Skip = "Remove to run this test")]
        public void Unicorn_CheckSilver_ReturnsTrue()
        {
            var unicorn = new Unicorn("Margaret");
            Assert.True(unicorn.CheckSilver());
        }

        [Fact(Skip = "Remove to run this test")]
        public void Unicorn_SetColor_ColorChanged()
        {
            var unicorn = new Unicorn("Barbara");
            unicorn.SetColor("purple");
            Assert.Equal("purple", unicorn.Color);
            Assert.False(unicorn.CheckSilver());
        }

        [Fact(Skip = "Remove to run this test")]
        public void Unicorn_SaySparkly_AddFlourish()
        {
            var unicorn = new Unicorn("Johnny");
            string output1 = unicorn.SaySparkly("Wonderful!");
            Assert.Equal("**;* Wonderful! **;*", output1);
            string output2 = unicorn.SaySparkly("I don't like you very much.");
            Assert.Equal("**;* I don't like you very much. **;*", output2);
        }
    }
}