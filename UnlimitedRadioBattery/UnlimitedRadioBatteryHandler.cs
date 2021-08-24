using Exiled.Events.EventArgs;

namespace UnlimitedRadioBattery
{
    public sealed class UnlimitedRadioBatteryHandler
    {
        public UnlimitedRadioBattery plugin;
        public UnlimitedRadioBatteryHandler(UnlimitedRadioBattery plugin) => this.plugin = plugin;

        public void UsingRadioBattery(UsingRadioBatteryEventArgs ev)
        {
            ev.Drain = 0;
        }
    }
}
