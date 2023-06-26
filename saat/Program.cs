using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saatee
{
    class zaman
    {
        private int hours;
        private int minutes;
        public int Hours
        {
            get { return hours; }
            set
            {
                if (value > 0)
                {
                    hours = value;
                }
            }
        }
        public int Minuts
        {
            get{ return minutes; }
            set
            {
                if (value > 0)
                {
                    minutes = value;
                }
            }
        }
        public zaman() { }
        public zaman(int Hours,int Minutes ) 
        {
            minutes = Minutes;
            hours = Hours;
        }
        public void saat()
        {
            if (hours <= 0 || minutes <= 0)
            {
                Console.WriteLine("eror");
            }
            else if (hours > 12 && hours < 24)
            {
                Console.WriteLine("pm");
            }
            else
            {
                Console.WriteLine("am");
            }
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hours");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("minutes");
            int minutes = Convert.ToInt32(Console.ReadLine());
            zaman ts = new zaman(hours,minutes);
            ts.saat();
        }
    }
}
