﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Project_4.App_Code;
using Project_4.App_Code.StaticMethods;
using Project_4.User_Classes;

namespace Project_4
{
    public partial class Form1 : Form
    {
        public int index = 0;
        List<Image> pics = Images.pic;
        SearchCategoriesControl sccsearch = new SearchCategoriesControl();
        SearchCategoriesControl sccmusic = new SearchCategoriesControl(1);
        SearchCategoriesControl scctheater = new SearchCategoriesControl(2);
        SearchCategoriesControl sccconferences = new SearchCategoriesControl(3);
        SearchCategoriesControl scceducation = new SearchCategoriesControl(6);
        SearchCategoriesControl sccinforming = new SearchCategoriesControl(7);
        SearchCategoriesControl sccfestivals = new SearchCategoriesControl(4);
        SearchCategoriesControl sccsports = new SearchCategoriesControl(5);
        SearchCategoriesControl sccsoccer = new SearchCategoriesControl(8);
        SearchCategoriesControl sccbasket = new SearchCategoriesControl(9);
        SearchCategoriesControl scccinema = new SearchCategoriesControl(10);
        Advanced_Search searchFilters = new Advanced_Search();
        HomeMain hm1 = new HomeMain();
        HomeMain hm2 = new HomeMain();
        User user = InstanceOfUser.GetUser();
        HomeMain hm = new HomeMain();
        
        public Form1()
        {
            InitializeComponent();
            conferenceSubMenu.BackColor = Color.FromArgb(193, 200, 228);
            sportsSubMenu.BackColor = Color.FromArgb(193, 200, 228);
            hideSubmenus();
            MainPanel.Controls.Clear();
            //HomeMain su = new HomeMain();
            MainPanel.Controls.Add(hm);
            cCircularButton1.Visible = false;
            this.searchButton.Visible = false;
        }

        private void Splash_Animation()
        {
            Splash_Animation sa = new Splash_Animation();
            sa.SetDesktopLocation(500, 500);
            Application.Run(new Splash_Animation());
            homepagePanel.BringToFront();
        }

        public HomeMain GetHome()
        {
            return hm1;
        }

        public string GetSearchText()
        {
            return searchTextBox.Text;
        }

        private void hideSubmenus()
        {
            conferenceSubMenu.Visible = false;
            sportsSubMenu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(hm);
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            SignUpstep1 su = new SignUpstep1();
            MainPanel.Controls.Add(su);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "LOGIN")
            {
                MainPanel.Controls.Clear();
                LogIn su = new LogIn();
                MainPanel.Controls.Add(su);
            }
            else if (button8.Text == "LOGOUT")
            {
                InstanceOfUser.LogOut();
                button8.Text = "LOGIN";
                button7.Visible = true;
                cCircularButton1.Visible = false;
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(hm);
            }
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enventDataSet.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.enventDataSet.category);

        }

        private void festivalsBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(sccfestivals);
        }

        private void educationBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(scceducation);
        }

        private void sportsBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(sccsports);
        }
        private void conferencesBtn_MouseEnter(object sender, EventArgs e)
        {
            if (sideBarPanel.Width == 300)
            {
                conferenceSubMenu.Visible = true;
                sportsSubMenu.Visible = false;
            }
        }

        private void sportsBtn_MouseEnter(object sender, EventArgs e)
        {
            if (sideBarPanel.Width == 300)
            {
                sportsSubMenu.Visible = true;
                conferenceSubMenu.Visible = false;
            }
        }

        private void cCircularButton1_Click(object sender, EventArgs e)
        {
            User x = InstanceOfUser.GetUser();
            if (x is NormalUser)
            {
                MainPanel.Controls.Clear();
                ProfileControl su = new ProfileControl();
                MainPanel.Controls.Add(su);
            }
            else if (x is EventManager)
            {
                MainPanel.Controls.Clear();
                ProfileEventManager su = new ProfileEventManager();
                MainPanel.Controls.Add(su);

            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!MainPanel.Controls[0].Name.Equals("Advanced_Search"))
            {
                String keyword = searchTextBox.Text;
                List<Event> events = new List<Event>();
                events = user.SearchForEvent(keyword);
                if(searchTextBox.TextLength == 0)
                {
                    MainPanel.Controls.Clear();
                    MainPanel.Controls.Add(hm);
                }
                else
                {
                    this.loadResults(events);
                }
            }
            
            #region Comments           
            #endregion
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void searchTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void newsButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(sccinforming);
        }

        private void musicBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(sccmusic);
        }

        private void theaterBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(scctheater);
        }

        private void conferencesBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(sccconferences);
        }

        private void footballBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(sccsoccer);
        }

        private void basketBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(sccbasket);
        }

        private void cinemaBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(scccinema);
        }

        private void adv_src_btn_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(searchFilters))
            {
                MainPanel.Controls.Add(searchFilters);
                searchFilters.BringToFront();
                this.searchButton.Visible = true;
            }
            else
            {
                MainPanel.Controls.Remove(searchFilters);
                this.searchButton.Visible = false;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            String keyword = searchTextBox.Text;
            List<Event> events = new List<Event>();
            String category = searchFilters.GetCategory();
            DateTime since = searchFilters.GetSince();
            DateTime until = searchFilters.GetUntil();
            string city = searchFilters.GetCity();
            events = user.FilterSearch(keyword,category,since,until,city);
            this.loadResults(events);
            this.searchButton.Visible = false;
        }

        protected void loadResults(List<Event> events)
        {
            MainPanel.Controls.Clear();
            int imgIndex = 0;
            int tileIndex = 0;
            int panelIndex = 0;
            Control eventsTile;
            Control.ControlCollection tiles = sccsearch.Controls;
            for (int i = 0; i <= 10; i++)
            {
                eventsTile = tiles[tiles.Count - panelIndex - 1].Controls[tiles[tiles.Count - panelIndex - 1].Controls.Count - tileIndex - 1];
                if (events.Count > i)
                {
                    foreach (Control v in eventsTile.Controls)
                    {
                        if (v is PictureBox)
                        {
                            PictureBox eventPic = (PictureBox)v;
                            Image rszimg = Images.resizeImage(Images.pic.ElementAt(imgIndex), new Size(241, 110));
                            eventPic.Image = rszimg;
                            imgIndex++;
                        }
                        if (v is Label)
                        {
                            Label lb = (Label)v;
                            lb.Text = events.ElementAt(i).GetTitle();
                            eventsTile.Visible = true;
                        }
                    }
                }
                else
                {
                    eventsTile.Visible = false;
                }

                tileIndex++;
                if (tileIndex == 4)
                {
                    panelIndex++;
                    tileIndex = 0;
                }
                if (panelIndex == 3)
                {
                    panelIndex = 0;
                    break;
                }
            }
            MainPanel.Controls.Add(sccsearch);
        }
    }
}
