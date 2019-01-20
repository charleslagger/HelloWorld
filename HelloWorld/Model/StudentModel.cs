using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace HelloWorld.Model
{
    public class StudentModel { };

    public class Student : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    RaiseItemChanged("LastName");
                    RaiseItemChanged("FullName");
                }
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    RaiseItemChanged("LastName");
                    RaiseItemChanged("FullName");
                }
            }
        }

        public string FullName
        {
            get
            {
                return _firstName + _lastName;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaiseItemChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }

}
