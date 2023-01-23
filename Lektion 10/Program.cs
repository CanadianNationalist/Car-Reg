namespace Vehicle
{
class Program
{
static void Main(string[] args)
{
int choice = 1;
VehicleList x = new VehicleList();
while (choice != 0)
{
Console.WriteLine("Vehicle register");
Console.WriteLine("==============");
Console.WriteLine("1. Register a new vehicle");
Console.WriteLine("2. Print vehicles");
Console.WriteLine("0. Terminate");
Console.Write("Submit choice of action: ");
choice = Convert.ToInt32(Console.ReadLine());
if (choice == 1)
x.newVehicle();
else if (choice == 2)
x.print();
}
}
}
}
