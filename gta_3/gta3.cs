﻿using System;
using System.Windows.Forms;

namespace gta_3
{
    static class gta3
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new gta_3());
        }
    }
}
