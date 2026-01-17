using PPTMS_DataAccessLayar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTMS_BusinessLayer
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 }
        protected enMode Mode = enMode.AddNew;

        public int PersonID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }


        public clsPerson()
        {
            PersonID = -1;
            FullName = "";
            DateOfBirth = DateTime.Now;
            Gender = 0;
            Email = "";
           

            Mode = enMode.AddNew;

        }

        private clsPerson(int PersonID, string FullName, string Email, DateTime DateOfBirth, byte Gender)  
        {
            this.PersonID = PersonID;
            this.FullName = FullName;
            this.Email = Email;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
           
            Mode = enMode.Update;

        }

        public static clsPerson FindBasePerson(int PersonID)
        {
            string FullName = "", Email = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gender = 0;

            if (clsPeopleData.GetPersonInfoByID(PersonID, ref FullName, ref Email , ref DateOfBirth, ref Gender ))
            {
                return new clsPerson(PersonID, FullName, Email, DateOfBirth, Gender);
            }
            else
            {
                return null;
            }


        }



        private bool _AddNewPerson()
        {
            this.PersonID = clsPeopleData.AddNewPerson(this.FullName, this.Email, this.DateOfBirth, this.Gender);
            return (PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPeopleData.UpdatePerson(this.PersonID, this.FullName, this.Email, this.DateOfBirth, this.Gender);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;

                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();

            }

            return false;
        }


        public bool Delete()
        {
            return clsPeopleData.DeletePerson(this.PersonID);
        }

        public static DataTable GetAllPeople()
        {
            return clsPeopleData.GetAllPeople();

        }

        public static bool IsPersonExists(int PersonID)
        {
            return clsPeopleData.IsPersonExists(PersonID);
        }

        public byte GetAge()
        {
            if (PersonID == -1)
                return 0;

            return (byte)(DateTime.Now.Year - DateOfBirth.Year);
        }


    }
}
