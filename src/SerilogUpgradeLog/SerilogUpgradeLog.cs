using System;
using DbUp.Engine.Output;
using Serilog;

namespace SerilogUpgradeLog
{
    public class SerilogUpgradeLog : IUpgradeLog
    {
        public void WriteInformation(String format, params Object[] args)
        {
            Log.Information(String.Format(format, args));
        }

        public void WriteError(String format, params Object[] args)
        {
            Log.Error(format, args);
        }

        public void WriteWarning(String format, params Object[] args)
        {
            Log.Warning(format, args);
        }
    }
}
