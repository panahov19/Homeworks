class Car
{
    public void Connect(Old_Diagnostic_Computer computer)
    {
        computer.Connect();
    }
}

class Old_Diagnostic_Computer
{
    public virtual void Connect() { Console.WriteLine( "Old Computer Connected"); }
}


class Adapter : Old_Diagnostic_Computer 
{
    private New_Diagnostic_Computer Computer = new New_Diagnostic_Computer();
    public override void Connect() 
    {
        Computer.NewGenConnect();
    }
}


class New_Diagnostic_Computer
{
    public void NewGenConnect() { Console.WriteLine("New Computer Connected");  }
}




















