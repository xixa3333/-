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
        const int PointMAX = 16;
        int swi = 0, PoingFlag = 0, i = 0, zeronum = 0, numswi = 0, num = 1,flag=0,swi2=0;
        char[] Zero = new char[PointMAX];
        double[] num1and2 = new double[2];
        public Form1()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            number(0);//按數字0
        }

        private void one_Click(object sender, EventArgs e)
        {
            number(1);//按數字1
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

        private void add_Click(object sender, EventArgs e)
        {
            symbol(1);//按相加
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

        private void xpowy_Click(object sender, EventArgs e)
        {
            symbol(5);//x的y平方
        }
        private void ysqrtx_Click(object sender, EventArgs e)
        {
            symbol(6);//x的y分之1平方
        }
        private void logx_Click(object sender, EventArgs e)
        {
            symbol(7);//logxy
        }

        private void divide100_Click(object sender, EventArgs e)
        {
            CalDir(0);//算百分比
        }

        private void posneg_Click(object sender, EventArgs e)
        {
            CalDir(1);//乘上-1
        }
        private void sqrt_Click(object sender, EventArgs e)
        {
            CalDir(2);//根號
        }

        private void pow_Click(object sender, EventArgs e)
        {
            CalDir(3);//平方
        }

        private void sin_Click(object sender, EventArgs e)
        {
            CalDir(4);//sin
        }

        private void cos_Click(object sender, EventArgs e)
        {
            CalDir(5);//cos
        }

        private void tan_Click(object sender, EventArgs e)
        {
            CalDir(6);//tan
        }

        private void log_Click(object sender, EventArgs e)
        {
            CalDir(7);//log10x
        }

        private void ln_Click(object sender, EventArgs e)
        {
            CalDir(8);//ln
        }

        private void rad_Click(object sender, EventArgs e)
        {
            CalDir(9);//換成度度量
        }

        private void reciprocal_Click(object sender, EventArgs e)
        {
            CalDir(10);//倒數
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            CalDir(11);//階乘
        }

        private void cleared_Click(object sender, EventArgs e)
        {
            Clearvoid();
        }

        private void point_Click(object sender, EventArgs e)
        {
            pointvoid();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            equalvoid();
        }

        private void back_Click(object sender, EventArgs e)
        {
            voidback();//刪除
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Dictionary<Keys, Action> keyMappings = new Dictionary<Keys, Action>
            {
                { Keys.NumPad0, () => { number(0); } },
                { Keys.D0, () => { number(0); } },
                { Keys.NumPad1, () => { number(1); } },
                { Keys.D1, () => { number(1); } },
                { Keys.NumPad2, () => { number(2); } },
                { Keys.D2, () => { number(2); } },
                { Keys.NumPad3, () => { number(3); } },
                { Keys.D3, () => { number(3); } },
                { Keys.NumPad4, () => { number(4); } },
                { Keys.D4, () => { number(4); } },
                { Keys.NumPad5, () => { number(5); } },
                { Keys.D5, () => { number(5); } },
                { Keys.NumPad6, () => { number(6); } },
                { Keys.D6, () => { number(6); } },
                { Keys.NumPad7, () => { number(7); } },
                { Keys.D7, () => { number(7); } },
                { Keys.NumPad8, () => { number(8); } },
                { Keys.D8, () => { number(8); } },
                { Keys.NumPad9, () => { number(9); } },
                { Keys.D9, () => { number(9); } },
                { Keys.Add, () => { symbol(1); } },
                { Keys.Subtract, () => { symbol(2); } },
                { Keys.Multiply, () => { symbol(3); } },
                { Keys.Divide, () => { symbol(4); } },
                { Keys.Decimal, () => { pointvoid(); } },
                { Keys.Oemplus, () => { equalvoid(); } },
                { Keys.Enter, () => { Clearvoid(); } },
                { Keys.Back, () => { voidback(); } }
            };

            if (keyMappings.ContainsKey(e.KeyCode))
            {
                keyMappings[e.KeyCode].Invoke();
            }
        }

        void voidback()
        {
            if (PoingFlag == 0)
            {
                if (num1and2[numswi] != 0) num1and2[numswi] = (long)num1and2[numswi] / 10;
                show.Text = num1and2[numswi].ToString();
            }
            else if (PoingFlag == 1)
            {
                if(i!=0)i--;
                double pownum = Math.Pow(10, i);
                num1and2[numswi] = (long)(num1and2[numswi] * pownum) / pownum;
                show.Text = num1and2[numswi].ToString();
                Array.Clear(Zero, 0, PointMAX);//清除多個0
                zeronum = 0;
                if (num1and2[numswi] != 0)
                {
                    while (num1and2[numswi] * (Math.Pow(10, num)) / ((long)(num1and2[numswi] * (Math.Pow(10, num)))) != 1) num++;
                    while (num1and2[numswi] * (Math.Pow(10, num) / 10) / ((long)(num1and2[numswi] * (Math.Pow(10, num)) / 10)) == 1) num--;
                }
                else num = 0;
                if (num != i)
                {
                    num = i - num;
                    for (int j = 0; j < num; j++) Zero[zeronum++] = '0';//小數點後新增0
                    string Zerostr = new string(Zero);//字元陣列轉字串
                    if (num1and2[numswi] / (long)num1and2[numswi] == 1 || num1and2[numswi] == 0) show.Text = (num1and2[numswi].ToString() + "." + Zerostr);//判斷是否為整數或0
                    else show.Text = (num1and2[numswi].ToString() + Zerostr);//判斷是否為小數
                }
            }
            if (i == 0 &&( num1and2[numswi] / (long)num1and2[numswi] == 1 || num1and2[numswi] == 0)) PoingFlag = 0;
            if (num1and2[numswi] == 0) swi2 = 0;
        }

        void number(double num)
        {
            if (swi == 0&&flag==0) numswi = 0;//沒有值按加減乘除輸入到第1個數字字串
            else if(swi!=0&&flag==0)//代表按下了加減乘除
            {
                numswi = 1;//輸入到第2個數字字串
                reduction();//重置顏色
            }
            if (PoingFlag == 0)//要輸入整數值
            {
                num1and2[numswi] = num1and2[numswi] * 10 + num;
                show.Text = num1and2[numswi].ToString();
                Array.Clear(Zero, 0, PointMAX);//清除多個0
                zeronum = 0;
            }
            else if (PoingFlag == 1)//要輸入小數點後值
            {
                if (num != 0 && show.Text.Length < PointMAX)//按下值為1-9
                {
                    i++;//小數點後數字紀錄
                    num1and2[numswi] += num / Math.Pow(10, i);//小數點後新增值
                    show.Text = num1and2[numswi].ToString();
                    Array.Clear(Zero, 0, PointMAX);//清除多個0
                    zeronum = 0;
                }
                else if ((num == 0 && show.Text.Length < PointMAX))
                {
                    i++;//小數點後數字紀錄
                    Zero[zeronum++] = '0';//小數點後新增0
                    string Zerostr = new string(Zero);//字元陣列轉字串
                    if (i == 0 || num1and2[numswi] / (long)num1and2[numswi] == 1 || num1and2[numswi] == 0) show.Text = (num1and2[numswi].ToString() + "." + Zerostr);//判斷是否為整數或0
                    else if (num1and2[numswi] / (long)num1and2[numswi] != 1) show.Text = (num1and2[numswi].ToString() + Zerostr);//判斷是否為小數

                }
            }
            else if (PoingFlag == 2)//判斷為輸入pi或是e
            {
                num1and2[numswi] = num;
                i = 14;
                PoingFlag = 1;
                show.Text = num1and2[numswi].ToString();
                Array.Clear(Zero, 0, PointMAX);
                zeronum = 0;
            }
            if (flag == 1)
            {
                flag = 0;
                swi = 0;
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
            flag = 0;
            reduction();//顏色變回原樣
            swi = swiint;
            switch (swi){
                case 1:
                    add.BackColor = Color.Yellow;
                    break;
                case 2:
                    sub.BackColor = Color.Yellow;
                    break;
                case 3:
                    multiply.BackColor = Color.Yellow;
                    break;
                case 4:
                    divide.BackColor = Color.Yellow;
                    break;
                case 5:
                    xpowy.BackColor = Color.Yellow;
                    break;
                case 6:
                    ysqrtx.BackColor = Color.Yellow;
                    break;
                case 7:
                    logx.BackColor = Color.Yellow;
                    break;
            }
            switch (swi2)
            {
                case 1:
                    num1and2[0] += num1and2[1];
                    break;
                case 2:
                    num1and2[0] -= num1and2[1];
                    break;
                case 3:
                    num1and2[0] *= num1and2[1];
                    break;
                case 4:
                    num1and2[0] /= num1and2[1];
                    break;
                case 5:
                    num1and2[0] = Math.Pow(num1and2[0], num1and2[1]);
                    break;
                case 6:
                    num1and2[0] = Math.Pow(num1and2[0], 1 / num1and2[1]);
                    break;
                case 7:
                    num1and2[0] = Math.Log(num1and2[1]) / Math.Log(num1and2[0]);
                    break;
            }
            num1and2[1] = 0; PoingFlag = 0; i = 0;//歸零
            show.Text = num1and2[0].ToString();
            swi2 = swi;
        }

        void pointvoid()
        {
            if (num1and2[numswi] / (long)num1and2[numswi] == 1 || num1and2[numswi] == 0) PoingFlag = 0;
            //判斷第一個或第二個數字字串為整數或第一個或第二個數字字串為0
            else PoingFlag = 1;//否則為1
            if (PoingFlag == 0 && !show.Text.Contains("."))
            {
                show.Text += ".";
                i = 0;
                zeronum = 0;
                Array.Clear(Zero, 0, PointMAX);
            }
            PoingFlag = 1;
        }

        void equalvoid()
        {
            swi2 = 0;
            numswi = 0;
            double operand1 = num1and2[0];
            double operand2 = num1and2[1];
            double result = 0;

            switch (swi)
            {
                case 1:
                    result = add.BackColor == SystemColors.Control ? operand1 + operand2 : operand1 + operand1;
                    break;
                case 2:
                    result = sub.BackColor == SystemColors.Control ? operand1 - operand2 : operand1 - operand1;
                    break;
                case 3:
                    result = multiply.BackColor == SystemColors.Control ? operand1 * operand2 : operand1 * operand1;
                    break;
                case 4:
                    if ((divide.BackColor == SystemColors.Control && operand2 == 0) || (divide.BackColor == Color.Yellow && operand1 == 0))
                    {
                        show.Text = "錯誤";
                        break;
                    }
                    result = divide.BackColor == SystemColors.Control ? operand1 / operand2 : operand1 / operand1;
                    break;
                case 5:
                    result = xpowy.BackColor == SystemColors.Control ? Math.Pow(operand1, operand2) : Math.Pow(operand1, operand1);
                    break;
                case 6:
                    result = ysqrtx.BackColor == SystemColors.Control ? Math.Pow(operand1, 1 / operand2) : Math.Pow(operand1, 1 / operand1);
                    break;
                case 7:
                    result = logx.BackColor == SystemColors.Control ? Math.Log(operand2) / Math.Log(operand1) : Math.Log(operand1) / Math.Log(operand1);
                    break;
            }

            if (swi != 4 || (divide.BackColor == SystemColors.Control && operand2 != 0) || (divide.BackColor == Color.Yellow && operand1 != 0))
            {
                num1and2[numswi] = result;
                show.Text = result.ToString();
            }
            PoingFlag =(num1and2[numswi] / (long)num1and2[numswi] != 1) ?1:0;
            reduction();
            flag = 1;
            i = 0;
            SecPow(num1and2[numswi]);
        }

        void Clearvoid()//全部清零
        {
            swi2 = 0;
            flag = 0;
            reduction();
            show.Text = "0";
            num1and2[0] = 0;
            num1and2[1] = 0;
            swi = 0;
            cleared.Text = "AC";
            PoingFlag = 0;
            i = 0;
            Array.Clear(Zero, 0, PointMAX);
            zeronum = 0;
        }

        void CalDir(int swisym)
        {
            if (swi <= 1)
            {
                numswi = swi;
                swisymvoid(swisym);
            }
            SecPow(num1and2[numswi]);
        }

        void swisymvoid(int swisym)
        {
            switch (swisym)
            {
                case 0:
                    num1and2[numswi] /= 100;
                    break;
                case 1:
                    num1and2[numswi] *= -1;
                    break;
                case 2:
                    num1and2[numswi] = Math.Sqrt(num1and2[numswi]);
                    break;
                case 3:
                    num1and2[numswi] *= num1and2[numswi];
                    break;
                case 4:
                    num1and2[numswi] = Math.Sin(num1and2[numswi]);
                    break;
                case 5:
                    num1and2[numswi] = Math.Cos(num1and2[numswi]);
                    break;
                case 6:
                    num1and2[numswi] = Math.Tan(num1and2[numswi]);
                    break;
                case 7:
                    num1and2[numswi] = Math.Log10(num1and2[numswi]);
                    break;
                case 8:
                    num1and2[numswi] = Math.Log(num1and2[numswi]);
                    break;
                case 9:
                    num1and2[numswi] *= Pi / 180;
                    break;
                case 10:
                    num1and2[numswi] = Math.Pow(num1and2[numswi], -1);
                    break;
                case 11 when num1and2[numswi] > 2 && num1and2[numswi] / (ulong)num1and2[numswi] == 1:
                    ulong num = (ulong)num1and2[numswi];
                    for (ulong j = num - 1; j > 1; j--) num1and2[numswi] *= j;
                    break;
            }
            show.Text = num1and2[numswi].ToString();
        }

        void SecPow(double num)
        {
            if (num != 0)
            {
                while (num * (Math.Pow(10, i)) / ((long)(num * (Math.Pow(10, i)))) != 1) i++;
                while (num * (Math.Pow(10, i) / 10) / ((long)(num * (Math.Pow(10, i)) / 10)) == 1) i--;
            }
            else i = 0;
            if (i > 0) PoingFlag = 1;
        }
    }
}
