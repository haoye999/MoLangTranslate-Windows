using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoLang_cs.UserControls
{
    public partial class ucInput : UserControl
    {
        public ucInput()
        {
            InitializeComponent();
        }

        public Image profileImgaine
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public string text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public Font FontText
        {
            get { return textBox1.Font; }
            set { textBox1.Font = value; }
        }
    }
}
