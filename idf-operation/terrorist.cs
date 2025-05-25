using System;
public class terrorist
{
    public string name;
    public int rank;
    public string Weapon;
    public bool isLive = true;

    public terrorist(string name, int rank, string Weapon, bool isLive = true)
    {
        this.name = name;
        this.rank = rank;
        this.Weapon = Weapon;
        this.isLive = isLive;
    }
}