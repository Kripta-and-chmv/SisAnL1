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
            "[8]Увеличение парка машин скорой помощи."};//это вот тоже надо убрать, тк у нас из файла будет в лист бокс альтернативы попадать
        string[] alt = new string[8];
        bool flag = false;
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)// проверь работает ли с любыми матрицами
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
           /* for (int i = 0; i < 8; ++i)
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
            flag = true;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                return;
            }
            float R = 0;
            for (int i = 0; i < list_Alt.Items.Count; i++)
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
            list_Alt.Items.Clear();
            for (int i = 0; i < C.Length; i++)
                list_Alt.Items.Add(alterntaiv[i]);
        }//сам алгоритм
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

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)//очистка матрицы
        {
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                for (int j = 0; j < dataGridView1.Columns.Count; ++j)
                {

                    if (i!=j)
                    {
                        dataGridView1[j, i].Style.BackColor = Color.White;
                        dataGridView1[i, j].Value = "1";
                        dataGridView1[j, i].Value = "0";
                    }
                    else
                    {
                        dataGridView1[i, i].Style.BackColor = Color.Aqua;
                        dataGridView1[i, i].ReadOnly = true;
                    }
                    
                }
            }
            for (var i = 0; i < list_Alt.Items.Count; i++)
                C[i] = 0;
            
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)//это не надо, в самом низу то что нужно
        {
            /*if (saveFileDialog1.ShowDialog() == DialogResult.OK)
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
            }*/

        }
        bool check()
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (i != j)
                        if ((!el.Contains(dataGridView1[i, j].Value)))
                        {
                            MessageBox.Show("Неверно задана матрица предпочтений!");
                            dataGridView1[i, j].Value = "0";
                            dataGridView1[j, i].Value = "1";
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

        private void Add_altern_Click(object sender, EventArgs e)//добавить альтернативу

        {
            int alt = list_Alt.Items.Count; 
            if (add_alt.Text != "")
            {
                list_Alt.Items.Add(add_alt.Text);
                add_alt.Text = "";
                dataGridView1.Columns.Add("z" + alt.ToString(), "z" + alt.ToString());
                dataGridView1.Rows.Add();
                dataGridView1.Rows[alt].HeaderCell.Value = "z" + alt.ToString();
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    int j = dataGridView1.Rows.Count - 1;
                        if (i == j)
                        {
                            dataGridView1[i, i].Style.BackColor = Color.Aqua;
                            dataGridView1[i, i].ReadOnly = true;
                        }
                        else
                        {
                            dataGridView1[i, j].Value = "0";
                            dataGridView1[j, i].Value = "1";
                        }

                }
            }

        }
        private void Del_altern_Click(object sender, EventArgs e)//удаление выбранных альтернатив
        {
            if (list_Alt.Items.Count != 0)
            {
                dataGridView1.Rows.RemoveAt(list_Alt.SelectedIndex);
                dataGridView1.Columns.RemoveAt(list_Alt.SelectedIndex);
                list_Alt.Items.RemoveAt(list_Alt.SelectedIndex);
                for (int i = 0; i < list_Alt.Items.Count; i++)
                {
                    dataGridView1.Rows[i].HeaderCell.Value = "z" + i.ToString();
                    dataGridView1.Columns[i].HeaderText = "z" + i.ToString();
                }
            }
        }

        private void Del_All_Click(object sender, EventArgs e)//очистить все
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            list_Alt.Items.Clear();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)//автоподстановка
        {
            
            dataGridView1[e.RowIndex, e.ColumnIndex].Value = 
               (1 - Convert.ToSingle(dataGridView1[e.ColumnIndex, e.RowIndex].Value)).ToString();
            check();
        }

        private void матрицаПредпочтенийToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void списокАльтернативToolStripMenuItem_Click(object sender, EventArgs e)//сохранение в файл
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Out = string.Empty;
                for (int i = 0; i < list_Alt.Items.Count; i++)
                {
                    
                   
                }
                File.WriteAllText(saveFileDialog1.FileName, Out);
            }
        }


    }
}
