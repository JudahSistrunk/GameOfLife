﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Living_Life
{
    public partial class MainScreen : Form
    {

        public Main mainGame = new Main();

        public MainScreen()
        {
            InitializeComponent();
        }

        public MainScreen(Player newPlayer)
        {
            InitializeComponent();
            mainGame.player = newPlayer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndMonth monthEnd = new EndMonth();
            monthEnd.Show();
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            EndMonth monthEnd = new EndMonth();
            monthEnd.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

            this.Enabled = false;
            LoadScreen loadGame = new LoadScreen(this);
            loadGame.Show();

        }
    }
}
