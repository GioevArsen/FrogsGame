using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogsGame
{
    public partial class EnterUserName : Form
    {
        public int score = 10000;
        
        
        public EnterUserName()
        {
            InitializeComponent();
        }

        private void buttonSaveUserName_Click(object sender, EventArgs e)
        {
            StreamWriter fileresult = new StreamWriter("result.txt", true);
            fileresult.WriteLine(score.ToString() + "\t" + textBoxUserName.Text);
            fileresult.Close();
            this.Close();
        }
    }
}
