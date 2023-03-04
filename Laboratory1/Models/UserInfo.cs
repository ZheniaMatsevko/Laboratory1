using Laboratory1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1.Models
{
    class UserInfo
    {
        private DateTime _dateOfBirth;
        private int _age;
        private WestZodiacSigns _westZodiacSign;
        private ChineseZodiacSigns _chineseZodiacSign;

        public WestZodiacSigns WestZodiacSign
        {
            get { return _westZodiacSign; }
            set { _westZodiacSign = value; }
        }

        public ChineseZodiacSigns ChineseZodiacSign
        {
            get { return _chineseZodiacSign; }
            set { _chineseZodiacSign = value; }
        }


        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

    }
}
