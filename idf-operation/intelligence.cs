using System;

public class intelligence
{
    private intel[] _inteles = new intel[5];

    public void IntelligenceGathering(hamas ListTerrorists)
    {
        Random random = new Random();

        intel NewIntel = new intel(ListTerrorists.TerroristsList[random.Next(0, ListTerrorists.TerroristsList.Length)]);

        for (int i = 0; i < this._inteles.Length; i++)
        {
            if (this._inteles[i] == null)
            {
                this._inteles[i] = NewIntel;
                Console.WriteLine("Intelligence collected");
                break;
            }
        }
    }

    public intel GetIntel()
    {
        foreach (intel Intel in this._inteles)
        {
            if (Intel.Terrorist.IsLive)
            {
                return Intel;
            }
        }
        throw new Exception("There are no living terrorists.");
    }
}