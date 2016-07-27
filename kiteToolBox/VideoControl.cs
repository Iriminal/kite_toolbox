using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kiteToolBox {
    public partial class VideoControl : UserControl {
        public VideoControl() {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e) {
            OpenFileDialog chooseFile = new OpenFileDialog();
            if (chooseFile.ShowDialog() == DialogResult.OK) {
                chooseFile.Title = "请选择文件";
                chooseFile.Filter = "所有文件(*.*)|*.*";
                string a = chooseFile.FileName;
                textBox6.Clear();
                textBox6.AppendText(a);

            }
        }

        private void buttonChooseFile_Click(object sender, EventArgs e) {
            FolderBrowserDialog chooseOutPutPath = new FolderBrowserDialog();
            if (chooseOutPutPath.ShowDialog() == DialogResult.OK) {
                chooseOutPutPath.Description = "请选择文件夹";
                string b = chooseOutPutPath.SelectedPath;
                textBox5.Clear();
                textBox5.AppendText(b);
            }
        }
    }
}
