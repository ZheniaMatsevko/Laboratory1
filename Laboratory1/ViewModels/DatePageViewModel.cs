using Laboratory1.Models;
using Laboratory1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Laboratory1.ViewModels
{

    class DatePageViewModel :INotifyPropertyChanged
    {
        private UserInfo _user = new UserInfo();
        private DateTime? _chosenDate;

        public DateTime DateOfBirth
        {
            get { return _user.DateOfBirth; }
            set { _user.DateOfBirth = value; 
            }
        }

        public string Age
        {
            get { return _user.Age == -1 ? "" : _user.Age.ToString(); }
            set
            {
                _user.Age = int.Parse(value);
                OnPropertyChanged();
            }
        }
        public string WestZodiacSign
        {
            get
            {
                return (_user.WestZodiacSign == WestZodiacSigns.None) ? "" : _user.WestZodiacSign.ToString();
            }
            set
            {
                _user.WestZodiacSign = (WestZodiacSigns)Enum.Parse(typeof(WestZodiacSigns), value);
                OnPropertyChanged();
            }
        }

        public string ChineseZodiacSign
        {
            get { return (_user.ChineseZodiacSign == ChineseZodiacSigns.None) ? "" : _user.ChineseZodiacSign.ToString(); }
            set
            {
                _user.ChineseZodiacSign = (ChineseZodiacSigns)Enum.Parse(typeof(ChineseZodiacSigns), value);
                OnPropertyChanged();
            }
        }

        public DateTime? ChosenDate
        {
            get
            {
                return _chosenDate ??= DateTime.Today;
            }
            set
            {
                if (_chosenDate.Value.CompareTo(value) != 0)
                    ProceedDate(value);
            }
        }

        private void ProceedDate(DateTime? date)
        {
            if (date == null)
                throw new NullReferenceException("Date is null");

            if (!WorkWithDate.checkDate(date.Value))
            {
                MessageBox.Show("Wrong date! The year must be between 1900 and 2023.");              
                return;
            }
            _chosenDate = date.Value;
            DateOfBirth = _chosenDate.Value;
            Age = WorkWithDate.calculateAge(_chosenDate.Value).ToString();
            WestZodiacSign = WorkWithDate.calculateWestZodiacSign(_chosenDate.Value).ToString();
            ChineseZodiacSign = WorkWithDate.calculateChineseZodiacSign(_chosenDate.Value).ToString();

            if(_chosenDate.Value.Day==DateTime.Today.Day && _chosenDate.Value.Month == DateTime.Today.Month)
                MessageBox.Show("Happy birthday!!!");

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
