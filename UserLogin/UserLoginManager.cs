using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogin
{
    /// <summary>
    /// This user login manager manages a simple list of users and there passwords (string, string)
    /// Username is unique
    /// Password needs to contain a letter and a digit(number)
    /// </summary>
    public class UserLoginManager
    {

        private static Dictionary<string, string> userDict = new Dictionary<string, string>()
        {   // init with two users in the dictionary: admin & guest
            { "admin", "Qwerty123"   },
            { "guest", "Password123" }
        };


        public static int UserCount()
        {
            return userDict.Count;
        }

        public static bool UserExcists(string userName)
        {
            return userDict.ContainsKey(userName);
        }

        public static bool AddUser(string userName, string password)
        {
            if (UserExcists(userName) || ValidatePassword(password))
            {
                return false;
            }
            else
            {
                userDict.Add(userName, password);
                return true;
            }

        }

        public static bool LoginUser(string userName, string password)
        {
            if (UserExcists(userName))
            {
                string userPass = "";

                if (userDict.TryGetValue(userName, out userPass))
                {
                    if (userPass.Equals(password))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool ValidatePassword(string password)
        {
            if (password.Any(char.IsDigit) && password.Any(char.IsLetter))
            {
                return true;
            }

            return false;
        }

    }
}
