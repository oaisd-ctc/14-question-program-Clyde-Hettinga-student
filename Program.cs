using System;

public class Program
{
    static string name, pronouns, ageStr, eyes, hair, shoes, favColor, song, holiday, season, teacher, favClass, dreamJob, siblings;
    static int age;

    public static void Main(string[] args)
    {
        AskName();
        AskPronouns();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteSong();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskDreamJob();
        AskNumberOfSiblings();
        CalculateAgeIn5Years();
        DisplaySummaryMessage();
    }

    public static void AskName()
    {
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
    }

    public static void AskPronouns()
    {
        Console.WriteLine("What pronouns would you like this program to refer to you by? (enter he, she, or they)");
        pronouns = Console.ReadLine();
    }
    //This is only here because repeating their name would feel weird

    public static void AskAge()
    {
        Console.WriteLine("How old are you?");
        ageStr = Console.ReadLine();
    }

    public static void AskEyeColor()
    {
        Console.WriteLine("What is your eye color?");
        eyes = Console.ReadLine();
    }

    public static void AskHairColor()
    {
        Console.WriteLine("What is your hair color?");
        hair = Console.ReadLine();
    }

    public static void AskShoeSize()
    {
        Console.WriteLine("What is your shoe size?");
        shoes = Console.ReadLine();
    }

    public static void AskFavoriteColor()
    {
        Console.WriteLine("What is your favorite color?");
        favColor = Console.ReadLine();
    }

    public static void AskFavoriteSong()
    {
        Console.WriteLine("What is your favorite song?");
        song = Console.ReadLine();
    }
    //Mr. Luyk said I could change this one

    public static void AskFavoriteHoliday()
    {
        Console.WriteLine("What is your favorite holiday?");
        holiday = Console.ReadLine();
    }

    public static void AskFavoriteSeason()
    {
        Console.WriteLine("What is your favorite season?");
        season = Console.ReadLine();
    }

    public static void AskFavoriteTeacher()
    {
        Console.WriteLine("Who is your favorite teacher?");
        teacher = Console.ReadLine();
    }

    public static void AskFavoriteClass()
    {
        Console.WriteLine("What is your favorite class?");
        favClass = Console.ReadLine();
    }

    public static void AskDreamJob()
    {
        Console.WriteLine("What is your dream job?");
        dreamJob = Console.ReadLine();
    }

    public static void AskNumberOfSiblings()
    {
        Console.WriteLine("How many siblings do you have?");
        siblings = Console.ReadLine();
    }

    public static void CalculateAgeIn5Years()
    {
        age = int.Parse(ageStr);
        age += 5;
    }

    public static void DisplaySummaryMessage()
    {
        /*Format for if/else statements in C# taken from https://www.w3schools.com/cs/cs_conditions.php
        Comparing strings in if/else statements in C# taken from https://stackoverflow.com/questions/11283764/comparing-strings-in-c-sharp-with-or-in-an-if-statement
        I already kind of knew how to do these (courtesy of Java) but wanted to make sure the syntax was right*/

        if (pronouns.ToLower().Contains("she"))
        {
            Console.WriteLine("My friend's name is " + name + ". She is " + ageStr + " years old and has " + siblings + " siblings. Her eyes are "
                              + eyes + " and her hair is " + hair + ". She wears size " + shoes + " shoes. Her favorite color is " + favColor +
                              ", favorite song is \"" + song + "\", favorite holiday is " + holiday + ", and favorite season is " + season +
                              ". Her favorite teacher is " + teacher + " and her favorite class is " + favClass + ". Her dream job is to be a "
                              + dreamJob + ". She will be " + age + " in 5 years.");
        }
        else if (!pronouns.ToLower().Contains("they") && pronouns.ToLower().Contains("he"))
        {
            Console.WriteLine("My friend's name is " + name + ". He is " + ageStr + " years old and has " + siblings + " siblings. His eyes are "
                              + eyes + " and his hair is " + hair + ". He wears size " + shoes + " shoes. His favorite color is " + favColor +
                              ", favorite song is \"" + song + "\", favorite holiday is " + holiday + ", and favorite season is " + season +
                              ". His favorite teacher is " + teacher + " and his favorite class is " + favClass + ". His dream job is to be a "
                              + dreamJob + ". He will be " + age + " in 5 years.");
        }
        else
        {
            Console.WriteLine("My friend's name is " + name + ". They are " + ageStr + " years old and have " + siblings + " siblings. Their eyes are "
                              + eyes + " and their hair is " + hair + ". They wear size " + shoes + " shoes. Their favorite color is " + favColor +
                              ", favorite song is \"" + song + "\", favorite holiday is " + holiday + ", and favorite season is " + season +
                              ". Their favorite teacher is " + teacher + " and their favorite class is " + favClass + ". Their dream job is to be a "
                              + dreamJob + ". They will be " + age + " in 5 years.");
        }
    }
}