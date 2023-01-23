using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle
{
public class VehicleList
{
private List<Vehicle> list = new List<Vehicle>();
public void newVehicle()
{
string newMaker;
string newModel;
int newYear;
int newWeight;
Console.WriteLine("Submit maker: ");
newMaker = Console.ReadLine();
Console.WriteLine("Submit model: ");
newModel = Console.ReadLine();
Console.WriteLine("Submit year: ");
newYear = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Submit weight: ");
newWeight = Convert.ToInt32(Console.ReadLine());
Vehicle newVehicle = new Vehicle(newMaker, newModel, newYear, newWeight);
list.Add(newVehicle);
}
public void print()
{
foreach (Vehicle element in list)
{
Console.WriteLine(element.Maker);
Console.WriteLine(element.Model);
Console.WriteLine(element.Year);
Console.WriteLine(element.Weight);
}
}
}
}