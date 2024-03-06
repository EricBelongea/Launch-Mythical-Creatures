using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MythicalCreatures.Creatures;

namespace MythicalCreatures.UnitTests
{
    public class HobbitTests
    {
        [Fact]
        public void Hobbit_Constructor_SetsName()
        {
            var bilbo = new Hobbit("Bilbo");
            var peregrin = new Hobbit("Peregrin");
            Assert.Equal("Bilbo", bilbo.Name);
            Assert.Equal("Peregrin", peregrin.Name);
        }

        [Fact]
        public void Hobbit_Constructor_SetsDefaultDisposition()
        {
            var sam = new Hobbit("Samwise");
            Assert.Equal("homebody", sam.Disposition);
        }

        [Fact]
        public void Hobbit_SecondConstructor_SetsDifferentDisposition()
        {
            var frodo = new Hobbit("Frodo", "adventurous");
            Assert.Equal("adventurous", frodo.Disposition);
        }

        [Fact]
        public void Hobbit_Constructor_AgeZeroAtBirth()
        {
            var hobbit = new Hobbit("Meriadoc");
            Assert.Equal(0, hobbit.Age);
        }

        [Fact]
        public void Hobbit_CelebrateBirthday_AgeIncreasesByOne()
        {
            var hobbit = new Hobbit("Meriadoc");
            hobbit.CelebrateBirthday(); // first birthday
            Assert.Equal(1, hobbit.Age);
            for (int i = 1; i < 5; i++) // 4 more birthdays
                hobbit.CelebrateBirthday();
            Assert.Equal(5, hobbit.Age);
        }

        [Fact]
        public void Hobbit_ReachedAdulthood_ChildAtAgeThirtyTwo()
        {
            var hobbit = new Hobbit("Gerontius");
            for (int i = 0; i < 32; i++) // 32 birthdays
                hobbit.CelebrateBirthday();
            Assert.False(hobbit.ReachedAdulthood());
        }

        [Fact]
        public void Hobbit_ReachedAdulthood_AdultAtAgeThirtyThree()
        {
            var hobbit = new Hobbit("Otho");
            for (int i = 0; i < 33; i++) // 33 birthdays
                hobbit.CelebrateBirthday();
            Assert.True(hobbit.ReachedAdulthood());
            hobbit.CelebrateBirthday(); // another birthday
            Assert.True(hobbit.ReachedAdulthood()); // still an adult
        }

        /* Want more tests to write?
         * - Name each test using the convention Class_Method_Result
         * - Create object(s) and run method(s)
         * - Assert equality or truth as needed
         * - Make sure to add [Fact] attribute before each test
         */


        /* A hobbit is considered old at age 101
         * - Create a hobbit
         * - Age the hobbit 101 years
         * - Check method returns `true`
         */
        [Fact]
        public void Hobbit_IsOld_OldWhen101()
        {
            var hobbit = new Hobbit("Kat");
            for (int i = 0; i < 100; i++) // 100 birthdays
                hobbit.CelebrateBirthday();
            Assert.False(hobbit.IsOld()); // Not old until 101
            hobbit.CelebrateBirthday(); // another birthday == 101
            Assert.True(hobbit.IsOld()); // is old now
            hobbit.CelebrateBirthday(); // 102
            Assert.True(hobbit.IsOld()); // Still true, still old.
        }

        /* A hobbit named Frodo has the ring
         * - Create two hobbits named Frodo and Sam
         * - Check method returns `true` for Frodo
         * - Check method returns `false` for Sam
         */

        [Fact]
        public void Hobbit_HasRing_FrodoHasRing()
        {
            var frodo = new Hobbit("Frodo");
            var sam = new Hobbit("Sam");

            Assert.True(frodo.HasRing());
            Assert.False(sam.HasRing());

            var frodo2 = new Hobbit("fRoDo"); // Test checking case insensitivity
            Assert.True(frodo2.HasRing());
        }

        /* A hobbit is short
         * - Create a hobbit
         * - Check method returns `true`
         */

        [Fact]
        public void Hobbit_IsShort_HobbitsAreAllShort()
        {
            var hobbit = new Hobbit("yolo");

            Assert.True(hobbit.IsShort());
        }
    }
}
