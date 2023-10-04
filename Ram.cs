namespace Garage;

// public class Ram  // Gas powered truck
// {
//     public double FuelCapacity { get; set; }
//     public string MainColor { get; set; }
//     public int MaximumOccupancy { get; set; }

//     public void RefuelTank()
//     {
//         // method definition omitted
//     }
// }

public class Ram : Vehicle, IGasVehicle
{
    public double FuelCapacity {get; set;}

    public int CurrentFuelPercentage {get; set;} = 0;
    public void RefuelTank()
    {
        CurrentFuelPercentage = 5;
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram drives past. AHHHHHH! (the sound of mowing down pedestrians because no visibility)");
    }
    public override void Turn(string direction)
    {
        Console.WriteLine($"The Ram slams on the brakes while making a hard {direction} turn, spinning out of control!");
        
    }
    public override void Stop()
    {
        Console.WriteLine($"The Ram's {MaximumOccupancy} occupants, unable to see anything due to the Ram being far too high up, crash into a pole.");
        
    }
}