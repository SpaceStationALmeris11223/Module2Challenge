// Welcome the use to the program
Console.WriteLine("Welcome to the miles per gallon calculator!");

//Declaring the variables
double milesDriven;
double gallonsUsed;

//Ask the user how many miles they drove
Console.WriteLine("How Many Miles long was your trip?");
milesDriven = double.Parse(Console.ReadLine());
//Ask the user how many gallons of gas they used
Console.WriteLine("How many gallons of gas did you use for this trip?");
gallonsUsed = double.Parse(Console.ReadLine());

//calculate Their Miles Per Gallon 
double mpg = milesDriven / gallonsUsed;
double roundedMPG = Math.Round(mpg, 2);
//output the results 
Console.WriteLine($"you drove {milesDriven} and burned {gallonsUsed} of gas during this trip. Your Miles per gallon is {roundedMPG} ");

