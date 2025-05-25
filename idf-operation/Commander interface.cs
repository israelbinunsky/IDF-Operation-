
public class CommanderInterface
{
    private IDF _IDF = new IDF();
    private hamas _Hamas = new hamas();

    public IDF IDF
    {
        get { return this._IDF; }
    }

    public hamas Hamas
    {
        get { return this._Hamas; }
    }
}