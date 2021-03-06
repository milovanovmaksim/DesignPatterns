using System;
using System.Reflection.PortableExecutable;

namespace EventSub
{
    public class TemperatureEventArgs : EventArgs
    {
        public double Temperature { get; }
        public TemperatureEventArgs(double tempreture)
        {
            Temperature = tempreture;
        }
    }

    public class PressureEventArgs : EventArgs
    {
        public double Pressure { get; }
        public PressureEventArgs(double pressure)
        {
            Pressure = pressure;
        }

    }
}