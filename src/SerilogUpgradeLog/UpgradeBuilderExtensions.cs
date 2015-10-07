using DbUp.Builder;

namespace SerilogUpgradeLog
{
    public static class UpgradeBuilderExtensions
    {
        public static UpgradeEngineBuilder LogToSerilog(this UpgradeEngineBuilder upgradeEngineBuilder)
        {
            return upgradeEngineBuilder.LogTo(new SerilogUpgradeLogger());
        }
    }
}
