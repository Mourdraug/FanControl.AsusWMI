using FanControl.Plugins;

namespace FanControl.AsusWMI
{
    internal class AsusWMISensor : IPluginSensor
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public float? Value { get; set; }

        public void Update()
        {
        }

        public uint WmiIndex { get; set; }
        public uint WmiDataType { get; set; }

    }
}
