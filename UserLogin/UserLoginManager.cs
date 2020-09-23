using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogin
{
    /// <summary>
    /// This user login manager manages a simple list of users and there passwords (string, string)
    /// Username is unique
    /// Password needs to contain a letter and a digit(number)
    /// Defualt UserLoginManager will have two users: admin & guest
    /// </summary>
    public class UserLoginManager
    {
        //Stores user & password
        private Dictionary<string, string> userDict;

        public UserLoginManager()
        {
            userDict = new Dictionary<string, string>()
            {   // init with two users in the dictionary: admin & guest
                { "admin", "Qwerty123"   },
                { "guest", "Password123" }
            };
        }

        public UserLoginManager(Dictionary<string, string> userDict)
        {
            this.userDict = userDict;
        }

        /// <summary>
        /// Get amount of users
        /// </summary>
        /// <returns>int amount of users</returns>
        public int UserCount()
        {
            return userDict.Count;
        }

        /// <summary>
        /// Checks if Username Excists
        /// </summary>
        /// <param name="userName">true or false</param>
        /// <returns></returns>
        public bool UserExcists(string userName)
        {
            return userDict.ContainsKey(userName);
        }

        /// <summary>
        /// Add a new Username and there password
        /// </summary>
        /// <param name="userName">Must be unique</param>
        /// <param name="password">Must be valid</param>
        /// <returns></returns>
        public bool AddUser(string userName, string password)
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

        /// <summary>
        /// Logins in valid user
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>returns true if its a valid login otherwise false</returns>
        public bool LoginUser(string userName, string password)
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

        /// <summary>
        /// Validates password
        /// Must contain a letter and a digit(number)
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidatePassword(string password)
        {
            if (password.Any(char.IsDigit) && password.Any(char.IsLetter))
            {
                return true;
            }

            return false;
        }

    }
}
