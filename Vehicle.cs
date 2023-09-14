namespace Garage;

// this is a base (parent) class.
public class Vehicle
{
    public string MainColor { get; set; }
    public int MaximumOccupancy { get; set; }
    public virtual void Drive()
    {
        Console.WriteLine("Vroooom!");
    }
    public virtual void Turn(string direction)
    {
        Console.WriteLine($"The vehicle makes a hard {direction} turn");
    }
    public virtual void Stop()
    {
        Console.WriteLine($"The vehicle rolls to a nice stop.");
        
    }
}