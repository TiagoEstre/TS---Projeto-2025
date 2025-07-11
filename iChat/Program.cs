﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iChat
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm loginForm1 = new LoginForm();
            LoginForm loginForm2 = new LoginForm();

            loginForm1.Show();

            loginForm2.Show();

            Application.Run(loginForm1);
        }
    }
}
