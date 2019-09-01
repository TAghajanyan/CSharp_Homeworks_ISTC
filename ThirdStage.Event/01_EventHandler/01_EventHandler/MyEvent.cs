using System;
using System.IO;

namespace _01_EventHandler
{
    public class MyEvent 
    {
        private event Action<DateTime, StreamWriter> myEvent = null;

        public void AddMethods()
        {
            if (myEvent == null)
            {
                Handlers handlers = new Handlers();
                myEvent += handlers.Handler1;
                myEvent += handlers.Handler2;
                myEvent += handlers.Handler3;
            }
        }

        public void InvokeEvent(DateTime time)
        {
            StreamWriter writer = new StreamWriter("File.txt", true);
            myEvent.Invoke(time, writer);
            writer.Close();
        }
    }
}
