using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTime
{
    internal class MyTime
    {
        //instance variables
        private int _hour, _minute, _second;

        //default constructor
        public MyTime()
        {
            _hour = 0;
            _minute = 0;
            _second = 0;
        }

        //paraneterized constructor with validation
        public MyTime(int hour, int minute, int second)
        {
            if (IsValidTime(hour, minute, second))
            {
                _hour = hour;
                _minute = minute;
                _second = second;
            }
            else
            {
                throw new ArgumentException("Invalid hour, minute, or second.");
            }
        }

        //validation helper methods
        private bool IsValidTime(int hour, int minute, int second)
        {
            return hour >= 0 && hour <= 23 &&
                minute >= 0 && minute <= 59 &&
                second >= 0 && second <= 59;
        }

        private bool IsValidHour(int hour) => hour >= 0 && hour <= 23;
        private bool IsValidMinute(int minute) => minute >= 0 && minute <= 59;
        private bool IsValidSecond(int second) => second >= 0 && second <= 59;


        //methods
        public void SetTime(int hour, int minute, int second)
        {
            if (IsValidTime(hour, minute, second))
            {
                _hour = hour;
                _minute = minute;
                _second = second;
            }
            else
            {
                throw new ArgumentException("Invalid hour, minute, or second.");
            }
        }

        public void SetHour(int hour)
        {
            if (IsValidHour(hour))
            {
                _hour = hour;
            }
            else
            {
                throw new ArgumentException("Invalid hour.");
            }
        }

        public void SetMinute(int minute)
        {
            if (IsValidMinute(minute))
            {
                _minute = minute;
            }
            else
            {
                throw new ArgumentException("Invalid minute.");
            }
        }

        public void SetSecond(int second)
        {
            if (IsValidSecond(second))
            {
                _second = second;
            }
            else
            {
                throw new ArgumentException("Invalid second.");
            }
        }

        public int GetHour()
        {
            return _hour;
        }

        public int GetMinute()
        {
            return _minute;
        }

        public int GetSecond()
        {
            return _second;
        }

        public override string ToString()
        {
            return $"{_hour:D2}:{_minute:D2}:{_second:D2}";
        }

        public MyTime NextHour()
        {
            ++_hour;
            if(_hour > 23)
            {
                _hour = 0;
            }
            return this;
        }

        public MyTime NextMinute()
        {
            ++_minute;
            if(_minute > 59)
            {
                _minute = 0;      
                NextHour();
            }
            return this;
        }

        public MyTime NextSecond()
        {
            ++_second;
            if(_second > 59)
            {
                _second = 0;
                NextMinute();
            }
            return this;
        }

        public MyTime PreviousHour()
        {
            --_hour;
            if(_hour < 0)
            {
                _hour = 23;
            }
            return this;
        }

        public MyTime PreviousMinute()
        {
            --_minute;
            if(_minute < 0)
            {
                _minute = 59;
                PreviousHour();
            }
            return this;
        }

        public MyTime PreviousSecond()
        {
            --_second;
            if(_second < 0)
            {
                _second = 59;
                PreviousMinute();
            }
            return this;
        }
    }
}
