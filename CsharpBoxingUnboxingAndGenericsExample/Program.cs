using System;
using System.Diagnostics;

namespace CsharpBoxingUnboxingAndGenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new ConsoleTraceListener());
            objectAndLongComparison();
            objectAndClassComparison();
        }

        private static void objectAndLongComparison()
        {
            long longCounter = 0;
            object objectCounter = longCounter;
            DateTime timeLongStart, timeLongStop, timeObjectStart, timeObjectStop;
            Trace.WriteLine("Object and Long comparison:");
            timeLongStart = DateTime.Now;
            for (int i = 0; i < int.MaxValue; i++)
            {
                longCounter = longCounter + 1;
            }
            timeLongStop = DateTime.Now;
            Trace.WriteLine(timeLongStop - timeLongStart);

            timeObjectStart = DateTime.Now;
            for (int i = 0; i < int.MaxValue; i++)
            {
                objectCounter = ((long)objectCounter) + 1;
            }
            timeObjectStop = DateTime.Now;
            
            Trace.WriteLine(timeObjectStop - timeObjectStart);
        }

        private static void objectAndClassComparison()
        {

            var timeStart = new DateTime[3];
            var timeStop = new DateTime[3];
            Class1 myClass = new Class1();
            object myObject = myClass;
            dynamic myDynamic = myClass;

            Trace.WriteLine("Object and Class comparison:");
            timeStart[0] = DateTime.Now;

            for (int i = 0; i < int.MaxValue; i++)
            {
                myClass.MyProperty1 = i;
                //myClass.MyProperty2 = string.Empty;
            }
            timeStop[0] = DateTime.Now;
            Trace.WriteLine(timeStop[0] - timeStart[0]);

            timeStart[1] = DateTime.Now;
            for (int i = 0; i < int.MaxValue; i++)
            {
                ((Class1)myObject).MyProperty1 = i;
                //((Class1)myObject).MyProperty2 = string.Empty;
            }
            timeStop[1] = DateTime.Now;
            Trace.WriteLine(timeStop[1] - timeStart[1]);

            timeStart[2] = DateTime.Now;
            for (int i = 0; i < int.MaxValue; i++)
            {
                myDynamic.MyProperty1 = i;
                //myDynamic.MyProperty2 = string.Empty;
            }
            timeStop[2] = DateTime.Now;
            Trace.WriteLine(timeStop[2] - timeStart[2]);

        }
    }
}
