namespace Logger
{
    public class Starter
    {
        public void Run()
        {

            Random random = new Random();
            Actions act = new Actions();
            int number = random.Next(0, 3);
            for (int i = 0; i < 100; i++)
            {
                if (number == 0)
                {
                    act.StartMethod();
                }

                if (number == 1)
                {
                    act.SkippedLogicInMethod();
                }

                if (number == 2)
                {
                    act.Method();
                }

                break;
            }
        }
    }
}