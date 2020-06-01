using log4net;

namespace Log4NetDemo
{
    public class Simulation
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Simulation));

        public void RunSimulation()
        {
            for (var i = 0; i < 10; i++)
            {
                GlobalContext.Properties["Counter"] = i;
                Log.Debug("This is a new iteration");
            }
        }
    }
}