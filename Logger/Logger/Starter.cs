namespace Logger
{
    public class Starter
    {
        public string Text { get; set; }

        public string path = "log.txt";

        public void WriteText(string text)
        {
            Text += text;
        }

        public void Save()
        {
            using (var sw = new StreamWriter(path, false))
            {
                sw.WriteLine(Text);
            }
        }

        public void ReadOnlyFromFile()
        {
            if (!File.Exists(path))
            {
                Text = "";
            }
            else
            {
                using (var sr = new StreamReader(path))
                {
                    Text = sr.ReadToEnd();
                }
            }
        }

        public void Run()
        {

            Random random = new Random();
            Actions act = new Actions();
            string buff = string.Empty;
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