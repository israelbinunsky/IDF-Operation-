using System.Collections.Generic;

class aman
{
    public List<intel> intels;

    public aman()
    {
        intels = new List<intel>();

    }

    public void addIntel(string terrorist, string location, string timestamp)
    {
        intel i = new intel(terrorist, location, timestamp);
        this.intels.Add(i);
    }
}