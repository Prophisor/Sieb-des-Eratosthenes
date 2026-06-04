using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sieb_des_Eratosthenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int Zahlen;
        Button btn;

        //public object Thread { get; private set; }

        private void click_funktion(object sender, EventArgs e)
        {         
        }

        private void Primzahlen_Click(object sender, EventArgs e)
        {
            List<int> primzahlen = new List<int>();

            foreach (Control c in this.Controls) // c ist nur ein Name 
            {
                if (c is Button)
                {
                    btn = c as Button;

                    if (btn.Name != "Primzahlen" && btn.Name != "button1")
                    {

                        // MessageBox.Show(btn.Text);
                        Zahlen = Convert.ToInt32(btn.Text);



                        if (Zahlen % 2 == 0 && btn.BackColor == Color.FloralWhite)
                        {
                            btn.BackColor = Color.Red;
                            button2.BackColor = Color.DarkCyan;
                            //System.Threading.Thread.Sleep(100);
                        }

                        if (Zahlen % 3 == 0)
                        {
                            if (btn.BackColor != Color.Red && timer1.Enabled == true)
                            {
                                btn.BackColor = Color.Green;
                                button3.BackColor = Color.DarkCyan;
                            }
                        }
                        if (Zahlen % 5 == 0)
                        {
                            if (btn.BackColor != Color.Green && btn.BackColor != Color.Red)
                            {
                                btn.BackColor = Color.Blue;
                                button5.BackColor = Color.DarkCyan;
                            }
                        }
                        if (Zahlen % 7 == 0)
                        {
                            if (btn.BackColor != Color.Green && btn.BackColor != Color.Red && btn.BackColor != Color.Blue)
                            {
                                btn.BackColor = Color.Yellow;
                                button7.BackColor = Color.DarkCyan;
                            }
                        }
                        if (Zahlen >= 11)
                        {
                            if (btn.BackColor != Color.Green && btn.BackColor != Color.Red && btn.BackColor != Color.Blue && btn.BackColor != Color.Yellow)
                            {
                                btn.BackColor = Color.DarkCyan;
                            }
                        }
                        if (btn.BackColor == Color.DarkCyan)
                        {
                            //display.AppendText("" + btn.Text + ", ");
                            primzahlen.Add(Convert.ToInt32(btn.Text));      // convert.ToInt32, weil die Buttons sind Text hier und deshalb mussen umgewandelt werden, da die Liste Int ist. 
                            primzahlen.Sort();    
                        }
                    }
                }  
            }
            foreach (int value in primzahlen)
            {
                display.AppendText("" + value + ", ");
               
                // display22.AppendText("" + value + ", ");
            }
            display.AppendText("\r\n.................................");            // neue anfängt und man weiß wo die Ende war und wo der Anfang ist. 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void display_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
