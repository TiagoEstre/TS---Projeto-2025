using iChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iChat.controller
{
    internal static class sessionManager
    {
        public static User CurrentUser { get; set; }

        public static void Login(User user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
        public static bool IsLoggedIn()
        {
            return CurrentUser != null;
        }
    }
}
