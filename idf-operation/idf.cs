using System.Runtime.CompilerServices;

class idf
{
    public weapon F16;
    public weapon Hermes460;
    public weapon M109;

    public idf()
    {
        F16 = new weapon("F16 Fighter Jet", 8, "building");
        Hermes460 = new weapon("zik Drone", 3, "car");
        M109 = new weapon("M109 Artillery", 40, "open space");
    }
}