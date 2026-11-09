class BreathingActivity : BaseActivity
{
    public BreathingActivity(): base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    public void RunActivity()
    {
        StartActivity();

        while(! HasTimerExpired())
        {
            RunCountDownMessage("Breath in", 4);
            if (! HasTimerExpired())
            {
                RunCountDownMessage("Breathe out", 6);
            }
        }

        EndActivity();
    }
}