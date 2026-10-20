class World
{
    
    private string _word;
    private bool _hidden;

    public World(string Word)
    {
        _word = Word;
        _hidden = false;

    }

    public bool isHidden()
    {
        return _hidden;
    }

    public void Hide()
    {
        _hidden = true;
    }

    

}