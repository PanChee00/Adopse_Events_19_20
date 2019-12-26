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
    public partial class HomeMain : UserControl
    {
        public HomeMain()
        {
            InitializeComponent();
        }

        private void HomeMain_Load(object sender, EventArgs e)
        {
            int indexImg;
            int indexEv;

            Dictionary<string, int> category = new Dictionary<string, int>();
            category["musicPanel"] = 1; category["theaterPanel"] = 2; category["conferencePanel"] = 3; category["festivalsPanel"] = 4; category["sportsPanel"] = 8;
            User user = InstanceOfUser.GetUser();
            List<Event> events = App_Code.StaticMethods.Events.events;
            List<Event> eventsCat = new List<Event>();
            List<Categories> cat = Categories.categories;
            foreach (Control i in flowLayoutPanel1.Controls)
            {
                indexImg = 0;
                indexEv = 0;
                eventsCat = events.FindAll(x => x.GetCategory() == category[i.Name]);
                foreach (Control k in i.Controls)
                {
                    foreach(Control p in k.Controls)
                    {   
                        if (indexImg < eventsCat.Count)
                        {
                            if (p is PictureBox)
                            {
                                PictureBox pic = (PictureBox)p;
                                pic.Image = Images.pic.ElementAt(indexImg);
                                indexImg++;
                            }
                            if (p is Label)
                            {
                                Label lb = (Label)p;
                                lb.Text = eventsCat.ElementAt(indexEv).GetTitle();
                                indexEv++;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
