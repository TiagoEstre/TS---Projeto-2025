using iChat.Models;
using System;

namespace iChat.controller
{
    internal static class sessionManager
    {
        public static User CurrentUser { get; set; }

        // ⚠️ NOVO: Chave privada RSA do utilizador autenticado (para assinatura digital)
        public static string CurrentUserPrivateKey { get; set; }

        public static void Login(User user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
            CurrentUserPrivateKey = null; // limpa também a chave privada ao fazer logout
        }

        public static bool IsLoggedIn()
        {
            return CurrentUser != null;
        }
    }
}
