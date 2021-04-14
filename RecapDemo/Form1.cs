using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
                Button[,] btn = new Button[8,8];
                int top = 0;
                int left = 0;

                for (int i = 0; i < btn.GetUpperBound(0); i++)
                {
                    

                    for (int j = 0; j < btn.GetUpperBound(1); j++)
                    {
                        btn[i,j]=new Button();
                        btn[i, j].Width = 50;
                        btn[i, j].Height = 50;
                        btn[i, j].Left = left;
                        btn[i, j].Top = top;
                        left += 50;
                        this.Controls.Add(btn[i,j]);
                        btn[i, j].BackColor = Color.Black;


                    }

                    btn[i,1].BackColor = Color.White;
                    btn[i, 3].BackColor = Color.White;
                    btn[i, 5].BackColor = Color.White;
                   
                    left = 0;
                    top += 50;
                    

            }
                
                
           
            
        }
    }
}
