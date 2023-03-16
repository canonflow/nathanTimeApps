using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nathanTimeApps
{
    public class NathanTime
    {
        #region FIELDS
        private int _second, _minute, _hour;
        #endregion

        #region CONSTRUCTOR

        public NathanTime()
        {
            this.Second = 0;
            this.Minute = 0;
            this.Hour = 0;
        }
        public NathanTime(int second, int minute, int hour)
        {
            this.Second = second;
            this.Minute = minute;
            this.Hour = hour;
        }
        #endregion

        #region PROPERTIES
        public int Second 
        { 
            get => _second; 
            set
            {
                if (value >= 0 && value <= 59)
                {
                    _second = value;    
                }
                else
                {
                    throw new ArgumentException("Please enter the number in range correctly!");
                }
            }
        }
        public int Minute 
        {
            get => _minute;
            set
            {
                if (value >= 0 && value <= 59)
                {
                    _minute = value;
                }
                else
                {
                    throw new ArgumentException("Please enter the number in range correctly!");
                }
            }
        }
        public int Hour 
        {
            get => _hour;
            set
            {

                if (value >= 0 && value <= 23)
                {
                    _hour= value;
                }
                else
                { 
                
                    throw new ArgumentException("Please enter the number in range correctly!");
                }
            }
        }
        #endregion

        #region METHODS
        public void SetTime(int hh, int mm, int ss)
        {
            Hour = hh;
            Minute = mm;
            Second = ss;
        }

        public int ConvertToSecond()
        {
            int totalSec = Second;

            totalSec += (Hour * 3600) + (Minute * 60);

            return totalSec;
        }

        public void ConvertCurrentTime(int totalSec)
        {
            Hour = totalSec / 3600;
            totalSec %= 3600;
            Minute = totalSec / 60;
            totalSec %= 60;
            Second = totalSec;
        }

        public void AddSecond(int secAdd)
        {
            int totalSecond = ConvertToSecond();
            totalSecond = (totalSecond + secAdd) % 86400;  // Utk seandainya melebihi 23.59, maka akan reset ke 00.00
            ConvertCurrentTime(totalSecond);
        }
        #endregion
    }
}
