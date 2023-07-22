using System;
using System.Security.Cryptography;

namespace CCubAPI.Configuration
{
    public class PasswordHasher
    {
        public string HashPassword(string password)
        {
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            byte[] hash = HashPasswordWithSalt(password, salt);

            // Combine the salt and hash and convert to a string for storage
            byte[] saltedHash = new byte[salt.Length + hash.Length];
            Array.Copy(salt, 0, saltedHash, 0, salt.Length);
            Array.Copy(hash, 0, saltedHash, salt.Length, hash.Length);
            return Convert.ToBase64String(saltedHash);
        }

        private byte[] HashPasswordWithSalt(string password, byte[] salt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                return pbkdf2.GetBytes(20); // 20 is the size of the resulting hash
            }
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            byte[] saltedHash = Convert.FromBase64String(hashedPassword);
            byte[] salt = new byte[16];
            byte[] hash = new byte[20];

            // Split the stored hash into the salt and hash
            Array.Copy(saltedHash, 0, salt, 0, salt.Length);
            Array.Copy(saltedHash, salt.Length, hash, 0, hash.Length);

            // Compute the hash of the provided password using the stored salt
            byte[] computedHash = HashPasswordWithSalt(password, salt);

            // Compare the computed hash with the stored hash
            return computedHash.SequenceEqual(hash);
        }
    }
}
