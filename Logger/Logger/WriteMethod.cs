using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class WriteMethod
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
    }
}
