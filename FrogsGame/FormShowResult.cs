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
    public partial class FormShowResult : Form
    {
        public FormShowResult()
        {
            InitializeComponent();
        }

        private void FormShowResult_Load(object sender, EventArgs e)
        {
            string[] listresult = new string[100];
            StreamReader fileresult = new StreamReader("result.txt");
            int i = 0;
            while (!fileresult.EndOfStream)
            {
                string s = fileresult.ReadLine();
                listresult[i++] = s;
                if(i == 100)
                {
                    break;
                }
            }
            fileresult.Close();
            Array.Sort(listresult);
            for(int j = 0; j < 100; j++)
            {
                if (listresult[j] != null)
                {
                    listBoxResult.Items.Add(listresult[j]);
                }
            }
            
        }
    }
}
