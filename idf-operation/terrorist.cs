using System;
public class terrorist
{
    private bool _IsLive = true;

    public void KillHim()
    {
        this._IsLive = false;
        Console.WriteLine("killd");
    }

    public bool IsLive
    {
        get { return this.IsLive; }
    }
}
