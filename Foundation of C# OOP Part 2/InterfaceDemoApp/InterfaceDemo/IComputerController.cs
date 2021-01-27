using System;

namespace InterfaceDemo
{
    public interface IComputerController : IDisposable
    {
        void Connect();
        void CurrentKeyPressed();

    }
}
