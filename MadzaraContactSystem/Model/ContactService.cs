using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadzaraContactSystem.Model
{
    public class ContactService
    {
        private static List<Contact> ObjContactList;
       
     
        public ContactService()
        {

            var date1 = new DateTime(2022, 12, 31, 8, 30, 52);
            var date2 = new DateTime(2022, 12, 31, 8, 30, 52);
            ObjContactList = new List<Contact>()
            {
               new Contact () { Name="Roland", Email = "roland@gmail.com", TNumber = 78888, Dob = date1},
                new Contact () { Name="Roland", Email = "rand@gmail.com", TNumber = 7888 , Dob = date2},
                  new Contact () { Name="Roland", Email = "rand@gmail.com", TNumber = 7888 , Dob = date2}
             };


          
        }
        List<Contact> contactss = new List<Contact>();

        public List<Contact> GetContacts()
        {
            var dateBound = new DateTime(2006, 5, 1, 8, 30, 52);
            DateTime aDay = DateTime.Now;
            DateTime lDay = DateTime.Now;
         
            bool z = false;
            int y = 0;
            while( z == false ){
                TimeSpan ts = new TimeSpan(y, 0, 0, 0, 0);
                if (Convert.ToString(aDay.DayOfWeek) == "Sunday")
                {            
                  
                    z = true;
                }
                aDay = aDay.Subtract(ts);
                y++;
               
            }
            lDay = aDay.AddDays(7);
           
            for (int i = 0; i < ObjContactList.Count; i++)
            {
                if (ObjContactList[i].Dob > aDay && ObjContactList[i].Dob > lDay)
                {
                    contactss.Add(new Contact { Name = ObjContactList[i].Name, Email = ObjContactList[i].Email, TNumber = ObjContactList[i].TNumber, Dob = ObjContactList[i].Dob });
                }


            }
                return contactss; 
           
        }

        public bool Add(Contact ObjNewContact)
        {
            ObjContactList.Add(ObjNewContact);
            return true;
        }
        public bool Update(Contact ObjContactToUpd) {
        bool isUpdated = false;

            for (int i = 0; i < ObjContactList.Count; i++)
            {
                if (ObjContactList[i].TNumber == ObjContactToUpd.TNumber)
                {
                    ObjContactList[i].Name = ObjContactToUpd.Name;
                    ObjContactList[i].Email = ObjContactToUpd.Email;
                   ObjContactList[i].Dob = ObjContactToUpd.Dob;

                
                    isUpdated = true;
               

                }
            
            }

            for (int i = 0; i < contactss.Count; i++)
            {
                if (contactss[i].TNumber == ObjContactToUpd.TNumber)
                {
                    contactss[i].Name = ObjContactToUpd.Name;
                    contactss[i].Email = ObjContactToUpd.Email;
                    contactss[i].Dob = ObjContactToUpd.Dob;


                    isUpdated = true;


                }

            }
            return isUpdated;
        }
        public bool Delete(int tnumber) {
            bool isRemoved = false;
            for (int i = 0; i < contactss.Count; i++)
            {
                if (contactss[i].TNumber == tnumber)
                {
                    contactss.RemoveAt(i);
                    isRemoved = true;
                    break;
                }
            } 
        
            return isRemoved;
            
        }

        public Contact Search(int tnumber)
        {
            return ObjContactList.FirstOrDefault(e=>e.TNumber == tnumber); 
        }
    }

}
