using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal class TG_Sender
    {
        public string TestText { get; set; }


        public TG_Sender() 
        {
            this.TestText = string.Empty;
        }

        public TG_Sender(string text)
        {
            this.TestText = text;
        }
        public void Send() {
            Console.WriteLine(TestText);
                }
    }
}
