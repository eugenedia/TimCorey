using System;

namespace InterfaceDemo
{
    public class GameController : IComputerController, IDisposable
    {
        public void Connect()
        {
        }

        public void CurrentKeyPressed()
        {
        }

        public void Dispose()
        {
            // do whatever shutdown tasks needed
        }

        
    }
}
