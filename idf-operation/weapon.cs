class weapon
{
    public string name;
    public int remainingStrikes;
    public string target;

    public weapon(string name, int remainingStrikes, string target)
    {
        this.name = name;
        this.remainingStrikes = remainingStrikes;
        this.target = target;
    }
}