using Exiled.API.Interfaces;

namespace UnlimitedRadioBattery
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
    }
}
