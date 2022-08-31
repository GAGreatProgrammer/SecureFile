using System;
using System.IO;
using System.Security.Cryptography;

namespace SecureFile.Classes
{
    public static class CalculateHASH
    {
        public static string GetMD5HashFromFile(string fileName)
        {
            var md5 = MD5.Create();
            var stream = File.OpenRead(fileName);

            return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
        }
    }
}
