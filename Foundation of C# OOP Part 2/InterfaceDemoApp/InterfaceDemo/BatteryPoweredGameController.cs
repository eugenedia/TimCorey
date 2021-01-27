namespace InterfaceDemo
{
    public class BatteryPoweredGameController : GameController, IBatteryPowered
    {
        public int BatteryLevel { get; set; }
    }
}
