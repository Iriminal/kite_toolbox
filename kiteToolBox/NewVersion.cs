using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kiteToolBox {
    public partial class NewVersion : Form {

        private string newVersion = "";
        private string description = "";

        public NewVersion(string newVer,string des) {
            InitializeComponent();

            this.newVersion = newVer;
            this.description = des;
        }

        private void NewVersion_Load(object sender, EventArgs e) {
            labelUpdate.Text += newVersion;
            richDescription.Text = description;
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
            new MainForm().Show();
        }
    }
}
