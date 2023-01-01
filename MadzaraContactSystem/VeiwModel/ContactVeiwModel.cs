using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MadzaraContactSystem.Model;
using System.Collections.ObjectModel;
using MadzaraContactSystem.Command;


namespace MadzaraContactSystem.VeiwModel
{
    public class ContactVeiwModel: INotifyPropertyChanged
    {
        #region INotify Property Changed
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
        ContactService ObjContactService;
        public ContactVeiwModel()
        {
            ObjContactService = new ContactService(); 
            LoadData();
            CurrentContact = new Contact();
            saveCommand = new RelayCommand(Save);
            searchCommand = new RelayCommand(Search);
            updateCommand = new RelayCommand(Update);
            deleteCommand= new RelayCommand(Delete);

        }
        #region Display operation

        private ObservableCollection<Contact> contactsList;

        public ObservableCollection<Contact> ContactsList
        {
            get { return contactsList; }
            set { contactsList = value; OnPropertyChanged("ContactsList"); } 
        }
        private void LoadData()
        {
            contactsList = new  ObservableCollection<Contact>( ObjContactService.GetContacts());
        }
        #endregion

        private Contact currentContact;


        public Contact CurrentContact
        {
            get { return currentContact; }
            set { currentContact = value; OnPropertyChanged("CurrentContact");   }
        }
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }
        #region Save opration

        private RelayCommand saveCommand;

        public RelayCommand  SaveCommand
        {
            get { return saveCommand; }
          
        }

        public void Save()
        {
            try
            {
                var isSaved = ObjContactService.Add(CurrentContact);
                LoadData();
                if (isSaved == true)
                {
                    Message = "Contact Saved";
                }else
                {
                    Message = "Contact Not Saved";
                }
            }
            catch (Exception ex)
            {

                Message = ex.Message;
            }
        }
        #endregion

        #region Search region

        private RelayCommand searchCommand;

        public RelayCommand SearchCommand
        {
            get { return searchCommand; }
       
        }
        public void Search()
        {
            try
            {
                var ObjContact = ObjContactService.Search(currentContact.TNumber);
                if(ObjContact != null)
                {
                    CurrentContact.Name = ObjContact.Name;
                    CurrentContact.Email = ObjContact.Email;
                 }
                else
                {
                    Message = "Contact Not found";
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion

        #region Update

        private RelayCommand updateCommand;

        public RelayCommand UpdateCommand
        {
            get { return updateCommand; }
          
        }
        public void Update()
        {
            try
            {
                var isUpdated = ObjContactService.Update(CurrentContact);
                if (isUpdated)
                {
                    Message = "Contact Updated";
                    LoadData();

                }
                else
                {
                    Message = "Update Operation Failed";
                }

            }
            catch (Exception ex)
            {

                Message = ex.Message;
            }
        }
        #endregion

        private RelayCommand deleteCommand;

        public RelayCommand DeleteCommand
        {
            get { return deleteCommand; }
        }
        public void Delete()
        {
            try
            {
                var isDeleted = ObjContactService.Delete(CurrentContact.TNumber);
                if (isDeleted)
                {
                    Message = "Current Contact is Deleted";
                    LoadData();
                }
                else
                {
                    Message = "Delete message Failed";
                }
            }
            catch (Exception ex)
            {

                Message = ex.Message;
            }
        }

    }
}
