using System;
using System.Collections.Generic;
using System.Linq;
using DotnetIteration.Models;

namespace DotnetIteration
{
  public static class Iteration
  {
    /*
       Welcome to Interation
       Down below you will find instructions for code to write.
       As you write and save your code, you can look in your terminal where you
       ran `dotnet watch test` to see if your code is working. The tests continuously check
       your work each time you save. If a test is failing you have not yet completed that method
       Once you finish a method and have it correct, the test will tell you how
       the next method is working.
    */

    /*  
      * 1) Define a function named `yelling` that takes an list of
      * strings as an argument and returns a new list with all
      * the words forced to uppercase
      *
    
   */
    public static IEnumerable<string> Yelling(List<string> words)
    {
      var yellingOutput = words.Select(word => word.ToUpper());
      return yellingOutput;
    }

    /* 
      * 2) Define a function named `doubleTrouble` that takes an list of
      * numbers as an argument and returns a new list with all
      * the numbers multiplied by 2
      */

    public static IEnumerable<int> Double(List<int> numbers)
    {
      var doubleOutput = numbers.Select(number => number * 2);
      return doubleOutput;
    }
    /*
      * 3) Define a function stringyIndexes() that takes an list of
      * strings as an argument and returns a new list with each string
      * suffixed with " is at index X" where X is the index of the element
      */
    public static IEnumerable<string> StringyIndexes(List<string> data)
    {
      var stringOutput = new List<string>();

      for (var i = 0; i < data.Count; i++)
      {
        stringOutput.Add($"{data[i]} is at index {i}");
      }

      return stringOutput;
    }
    /*
       * 4) Define a function onlyTheEvenSurvive that accepts an list of
       * numbers and returns only the elements that are even
       */

    public static IEnumerable<int> OnlyTheEvenSurvive(List<int> data)
    {
      var evenNumbers = data.Where(number => number % 2 == 0);
      return evenNumbers;
    }
    /*
        * 5) Define a function onlyTheEvenIndexedSurvive that accepts an list of
        * numbers and returns only the elements at indexes that are even
        */
    public static IEnumerable<int> OnlyTheEvenIndexedSurvive(List<int> data)
    {
      var evenIndexedNumbers = new List<int>();

      for (var i = 0; i < data.Count; i++)
      {
        if (i % 2 == 0)
        {
          evenIndexedNumbers.Add(data[i]);
        }
      }

      return evenIndexedNumbers;
    }
    /*
      * 6)  Define a function bestMoviesOfTheYear that accepts an list of
      * movie objects AND a year and returns the names of movies that are
      * from that year AND have a score more than 90
      *
      * A movie object looks like this:
      *
      * {
      *   name: "Get Out",
      *   year: "2017",
      *   score: 99
      * }
      */
    public static IEnumerable<string> BestMovieOfTheYear(List<Movie> data, int year)
    {
      var movieList = new List<string>();

      foreach (var movie in data)
      {
        if (movie.Year == year && movie.Score > 90)
        {
          movieList.Add(movie.Name);
        }
      }

      return movieList;
    }

    /*
      * 7) Define a function everyoneIsOdd that accepts an list of
      * numbers and returns true if every element of the list is
      * odd.
      */

    public static bool EveryoneIsOdd(List<int> data)
    {
      var isOdd = true;

      foreach (var number in data)
      {
        if (number % 2 == 0)
        {
          isOdd = false;
        }
      }

      return isOdd;
    }
    /*
      * 8) Define a function findTheNeedle that accepts an list of
      * strings and returns the one string that contains the word
      * `needle` 
      */
    public static string FindTheNeedle(List<string> data)
    {
      var needleString = "";

      foreach (var sentence in data)
      {
        if (sentence.IndexOf("needle") > 0)
        {
          needleString = sentence;
          break;
        }
      }

      return needleString;
    }

    /*
        * 9) Define a function findTheNeedleIndex that accepts an list of
        * strings and returns the index of the string that contains
        *  the word `needle` inside
        */

    public static int FindTheNeedleIndex(List<string> data)
    {
      var needleString = 0;

      for (var i = 0; i < data.Count; i++)
      {
        if (data[i].IndexOf("needle") > 0)
        {
          needleString = i;
        }
      }

      return needleString;
    }

    /*
      *` 10)  Define a function someoneToLove that accepts an list of
      * strings and returns true if at least one string is exactly
      * four characters long
      */


    public static bool SomeoneToLove(List<string> data)
    {
      var foundFourLetterWord = false;

      foreach (var word in data)
      {
        if (word.Length == 4)
        {
          foundFourLetterWord = true;
          break;
        }
      }

      return foundFourLetterWord;
    }
  }

}