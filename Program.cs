using System;

namespace DrillOnArray
{
    class Program
    {
        static void Main(string[] args)
        {
       
    Console.WriteLine("Declare an array from January to December");
    Console.WriteLine("--------Question 1-----\nReturn the number of months in the array");
    string [] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
    int numberOfMonths = months.Length;
    Console.WriteLine($"The number of months is : {numberOfMonths}");

    Console.WriteLine("-------Question 2-----\nReturn the rank of the months");
    Console.WriteLine($"The rank of the array of months is : {months.Rank}");
    Console.WriteLine("-------Question 3------\nReverse the array using loop and array method"); 
    Console.WriteLine("Using Loop Method : ");
     for(int i = months.Length - 1; i >= 0; i--)
        {
          Console.WriteLine(months[i]);
        }
    Console.WriteLine("Using Array Method : ");
       Array.Reverse(months);
        foreach(string reversedMonths in months)
        {
          Console.WriteLine(reversedMonths);
        }
    Console.WriteLine("------Question 4------\nSort the months alphabetically");
    Console.WriteLine("The months arranged alphabetically are : ");
    Array.Sort(months);
        foreach(string sortedMonths in months)
        {
            Console.WriteLine(sortedMonths);
        }
    Console.WriteLine("-------Question 5-------\nCopy the first six months to another array");
    string [] months2 = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
    string [] firstSixMonths = new string [6];
        Array.Copy(months2, firstSixMonths, 6);
        foreach(string firstSix in firstSixMonths)
        {
            Console.WriteLine(firstSix);
        }
        Console.WriteLine("-------Question 6--------\nClone the months using array method");
        string [] clonedMonths = (string [])months2.Clone();
        foreach(string clones in clonedMonths)
        {
            Console.WriteLine(clones);
        }
        Console.WriteLine("--------Question 7------\nClear all the months");
        Console.WriteLine("Already cleared months : ");
        Array.Clear(months, 0, months.Length);
        foreach(string cleared in months)
        {
            Console.WriteLine(cleared);
        }
       Console.WriteLine("------Question 8-------\nClear the months starting from index 6");
       Console.WriteLine("Array of months from index 6 : ");
       string [] months3 = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
       Array.Clear(months3, 0, 6);
       foreach(string clearSix in months3)
       {
           Console.WriteLine(clearSix);
       }
        




        }
    }
}
