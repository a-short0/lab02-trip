using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

/*
* Name: Avery Hayden Short
* Course: CSCI 1250, Section 001
* Assignment: Lab 02, Trip Calculator
* Date: September 22, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/

Console.WriteLine(" === Part 1: Road Trip === ");
Console.Write("What was the round trip in miles? ");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the miles per gallon of the car you are using? ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What was the gas price? ");
double gasPrice = Convert.ToDouble(Console.ReadLine());

//do the math

double gallonsNeeded = milesForTheTrip / (double)milesPerGallon;

double fuelCost = gallonsNeeded * gasPrice;

//do the output
System.Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));
System.Console.WriteLine(          );

Console.WriteLine(" === Part 2: Pizza Party === ");
Console.Write("How many people are going to the party? ");
int peopleGoing = Convert.ToInt32(Console.ReadLine());

Console.Write("How many pizzas are you going to get? ");
int pizzaBought = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the price per pizza? ");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());

Console.Write("There is 8 slices per pizza");

const int pizzaSlices = 8;
Console.WriteLine(pizzaSlices);

//do the math

double totalSlices = pizzaBought * pizzaSlices;

double slicesPerPerson = totalSlices / (double)peopleGoing;

double pizzaCost = pizzaBought * pizzaPrice;

//do the output

System.Console.WriteLine("Total Slices; " + totalSlices.ToString("F2"));
System.Console.WriteLine("Slices Per Person " + slicesPerPerson.ToString("F1"));
System.Console.WriteLine("Pizza Cost " + pizzaCost.ToString("C"));
Console.WriteLine("              ");

Console.WriteLine(" === Part 3: Paycheck === "); 
Console.WriteLine("How many hours did you work this week? ");
int hoursWorked = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is your hourly rate?" );
double hourlyRate = Convert.ToDouble(Console.ReadLine());

const double  tax = (double)0.18m;
Console.WriteLine(tax);

//do the math

double grossPay = (double)hoursWorked * tax;
double tax_Withheld = grossPay * tax;
double takeHomePay = grossPay - tax_Withheld;

//do the output

System.Console.WriteLine("Gross Pay; " + grossPay.ToString("C"));
System.Console.WriteLine("Tax Withheld " + tax_Withheld.ToString("C"));
System.Console.WriteLine("Take home pay " + takeHomePay.ToString("F1") );
System.Console.WriteLine(         );
//Part 4 

double tripTotal = fuelCost + pizzaCost;
double costPerPerson = tripTotal / peopleGoing;
double takeHomePayPerHour = takeHomePay / hoursWorked;
double hoursMustBeWorked = costPerPerson / takeHomePayPerHour;

//do the output
Console.WriteLine(" === Part 4: The Whole Trip === ");
System.Console.WriteLine("Trip Total  " + tripTotal.ToString("C") );
System.Console.WriteLine("Cost Per Person  " + costPerPerson.ToString("C") );
System.Console.WriteLine("Take home pay per hour  " + takeHomePayPerHour.ToString("C") );
System.Console.WriteLine("Hours you must work  " + hoursMustBeWorked.ToString("F1") );




