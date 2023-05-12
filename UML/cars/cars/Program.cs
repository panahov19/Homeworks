interface Car
{
    public void ToWreck() { }
    public void UpdateEngine(double engine) { }
    
}

class CityCar : Car
{

}

class OffRoadCar : Car
{

}


 class Master
{
    protected Car car ;
    public void MakeColor(string color)
    {
        Console.WriteLine($"Color Changed to {color}");
    }

    public void Diagnostic_Check()
    {
        Console.WriteLine("Checked Succesfully");
    }
}

class Sport_Car_Master : Master
{
    void Update()
    {
        car.UpdateEngine(5.5);
        Console.WriteLine("Engine Updated to Sport type");
    }
}










