﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NetScrattinoWin
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.Startup += Application_Startup;
        }

        public static string[] CommandLineArgs { get; private set; }
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            if (e.Args.Length == 0)
                return;
            CommandLineArgs = e.Args;
        }
    }
}