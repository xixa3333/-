using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace 計算機
{
    public partial class Form1 : Form
    {
        const double Pi = Math.PI, E = Math.E;
        int swi = 0, flag = 0, PoingFlag = 0, i = 0, zeronum = 0, numswi = 0;
        char[] Zero = new char[10];
        double[] num1and2 = new double[2];
        public Form1()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            number(0);
        }

        private void one_Click(object sender, EventArgs e)
        {
            number(1);
        }

        private void two_Click(object sender, EventArgs e)
        {
            number(2);
        }

        private void three_Click(object sender, EventArgs e)
        {
            number(3);
        }

        private void four_Click(object sender, EventArgs e)
        {
            number(4);
        }

        private void five_Click(object sender, EventArgs e)
        {
            number(5);
        }

        private void six_Click(object sender, EventArgs e)
        {
            number(6);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            number(7);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            number(8);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            number(9);
        }

        private void add_Click(object sender, EventArgs e)
        {
            symbol(1);
        }

        private void sub_Click(object sender, EventArgs e)
        {
            symbol(2);
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            symbol(3);
        }

        private void divide_Click(object sender, EventArgs e)
        {
            symbol(4);
        }


        private void divide100_Click(object sender, EventArgs e)
        {
            CalDir(0);
        }

        private void posneg_Click(object sender, EventArgs e)
        {
            CalDir(1);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0) number(0);
            else if (e.KeyCode == Keys.NumPad1|| e.KeyCode == Keys.D1) number(1);
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2) number(2);
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3) number(3);
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4) number(4);
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5) number(5);
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6) number(6);
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7) number(7);
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8) number(8);
            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9) number(9);
            else if (e.KeyCode == Keys.Add) symbol(1);
            else if (e.KeyCode == Keys.Subtract) symbol(2);
            else if (e.KeyCode == Keys.Multiply) symbol(3);
            else if (e.KeyCode == Keys.Divide) symbol(4);
            else if (e.KeyCode == Keys.Decimal) pointvoid();
            else if (e.KeyCode == Keys.Oemplus) equalvoid();
            else if (e.KeyCode == Keys.Enter) Clearvoid();
            else if (e.KeyCode == Keys.Back) voidback();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cleared_Click(object sender, EventArgs e)
        {
            Clearvoid();
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            CalDir(2);
        }

        private void pow_Click(object sender, EventArgs e)
        {
            CalDir(3);
        }

        private void ysqrtx_Click(object sender, EventArgs e)
        {
            symbol(6);
        }

        private void xpowy_Click(object sender, EventArgs e)
        {
            symbol(5);
        }

        private void sin_Click(object sender, EventArgs e)
        {
            CalDir(4);
        }

        private void cos_Click(object sender, EventArgs e)
        {
            CalDir(5);
        }

        private void tan_Click(object sender, EventArgs e)
        {
            CalDir(6);
        }

        private void pi_Click(object sender, EventArgs e)
        {
            PoingFlag = 2;
            number(Pi);
        }

        private void e_Click(object sender, EventArgs e)
        {
            PoingFlag = 2;
            number(E);
        }

        private void log_Click(object sender, EventArgs e)
        {
            CalDir(7);
        }

        private void ln_Click(object sender, EventArgs e)
        {
            CalDir(8);
        }

        private void logx_Click(object sender, EventArgs e)
        {
            symbol(7);
        }

        private void rad_Click(object sender, EventArgs e)
        {
            CalDir(9);
        }

        private void point_Click(object sender, EventArgs e)
        {
            pointvoid();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            equalvoid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void reciprocal_Click(object sender, EventArgs e)
        {
            CalDir(10);
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            CalDir(11);
        }

        private void back_Click(object sender, EventArgs e)
        {
            voidback();
        }

        void voidback()
        {
            if (flag == 1)
            {
                flag = 0;
                swi = 0;
            }
            if (swi == 0) numswi = 0;
            else if (swi != 0)
            {
                numswi = 1;
                reduction();
            }
            if (PoingFlag == 0)
            {
                if (num1and2[numswi] > 0) num1and2[numswi] = (long)num1and2[numswi] / 10;
                show.Text = num1and2[numswi].ToString();
                i = 0;
            }
            else if (PoingFlag == 1)
            {
                double pownum = Math.Pow(10, SecPow(num1and2[numswi]));
                num1and2[numswi] = (long)(num1and2[numswi] * pownum / 100) / pownum * 100;
                i -= 2;
                show.Text = num1and2[numswi].ToString();
            }
            if ((num1and2[0] / (long)num1and2[0] == 1 && num1and2[0] != 0) || (num1and2[1] / (long)num1and2[1] == 1 && num1and2[1] != 0)|| (num1and2[0] == 0 && num1and2[1] == 0)|| (swi!=0 && num1and2[1] == 0)) PoingFlag = 0;
        }

        void number(double num)
        {
            if (flag == 1)
            {
                flag = 0;
                swi = 0;
            }
            if (swi == 0) numswi = 0;
            else if (swi != 0)
            {
                numswi = 1;
                reduction();
            }
            if (PoingFlag == 0)
            {
                num1and2[numswi] = num1and2[numswi] * 10 + num;
                show.Text = num1and2[numswi].ToString();
                Array.Clear(Zero, 0, 10);
                zeronum = 0;
            }
            else if (PoingFlag == 1 && i < 7)
            {
                if (num != 0)
                {
                    num1and2[numswi] = num1and2[numswi] + (num / Math.Pow(10, SecPow(num1and2[numswi])));
                    show.Text = num1and2[numswi].ToString();
                    Array.Clear(Zero, 0, 10);
                    zeronum = 0;
                }
                else
                {
                    Zero[zeronum] = '0';
                    string Zerostr = new string(Zero);
                    if (num1and2[numswi] / (long)num1and2[numswi] == 1 || num1and2[numswi] == 0) show.Text = (num1and2[numswi].ToString() + "." + Zerostr);
                    else if (num1and2[numswi] / (long)num1and2[numswi] != 1) show.Text = (num1and2[numswi].ToString() + Zerostr);
                    zeronum++;
                    i++;
                }
            }
            else if (PoingFlag == 2)
            {
                num1and2[numswi] = num;
                i = 11;
                PoingFlag = 1;
                show.Text = num1and2[numswi].ToString();
                Array.Clear(Zero, 0, 10);
                zeronum = 0;
            }
            cleared.Text = "C";
        }

        void reduction()
        {
            add.BackColor = SystemColors.Control;
            sub.BackColor = SystemColors.Control;
            divide.BackColor = SystemColors.Control;
            multiply.BackColor = SystemColors.Control;
            xpowy.BackColor = SystemColors.Control;
            ysqrtx.BackColor = SystemColors.Control;
            logx.BackColor = SystemColors.Control;
        }

        void symbol(int swiint)
        {
            num1and2[1] = 0; flag = 0; PoingFlag = 0; i = 0;
            reduction();
            swi = swiint;
            if (swi == 1) add.BackColor = Color.Yellow;
            else if (swi == 2) sub.BackColor = Color.Yellow;
            else if (swi == 3) multiply.BackColor = Color.Yellow;
            else if (swi == 4) divide.BackColor = Color.Yellow;
            else if (swi == 5) xpowy.BackColor = Color.Yellow;
            else if (swi == 6) ysqrtx.BackColor = Color.Yellow;
            else if (swi == 7) logx.BackColor = Color.Yellow;
        }

        void pointvoid()
        {
            if ((num1and2[0] / (long)num1and2[0] == 1 || num1and2[0] == 0) || (num1and2[1] / (long)num1and2[1] == 1 || num1and2[1] == 0)) PoingFlag = 0;
            else PoingFlag = 1;
            if ((swi == 0 || flag == 1) && PoingFlag == 0 && (num1and2[0] / (long)num1and2[0] == 1 || num1and2[0] == 0)) show.Text = (num1and2[0].ToString() + ".");
            else if ((swi != 0 && flag == 0) && PoingFlag == 0 && (num1and2[1] / (long)num1and2[1] == 1 || num1and2[1] == 0)) show.Text = (num1and2[1].ToString() + ".");
            PoingFlag = 1;
        }

        void equalvoid()
        {
            if (swi == 1 && add.BackColor == SystemColors.Control) num1and2[0] += num1and2[1];
            else if (swi == 1 && add.BackColor == Color.Yellow) num1and2[0] += num1and2[0];
            else if (swi == 2 && sub.BackColor == SystemColors.Control) num1and2[0] -= num1and2[1];
            else if (swi == 2 && sub.BackColor == Color.Yellow) num1and2[0] -= num1and2[0];
            else if (swi == 3 && multiply.BackColor == SystemColors.Control) num1and2[0] *= num1and2[1];
            else if (swi == 3 && multiply.BackColor == Color.Yellow) num1and2[0] *= num1and2[0];
            else if (swi == 4 && ((divide.BackColor == SystemColors.Control && num1and2[1] == 0) || (divide.BackColor == Color.Yellow && num1and2[0] == 0))) show.Text = "錯誤";
            else if (swi == 4 && divide.BackColor == SystemColors.Control) num1and2[0] /= num1and2[1];
            else if (swi == 4 && divide.BackColor == Color.Yellow) num1and2[0] /= num1and2[0];
            else if (swi == 5 && xpowy.BackColor == SystemColors.Control) num1and2[0] = Math.Pow(num1and2[0], num1and2[1]);
            else if (swi == 5 && xpowy.BackColor == Color.Yellow) num1and2[0] = Math.Pow(num1and2[0], num1and2[0]);
            else if (swi == 6 && ysqrtx.BackColor == SystemColors.Control) num1and2[0] = Math.Pow(num1and2[0], 1/num1and2[1]);
            else if (swi == 6 && ysqrtx.BackColor == Color.Yellow) num1and2[0] = Math.Pow(num1and2[0], 1/num1and2[0]);
            else if (swi == 7 && logx.BackColor == SystemColors.Control) num1and2[0] = Math.Log(num1and2[1]) / Math.Log(num1and2[0]);
            else if (swi == 7 && logx.BackColor == Color.Yellow) num1and2[0] = Math.Log(num1and2[0]) / Math.Log(num1and2[0]);
            if (swi != 4 || (swi == 4 && divide.BackColor == SystemColors.Control && num1and2[1] != 0) || (swi == 4 && divide.BackColor == Color.Yellow && num1and2[0] != 0)) show.Text = num1and2[0].ToString();
            if (num1and2[0] / (long)num1and2[0] != 1) PoingFlag = 1;
            else PoingFlag = 0;
            reduction();
            flag = 1; i = 0;
        }

        void Clearvoid()
        {
            reduction();
            show.Text = "0";
            num1and2[0] = 0;
            num1and2[1] = 0;
            swi = 0;
            cleared.Text = "AC";
            PoingFlag = 0;
            i = 0;
            Array.Clear(Zero, 0, 10);
            zeronum = 0;
        }

        void CalDir(int swisym)
        {
            if (swi == 0 || flag == 1)
            {
                numswi = 0;
                swisymvoid(swisym);
            }
            else if (swi != 0 || flag == 1)
            {
                numswi = 1;
                swisymvoid(swisym);
            }
        }

        void swisymvoid(int swisym)
        {
            if (swisym == 0) num1and2[numswi] /= 100;
            else if (swisym == 1) num1and2[numswi] *= -1;
            else if (swisym == 2) num1and2[numswi] = Math.Sqrt(num1and2[numswi]);
            else if (swisym == 3) num1and2[numswi] *= num1and2[numswi];
            else if (swisym == 4) num1and2[numswi] = Math.Sin(num1and2[numswi]);
            else if (swisym == 5) num1and2[numswi] = Math.Cos(num1and2[numswi]);
            else if (swisym == 6) num1and2[numswi] = Math.Tan(num1and2[numswi]);
            else if (swisym == 7) num1and2[numswi] = Math.Log10(num1and2[numswi]);
            else if (swisym == 8) num1and2[numswi] = Math.Log(num1and2[numswi]);
            else if (swisym == 9) num1and2[numswi] = num1and2[numswi] * Pi / 180;
            else if (swisym == 10) num1and2[numswi] = Math.Pow(num1and2[numswi], -1);
            else if (swisym == 11 && num1and2[numswi] > 2 && num1and2[numswi] / (ulong)num1and2[numswi] == 1)
            {
                ulong num = (ulong)num1and2[numswi];
                for (ulong j = num - 1; j > 1; j--) num1and2[numswi] *= j;
            }
            show.Text = num1and2[numswi].ToString();
        }

        int SecPow(double num)
        {
            if (num != 0) while (num * (Math.Pow(10, i)) / ((long)(num * (Math.Pow(10, i)))) != 1) i++;
            return ++i;
        }

    }
}
