using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nem
{
    public partial class Form1 : Form
    {
        int chislo = 0;

        public Form1()
        {
            InitializeComponent();
        }


        public void bt1_Click(object sender, EventArgs e)
        {
            string[] param1 = { "ein", "eines", "zwei", "drei", "vier", "fünf", "sechs", "sieben", "acht", "neun" };
            string[] param2 = { "elf", "zwölf", "dreizehn", "vierzehn", "fünfzehn", "sechzehn", "siebzehn", "achtzehn", "neunzehn" };
            string[] param3 = { "zehn", "zwanzig", "dreißig", "vierzig", "fünfzig", "sechzig", "siebzig", "achtzig", "neunzig" };
            int mistake = 0;
            string text = numberWas.Text.ToLower();
            string[] content = text.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();


            if (content.Length >= 1 && !param1.Contains(content[0]) && !param3.Contains(content[0]) && !param2.Contains(content[0]) && content[0] != "null")
            {
                mistake = -1;
                MessageBox.Show("Число не может начинаться со слова " + content[0]);
            }
            if (content.Length > 1 && content[0] == "null")
            {
                mistake = -1;
                MessageBox.Show("Ошибка. После слова null не должно быть слов никакого формата");
            }

            if (content.Length > 1 && param2.Contains(content[0]) && !param2.Contains(content[1]) && !param3.Contains(content[1]) && !param1.Contains(content[1]))
            {
                mistake = -1;
                MessageBox.Show($"Ошибка написания слова [ " + content[1] + " ]");
            }
            if (content.Length > 1 && param3.Contains(content[0]) && !param2.Contains(content[1]) && !param3.Contains(content[1]) && !param1.Contains(content[1]) && content[1] != "hundert" && content[1] != "und")
            {
                mistake = -1;
                MessageBox.Show($"Ошибка написания слова [ " + content[1] + " ]");
            }

            if (content.Length > 1 && param3.Contains(content[0]) && param1.Contains(content[1]))
            {
                mistake = -1;
                MessageBox.Show("Слово единичного формата [ " + content[1] + " ] не должно идти после слова десятичного формата");
            }
            if (content.Length > 1 && param3.Contains(content[0]) && param3.Contains(content[1]))
            {
                mistake = -1;
                MessageBox.Show("Слово десятичного формата [ " + content[1] + " ] не должно идти после слова десятичного формата");
            }
            if (content.Length > 1 && param3.Contains(content[0]) && param2.Contains(content[1]))
            {
                mistake = -1;
                MessageBox.Show("Слово формата 11-19 [ " + content[1] + " ] не должно идти после слова десятичного формата");
            }

            if (content.Length > 1 && param2.Contains(content[0]) && param1.Contains(content[1]))
            {
                mistake = -1;
                MessageBox.Show("Слово единичного формата [ " + content[1] + " ] не должно идти после слова формата 11-19");
            }
            if (content.Length > 1 && param2.Contains(content[0]) && param3.Contains(content[1]))
            {
                mistake = -1;
                MessageBox.Show("Слово десятичного формата [ " + content[1] + " ] не должно идти после слова формата 11-19");
            }
            if (content.Length > 1 && param2.Contains(content[0]) && param2.Contains(content[1]))
            {
                mistake = -1;
                MessageBox.Show("Слово формата 11-19 [ " + content[1] + " ] не должно идти после слова формата 11-19");
            }

            if (content.Length > 1 && param1.Contains(content[0]) && !param2.Contains(content[1]) && !param3.Contains(content[1]) && !param1.Contains(content[1]) && content[1] != "hundert" && content[1] != "und")
            {
                mistake = -1;
                MessageBox.Show($"Ошибка написания слова [ " + content[1] + " ]");
            }

            if (content.Length > 1 && param1.Contains(content[0]) && param3.Contains(content[1]))
            {
                mistake = -1;
                MessageBox.Show("После слова единичного формата [ " + content[0] + " ], перед словом десятичного формата [ " + content[1] + " ] должно идти слово und или hundert");
            }

            if (content.Length > 1 && param1.Contains(content[0]) && param2.Contains(content[1]))
            {
                mistake = -1;
                MessageBox.Show("После слова единичного формата [ " + content[0] + " ], перед словом формата 11-19 [ " + content[1] + " ] должно идти слово hundert");
            }

            if (content.Length > 3 && param1.Contains(content[0]) && content[1] == "und" && param3.Contains(content[2]))
            {
                mistake = -1;
                MessageBox.Show($"После слова десятичного формата [ " + content[2] + " ] других слов быть не должно");
            }

            if (content.Length > 3 && param1.Contains(content[0]) && content[1] == "hundert" && param3.Contains(content[2]) && content[3] != "und")
            {
                mistake = -1;
                MessageBox.Show($"После слова десятичного формата [ " + content[2] + " ] ничего не должно быть");
            }

            if (content.Length > 3 && param1.Contains(content[0]) && content[1] == "hundert" && param3.Contains(content[2]) && content[3] == "und")
            {
                mistake = -1;
                MessageBox.Show($"Перед словом und должно быть слово единичного формата, а не слово десятичного формата " + content[2]);
            }

            if (content.Length > 3 && param1.Contains(content[0]) && content[1] == "hundert" && param2.Contains(content[2]) && content[3] == "und")
            {
                mistake = -1;
                MessageBox.Show($"Перед словом und должно быть слово единичного формата, а не слово формата 11-19 " + content[2]);
            }

            if (content.Length > 3 && param1.Contains(content[0]) && content[1] == "hundert" && param2.Contains(content[2]) && param1.Contains(content[3]))
            {
                mistake = -1;
                MessageBox.Show($"После слова формата 11-19 ( " + content[2] + " ) не должно идти слово едичиного формата [ " + content[3] + " ]");
            }

            if (content.Length > 5 && param1.Contains(content[0]) && content[1] == "hundert" && param1.Contains(content[2]) && content[3] == "und" && param3.Contains(content[4]))
            {
                mistake = -1;
                MessageBox.Show($"После слова десятичного формата [" + content[4] + "] быть ничего не должно  [ " + content[5] + " ]");
            }

            if (content.Length > 2 && param1.Contains(content[0]) && content[1] == "und" && !param3.Contains(content[2]) && !param1.Contains(content[2]) && !param2.Contains(content[2]))
            {
                mistake = -1;
                MessageBox.Show($"Ошибка написания слова [ " + content[2] + " ]");
            }
            if (content.Length > 2 && param1.Contains(content[0]) && content[1] == "und" && param1.Contains(content[2]))
            {
                mistake = -1;
                MessageBox.Show($"После слово und должно быть слово десятичного формата, а не единичного [ " + content[2] + " ]");
            }

            if (content.Length > 2 && param1.Contains(content[0]) && content[1] == "und" && param2.Contains(content[2]))
            {
                mistake = -1;
                MessageBox.Show($"После слово und должно быть слово десятичного формата, а не формата 11-19 [ " + content[2] + " ]");
            }

            if (content.Length > 3 && param1.Contains(content[0]) && content[1] == "hundert" && param2.Contains(content[2]) && !param1.Contains(content[3]) && !param3.Contains(content[3]) && !param2.Contains(content[3]) && content[3] != "und")
            {
                mistake = -1;
                MessageBox.Show($"После слова формата 11-19 [ " + content[2] + " ] ничего не должно быть");
            }

            if (content.Length > 3 && param1.Contains(content[0]) && content[1] == "hundert" && param2.Contains(content[2]) && param3.Contains(content[3]) && content[3] != "und")
            {
                mistake = -1;
                MessageBox.Show($"После слова формата 11-19 [ " + content[2] + " ] не должно идти слово десятичного формата [ " + content[3] + " ]");
            }

            if (content.Length > 3 && param1.Contains(content[0]) && content[1] == "hundert" && param2.Contains(content[2]) && param2.Contains(content[3]) && content[3] != "und")
            {
                mistake = -1;
                MessageBox.Show($"После слова формата 11-19 [ " + content[2] + " ] не должно идти слово формата 11-19 [ " + content[3] + " ]");
            }

            if (content.Length > 3 && param1.Contains(content[0]) && content[1] == "hundert" && param1.Contains(content[2]) && !param1.Contains(content[3]) && !param3.Contains(content[3]) && !param2.Contains(content[3]) && content[3] != "und")
            {
                mistake = -1;
                MessageBox.Show($"Ошибка написания слова [ " + content[3] + " ]");
            }

            if (content.Length == 4 && param1.Contains(content[0]) && content[1] == "hundert" && param1.Contains(content[2]) && param2.Contains(content[3]))
            {
                mistake = -1;
                MessageBox.Show($"После слова единичного формата [ " + content[3] + " ] не может идти слово формата 11-19 [ " + content[3] + " ]");
            }

            if (content.Length == 4 && param1.Contains(content[0]) && content[1] == "hundert" && param1.Contains(content[2]) && param1.Contains(content[3]))
            {
                mistake = -1;
                MessageBox.Show($"После слова единичного формата [ " + content[3] + " ] не может идти слово единичного формата [ " + content[3] + " ]");
            }

            if (content.Length > 2 && param1.Contains(content[0]) && content[1] == "hundert" && !param3.Contains(content[2]) && !param1.Contains(content[2]) &&
              !param2.Contains(content[2]))
            {

                if (content[2] == "hundert")
                {
                    mistake = -1;
                    MessageBox.Show($"Повтор слова hundert");
                }

                else if (content[2] == "und")
                {
                    mistake = -1;
                    MessageBox.Show($"После слова hundert, перед словом und должно идти слово единичного формата");
                }
                else
                {
                    mistake = -1;
                    MessageBox.Show($"Ошибка написания слова [ " + content[2] + " ]");
                }
            }

            if (content.Length > 1 && param1.Contains(content[0]) && param1.Contains(content[1]))
            {
                mistake = -1;
                MessageBox.Show("После слова единичного формата [" + content[0] + "] не должно идти слово единичного формата [" + content[1] + "]");
            }
            /*
            if (content.Length > 1 && param1.Contains(content[0]) && param1.Contains(content[1]))
            {
                mistake = -1;
                MessageBox.Show("После слова единичного формата [" + content[0] + "], перед словом едичиного формата [" + content[1] + "] должно идти слово hundert");
            } */

            if (content.Length == 2 && param1.Contains(content[0]) && content[1] == "und")
            {
                mistake = -1;
                MessageBox.Show("После слова und должно идти слово десятичного формата");
            }
            /*
            if (content.Length == 2 && param1.Contains(content[0]) && content[1] == "hundert")
            {
              mistake = -1;
              MessageBox.Show("После слова hundert должно идти слово единичного/десятичного/11-19 формата");
            }*/


            if (content.Length > 3 && param1.Contains(content[0]) && content[1] == "hundert" && param1.Contains(content[2]) && param3.Contains(content[3]))
            {
                mistake = -1;
                MessageBox.Show($"После слова едичиного формата [ " + content[2] + " ], перед словом десятичного формата [ " + content[3] + "] должно быть слово und");
            }
            //!!!
            if (content.Length > 4 && param1.Contains(content[0]) && content[1] == "hundert" && param1.Contains(content[2]) && content[3] == "und" && !param3.Contains(content[4]) && !param2.Contains(content[4]) && !param1.Contains(content[4]) && content[4] != "und")
            {
                mistake = -1;
                MessageBox.Show($"Ошибка написания слова [ " + content[4] + " ]");
            }
            if (content.Length > 4 && param1.Contains(content[0]) && content[1] == "hundert" && param1.Contains(content[2]) && content[3] == "und" && content[4] == "und")
            {
                mistake = -1;
                MessageBox.Show($"Повтор слова und");
            }

            if (content.Length > 4 && param1.Contains(content[0]) && content[1] == "hundert" && param1.Contains(content[2]) && content[3] == "und" && !param3.Contains(content[4]) && param2.Contains(content[4]) && !param1.Contains(content[4]))
            {
                mistake = -1;
                MessageBox.Show($"После слова und должно идти слово десятичного формата [а не слово формата 11-19 " + content[4] + "]");
            }

            if (content.Length > 4 && param1.Contains(content[0]) && content[1] == "hundert" && param1.Contains(content[2]) && content[3] == "und" && !param3.Contains(content[4]) && !param2.Contains(content[4]) && param1.Contains(content[4]))
            {
                mistake = -1;
                MessageBox.Show($"После слова und должно идти слово десятичного формата [а не слово едичиного формата " + content[4] + "]");
            }


            if (content.Length == 4 && param1.Contains(content[0]) && content[1] == "hundert" && param1.Contains(content[2]) && content[3] == "und")
            {
                mistake = -1;
                MessageBox.Show($"После слова und должно быть слово десятичного формата");
            }

            if (content.Length > 4 && param2.Contains(content[0]) && content[1] == "hundert" && param1.Contains(content[2]) && param3.Contains(content[4]) && content[3] == "und")
            {
                mistake = -1;
                MessageBox.Show($"Слово формата 11-19 [ " + content[0] + "] не может идти перед словом hundert ");
            }
            if (content.Length > 4 && param3.Contains(content[0]) && content[1] == "hundert" && param1.Contains(content[2]) && param3.Contains(content[4]) && content[3] == "und")
            {
                mistake = -1;
                MessageBox.Show($"Слово десятичного формата [ " + content[0] + " ] не может идти перед словом hundert ");
            }



            if (content.Length > 4 && param1.Contains(content[0]) && content[1] == "hundert" && param1.Contains(content[2]) && param1.Contains(content[3]))
            {
                mistake = -1;
                MessageBox.Show($"После слова единичного формата [ " + content[2] + " ] не может быть слово едичиного формата [ " + content[3] + " ]");
            }

            if (content.Length > 4 && param1.Contains(content[0]) && content[1] == "hundert" && param1.Contains(content[2]) && param2.Contains(content[3]))
            {
                mistake = -1;
                MessageBox.Show($"После слова единичного формата [ " + content[2] + " ] не может быть слово формата 11-19 [ " + content[3] + " ]");
            }

            if (content.Length == 0)
            {
                MessageBox.Show("Вы ничего не ввели");
            }
            else if (content.Length == 1 && mistake == 0)
            {
                if (param1.Contains(content[0]))
                {
                    int r = Summparam1(content[0]);
                    numberRes.Text = r.ToString();
                }
                else if (param2.Contains(content[0]))
                {
                    int r = Summparam2(content[0]);
                    numberRes.Text = r.ToString();
                }
                else if (param3.Contains(content[0]))
                {
                    int r = Summparam3(content[0]);
                    numberRes.Text = r.ToString();
                }
                else if (content[0] == "hundert")
                {
                    numberRes.Text = "100";
                }
                else if (content.Length == 1 && content[0] == "null")
                {
                    int chislo1 = 0;
                    numberRes.Text = chislo1.ToString();
                }
                else if (content[0] == "und")
                {
                    MessageBox.Show("Und должен быть после слова единичного формата");
                }
                else
                {
                    if (content[0] != "null")
                        MessageBox.Show("Проверьте введенное слово, " + numberWas.Text + " не существует в немецком языке");

                }
            }

            else if (content.Length == 2 && mistake == 0)
            {
                if (param1.Contains(content[0]) && content[1] == "hundert")
                {
                    int r = Summparam1(content[0]) * 100;
                    numberRes.Text = r.ToString();
                }
            }


            else if (content.Length >= 3 && mistake == 0)
            {
                if (content.Length == 3 && param1.Contains(content[0]) && content[1] == "und" && param3.Contains(content[2])) //для 45 и тд
                {
                    int chislo1 = 0;
                    chislo1 += Summparam1(content[0]);
                    chislo1 += Summparam3(content[2]);
                    numberRes.Text = chislo1.ToString();
                }

                else if (content.Length == 3 && param1.Contains(content[0]) && content[1] == "hundert" && param2.Contains(content[2])) //для 119 и тд
                {
                    int chislo1 = 0;
                    chislo1 += Summparam1(content[0]) * 100;
                    chislo1 += Summparam2(content[2]);
                    numberRes.Text = chislo1.ToString();
                }
                else if (content.Length == 3 && param1.Contains(content[0]) && content[1] == "hundert" && param3.Contains(content[2])) //для 250 и тд
                {
                    int chislo1 = 0;
                    chislo1 += Summparam1(content[0]) * 100;
                    chislo1 += Summparam3(content[2]);
                    numberRes.Text = chislo1.ToString();
                }

                else if (content.Length == 3 && param1.Contains(content[0]) && content[1] == "hundert" && param1.Contains(content[2])) //для 303 и тд
                {
                    int chislo1 = 0;
                    chislo1 += Summparam1(content[0]) * 100;
                    chislo1 += Summparam1(content[2]);
                    numberRes.Text = chislo1.ToString();
                }

                else if (content.Length == 5 && param1.Contains(content[0]) && content[1] == "hundert" && param1.Contains(content[2]) && content[3] == "und" && param3.Contains(content[4])) //для 342 и тд
                {
                    int chislo1 = 0;
                    chislo1 += Summparam1(content[0]) * 100;
                    chislo1 += Summparam1(content[2]);
                    chislo1 += Summparam3(content[4]);
                    numberRes.Text = chislo1.ToString();
                }



            }

        }
        public int Summparam1(string param1)
        {
            chislo = 0;
            if (param1 == "null")
            {
                chislo += 0;
            }

            else if (param1 == "eines" || param1 == "ein")
            {
                chislo += 1;
            }

            else if (param1 == "zwei")
            {
                chislo += 2;
            }

            else if (param1 == "drei")
            {
                chislo += 3;
            }

            else if (param1 == "vier")
            {
                chislo += 4;
            }

            else if (param1 == "fünf")
            {
                chislo += 5;
            }

            else if (param1 == "sechs")
            {
                chislo += 6;
            }

            else if (param1 == "sieben")
            {
                chislo += 7;
            }

            else if (param1 == "acht")
            {
                chislo += 8;
            }

            else if (param1 == "neun")
            {
                chislo += 9;
            }

            return chislo;
        }

        public int Summparam2(string param1)
        {
            chislo = 0;
            if (param1 == "elf")
            {
                chislo += 11;
            }

            else if (param1 == "zwölf")
            {
                chislo += 12;
            }

            else if (param1 == "dreizehn")
            {
                chislo += 13;
            }

            else if (param1 == "vierzehn")
            {
                chislo += 14;
            }

            else if (param1 == "fünfzehn")
            {
                chislo += 15;
            }

            else if (param1 == "sechzehn")
            {
                chislo += 16;
            }

            else if (param1 == "siebzehn")
            {
                chislo += 17;
            }

            else if (param1 == "achtzehn")
            {
                chislo += 18;
            }

            else if (param1 == "neunzehn")
            {
                chislo += 19;
            }
            return chislo;
        }


        public int Summparam3(string param1)
        {
            chislo = 0;
            if (param1 == "zehn")
            {
                chislo += 10;
            }
            else if (param1 == "zwanzig")
            {
                chislo += 20;
            }

            else if (param1 == "dreißig")
            {
                chislo += 30;
            }

            else if (param1 == "vierzig")
            {
                chislo += 40;
            }

            else if (param1 == "fünfzig")
            {
                chislo += 50;
            }

            else if (param1 == "sechzig")
            {
                chislo += 60;
            }

            else if (param1 == "siebzig")
            {
                chislo += 70;
            }

            else if (param1 == "achtzig")
            {
                chislo += 80;
            }

            else if (param1 == "neunzig")
            {
                chislo += 90;
            }
            return chislo;
        }
    }
}
