using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarısması2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void btn_a_Click(object sender, EventArgs e)
        {

            btn_a.Enabled = false;
            btn_b.Enabled = false;
            btn_c.Enabled = false;
            btn_d.Enabled = false;
            btn_sonraki.Enabled = true;



            label2.Text = btn_a.Text;

            if (label1.Text==label2.Text)
            {
                dogru++;
                dogrusayısı.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                yanlıssayısı.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }

            




        }

        private void btn_b_Click(object sender, EventArgs e)
        {
            btn_a.Enabled = false;
            btn_b.Enabled = false;
            btn_c.Enabled = false;
            btn_d.Enabled = false;
            btn_sonraki.Enabled = true;


            label2.Text = btn_b.Text;

            if (label1.Text==label2.Text)
            {
                dogru++;
                dogrusayısı.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                yanlıssayısı.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            btn_a.Enabled = false;
            btn_b.Enabled = false;
            btn_c.Enabled = false;
            btn_d.Enabled = false;
            btn_sonraki.Enabled = true;

            label2.Text = btn_c.Text;

            if (label1.Text == label2.Text)
            {
                dogru++;
                dogrusayısı.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                yanlıssayısı.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            btn_a.Enabled = false;
            btn_b.Enabled = false;
            btn_c.Enabled = false;
            btn_d.Enabled = false;
            btn_sonraki.Enabled = true;


            label2.Text = btn_d.Text;

            if (label1.Text == label2.Text)
            {
                dogru++;
                dogrusayısı.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                yanlıssayısı.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "0";
            dogrusayısı.Text = "0";
            yanlıssayısı.Text = "0";

            

        }

        private void btn_sonraki_Click(object sender, EventArgs e)
        {
            btn_a.Enabled = true;
            btn_b.Enabled = true;
            btn_c.Enabled = true;
            btn_d.Enabled = true;
            btn_sonraki.Enabled = false;



            soruno++;

            label4.Text = soruno.ToString();


            if (soruno == 1)
            {
                richTextBox1.Text=("Cumhuriyetin ilanı aşağıdakilerden hangisidir.");
                btn_a.Text = "1920";
                btn_b.Text = "1921";
                btn_c.Text = "1922";
                btn_d.Text = "1923";

                label1.Text = "1923";

            }


            if (soruno==2)
            {
                richTextBox1.Text=("Türkiyenin başkenti aşağıdakilerden hangisidir.");
                btn_a.Text = "Sivas";
                btn_b.Text = "Muğla";
                btn_c.Text = "İstanbul";
                btn_d.Text = "Ankara";

                label1.Text = "Ankara";
                

            }
           
            if (soruno==3)
            {
                richTextBox1.Text=("Fethiye ilçesi aşağıdaki şehirlerden hangisindedir");
                btn_a.Text = "Muğla";
                btn_b.Text = "Antalya";
                btn_c.Text = "Mersin";
                btn_d.Text = "İzmir";

                label1.Text = "Muğla";
            }

            if (soruno==4)
            {
                btn_a.Enabled = false;
                btn_b.Enabled = false;
                btn_c.Enabled = false;
                btn_d.Enabled = false;
                btn_sonraki.Enabled = false;
                MessageBox.Show("Yarışma bitti."+"\n"+"Doğru sayınız:"+"\n"+ dogru + "\n" + "Yanlış Sayınız:" + yanlis);
            }




        }

        

        
    }
}
