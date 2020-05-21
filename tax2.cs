﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g2.Visible = false;
            g34.Visible = false;
            g5.Visible = false;
            comboBox1.Text = "โสด";
            comboBox2.Text = "ไม่มี";
            comboBox3.Text = "ไม่มี";
        }
        public double money,sum1,sum2,sum3,sum4,sum5,sum_all;

        private void button6_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            numericUpDown9_ValueChanged(sender, e);
            g34.Visible = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            numericUpDown9_ValueChanged(sender, e);
            g34.Visible = true;
            g5.Visible = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            g1.Visible = true;
            g2.Visible = false;
            g34.Visible = false;
            g5.Visible = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            g5.Visible = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            g2.Visible = true;
            g34.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            g2.Visible = true;
            g34.Visible = false;
            g5.Visible = false;
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            sum2 = 0;
            double prakan_social = Convert.ToDouble(numericUpDown12.Value);
            double prakan_life = Convert.ToDouble(numericUpDown13.Value);
            double prakan_healt = Convert.ToDouble(numericUpDown14.Value);
            double prakan_healtfam = Convert.ToDouble(numericUpDown15.Value);
            double prakan_marry = Convert.ToDouble(numericUpDown16.Value);
            double kor_or_shor = Convert.ToDouble(numericUpDown17.Value);
            double kor_bor_khor = Convert.ToDouble(numericUpDown20.Value);
            double sumrong_life = Convert.ToDouble(numericUpDown18.Value);
            double bumnan = Convert.ToDouble(numericUpDown19.Value);
            double LTF = Convert.ToDouble(numericUpDown21.Value);
            double RMF = Convert.ToDouble(numericUpDown22.Value);
            
            if(prakan_healt + prakan_life > 100000) 
            {
                sum2 += 100000;
            }
            else
            {
                sum2 += prakan_healt + prakan_life;
            }

            if((money * 0.15) > 490000)
            {
                numericUpDown18.Maximum = Convert.ToInt64(490000);
            }
            else
            {
                numericUpDown18.Maximum = Convert.ToInt64(money * 0.15);
            }

            if ((money * 0.15) > 500000)
            {
                numericUpDown20.Maximum = Convert.ToInt64(500000);
            }
            else
            {
                numericUpDown20.Maximum = Convert.ToInt64(money * 0.15);
            }

            if ((money * 0.15) > 200000)
            {
                numericUpDown19.Maximum = Convert.ToInt64(200000);
            }
            else
            {
                numericUpDown19.Maximum = Convert.ToInt64(money * 0.15);
            }

            if ((money * 0.15) > 500000)
            {
                numericUpDown21.Maximum = Convert.ToInt64(500000);
            }
            else
            {
                numericUpDown21.Maximum = Convert.ToInt64(money * 0.15);
            }

            if ((money * 0.15) > 500000)
            {
                numericUpDown22.Maximum = Convert.ToInt64(500000);
            }
            else
            {
                numericUpDown22.Maximum = Convert.ToInt64(money * 0.15);
            }

            if (bumnan + sumrong_life + kor_bor_khor + RMF > 500000)
            {
                sum2 += 500000;
            }
            else
            {
                sum2 += bumnan + sumrong_life + kor_bor_khor + RMF;
            }
            sum2 += prakan_social + prakan_healtfam + LTF + kor_or_shor + prakan_marry;
            textBox6.Text = sum2.ToString();
        }


        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            sum4 = 0;
            money = Convert.ToDouble(numericUpDown1.Value) * 12;
            double sum1235 = ((money - (sum1 + sum2 + sum3 + sum5)) * 0.1) / 2;
            if (sum1235 < 0) { sum1235 = 0; }
            numericUpDown10.Maximum = Convert.ToInt32(sum1235);
            double donate_sub = Convert.ToDouble(numericUpDown10.Value) * 2;

            double sum12359 = (money - (sum1 + sum2 + sum3 + sum5 + donate_sub)) * 0.1;
            if (sum12359 < 0) { sum12359 = 0; }
            numericUpDown9.Maximum = Convert.ToInt32(sum12359);
            double donate_gen = Convert.ToDouble(numericUpDown9.Value);

            double บริจาคพรรคการเมือง = Convert.ToDouble(numericUpDown11.Value);
            sum4 = บริจาคพรรคการเมือง + donate_gen + donate_sub;
            textBox5.Text = sum4.ToString();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            g1.Visible = true;
            g34.Visible = false;
            g2.Visible = false;
            g5.Visible = false;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            numericUpDown9.Value = 0;
            numericUpDown10.Value = 0;
            numericUpDown11.Value = 0;
            numericUpDown12.Value = 0;
            numericUpDown13.Value = 0;
            numericUpDown14.Value = 0;
            numericUpDown15.Value = 0;
            numericUpDown16.Value = 0;
            numericUpDown17.Value = 0;
            numericUpDown18.Value = 0;
            numericUpDown19.Value = 0;
            numericUpDown20.Value = 0;
            numericUpDown21.Value = 0;
            numericUpDown22.Value = 0;
            numericUpDown23.Value = 0;
            numericUpDown24.Value = 0;
            numericUpDown25.Value = 0;
            numericUpDown26.Value = 0;
            numericUpDown27.Value = 0;
            numericUpDown28.Value = 0;
            sum1 = 0;
            sum3 = 0;
            sum4 = 0;
            sum2 = 0;
            sum5 = 0;
            sum_all = 0;
            textBox2.Text = "0";
        }

        private void numericUpDown23_ValueChanged(object sender, EventArgs e)
        {


            sum5 = 0;
            double shop = Convert.ToDouble(numericUpDown23.Value);
            double edu = Convert.ToDouble(numericUpDown24.Value);
            double book = Convert.ToDouble(numericUpDown25.Value);
            double otop = Convert.ToDouble(numericUpDown26.Value);
            double main = Convert.ToDouble(numericUpDown27.Value);
            double second = Convert.ToDouble(numericUpDown28.Value);

            if(main + second > 20000)
            {
                sum5 += 20000;
            }
            else
            {
                sum5 += main + second;
            }
            sum5 += shop + edu + book + otop ;
            textBox7.Text = sum5.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            if (sum_all >= 0 && sum_all <= 150000)
            {
                sum_all = 0;
            }
            else if (sum_all > 150000 && sum_all <= 300000)
            {
                sum_all = (sum_all - 150000) * 0.05;
            }
            else if (sum_all > 300000 && sum_all <= 500000)
            {
                sum_all = ((sum_all - 300000) * 0.1) + 7500;
            }
            else if (sum_all > 500000 && sum_all <= 750000)
            {
                sum_all = ((sum_all - 500000) * 0.15) + 27500;
            }
            else if (sum_all > 750000 && sum_all <= 1000000)
            {
                sum_all = ((sum_all - 750000) * 0.2) + 65000;
            }
            else if (sum_all > 1000000 && sum_all <= 2000000)
            {
                sum_all = ((sum_all - 1000000) * 0.25) + 115000;
            }
            else if (sum_all > 2000000 && sum_all <= 5000000)
            {
                sum_all = ((sum_all - 2000000) * 0.3) + 365000;
            }
            else if (sum_all > 5000000)
            {
                sum_all = ((sum_all - 5000000) * 0.35) + 1265000;
            }
            textBox2.Text = sum_all.ToString();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            sum3 = 0;
            double inter_home = Convert.ToDouble(numericUpDown6.Value);
            double home58 = Convert.ToDouble(numericUpDown7.Value);
            double home62 = Convert.ToDouble(numericUpDown8.Value);

            if(home58 > 3000000)
            {
                sum3 += 0;
            }
            else
            {
                sum3 += home58 * 0.04;
            }

            if(home62 > 5000000)
            {
                sum3 += 0;
            }
            else
            {
                sum3 += home62 * 0.04;
            }
            sum3 += inter_home;
            textBox4.Text = sum3.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            sum1 = 0;
            money = Convert.ToDouble(numericUpDown1.Value) * 12;
            double baby60 = Convert.ToDouble(numericUpDown2.Value) * 30000;
            double baby61 = Convert.ToDouble(numericUpDown3.Value);
            double preg = Convert.ToDouble(numericUpDown4.Value);
            double disab = Convert.ToDouble(numericUpDown5.Value) * 60000;
            double sumn = money * 0.5;

            if(sumn > 100000)
            {
                sum1 += 100000;
            }
            else
            {
                sum1 += sumn;
            }
            
            if(comboBox1.Text == "คู่สมรสไม่มีรายได้")
            {
                sum1 += 120000;
            }
            else
            {
                sum1 += 60000;
            }
            if (baby61 > 0)
            {
                if (baby60 == 0)
                {
                    baby61 = ((baby61 - 1) * 60000) + 30000;
                }
                else
                {
                    baby61 = baby61 * 60000;
                }
            }
            else
            {
                baby61 = 0;
            }
            sum1 += baby61;

            if(comboBox2.Text == "ไม่มี")
            {
                sum1 += 0;
            }
            else if(comboBox2.Text == "บิดาหรือมารดา")
            {
                sum1 += 30000;
            }
            else if (comboBox2.Text == "บิดาเเละมารดา")
            {
                sum1 += 60000;
            }

            if (comboBox3.Text == "ไม่มี")
            {
                sum1 += 0;
            }
            else if (comboBox3.Text == "บิดาหรือมารดา")
            {
                sum1 += 30000;
            }
            else if (comboBox3.Text == "บิดาเเละมารดา")
            {
                sum1 += 60000;
            }
            sum1 += baby60 + preg + disab;
            textBox3.Text = sum1.ToString();
            sum_all = money - (sum1 + sum3 + sum4 + sum2 + sum5);
            if(sum_all < 0)
            {
                sum_all = 0;
            }
            textBox1.Text = sum_all.ToString();
        }
    }
}
