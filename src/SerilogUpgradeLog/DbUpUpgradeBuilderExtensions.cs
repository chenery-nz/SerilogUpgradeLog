using DbUp.Builder;
using Serilog;

namespace DbUp.SerilogUpgradeLog;

public static class DbUpUpgradeBuilderExtensions
{
    public static UpgradeEngineBuilder LogToSerilog(this UpgradeEngineBuilder upgradeEngineBuilder)
    {
        return upgradeEngineBuilder.LogTo(new SerilogUpgradeLog(Log.Logger));
    }

    public static UpgradeEngineBuilder LogToSerilog(this UpgradeEngineBuilder upgradeEngineBuilder, SerilogUpgradeLog logger)
    {
        return upgradeEngineBuilder.LogTo(logger);
    }
}