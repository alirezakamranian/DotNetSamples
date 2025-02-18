using UnitsNet.Units;
using UnitsNet;

//Lendth
Length meter = Length.FromMeters(1);
Length twoMeters = new(2, LengthUnit.Meter);

double cm = meter.Centimeters;
double yards = meter.Millimeters;
double feet = meter.Feet;
double inches = meter.Inches;

Length l1 = 2 * Length.FromMeters(1);
Length l2 = Length.FromMeters(1) / 2;
Length l3 = l1 + l2;

Console.WriteLine(l1+" " +l1.Unit);
Console.WriteLine(l2);
Console.WriteLine(l3);
 
//Weight
string PrintPersonWeight(Mass weight)
{
    return $"You weigh {weight.Kilograms:f10} kg.";
}

Console.WriteLine(PrintPersonWeight(new(1000000, MassUnit.Milligram)));


//Covert By Name
var a = UnitConverter.ConvertByName(1, "length", "kilometer", "mile");

Console.WriteLine(a);
Console.ReadKey();