using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
namespace SisAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float[] C = new float[8];
        string[] el = { "0", "1", "0,5", "_" };
        string[] alterntaiv = new string[] {
            "[1]Замена всего медицинского оборудования, отработавшего нормативный срок, на новое.",
            "[2]Открытие дневных стационаров при поликлиниках.",
            "[3]Создание единой электронной справочной медицинских заведений города.",
            "[4]Строительство специализированных медицинских центров.",
            "[5]Покупка и установка дорогостоящего современного оборудования в специализированных центрах и диспансерах.",
            "[6]Строительство поликлиник в густонаселенных микрорайонах.",
            "[7]Строительство наркологического центра.",
            "[8]Увеличение парка машин скорой помощи."};
        string[] alt = new string[8];
        bool flag = false;
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string[] str = sr.ReadToEnd().Split(new Char[] { ' ', '\r', '\n', '\t' });
                int pos = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (str[pos] == "")
                            pos++;
                        dataGridView1[j, i].Value = str[pos];
                        pos++;
                        if (i == j)
                        {
                            dataGridView1[i, i].Value = ' ';
                            dataGridView1[i, i].ReadOnly = true;
                            dataGridView1[i, i].Style.BackColor = Color.Aqua;
                        }
                    }
                }
                sr.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
            for (int i = 0; i < 8; ++i)
            {
                //Добавляем строку, указывая значения колонок поочереди слева направо
                dataGridView1.Rows.Add("");
                dataGridView1.Rows[i].HeaderCell.Value = "z" + (i + 1).ToString();
            }
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                dataGridView1[i, i].Style.BackColor = Color.Aqua;
                dataGridView1[i, i].ReadOnly = true;
            }
            Array.Copy(alterntaiv, alt, 8);
            flag = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                return;
            }
            float R = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
                C[i] = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (j != i)
                    {
                        C[i] += Convert.ToSingle(dataGridView1[j, i].Value);
                        R += Convert.ToSingle(dataGridView1[j, i].Value);
                    }
                }
                C[i] = C[i] / R;
            }
            BubbleSort(C);
            listBox1.Items.Clear();
            for (int i = 0; i < C.Length; i++)
                listBox1.Items.Add(alterntaiv[i]);
        }
        void BubbleSort(float[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] > A[i])
                    {
                        var temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                        var tmp = alterntaiv[i];
                        alterntaiv[i] = alterntaiv[j];
                        alterntaiv[j] = tmp;
                    }
                }
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                for (int j = 0; j < dataGridView1.Columns.Count; ++j)
                {
                    dataGridView1[i, i].Style.BackColor = Color.Aqua;
                    dataGridView1[i, i].ReadOnly = true;
                    dataGridView1[j, i].Style.BackColor = Color.White;
                    dataGridView1[j, i].Value = "";
                }
            }
            for (var i = 0; i < listBox1.Items.Count; i++)
                C[i] = 0;
            listBox1.Items.Clear();
            for (var i = 0; i < C.Length; i++)
                listBox1.Items.Add(alt[i]);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Out = string.Empty;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (i == j)
                            Out += "_\t";
                        else
                            Out += dataGridView1[j, i].Value + "\t";
                    }
                    Out += "\n";
                }
                File.WriteAllText(saveFileDialog1.FileName, Out);
            }

        }
        bool check()
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (i != j)
                        if (i != j && (!el.Contains(dataGridView1[i, j].Value)))
                        {
                            MessageBox.Show("Неверно задана матрица предпочтений!");
                            dataGridView1[i, j].Style.BackColor = Color.Red;
                            return false;
                        }
                        else
                        {
                            if (Convert.ToSingle(dataGridView1[i, j].Value) + Convert.ToSingle(dataGridView1[j, i].Value) != 1)
                            {
                                MessageBox.Show("Неверно задана матрица предпочтений!");
                                dataGridView1[i, j].Style.BackColor = dataGridView1[j, i].Style.BackColor = Color.Red;
                                return false;
                            }
                        }
                }


            }
            return true;
        }


    }
}
