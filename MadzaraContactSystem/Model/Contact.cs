using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MadzaraContactSystem.Model
{
    public class Contact : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {



            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); 
        
       }
    private int tnumber;

    public int TNumber
    {
        get { return tnumber; }
        set { tnumber = value;OnPropertyChanged("TNumber"); }
    }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged("Email"); }
        }

        private DateTime dob;

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; OnPropertyChanged("Dob"); }
        }
    }
    }

