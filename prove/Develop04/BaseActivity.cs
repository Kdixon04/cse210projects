class BaseActivity
{
    public BaseActivity()
    {
        // COMPLETE
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        for(int i = seconds; i>0; i--)
        {   
            Console.Clear();
            Console.WriteLine($"{message} - {i} ");
            Thread.Sleep(1000);
        }
    }
}