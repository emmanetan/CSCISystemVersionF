﻿using AntdUI;
using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Linq;
using System.Windows.Forms;

namespace AntdUIDemo
{
    public partial class HomeForm : AntdUI.Window
    {
        public HomeForm()
        {
            InitializeComponent();      
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = "Welcome back!";
        }
    }
}
