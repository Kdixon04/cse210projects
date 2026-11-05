class BreathingActivity : BaseActivity
{
    public void RunActivity()
    {
        // call StartActivity() method

        DateTime endTime = DateTime.Now.AddSeconds(20);
        RunCountDownMessage("Get Ready", 5);
        while (DateTime.Now < endTime)
        { 
            RunCountDownMessage("Breath in", 4);
            RunCountDownMessage("Breath out", 6);
        }
        

        // Call EndActivity()
    }
}