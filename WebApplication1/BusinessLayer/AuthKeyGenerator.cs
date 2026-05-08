using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace WebApplication1.BusinessLayer
{
    public static class AuthKeyGenerator
    {
        public static string GenerateAuthKey(string VA_Admin_id, string VA_Role, string VA_Password, string VA_Email)
        {
            string idPart = VA_Admin_id ?? string.Empty;
            string rolePart = VA_Role ?? string.Empty;
            string pwdPart = VA_Password ?? string.Empty;
            string emailPart = VA_Email ?? string.Empty;

            // Deterministic key based on the login payload fields.
            string raw = idPart + "|" + rolePart + "|" + pwdPart + "|" + emailPart;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(raw);
                byte[] hash = sha256.ComputeHash(bytes);
                return string.Concat(hash.Select(b => b.ToString("x2")));
            }
        }
    }
}

