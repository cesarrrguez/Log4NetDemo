using System;
using log4net;

namespace Log4NetDemo
{
    internal class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        private static void Main()
        {
            Console.WriteLine("Welcome to Log4NetDemo");
            Console.WriteLine("----------------------\n");

            //Log.Debug("Entering application");

            //Log.Info("This is an info message");
            //Log.Warn("This is a warning message");
            //Log.Error("This is an error message");
            //Log.Fatal("This is a fatal message");

            //Log.Debug("Exiting application");

            var simulation = new Simulation();
            simulation.RunSimulation();

            Console.WriteLine("\nPress any key to exist");
            Console.ReadKey();
        }
    }
}
