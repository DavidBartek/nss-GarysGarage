using Garage;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Zero fxs = new Zero() {MainColor = "Black", MaximumOccupancy = 1, BatteryKwh = 10};
Tesla modelS = new Tesla() {MainColor = "Blue", MaximumOccupancy = 5, BatteryKwh = 50};
Cessna mx410 = new Cessna() {MainColor = "White", MaximumOccupancy = 4, FuelCapacity = 43};
Ram dumbTruck = new Ram() {MainColor = "Red", MaximumOccupancy = 2, FuelCapacity = 100};

fxs.Drive(); 
modelS.Drive();
modelS.Turn("right");
modelS.Stop();
mx410.Drive();
dumbTruck.Drive();
dumbTruck.Turn("left");
dumbTruck.Stop();