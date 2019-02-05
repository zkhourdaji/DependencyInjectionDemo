using System;
namespace DIDemo.Models
{
    public class HondaWheel : IWheel
    {
        public HondaWheel()
        {
        }

        public string Deflate()
        {
            return "Deflating Honda Wheel";
        }

        public string Dismount()
        {
            return "Dismounting Honda Wheel";
        }

        public string Inflate()
        {
            return "Inflating Honda Wheel";
        }

        public string Mount()
        {
            return "Mounting Honda Wheel";
        }
    }
}
