using System;

namespace CurrentDatetimeFunc
{
    public class FunctionHandler
    {
        public void Handle(string input) => Console.WriteLine("Current date:" + DateTime.Now.ToShortDateString());
    }
}
