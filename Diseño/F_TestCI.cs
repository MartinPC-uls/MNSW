﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño
{
    public partial class F_TestCI : Form
    {
        public F_TestCI()
        {
            InitializeComponent();
            SetPregunta();
        }
        private void SetPregunta()
        {
            lblPregunta.Text = "";
        }

    }
}
