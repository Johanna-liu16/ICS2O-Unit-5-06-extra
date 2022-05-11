// Created by: Johanna Liu
// Created on: Mar 2022
//
// This program does basic math
using System;

class Program
{
    public static void Main(string[] args)
    {
        int counterOne;
        int counterTwo;
        var addedNumber = 0;
        var answer = 0;

        //Input 
        Console.WriteLine("This program multiplies two numbers using loops.");
        Console.WriteLine("");
        Console.Write("Enter side a number: ");
        counterOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("Enter another number: ");
        counterTwo = Convert.ToInt32(Console.ReadLine());

        //Process
        if (counterOne > 0 && counterTwo > 0) {
            while (addedNumber < counterTwo) {
                addedNumber = addedNumber + 1;
                answer = answer + counterOne;
            }
        } else if (counterOne < 0 && counterTwo < 0) {
            while (addedNumber > counterTwo) {
                addedNumber = addedNumber - 1;
                answer = answer - counterOne;
            }
        } else if (counterOne > 0 && counterTwo < 0) {
            while (addedNumber > counterTwo) {
                addedNumber = addedNumber - 1;
                answer = answer - counterOne;
            }
        } else if (counterOne < 0 && counterTwo > 0) {
            while (addedNumber < counterTwo) {
                addedNumber = addedNumber + 1;
                answer = answer + counterOne;
            }
        }
            Console.WriteLine(counterOne + " x " + addedNumber + " = " + answer);

        Console.WriteLine("\nDone.");
    }
}