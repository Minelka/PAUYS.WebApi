using System.Security.Cryptography;
using System.Text;

namespace PAUYS.Common
{
    public static class PasswordHash
    {
        public static string StringToHash(string text)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToUpperInvariant();
            }
        }

        public static bool HashValid(string text, string hashText)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                string _hashText = BitConverter.ToString(hashBytes).Replace("-", "").ToUpperInvariant();

                return hashText == _hashText;
            }
        }
    }
}
