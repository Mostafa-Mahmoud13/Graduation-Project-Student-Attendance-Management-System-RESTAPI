using System.Security.Cryptography;
using System.Text;
namespace Final_Project.secure
{
    public static class QrHelper
    {
        private static string secretKey = "MY_SECRET_KEY_123";

        public static string GenerateHash(int studentId)
        {
            using (var sha = SHA256.Create())
            {
                var raw = studentId + secretKey;
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(raw));

                return Convert.ToBase64String(bytes);
            }
        }

        public static bool Validate(int studentId, string hash)
        {
            return GenerateHash(studentId) == hash;
        }
    }
}