﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalBlackJack
{
    public partial class hongkongPanel : UserControl
    {
        
        public hongkongPanel()
        {
            InitializeComponent();
        }

        private void hongkongPanel_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is mainGameForm mainForm)
            {
                mainForm.ReturnToCarousel();
            }
        }
    }
}
