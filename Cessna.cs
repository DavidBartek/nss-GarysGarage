namespace Garage;

// pre-inheritance from Vehicle
// public class Cessna  // Propellor light aircraft
// {
//     public double FuelCapacity { get; set; }
//     public string MainColor { get; set; }
//     public int MaximumOccupancy { get; set; }

//     public void RefuelTank()
//     {
//         // method definition omitted
//     }
// }

// post-inheritance from Vehicle

public class Cessna : Vehicle, IGasVehicle
{
    public double FuelCapacity { get; set; }

    public int CurrentFuelPercentage {get; set;} = 20;

    public void RefuelTank()
    {
        CurrentFuelPercentage = 100;
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Cessna buzzes your house. Zoooooom!");
    }
}