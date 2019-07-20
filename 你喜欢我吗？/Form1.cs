using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 你喜欢我吗_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.BringToFront();
            resetLocation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("太好了！\n小姐姐，我也喜欢你！！！\n做我女朋友吧！\n爱你，么么哒！");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            int X = button2.Location.X+75;
            int Y = button2.Location.Y+23;
            if(X>this.Size.Width - 75){
                X = 0;
            }
            if(Y>this.Size.Height - 50){
                Y = 0;
            }
            Point point = new Point(X,Y);
            button2.Location = point;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("拒绝我？！不存在的！嘻嘻");
        }

        private void fun1()
        {
            DialogResult result = MessageBox.Show("我喜欢你！", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("太好了！\n小姐姐，我也喜欢你！！！\n做我女朋友吧！\n爱你，么么哒！");
            }
            else
            {
                fun2();
            }
        }

        private void fun2()
        {
            DialogResult result = MessageBox.Show("房产证写你名字", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                like();
            }
            else
            {
                fun3();
            }
        }

        private void fun3()
        {
            DialogResult result = MessageBox.Show("保大", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                like();
            }
            else
            {
                fun4();
            }
        }

        private void fun4()
        {
            DialogResult result = MessageBox.Show("我妈会游泳", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                like();
            }
            else
            {
                fun5();
            }
        }

        private void fun5()
        {
            DialogResult result = MessageBox.Show("我有钱", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                like();
            }
            else
            {
                fun6();
            }
        }

        private void fun6()
        {
            DialogResult result = MessageBox.Show("我有房", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                like();
            }
            else
            {
                fun7();
            }
        }

        private void fun7()
        {
            DialogResult result = MessageBox.Show("我有车", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                like();
            }
            else
            {
                fun8();
            }
        }

        private void fun8()
        {
            DialogResult result = MessageBox.Show("做我女朋友好不好", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                like();
            }
            else
            {
                fun1();
            }
        }

        

        private void like()
        {
            MessageBox.Show("太好了！\n小姐姐，我也喜欢你！！！\n做我女朋友吧！\n爱你，么么哒！");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            fun1();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            resetLocation();
            
        }

        private void resetLocation()
        {
            int button1X = 0 + 100;
            int button2X = this.Size.Width - 200;
            int button1Y = this.Size.Height - 100;
            int button2Y = this.Size.Height - 100;
            button1.Location = new Point(button1X, button1Y);
            button2.Location = new Point(button2X, button2Y);
        }
    }
}
