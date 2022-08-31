using System;

namespace SecureFile.Classes
{
    public class GeneratePassword
    {
        const string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string Lowercase = "abcdefghijklmnopqrstuvwxyz";
        const string Numbers = "1234567890";
        const string Symbols = @"~!@#$%^&*():;[]{}<>,.?/\|";


        public string Generate()
        {
            try
            {
                char[] password = new char[15];
                string charSet = "";
                

                Random random = new Random();

                charSet += Uppercase;

                charSet += Lowercase;

                charSet += Numbers;

                charSet += Symbols;

                for (int i = 0; i < 15; i++)
                    password[i] = charSet[random.Next(charSet.Length - 1)];

                return string.Join(null, password);
            }
            catch
            {
                return "Something went wrong!";
            }
        }
    }
}
