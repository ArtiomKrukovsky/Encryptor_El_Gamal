using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
namespace Gamal_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int power(int a, int b, int n) // a^b mod n - возведение a в степень b по модулю n
        {
            BigInteger rez;
            rez = BigInteger.Pow(a,b);
            rez = rez % n;
            return Convert.ToInt32(rez.ToString());
        }
        int mul(int a, int b, int n) // a*b mod n - умножение a на b по модулю n
        {
            BigInteger rez;
            rez = BigInteger.Multiply(a, b);
            rez = rez % n;
            return Convert.ToInt32(rez.ToString());
        }

        void crypt(int p, int g, int x, string strIn)
        {
            DeEncrypt_textbox.Text = "";
            int y = power(g, x, p);
            P_textbox.Text = p.ToString(); G_textbox.Text = g.ToString(); Y_textbox.Text = y.ToString(); X_textbox.Text = x.ToString();
            if (strIn.Length > 0)
            {
                char[] temp = new char[strIn.Length - 1];
                temp = strIn.ToCharArray();
                for (int i = 0; i <= strIn.Length - 1; i++)
                {
                    int m = (int)temp[i];
                    if (m > 0)
                    {
                        Random rd = new Random();
                        int k = rd.Next() % (p - 2) + 1; // 1 < k < (p-1)
                        int a = power(g, k, p);
                        int b = mul(power(y, k, p), m, p);
                        DeEncrypt_textbox.Text += a + " " + b + " ";
                    }
                }
            }
        }

        void decrypt(int p, int x, string strIn)
        {
            if (strIn.Length > 0)
            {
                rez_tex_box.Text = "";
                string[] strA = strIn.Split(' ');
                if (strA.Length > 0)
                {
                    for (int i = 0; i < strA.Length - 1; i += 2)
                    {
                        char[] a = new char[strA[i].Length];
                        char[] b = new char[strA[i + 1].Length];
                        int ai = 0; int bi = 0;
                        a = strA[i].ToCharArray();
                        b = strA[i + 1].ToCharArray();
                        for (int j = 0; (j < a.Length); j++)
                            ai = ai * 10 + (int)(a[j] - 48);
                        for (int j = 0; (j < b.Length); j++)
                            bi = bi * 10 + (int)(b[j] - 48);
                        if ((ai != 0) && (bi != 0))
                        {
                            int deM = mul(bi, power(ai, p - 1 - x, p), p);// m=b*(a^x)^(-1)mod p =b*a^(p-1-x)mod p 
                            rez_tex_box.Text+= (char)deM;
                        }
                    }
                }
            }
        }

        static int p = Convert.ToInt32(557);
        static int g = Convert.ToInt32(548);
        static int x = Convert.ToInt32(3);

        public static void Generate_Keys()
        {
            Random rd = new Random();
            while (true)
            {
                int f=0;
                p = rd.Next(100,600);
                for (int i = 2; i < p-1; i++)
                    if (p % i == 0) f++;
                if (f == 0) break;
            }
            g = rd.Next() % (p - 2) + 1;
            x = rd.Next(1, 11);
        }
        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            Generate_Keys();
            crypt(p, g, x, sms_textbox.Text);
        }

        private void btn_DeEncrypt_Click(object sender, EventArgs e)
        {
            decrypt(p, x, DeEncrypt_textbox.Text);
        }

    }
}
