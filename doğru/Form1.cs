using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace doğru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int say,tahminsayısı =3;
        ArrayList arrayList = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("tahmin sayımız"+tahminsayısı);
            Console.WriteLine("say" + say);
            Console.WriteLine("yazdığımız sayı"+textBox1);
            button2.Enabled = false;
            int tahmin;
            label5.Text = "";
            tahminsayısı--;
            tahmin = int.Parse(textBox1.Text);
            if (tahminsayısı>0)
            {
               
                if (tahmin!=say)
                {
                    label3.Text = "bir daha deneyin ";
                    button1.Enabled =true;                   
                    label5.Text = tahminsayısı.ToString();
                }
                else
                {
                    label3.Text = "doğru cevabı buldunuz";
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = true;
                    label5.Text = tahminsayısı.ToString();
                }
            }
            else if(tahmin != say && tahminsayısı == 0)
            {
                MessageBox.Show("tahmin hakkınız bitti");
                textBox1.Enabled = false;
                button1.Enabled = false;
                label3.Text = say.ToString();
                button2.Enabled = true;
                label5.Text = tahminsayısı.ToString();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
        }
        public void sayı_kontrol()
        {
            basadon:
            Random rnd = new Random();
            int saya = rnd.Next(0,3);
           
            Console.WriteLine("sayı kntr"+say);
            Console.WriteLine("seçilen sayı" + saya);
            foreach ( int item in arrayList)
            {
                if (item==saya)
                {
                    goto basadon;
                }
                
            }
            arrayList.Add(saya);
            say =saya;
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            tahminsayısı = 3;
            this.sayı_kontrol();
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = true;
            textBox1.Enabled = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.sayı_kontrol();
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = true;
            textBox1.Enabled = true;

        }
    }
}
