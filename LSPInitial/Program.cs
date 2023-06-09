﻿// See https://aka.ms/new-console-template for more information
using LSPInitial;

Console.WriteLine("The Liskov Substitution Principle (LSP)");

// LSP states that child class objects should be able to replace parent class objects witout compromising application integrity

// We are using a simple Sum Calculator example to describe this principle

var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };
SumCalculator sum = new SumCalculator(numbers);
Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");
Console.WriteLine();
EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");

// If we modify the code as below, we won't be able to get the correct result

SumCalculator Evensum = new EvenNumbersSumCalculator(numbers);

Console.WriteLine($"The sum of all the even numbers: {Evensum.Calculate()}"); // This prints 40 which is incorrect as we need 18 here

