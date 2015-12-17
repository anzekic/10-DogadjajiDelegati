using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vsite.CSharp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            buttonDelete.Click += ButtonDelete_Click;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            textBox.Text = string.Empty;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            buttonDelete.Enabled = textBox.TextLength > 0;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
