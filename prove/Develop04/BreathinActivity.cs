class BreathingActivity : Activity
{
    private Timer breathTimer = new Timer();
    
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        breathTimer = _mainTimer;
    }

    public void BreathLoop()
    {
        int inDisplay = 4;                                  // This is what the defualt breath timers will be
        int outDisplay = 6 ;                                // 4 secs for breating in and 6 seconds for breathing out
        breathTimer.StartTimer();
        if(breathTimer.getDuration() % 10 != 0)             //This if statements deals with numbers that are not divisable by 10
        {
            double leftOver = breathTimer.getDuration() % 10;
            inDisplay = int.Parse($"{double.Floor(leftOver/2)}");       // It will calculate a combonation of 2 numbers that will add up to the leftover number
            outDisplay = int.Parse($"{double.Ceiling(leftOver/2)}");
        }
        while(_mainTimer.IsDone() == false)                             // this is the main loop, breath in and out until the timer is up
        {
            Console.Write("Breath In... ");
            while(inDisplay > 0)
            {
                Console.Write(inDisplay);
                Thread.Sleep(1000);
                inDisplay = inDisplay - 1;
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.Write("Breath Out... ");
            while(outDisplay > 0)
            {
                Console.Write(outDisplay);
                Thread.Sleep(1000);
                outDisplay = outDisplay - 1;
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.WriteLine();
            inDisplay = 4;
            outDisplay = 6;
        }
        Console.WriteLine($"You've completed the Breathing Activity For {breathTimer.getDuration()} Seconds!");
        Console.WriteLine();
        Console.WriteLine("Press 'Enter' to continue");
        Console.ReadLine();
    }
}