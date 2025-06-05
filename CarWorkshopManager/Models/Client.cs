namespace CarWorkshopManager.Models;

public class Client(String name, String surname, String email)
{
    public int Id { get; set; }

    public String Name { get; set; } = name;

    public String Surname { get; set; } = surname;

    public String Email { get; set; } = email;

    private List<Vehicle> _vehicles = new List<Vehicle>();

    public void AddVehicle(Vehicle v)
    {
        _vehicles.Add(v);
    }

    public void RemoveVehicle(Vehicle v)
    {
        _vehicles.Remove(v);
    }
}