﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_4.User_Classes;
using Project_4.App_Code.StaticMethods;

namespace Project_4
{
    public partial class Advanced_Search : UserControl
    {

        Pen pen = new Pen(Color.FromArgb(86, 128, 233), 3);
        public Advanced_Search()
        {
            InitializeComponent();
        }

        public string GetCategory()
        {
            return categoryBox.Text;
        }

        public DateTime GetSince()
        {
            return since_dateTimePicker.Value;
        }

        public DateTime GetUntil()
        {
            return until_dateTimePicker2.Value;
        }

        public string GetCity()
        {
            return this.cityBox.Text;
        }

        private void Advanced_Search_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(pen, 0, 45, 230, 45);
        }
    }
}
