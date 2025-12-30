using PPTMS_DataAccessLayar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTMS_BusinessLayer
{
    public class clsTaskAttachment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public int AttachmentID { get; set; }
        public int TaskID { get; set; }
        public clsTask TaskInfo;
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadedDate { get; set; }
        

        public clsTaskAttachment()
        {
            AttachmentID = -1;
            TaskID = -1;
            FileName = "";
            FilePath = "";
            UploadedDate = DateTime.Now;
            

            Mode = enMode.AddNew;
        }

        private clsTaskAttachment(int AttachmentID, int TaskID,string FileName, string FilePath, DateTime UploadedDate)
        {
            this.AttachmentID = AttachmentID;
            this.TaskID       = TaskID;
            this.FileName     = FileName;
            this.FilePath     = FilePath;
            this.UploadedDate = UploadedDate;
            
            TaskInfo = clsTask.Find(TaskID);

            Mode = enMode.Update;
        }

        public static clsTaskAttachment Find(int AttachmentID)
        {
            int TaskID = -1;
            string FileName="", FilePath="";
            DateTime UploadedDate = DateTime.Now;

            if (clsTaskAttachmentsData.GetAttachmentInfoByAttachmentID(AttachmentID, ref TaskID,ref FileName,ref FilePath, ref UploadedDate))
            {
                return new clsTaskAttachment(AttachmentID, TaskID, FileName, FilePath, UploadedDate);
            }
            else
                return null;

        }

        private bool _AddNewAttachment()
        {
            this.AttachmentID = clsTaskAttachmentsData.AddNewAttachment(TaskID, FileName, FilePath , UploadedDate);
            return (AttachmentID != -1);
        }

        private bool _UpdateAttachment()
        {
            return clsTaskAttachmentsData.UpdateAttachment(AttachmentID, FileName, FilePath);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewAttachment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return (_UpdateAttachment());

            }

            return false;
        }

        public bool Delete()
        {
            return clsTaskAttachmentsData.DeleteAttachment(this.AttachmentID);
        }

        public static DataTable GetAllAttachments(int TaskID)
        {
            return clsTaskAttachmentsData.GetAllAttachments(TaskID);
        }


    }
}
