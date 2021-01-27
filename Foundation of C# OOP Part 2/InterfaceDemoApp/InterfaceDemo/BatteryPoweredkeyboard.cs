namespace InterfaceDemo
{
    public class BatteryPoweredkeyboard : Keyboard, IBatteryPowered
    {
        public int BatteryLevel { get; set; }
    }
}
