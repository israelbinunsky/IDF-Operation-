using System;
using System.Collections.Generic;

class hamas
{
    public List<terrorist> terrorists;


    public static terrorist createTer(string name, int rank, string Weapon)
    {
        terrorist ter = new terrorist(name, rank, Weapon, true);
        return ter;
    }

}