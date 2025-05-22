using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class hamas
{
    public List<terrorist> terrorists;

    public hamas()
    {
        terrorists = new List<terrorist>();  
    }
  
    public void addTerrorist(string name, int rank, string Weapon)
    {
        terrorist ter = new terrorist(name, rank, Weapon, true);
        this.terrorists.Add(ter);
    }
}