using System;
using System.IO;



namespace Files_Directories
{
    class Program
    {
        static void Main(string[] args)

        {


            string path = @"G:\QALearning";
            Directory.CreateDirectory(path);
            

            string filepath = @"G:\QALearning\UserData.txt";
            File.Create(filepath).Close();



            User carl  = new User("admin", "carl");

            using (StreamWriter stream = new StreamWriter(filepath))
            {
                stream.WriteLine($"Role: {carl.role} \nLogin: {carl.login}");
            }
        }
    }

 
    public class User
    {
        public string role;
        public string login;

        public User(string r, string l)
        {
            role = r;
            login = l;
        }

    }
    

    
}
