using PPTMS_DataAccessLayar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTMS_BusinessLayer
{
    public class clsTaskCategory
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public int CategoryID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        

       

        public clsTaskCategory()
        {
            CategoryID = -1;
            UserID = -1;
            Name = "";
            
            Mode = enMode.AddNew;
        }

        private clsTaskCategory(int CategoryID, int UserID,  string Name )
        {
            this.CategoryID = CategoryID;
            this.UserID = UserID;
            this.Name = Name;
            
            Mode = enMode.Update;
        }

        public static clsTaskCategory Find(int CategoryID)
        {
            int UserID = -1;
            string Name = "";

            if (clsTaskCategoriesData.GetCategoryInfoByCategoryID(CategoryID, ref UserID, ref Name))
            {
                return new clsTaskCategory(CategoryID, UserID, Name);
            }
            else
                return null;

        }

        private bool _AddNewCategory()
        {
            this.CategoryID = clsTaskCategoriesData.AddNewCategory(UserID, Name);
            return (CategoryID != -1);
        }

        private bool _UpdateCategory()
        {
            return clsTaskCategoriesData.UpdateCategory(CategoryID, Name);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewCategory())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return (_UpdateCategory());

            }

            return false;
        }

        public bool Delete()
        {
           return clsTaskCategoriesData.DeleteCategory(this.CategoryID);
        }

        public static DataTable GetAllCategories(int UserID)
        {
            return clsTaskCategoriesData.GetAllCategories(UserID);
        }

    }
}
