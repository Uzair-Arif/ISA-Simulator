using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Timers;
namespace ISA_Simulator
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        //string R1 = "0000";
        //string R2 = "0001";
        //string R3 = "0010";
        //string R4 = "0011";
        //string R5 = "0100";
        //string R6 = "0101";
        //string R7 = "0110";
        //string R8 = "0111";
        //string R9 = "1001";
        //string R10 = "1001";
        //string R11 = "1010";
        //string R12 = "1011";
        //string R13 = "1100";
        //string R14 = "1101";
        //string R15 = "1110";
        //string R16 = "1111";
            

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            
                //textBox1.Text=richTextBox1.Lines[0];
                //n1 = textBox1.Text;
                //textBox2.Text = n1.Substring(0, 4);
                
                //textBox3.Text = n1.Substring(4,8);
                //textBox4.Text = n1.Substring(12, 4);
                //textBox5.Text = n1.Substring(4, 8);
                //textBox6.Text = n1.Substring(12, 4);
                //textBox7.Text = n1.Substring(0, 4);
                //textBox8.Text = R1;
                
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Instructions");
            //DataRow dr = dt.NewRow();
            //dt.Rows.Add(n1);
            //dt.Rows.Add(n2);
            //dt.Rows.Add(n3);
            //dt.Rows.Add(n4);
            //dataGridView1.DataSource = dt;
            //textBox1.Text = n1;

           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f_name = "\\instructions.txt";
            f_name = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + f_name;
            System.IO.StreamReader obj;
            obj = new System.IO.StreamReader(f_name);
            string line = null;



            do
            {
                line = line + obj.ReadLine() + "\r\n";
            } while (obj.Peek() != -1);
            //MessageBox.Show(line);
            richTextBox1.Text = line;
            obj.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = richTextBox1.Lines[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = richTextBox1.Lines[1];
        }
        string r3 = null;
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = richTextBox1.Lines[2];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = richTextBox1.Lines[3];
            r3 = textBox1.Text;
            textBox26.Clear();
            textBox27.Clear();
        }
        int c = 1;//1//16
        string n1 = null;
        string n2 = null; 
        string n3 = null;
        string n4 = null;
           
        private void button6_Click(object sender, EventArgs e)
        {
            
            
            for (int i = 0; i < 1; i++)
            {
                
                textBox25.Text = c.ToString();
                Thread.Sleep(2000);
                textBox25.Refresh();
                Application.DoEvents();
            }
            for (int a = 0; a < 1;a++ ){
                if (textBox25.Text == c.ToString())
                {
                    
                    n1 = textBox1.Text;
                    if (c == 11)
                    {
                        textBox2.Text = n1.Substring(0, 4);

                        textBox3.Text = n1.Substring(4, 4);

                        textBox4.Text = n1.Substring(8, 4);
                        
                        textBox26.Text = n1.Substring(12, 4);
                        n4 = n1.Substring(12, 4);
                        c++;
                        textBox25.Text = c.ToString();
                        Thread.Sleep(2000);
                        Application.DoEvents();
                    }
                    else {
                        textBox2.Text = n1.Substring(0, 4);

                        textBox3.Text = n1.Substring(4, 4);

                        textBox4.Text = n1.Substring(8, 8); 
                        c++;//2//17
                        textBox25.Text = c.ToString();
                        Thread.Sleep(2000);
                        Application.DoEvents();
                    }
                }
                for(int b=0;b<1;b++){
                    if (c == 12)
                    {
                        textBox5.Text = n1.Substring(4, 4);
                        n3 = n1.Substring(4,4);
                        textBox6.Text = n1.Substring(8, 4);
                        textBox27.Text = n1.Substring(12, 4);
                        c++;
                        textBox25.Text = c.ToString();
                        Thread.Sleep(2000);
                        Application.DoEvents();
                    }
                    else {
                        textBox5.Text = n1.Substring(4, 4);

                        textBox6.Text = n1.Substring(8, 8); 
                        c++;//3//18
                        textBox25.Text = c.ToString();
                        Thread.Sleep(2000);
                        Application.DoEvents();
                    }
                }
                for(int u=0;u<1;u++){
                    textBox7.Text = n1.Substring(0, 4);
                    c ++;//4//19
                    textBox25.Text = c.ToString();
                    
                    Thread.Sleep(2000);
                    Application.DoEvents();
                }
                for (int k = 0; k < 1; k++)
                {
                    if (c == 19)
                    {
                        textBox8.Text = n1.Substring(8, 8);
                        c++;//4//20
                        textBox25.Text = c.ToString();
                        richTextBox3.Text = textBox17.Text;
                        //n2 = n2.Substring(4, 4).Insert(0, n3);
                        n2 = textBox7.Text + n4 + textBox8.Text; 
                        // n2= textBox7.Text + n3 + textBox8.Text;
                        richTextBox1.Text = richTextBox1.Lines[0] + "\r\n" + richTextBox1.Lines[1] + "\r\n" + richTextBox1.Lines[2] + "\r\n" + n2;
                        Thread.Sleep(2000);
                        Application.DoEvents();
                    }
                }

                    //textBox8.Text = R1;
                
                for (int d = 0; d < 1; d++)
                {
                    
                    if (c == 14)
                    {
                        textBox8.Text = n1.Substring(12, 4);
                        c++;
                        textBox25.Text = c.ToString();
                    }
                    else if(c==4||c==9)
                    {
                        textBox8.Text = n1.Substring(4, 4);
                        c++;
                        textBox25.Text = c.ToString();
                    }
                    if (c == 15)
                    {
                        textBox17.Text = "60";
                        Thread.Sleep(2000);
                        Application.DoEvents();
                        c++;//16
                    }
                    if (c == 5)
                    {
                        textBox15.Text = "12";
                        Thread.Sleep(2000);
                        Application.DoEvents();
                        c++;//6
                    }
                    else if (c == 10)
                    {
                        textBox13.Text = "48";
                        Thread.Sleep(2000);
                        Application.DoEvents();
                        c++;
                    }
                }
                    
                }
        }
                
                 
                

        private void timer1_tick(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
            
           
        
    }
}
