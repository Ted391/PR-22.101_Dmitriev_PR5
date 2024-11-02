using System;
using System.Security.Cryptography;
using System.Text;

namespace HashPasswords
{
    public class Hash
    {
        public static string hashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] sourceBytePassw = Encoding.UTF8.GetBytes(password);
                byte[] hashSourceBytePassword = sha256Hash.ComputeHash(sourceBytePassw);
                string hashPassw = BitConverter.ToString(hashSourceBytePassword).Replace("-", String.Empty);
                return hashPassw;
            }
        }
            
    }
}
