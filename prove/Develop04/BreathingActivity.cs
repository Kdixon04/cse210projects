class BreathingActivity : BaseActivity
{

    // No attributes to initialize so the constructor is empty
    public BreathingActivity() : base()
    {
        
    }
    public void RunActivity()
    {
        // call StartActivity() method
        RunCountDownMessage("Get Ready", 5);
        StartTimer();
        // DateTime endTime = DateTime.Now.AddSeconds(20); // Delete Later 
        // while (DateTime.Now < endTime)
        while (! HasTimerExpired()) // When Code is ready
        { 
            RunCountDownMessage("Breath in", 4);
            RunCountDownMessage("Breath out", 6);
        }
        

        // Call EndActivity()
    }
}