using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class Circle
    {
        public string Color { get; set; }

    }

    abstract class Device
    {
        public int Volume { get; set; }
        public int Channel { get; set; }
        public bool IsEnabled { get; set; }

    }

    class Tv : Device { }

    class Controller
    {

        public Device Device { get; set; }

        public void Power()
        {
            Device.IsEnabled = !Device.IsEnabled;
        }

        public void VolumeUp()
        {
            if (Device.IsEnabled)
                Device.Volume++;
        }
        public void VolumeDown()
        {
            if (Device.IsEnabled)

                Device.Volume--;
        }
    }
}
