using System;
using System.Collections.Generic;
using System.Text;

namespace HeThongQuanLiSoDienThoai.Models
{
    class PhoneBook : IPhone

    {
       public List<Phone> PhoneList = new List<Phone>();
        
        public void removePhone(string name)
        {
            if(PhoneList!= null)
            {
                foreach(Phone phoneName in PhoneList)
                {
                    if (phoneName.Name == name)
                    {
                        PhoneList.Remove(phoneName);
                        break;
                    }
                }
            }

        }
        public void insertPhone(Phone item)
        {
            if (PhoneList != null&& checkUser(item.Name))
            {
                foreach (Phone PhoneItem in PhoneList)
                {
                    if (PhoneItem.Name == item.Name)
                    {
                        if (PhoneItem.Phonee != item.Phonee)
                        {
                            PhoneItem.Phonee += ":" + item.Phonee;

                        }
                        else
                        {
                            Console.WriteLine("trong danh ba da ton tai");
                        }

                    }
                    
                }
            }
            else PhoneList.Add(item);






        }
        public void updatePhone(Phone item)
        {
            if (PhoneList != null)
            {
                foreach(Phone phoneName in PhoneList)
                {
                    if (phoneName.Name == item.Name)
                    {
                        phoneName.Phonee = item.NewPhone;
                    }
                }
            }
        }
        public void sort()
        {

        }
        public void searchPhone(string name)
        {
            if(PhoneList!= null) {
                foreach(Phone phoneItem in PhoneList)
                {
                    if (phoneItem.Name == name)
                    {
                        Console.WriteLine("Ket Qua Tim Kiem");
                        Console.WriteLine(phoneItem.Name);
                        Console.WriteLine(phoneItem.Phonee);
                    }
                }
                 }
        }
        public bool checkUser(string userName)
        {
            if(PhoneList!= null)
            {
                foreach (Phone PhoneItem in PhoneList)
                {
                    if (PhoneItem.Name == userName)
                    { 
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
