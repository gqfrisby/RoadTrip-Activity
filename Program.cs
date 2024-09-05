namespace High_Low_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run = true)
            { 
                        Console.WriteLine("Please insert your the distance (In miles) of your trip");
                        string Miles = "";
                        Miles = Console.ReadLine();
                        double MilesDouble = Convert.ToDouble(Miles);
                        MilesDouble = Math.Round(MilesDouble, 2);
                        Console.WriteLine("Please insert the average MPH of your trip");
                        string MPH = "";
                        MPH = Console.ReadLine();
                        double MPHDouble = Convert.ToDouble(MPH);
                        MPHDouble = Math.Round(MPHDouble, 2);
                        // Console.WriteLine("Miles as Double: " + MilesDouble + " Average MPH: " + MPHDouble);

                        double Time;
                        //Console.WriteLine(Time);
                        if (MPHDouble > 0)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                int speeding = i * 5;
                                Time = MilesDouble * (1 / MPHDouble);
                                TimeSpan timeSpan = TimeSpan.FromHours(Time);
                                int hours = timeSpan.Hours;
                                int minutes = timeSpan.Minutes;
                                int seconds = timeSpan.Seconds;
                                Console.WriteLine("If you went " + speeding + " over the speed limit: Hours:{0} Minutes:{1} Seconds:{2}", hours, minutes, seconds);
                                MPHDouble += 5;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                        }
                
            }
        }
    }
}