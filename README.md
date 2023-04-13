# Mod1 Week4 Assessment
This assessment has two parts - some questions about this week's lessons, and an exercise focused on our Testing lesson. Work on the Questions first, then move on to the Exercise!

## Setup

Fork this repository!

## Questions (12 Points Possible)
Edit this `README.md` file - answer the BLANK questions before moving on to the exercise.  Make sure to SAVE your changes to the README before moving on!

1. Review the class definition below:
    ```c#
    public class Chair
    {
        public int Height { get; }
        public bool HasBack { get; }

        public Chair(int height, bool hasBack)
        {
            Height = height;
            HasBack = hasBack;
        }
    }
    ```
    Which of the following is NOT a valid way to create an instance of Chair? And why does this option not work?  
    A. `var bench = new Chair(24, true);`  
    B. `Chair bench = new Chair(24, true);`  
    C. `var bench = new(24, true);`  
    D. `Chair bench = new(24, true);`  
    
    C is not a valid way to create an instance of Chair because we never tell the computer what kind of object we want to create and that "bench" will be an instance of Chair. Chair is never mentioned in this line of code.
    
2. Imagine you are interviewing for your first job.  The interviewer asks "What can you tell me about OOP?".  Write your response below:
OOP (Object Oriented Programming) is a programming model that uses objects to organize programs into reusable pieces of code. Objects are created through creating classes that can then be utilized multiple times throughout the code. OOP has many benefits including being able to easily reuse code, grouping related information, enforcing rules, and hiding complex functionality.

3. What is Automated Testing?
Automated testing uses a framework to run a lot of test cases at once and confirms the functionality of our code. It is much faster than manual testing and provides meaningful feedback.

4. What are some benefits of creating tests for our projects?
Automated testing is faster and more proactive than manual testing, can use multiple tests at once, and provides feedback based on the expected behavior of code.

5. When you create a test project, you do not immediately have access to the class(es) in the project that you are testing.  What do you need to do in order to have access to those classes?
In order to access classes in a test project, we need to add a project reference.

6. Take a look at the class below.  Write out the **names** of each test you would write to verify that this class is working.
```c#
    public class Vehicle
    {
        public int NumberOfWheels { get; }
        public string Color { get; private set;  }
        public int MilesDriven { get; private set; }

        public Vehicle(int numberOfWheels, string color)
        {
            NumberOfWheels = numberOfWheels;
            Color = color;
            MilesDriven = 0;
        }

        public string Sumary()
        {
            string summary = $"This {Color} vehicle has {NumberOfWheels} wheels, and has driven {MilesDriven} miles.";
            return summary;
        }

        public void Drive()
        {
            MilesDriven += 5;
        }

        public void Paint(string newColor)
        {
            Color = newColor;
        }
    }
```
1. Constructor_WhenInstantiated_SetsPropertyValues()
2. Summary_UtilizesCorrectValues()
3. Confirm_Vechicle_AddsMileageCorrectly
4. Confirm_Vehicle_PaintColor_GetsReassigned


## Exercise (8 Points Possible)
In Visual Studio, clone your forked repository.  
In this solution, there is a `Vehicle` project and a `Vehicle.UnitTests` project.  The class in `Vehicle.cs` is complete, but the tests for that class are not yet finished.  Add tests to the `VehicleTests.cs` file so that all the methods and properties for the `Vehicle` class have tests.  When finished, there should be a minimum of 4 tests (one is already completed for you!).

### Submission

When completed, commit the progress you have made, and push your project to GitHub.  Instructors will be following up with some video feedback!

### Rubric

This assessment has a total of **20 Points**.  Earning **10 or more** points is a **pass** and will indicate that you are progressing well with the material.

As a reminder, this assessment is for students and instructors to determine if there are any areas that need additional reinforcement!
