namespace Garage;

// public class Zero // electric motorcycle
// {
//     public double BatteryKwh {get; set;}
//     public string MainColor {get; set;}
//     public int MaximumOccupancy {get; set;}
//     public void ChargeBattery()
//     {
//         //
//     }
// }

public class Zero : Vehicle
{
    public double BatteryKwh {get; set;}
    public void ChargeBattery()
    {
        //
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Zero annoys you as it whines past: Reeearrrrrrr");
    }
}