using System.Diagnostics.Contracts;

public class Auto
{
    public Auto(string merk, string model)
    {
        Merk = merk;
        Model = model;
    }

    public string Merk {get; init;}
    public string Model {get; init;}

    public int Tankinhoud {get; private set;}

    public double Kilometerstand {get; private set;}


}