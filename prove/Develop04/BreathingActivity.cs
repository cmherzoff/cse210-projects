class BreathingActivity : BaseActivity
{
    public BreathingActivity(): base()
    {
    }
    public void RunActivity()
    {
        // call StartActivity() method

        RunCountDownMessage("Get Ready", 5);
        StartTimer();
        // DateTime endTime = DateTime.Now.AddSeconds(20);   // delete later
        // while (DateTime.Now < endTime)
        while(! HasTimerExpired())   // Add when code is ready
        {
            RunCountDownMessage("Breath in", 4);
            RunCountDownMessage("Breathe out", 6);
        }

        // CALL EndActivity()
    }
}