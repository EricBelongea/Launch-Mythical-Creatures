//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MythicalCreatures.Creatures;

//namespace MythicalCreatures.UnitTests
//{
//    public class HobbitTests
//    {
//        [Fact(Skip = "Remove to run this test")]
//        public void Hobbit_Constructor_SetsName()
//        {
//            var bilbo = new Hobbit("Bilbo");
//            var peregrin = new Hobbit("Peregrin");
//            Assert.Equal("Bilbo", bilbo.Name);
//            Assert.Equal("Peregrin", peregrin.Name);
//        }

//        [Fact(Skip = "Remove to run this test")]
//        public void Hobbit_Constructor_SetsDefaultDisposition()
//        {
//            var sam = new Hobbit("Samwise");
//            Assert.Equal("homebody", sam.Disposition);
//        }

//        [Fact(Skip = "Remove to run this test")]
//        public void Hobbit_SecondConstructor_SetsDifferentDisposition()
//        {
//            var frodo = new Hobbit("Frodo", "adventurous");
//            Assert.Equal("adventurous", frodo.Disposition);
//        }

//        [Fact(Skip = "Remove to run this test")]
//        public void Hobbit_Constructor_AgeZeroAtBirth()
//        {
//            var hobbit = new Hobbit("Meriadoc");
//            Assert.Equal(0, hobbit.Age);
//        }

//        [Fact(Skip = "Remove to run this test")]
//        public void Hobbit_CelebrateBirthday_AgeIncreasesByOne()
//        {
//            var hobbit = new Hobbit("Meriadoc");
//            hobbit.CelebrateBirthday(); // first birthday
//            Assert.Equal(1, hobbit.Age);
//            for (int i = 1; i < 5; i++) // 4 more birthdays
//                hobbit.CelebrateBirthday();
//            Assert.Equal(5, hobbit.Age);
//        }

//        [Fact(Skip = "Remove to run this test")]
//        public void Hobbit_ReachedAdulthood_ChildAtAgeThirtyTwo()
//        {
//            var hobbit = new Hobbit("Gerontius");
//            for (int i = 0; i < 32; i++) // 32 birthdays
//                hobbit.CelebrateBirthday();
//            Assert.False(hobbit.ReachedAdulthood());
//        }

//        [Fact(Skip = "Remove to run this test")]
//        public void Hobbit_ReachedAdulthood_AdultAtAgeThirtyThree()
//        {
//            var hobbit = new Hobbit("Otho");
//            for (int i = 0; i < 33; i++) // 33 birthdays
//                hobbit.CelebrateBirthday();
//            Assert.True(hobbit.ReachedAdulthood());
//            hobbit.CelebrateBirthday(); // another birthday
//            Assert.True(hobbit.ReachedAdulthood()); // still an adult
//        }

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



/* A hobbit named Frodo has the ring
 * - Create two hobbits named Frodo and Sam
 * - Check method returns `true` for Frodo
 * - Check method returns `false` for Sam
 */



/* A hobbit is short
 * - Create a hobbit
 * - Check method returns `true`
 */



//    }
//}
