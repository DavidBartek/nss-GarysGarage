using Garage;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Zero fxs = new Zero() {MainColor = "Black", MaximumOccupancy = 1, BatteryKwh = 10};
Zero fx = new Zero() {MainColor = "Blue", MaximumOccupancy = 1, BatteryKwh = 10};
Tesla modelS = new Tesla() {MainColor = "Blue", MaximumOccupancy = 5, BatteryKwh = 50};
Cessna mx410 = new Cessna() {MainColor = "White", MaximumOccupancy = 4, FuelCapacity = 43};
Ram dumbTruck = new Ram() {MainColor = "Red", MaximumOccupancy = 2, FuelCapacity = 100};

List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>()
{
    fxs, fx, modelS
};

List<IGasVehicle> gasVehicles = new List<IGasVehicle>()
{
    mx410, dumbTruck
};

fxs.Drive(); 
modelS.Drive();
modelS.Turn("right");
modelS.Stop();
mx410.Drive();
dumbTruck.Drive();
dumbTruck.Turn("left");
dumbTruck.Stop();

Console.WriteLine("Electric vehicles");
foreach(IElectricVehicle ev in electricVehicles)
{
    Console.WriteLine($"{ev.CurrentChargePercentage}");
}

foreach(IElectricVehicle ev in electricVehicles)
{
    ev.ChargeBattery();
}

foreach(IElectricVehicle ev in electricVehicles)
{
    Console.WriteLine($"{ev.CurrentChargePercentage}");
}

// ****************************** //


Console.WriteLine("Gas Vehicles");
foreach(IGasVehicle gv in gasVehicles)
{
    Console.WriteLine($"{gv.CurrentFuelPercentage}");
}

foreach(IGasVehicle gv in gasVehicles)
{
    // This should completely refuel the gas tank
    gv.RefuelTank();
}

foreach(IGasVehicle gv in gasVehicles)
{
    Console.WriteLine($"{gv.CurrentFuelPercentage}");
}