using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class hamas
{
    public Dictionary<string, terrorist> terrorists;
    public List<terrorist> terrorists_list;

    public hamas()
    {
        terrorists = new Dictionary<string, terrorist>();
        terrorists_list = new List<terrorist>();
    }
  
    public void addTerrorist(string name, int rank, string Weapon)
    {
        terrorist ter = new terrorist(name, rank, Weapon, true);
        this.terrorists[name] = ter;
        this.terrorists_list.Add(ter);
    }
}