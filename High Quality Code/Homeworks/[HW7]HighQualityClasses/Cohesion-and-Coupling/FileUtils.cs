namespace CohesionAndCoupling
{
    using System;
    
    public class FileUtils
    {
        // Return extension of the filename.
        public static string GetFileExtension(string fileName)
        {
            if (String.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentNullException("Please enter file name!");
            }
            
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return String.Empty; // or return "File name has no extension"; but this is side effect. 
                                    // I think that this method must return extension if exist or to return null/empty value and catch it by other method/
            }

            string fileNameExtension = fileName.Substring(indexOfLastDot + 1);
            return fileNameExtension;
        }

        // Returns filename without extension
        public static string GetFileNameWithoutExtension(string fileName)
        {
            if (String.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentNullException("Please enter file name!");
            }

            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string fileNameWithoutExtension = fileName.Substring(0, indexOfLastDot);
            return fileNameWithoutExtension;
        }
    }
}