using System.Dynamic;

public class IDF
{
    private weapon[] _Weapons = { new weapon(), new weapon(), new weapon() };
    private intelligence _Intelligence = new intelligence();

    public weapon GetWeapon()
    {
        return this._Weapons[0];
    }

    public weapon[] weapons
    {
        get { return this._Weapons; }

    }

    public intelligence Intelligence
    {
        get { return this._Intelligence; }
    }

}