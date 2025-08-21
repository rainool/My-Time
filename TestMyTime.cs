namespace MyTime
{
    internal class TestMyTime
    {
        static void Main(string[] args)
        {
            //Default time
            MyTime t1 = new MyTime();
            Console.WriteLine("Default: " + t1.ToString());

            //SetTime
            t1.SetTime(12, 30, 45);
            Console.WriteLine("SetTime: " + t1.ToString());

            //SetHour, SetMinute, SetSecond
            t1.SetHour(5);
            t1.SetMinute(15);
            t1.SetSecond(20);
            Console.WriteLine("SetHour/Minute/Second: " + t1.ToString());

            //GetHour, GetMinute, GetSecond
            Console.WriteLine($"Hour: {t1.GetHour()}, Minute: {t1.GetMinute()}, Second: {t1.GetSecond()}");

            //NextMinute
            t1.SetTime(10, 59, 59);
            t1.NextMinute();
            Console.WriteLine("NextMinute: " + t1.ToString());

            //PreviousMinute
            t1.PreviousMinute();
            Console.WriteLine("PreviousMinute: " + t1.ToString());

            //NextHour
            t1.SetTime(23, 59, 59);
            t1.NextHour();
            Console.WriteLine("NextHour: " + t1.ToString());

            //PreviousHour
            t1.PreviousHour();
            Console.WriteLine("PreviousHour: " + t1.ToString());



            //parameterized constructor
            Console.WriteLine("---------------------------");
            MyTime t2 = new MyTime(23, 59, 59);
            Console.WriteLine("Parameterized: " + t2.ToString());

            //NextSecond
            t2.NextSecond();
            Console.WriteLine("NextSecond: " + t2.ToString());

            //PreviousSecond
            t2.PreviousSecond();
            Console.WriteLine("PreviousSecond: " + t2.ToString());

        }
    }
}
