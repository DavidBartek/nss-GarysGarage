namespace Garage;

// pre-inheritance:
// public class Tesla  // Electric car
// {
//     public double BatteryKWh { get; set; }
//     public string MainColor { get; set; }
//     public int MaximumOccupancy { get; set; }

//     public void ChargeBattery()
//     {
//         // method definition omitted
//     }
// }

// post-inheritance: 
public class Tesla : Vehicle, IElectricVehicle
{
    public double BatteryKwh { get; set; }

    public int CurrentChargePercentage { get; set; } = 50;

    public void ChargeBattery()
    {
        CurrentChargePercentage = 100;
    }
    public override void Drive ()
    {
        Console.WriteLine($"The {MainColor} Tesla drives past. Whooosh");
        
    }
    public override void Turn (string direction)
    {
        Console.WriteLine($"The Tesla makes a nice {direction} turn.");
        
    }
    public override void Stop ()
    {
        Console.WriteLine($"The Tesla makes a controlled stop.");
        
    }
}