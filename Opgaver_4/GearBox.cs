using System;

namespace Opgaver_4
{
    public class GearBox
    {
        public int CurrentGear { get; set; } = 1;
        public void changeGear(int gear) 
        {
           if(Math.Abs(Math.Abs(CurrentGear) - Math.Abs(gear)) > 1) 
            {
                throw new IllegalGearChangeException("Illegal gear change...");
            }
            CurrentGear = gear;
            Console.WriteLine(gear);
        }
    }

}

