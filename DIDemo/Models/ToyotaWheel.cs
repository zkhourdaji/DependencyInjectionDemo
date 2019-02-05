using System;
namespace DIDemo.Models
{
    public class ToyotaWheel : IWheel
    {
        public ToyotaWheel()
        {
        }

        public string Deflate()
        {
            return "Deflating Toyota Wheel";
        }

        public string Dismount()
        {
            return "Dismounting Toyota Wheel";
        }

        public string Inflate()
        {
            return "Inflating Toyota Wheel";
        }

        public string Mount()
        {
            return "Mounting Toyota Wheel";
        }
    }
}
