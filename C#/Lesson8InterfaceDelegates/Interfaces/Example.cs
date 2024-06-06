using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICanTakePhoto
    {
        void TakePhotpo();
    }
    abstract class Electronic
    {
        public string Vendor { get; set; }
        public string Model { get; set; }
    }

    class Phone : Electronic, ICanTakePhoto
    {
        public void TakePhotpo() { }
    }

    class Computer : Electronic, ICanTakePhoto
    {
        public void TakePhotpo() { }
    }

    class Camera : Electronic, ICanTakePhoto 
    {
        public void TakePhotpo() { }
    }

    class Printer : Electronic
    {

    }

    class Person
    {
        public void TakePhoto(ICanTakePhoto takePhoto)
        {

            // shekil chekir
        }
    }
}
