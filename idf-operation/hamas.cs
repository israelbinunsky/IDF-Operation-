using System;
using System.Collections.Generic;

class hamas
{
    public List<terrorist> terrorists;

    public hamas()
    {
        terrorists = new List<terrorist>();
        addTerrorist("muhamad", 5, "AK47");
        addTerrorist("ali", 4, "M16");
        addTerrorist("ahmad", 3, "M16");
        addTerrorist("mustafa", 3, "gun");
        addTerrorist("abed", 2, "knife");
        addTerrorist("saud", 1, "knife");

    }

    public void addTerrorist(string name, int rank, string Weapon)
    {
        terrorist ter = new terrorist(name, rank, Weapon, true);
        this.terrorists.Add(ter);
    }
}