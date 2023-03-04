using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Laboratory1.Services
{
    enum WestZodiacSigns
    {
        Aries,
        Taurus,
        Gemini,
        Cancer,
        Leo,
        Virgo,
        Libra,
        Scorpio,
        Sagittarius,
        Capricorn,
        Aquarius,
        Pisces
    }
    enum ChineseZodiacSigns
    {
        Rat,
        Ox,
        Tiger,
        Rabbit,
        Dragon,
        Snake,
        Horse,
        Goat,
        Monkey,
        Rooster,
        Dog,
        Pig
    }
    static class WorkWithDate
    {

        public static bool checkDate(DateTime date)
        {
            return (date.CompareTo(DateTime.Today) < 0 && date.Year > 1900);
        }

        public static int calculateAge(DateTime date)
        {
            int age = DateTime.Today.Year - date.Year;

            if (date.Date > DateTime.Today.AddYears(-age)) 
                age--;

            return age;
        }

        public static WestZodiacSigns calculateWestZodiacSign(DateTime date)
        {
            if((date.Month==1 && date.Day>=20) || (date.Month==2 && date.Day<=18))
                return WestZodiacSigns.Capricorn;
            if ((date.Month == 2 && date.Day >= 19) || (date.Month == 3 && date.Day <= 20))
                return WestZodiacSigns.Pisces;
            if ((date.Month == 3 && date.Day >= 21) || (date.Month == 4 && date.Day <= 19))
                return WestZodiacSigns.Aries;
            if ((date.Month == 4 && date.Day >= 20) || (date.Month == 5 && date.Day <= 20))
                return WestZodiacSigns.Taurus;
            if ((date.Month == 5 && date.Day >= 21) || (date.Month == 6 && date.Day <= 20))
                return WestZodiacSigns.Gemini;
            if ((date.Month == 6 && date.Day >= 21) || (date.Month == 7 && date.Day <= 22))
                return WestZodiacSigns.Cancer;
            if ((date.Month == 7 && date.Day >= 23) || (date.Month == 8 && date.Day <= 22))
                return WestZodiacSigns.Leo;
            if ((date.Month == 8 && date.Day >= 23) || (date.Month == 9 && date.Day <= 22))
                return WestZodiacSigns.Virgo;
            if ((date.Month == 9 && date.Day >= 23) || (date.Month == 10 && date.Day <= 22))
                return WestZodiacSigns.Libra;
            if ((date.Month == 10 && date.Day >= 23) || (date.Month == 11 && date.Day <= 21))
                return WestZodiacSigns.Scorpio;
            if ((date.Month == 11 && date.Day >= 22) || (date.Month == 12 && date.Day <= 21))
                return WestZodiacSigns.Sagittarius;

            return WestZodiacSigns.Capricorn;
        }



    }
}
