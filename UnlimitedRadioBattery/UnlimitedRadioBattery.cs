using Exiled.API.Features;
using System;

namespace UnlimitedRadioBattery
{
    public sealed class UnlimitedRadioBattery : Plugin<Config>
    {
        public override string Author => "SoraCént";
        public override Version Version => new Version(0, 1, 0);
        public override Version RequiredExiledVersion => new Version(3, 0, 0);

        public UnlimitedRadioBatteryHandler Handler;

        public override void OnEnabled()
        {
            base.OnEnabled();

            Handler = new UnlimitedRadioBatteryHandler(this);

            Exiled.Events.Handlers.Player.UsingRadioBattery += Handler.UsingRadioBattery;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();

            Exiled.Events.Handlers.Player.UsingRadioBattery -= Handler.UsingRadioBattery;

            Handler = null;
        }
    }
}
