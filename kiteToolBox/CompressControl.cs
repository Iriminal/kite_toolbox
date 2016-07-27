using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kiteToolBox {
    public partial class CompressControl : UserControl {
        public CompressControl() {
            InitializeComponent();
        }

        private void textBox3_Enter(object sender, EventArgs e) {
            textBox3.Text = "";
            textBox3.ForeColor = Color.Black;
        }
    }
}
