// See https://aka.ms/new-console-template for more information
using ConsoleUI;

Random myRandom = new Random();

Temperature myTemperatures = new Temperature();



myTemperatures.Insert("TWO");
myTemperatures.Insert("TEN");

//myTemperatures.PrintAllTemperatures();

for (int i = 0; i < 98; i++)
{
    myTemperatures.Insert(myRandom.Next(1, 101));
}


myTemperatures.RunCalculations();

myTemperatures.DisplayCalculations();
