namespace CarWorkshopManager.Models;

public class Vehicle(string vin, string plateNo)
{
    public int Id { get; set; }
    
    public string Vin { get; set; } = vin;

    public string PlateNo { get; set; } = plateNo;
}