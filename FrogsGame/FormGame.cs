using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogsGame
{
    public partial class FormGame : Form
    {
        Image imgfrogleft, imgfrogright, imgleaf;
        int[] fieldStart = {2, 2, 2, 2, 1, 0, 1, 1, 1};
        int[] field = { 2, 2, 2, 2, 1, 0, 1, 1, 1 };
        int indexleaf = 5;
        int step = 0;
        
        public FormGame()
        {
            InitializeComponent();
        }

        void NewGame()
        {
            field = new int[fieldStart.Length];
            fieldStart.CopyTo(field, 0);
            indexleaf = 5;
            step = 0;
            ShowField();
        }
        
        
        private void dataGridViewFrogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Math.Abs(e.ColumnIndex - indexleaf) < 3)
            {
                field[indexleaf] = field[e.ColumnIndex];
                field[e.ColumnIndex] = 0;
                indexleaf = e.ColumnIndex;
                step += 1; 
                ShowField();
                

                if (IsGameOver())
                {
                    MessageBox.Show("You won!");
                    EnterUserName enterusername = new EnterUserName();
                    enterusername.score = step;
                    enterusername.ShowDialog();
                    FormShowResult formresult = new FormShowResult();
                    formresult.ShowDialog();
                    NewGame();
                }
            }
            else
            {
                MessageBox.Show("Nel'zya");
            }
           
        }

        bool IsGameOver()
        {
            int[] fieldEnd = { 2, 2, 2, 2, 0, 1, 1, 1, 1 };
            for(int i = 0; i < field.Length; i++)
            {
                if(field[i] != fieldEnd[i])
                {
                    return false;
                }
            }
            return true;
        }


        void ShowField()
        {
            for(int i = 0; i < field.Length; i++)
            {
                switch (field[i])
                {
                    case 1: dataGridViewFrogs[i, 0].Value = imgfrogleft; break;
                    case 2: dataGridViewFrogs[i, 0].Value = imgfrogright; break;
                    case 0: dataGridViewFrogs[i, 0].Value = imgleaf; break;
                }
                
            }
            dataGridViewFrogs[0, 0].Value = imgfrogleft;
            labelSteps.Text = "Количество шагов - " + step.ToString();
        }


        private void FormGame_Load(object sender, EventArgs e)
        {
            imgleaf = Image.FromFile("Images/leaf.png");
            imgfrogleft = Image.FromFile("Images/frogleft.png");
            imgfrogright = Image.FromFile("Images/frogright.png");
            dataGridViewFrogs.Rows.Add();
            dataGridViewFrogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.Width = imgleaf.Width * 9;

            ShowField();
        }
    }
}
