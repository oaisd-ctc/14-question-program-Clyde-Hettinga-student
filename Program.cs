using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        //This is here because repeating their name would feel weird
        Console.WriteLine("What pronouns would you like this program to refer to you by? (enter he, she, or they)");
        string pronouns = Console.ReadLine();

        Console.WriteLine("How old are you?");
        string ageStr = Console.ReadLine();
        int age = int.Parse(ageStr);

        Console.WriteLine("What is your eye color?");
        string eyes = Console.ReadLine();

        Console.WriteLine("What is your hair color?");
        string hair = Console.ReadLine();

        Console.WriteLine("What is your shoe size?");
        string shoes = Console.ReadLine();

        Console.WriteLine("What is your favorite color?");
        string favColor = Console.ReadLine();

        Console.WriteLine("What is your favorite song?");
        string song = Console.ReadLine();

        Console.WriteLine("What is your favorite holiday?");
        string holiday = Console.ReadLine();

        Console.WriteLine("What is your favorite season?");
        string season = Console.ReadLine();

        Console.WriteLine("Who is your favorite teacher?");
        string teacher = Console.ReadLine();

        Console.WriteLine("What is your favorite class?");
        string favClass = Console.ReadLine();

        Console.WriteLine("What is your dream job?");
        string dreamJob = Console.ReadLine();

        Console.WriteLine("How many siblings do you have?");
        string siblings = Console.ReadLine();

        //Format for if/else statements in C# taken from https://www.w3schools.com/cs/cs_conditions.php
        //Comparing strings in if/else statements in C# taken from https://stackoverflow.com/questions/11283764/comparing-strings-in-c-sharp-with-or-in-an-if-statement
        if (pronouns.ToLower().Equals("she"))
        {
            Console.WriteLine("My friend's name is " + name + ". She is " + age + " years old and has " + siblings + " siblings. Her eyes are "
                              + eyes + " and her hair is " + hair + ". She wears size " + shoes + " shoes. Her favorite color is " + favColor +
                              ", favorite song is " + song + ", favorite holiday is " + holiday + ", and favorite season is " + season +
                              ". Her favorite teacher is " + teacher + " and her favorite class is " + favClass + ". Her dream job is to be a "
                              + dreamJob + ". She will be " + (age + 5) + " in 5 years.");
        }
        else if (pronouns.ToLower().Equals("he"))
        {
            Console.WriteLine("My friend's name is " + name + ". He is " + age + " years old and has " + siblings + " siblings. His eyes are "
                              + eyes + " and his hair is " + hair + ". He wears size " + shoes + " shoes. His favorite color is " + favColor +
                              ", favorite song is " + song + ", favorite holiday is " + holiday + ", and favorite season is " + season +
                              ". His favorite teacher is " + teacher + " and his favorite class is " + favClass + ". His dream job is to be a "
                              + dreamJob + ". He will be " + (age + 5) + " in 5 years.");
        }
        else
        {
            Console.WriteLine("My friend's name is " + name + ". They are " + age + " years old and have " + siblings + " siblings. Their eyes are "
                              + eyes + " and their hair is " + hair + ". They wear size " + shoes + " shoes. Their favorite color is " + favColor +
                              ", favorite song is " + song + ", favorite holiday is " + holiday + ", and favorite season is " + season +
                              ". Their favorite teacher is " + teacher + " and their favorite class is " + favClass + ". Their dream job is to be a "
                              + dreamJob + ". They will be " + (age + 5) + " in 5 years.");
        }
    }
}