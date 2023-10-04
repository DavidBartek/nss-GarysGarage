public interface IElectricVehicle
{
    int CurrentChargePercentage { get; }
    void ChargeBattery();
}