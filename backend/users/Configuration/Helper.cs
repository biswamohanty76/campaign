using CCubAPI.Tenants;

namespace CCubAPI.Configuration
{
    public class Helper
    {
        public static string ProcessUserData(string userPssword)
        {

            PasswordHasher hash = new PasswordHasher();
            if (string.IsNullOrEmpty(userPssword))
                return "";
            return hash.HashPassword(userPssword);
           
        }

        public static bool VerifyUserPassword(string userPssword, string passwordHash)
        {

            PasswordHasher hash = new PasswordHasher();
            if (string.IsNullOrEmpty(userPssword))
                return false;
            return hash.VerifyPassword(userPssword,passwordHash);

        }
    }
}
