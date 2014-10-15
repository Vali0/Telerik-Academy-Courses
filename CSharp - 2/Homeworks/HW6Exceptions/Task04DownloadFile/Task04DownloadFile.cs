using System;
using System.Net;

//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
//and stores it the current directory. Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

class Task04DownloadFile
{
    static void Main(string[] args)
    {
        String address;
        //Console.WriteLine("Enter your full address: ");
        //address = Console.ReadLine(); // manual address
        
        address = "http://valentin.telerik-students.org/wp-content/uploads/2013/07/cropped-Valentims-Official-Blog.jpg"; // sample
        
        // Maybe couldn't run if your .NET framework is older than 4.5
        String homeFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile); // Getting your home folder
        try
        {
            DownloadMethod(address, homeFolder); // Call the method to download file
        }
        catch (Exception e)
        {
            throw new ApplicationException("Smth really bad happen!", e);
        }
    }

    static void DownloadMethod(String address, String homeFolder)
    {
        using (WebClient client = new WebClient()) // using guarateed closing the stream(not need finally to close streams)
        {
            try
            {
                client.DownloadFile(address, homeFolder + @"\Desktop\logo.png"); // Downloading file into homefolder\Desktop\
            }
            catch (WebException)
            {
                Console.WriteLine("Wrong address!");
            }
            catch (UriFormatException)
            {
                Console.WriteLine("URL address is empty!");
            }
        }
    }
}