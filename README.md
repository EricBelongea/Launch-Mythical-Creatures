# Launch Mythical Creatures

A collection of exercises to practice C# and test-driven design (TDD). This is adapted from [Mythical Creatures](https://github.com/turingschool-examples/mod-1-be-exercises/tree/main/ruby_exercises/mythical-creatures) from the Turing Backend Engineering program.

Make sure you understand the concepts covered in [Unit Testing I](https://launch.turing.edu/module1/lessons/Week4/UnitTestingI) and [Unit Testing II](https://launch.turing.edu/module1/lessons/Week5/UnitTestingII) from Mod 1 of the Launch program.

## How to Run

In order to complete these exercises:
* Fork and clone this repo to your local machine
* Create a class for each of the mythical creatures in the test project. Note that the `unicorn.cs` class has already been created for you.
* Open the test project and run your first test: `UnicornTests.cs`

[Video Walk-Through coming soon...]()

Continue to follow the errors that your test provides until the test passes. Then, unskip the next test by removing the `(Skip)` property from the `[Fact]` attribute. In other words, change this line:

```
[Fact(Skip = "Remove to run this test")]
```

to this:
```
[Fact]
```

Continue for each test for the current creature. Repeat this process until all tests pass for all creatures.

## Suggested Order

* `UnicornTests.cs`
* `VampireTests.cs`
* `DragonTests.cs`
* `HobbitTests.cs`
<!--
* `PirateTests.cs`
* `WizardTests.cs`
* `MedusaTests.cs`
* `WerewolfTests.cs`
* `CentaurTests.cs`
* `OgreTests.cs`
* `DirewolfTests.cs`
* `TheJourneyTests.cs` (see below)

## Extra Challenges

### Additional Testing

* Pick three of the creatures and create a new test file for each
* For each creature, add at least three additional tests / pieces of functionality
* Submit pull requests adding the tests to the repository

### The Dreaded `if` Statement

Can you complete implementations of each of the creatures without using `if`
statements? Think about how removing them affects your code. Remember that
a `switch` is just a different form of `if`, so don't use it.

### Imagine Two Creatures

Can you add two new creatures to the repository? How about a Hydra? Add rspec
tests exercising some of the following concepts:

* Passing data into `initialize`
* Using methods to change the internal state of an instance
* Using methods to query the internal state of an instance
* Functionality that necessitates the internal use of an Array

### So you feel like going on a journey?

 Are you up for an adventure traveller? This test involves the creation of new creatures as well as calling upon
 creatures from times once past.

 To get gold you are required to complete quests that act as mini exercisms; you will see three kinds:
 1. The number of times a letter is different.
 2. Adding up the sum of a number and then squaring it i.e. for 5 => 225 = (1 + 2 + 3 + 4 + 5)**
 3. Turning a num into a roman numeral.
 -->
