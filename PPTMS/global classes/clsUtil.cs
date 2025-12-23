using System;
using System.IO;
using System.Windows.Forms;

namespace PPTMS.Global_Classes
{
    public class clsUtil
    {
        public static string GenerateGUID()
        {
            Guid guid = Guid.NewGuid();

            return guid.ToString();

        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    // If it doesn't exist, create the folder
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }

            return true;
        }

        public static string ReplaceFileNameWithGUID(string sourceFile)
        {

            string extension = Path.GetExtension(sourceFile);

            return GenerateGUID() + extension;

        }

        public static bool CopyImageToProjectImagesFolder(ref string sourceFile)
        {

            string DestinationFolder = @"C:\CIMS-Images\";

            if (!CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }

            string destinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);

            try
            {
                File.Copy(sourceFile, destinationFile, true);

            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceFile = destinationFile;
            return true;


        }


    }
}
