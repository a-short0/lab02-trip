using System.Reflection.Metadata;

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

Console.WriteLine("How many hours did you work this week? ");
int hoursWorked = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is your hourly rate? ");


const int taxRate = 18;
Console.WriteLine(taxRate);

//do the math

double grossPay = hoursWorked * taxRate;
double taxWithheld = grossPay * taxRate;
double takeHomePay = grossPay - taxWithheld;

//do the output

System.Console.WriteLine("Gross Pay; " + grossPay.ToString("C"));
System.Console.WriteLine("Tax Withheld " + taxWithheld.ToString("C"));
System.Console.WriteLine("Take home pay " + takeHomePay.ToString("C") );




