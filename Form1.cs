using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrollProg
{
    public partial class Form1 : Form
    {
        //программ шутник
        //Чтобы избавиться от этого нажмите <ctrl>+<alt>+<del>
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Clip = RectangleToScreen(new Rectangle(button1.Location, button1.Size));
            
            label1.Text = "вот и все";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;//запрещаем закрытие формы
        }
    }
}
