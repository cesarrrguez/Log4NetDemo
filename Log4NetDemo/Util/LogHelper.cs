
using System.Runtime.CompilerServices;
using log4net;

namespace Log4NetDemo.Util
{
    internal class LogHelper
    {
        internal static ILog GetLogger([CallerFilePath]string filename = "")
        {
            return LogManager.GetLogger(filename);
        }
    }
}
