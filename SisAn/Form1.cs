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

        
        string[] el = {"0", "1", "0.5", "_"};
        //private string[] alterntaiv = new string[] {}; //= new string[] {
        //    "[1]Замена всего медицинского оборудования, отработавшего нормативный срок, на новое.",
        //    "[2]Открытие дневных стационаров при поликлиниках.",
        //    "[3]Создание единой электронной справочной медицинских заведений города.",
        //    "[4]Строительство специализированных медицинских центров.",
        //    "[5]Покупка и установка дорогостоящего современного оборудования в специализированных центрах и диспансерах.",
        //    "[6]Строительство поликлиник в густонаселенных микрорайонах.",
        //    "[7]Строительство наркологического центра.",
        //    "[8]Увеличение парка машин скорой помощи."};//это вот тоже надо убрать, тк у нас из файла будет в лист бокс альтернативы попадать
        //string[] alt = new string[8];
        bool flag = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgrdwMatrix.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
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
            int count = lstbxAltList.Items.Count;
            float[] C = new float[count];
            string[] sortedList = new string[count];
            for (int i = 0; i < count; i++)
            {
                sortedList[i] = lstbxAltList.Items[i].ToString();
            }
            if (!check())
            {
                return;
            }
            float R = 0;
            for (int i = 0; i < count; i++)
                C[i] = 0;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (j != i)
                    {
                        C[i] += Convert.ToSingle(dtgrdwMatrix[j, i].Value);
                        //R += Convert.ToSingle(dtgrdwMatrix[j, i].Value);
                    }
                }
                
            }
            //for(int i = 0; i<count; i++)
               // C[i] = C[i] / R;
            BubbleSort(C, sortedList);
            lstbxAltList.Items.Clear();
            lstbxAltList.Items.AddRange(sortedList);
        } //сам алгоритм

        void BubbleSort(float[] A, string[] sortedList)
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
                        var tmp = sortedList[i];
                        sortedList[i] = sortedList[j];
                        sortedList[j] = tmp;
                    }
                }
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e) //очистка матрицы
        {
            for (int i = 0; i < dtgrdwMatrix.Rows.Count; ++i)
            {

                for (int j = 0; j < dtgrdwMatrix.Columns.Count; ++j)
                {

                    if (i != j)
                    {
                        dtgrdwMatrix[j, i].Style.BackColor = Color.White;
                        dtgrdwMatrix[i, j].Value = "1";
                        dtgrdwMatrix[j, i].Value = "0";
                    }
                    else
                    {
                        dtgrdwMatrix[i, i].Style.BackColor = Color.Aqua;
                        dtgrdwMatrix[i, i].ReadOnly = true;
                    }

                }
            }

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
            //это не надо, в самом низу то что нужно
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

            for (int i = 0; i < dtgrdwMatrix.Rows.Count; i++)
            {
                for (int j = 0; j < dtgrdwMatrix.Columns.Count; j++)
                {
                    if (i != j)
                        if ((!el.Contains(dtgrdwMatrix[i, j].Value)))
                        {
                            MessageBox.Show("Неверно задана матрица предпочтений!");
                            dtgrdwMatrix[i, j].Value = "1";
                            dtgrdwMatrix[j, i].Value = "0";
                            return false;
                        }
                        else
                        {
                            if (Convert.ToSingle(dtgrdwMatrix[i, j].Value) + Convert.ToSingle(dtgrdwMatrix[j, i].Value) !=
                                1)
                            {
                                MessageBox.Show("Неверно задана матрица предпочтений!");
                                dtgrdwMatrix[i, j].Style.BackColor = dtgrdwMatrix[j, i].Style.BackColor = Color.Red;
                                return false;
                            }
                        }
                }


            }
            return true;
        }

        private void Add_altern_Click(object sender, EventArgs e) //добавить альтернативу

        {
            if (txtbxAddAlt.Text != "")
            {
                lstbxAltList.Items.Add("["+(lstbxAltList.Items.Count+1).ToString()+"] "+txtbxAddAlt.Text);
                txtbxAddAlt.Text = "";
                dtgrdwMatrix.Columns.Add("z" + lstbxAltList.Items.Count.ToString(), "z" + lstbxAltList.Items.Count.ToString());
                dtgrdwMatrix.Rows.Add();
                dtgrdwMatrix.Rows[lstbxAltList.Items.Count-1].HeaderCell.Value = "z" + lstbxAltList.Items.Count.ToString();
                for (int i = 0; i < dtgrdwMatrix.Rows.Count; ++i)
                {
                    int j = dtgrdwMatrix.Rows.Count - 1;
                    if (i == j)
                    {
                        dtgrdwMatrix[i, i].Style.BackColor = Color.Aqua;
                        dtgrdwMatrix[i, i].ReadOnly = true;
                    }
                    else
                    {
                        dtgrdwMatrix[j, i].Value = "0";
                        dtgrdwMatrix[i, j].Value = "1";
                    }

                }
            }

        }

        private void Del_altern_Click(object sender, EventArgs e) //удаление выбранных альтернатив
        {
            if ((lstbxAltList.Items.Count != 0)&&(lstbxAltList.SelectedIndex!=-1))
            {
                dtgrdwMatrix.Rows.RemoveAt(lstbxAltList.SelectedIndex);
                dtgrdwMatrix.Columns.RemoveAt(lstbxAltList.SelectedIndex);
                lstbxAltList.Items.RemoveAt(lstbxAltList.SelectedIndex);
                for (int i = 0; i < lstbxAltList.Items.Count; i++)
                {
                    dtgrdwMatrix.Rows[i].HeaderCell.Value = "z" + (i+1).ToString();
                    dtgrdwMatrix.Columns[i].HeaderText = "z" + (i+1).ToString();
                }
            }
        }

        private void Del_All_Click(object sender, EventArgs e) //очистить все
        {
            dtgrdwMatrix.Rows.Clear();
            dtgrdwMatrix.Columns.Clear();
            lstbxAltList.Items.Clear();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e) //автоподстановка
        {

            dtgrdwMatrix[e.RowIndex, e.ColumnIndex].Value =
                (1 - Convert.ToSingle(dtgrdwMatrix[e.ColumnIndex, e.RowIndex].Value)).ToString();
            check();
        }

        private void матрицаПредпочтенийToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Out = string.Empty;
                for (int i = 0; i < dtgrdwMatrix.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgrdwMatrix.Columns.Count; j++)
                    {
                        if (i == j)
                            Out += "_\t";
                        else
                            Out += dtgrdwMatrix[j, i].Value + "\t";
                    }
                    Out += "\n";
                }
                File.WriteAllText(saveFileDialog1.FileName, Out);
            }
        }

        private void списокАльтернативToolStripMenuItem_Click(object sender, EventArgs e) //сохранение в файл
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Out = string.Empty;
                for (int i = 0; i < lstbxAltList.Items.Count; i++)
                {


                }
                File.WriteAllText(saveFileDialog1.FileName, Out);
            }
        }

        private void альтернативаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] alts = File.ReadAllLines(openFileDialog1.FileName, Encoding.Default);

                int pos = 0;
                dtgrdwMatrix.Rows.Clear();
                for (int i = 0; i < alts.Length; i++)
                {
                    dtgrdwMatrix.Columns.Add("z"+(i+1).ToString(), "z" + (i + 1).ToString());
                }
                
                dtgrdwMatrix.Rows.Add(alts.Length);

                for (int j = 0; j < alts.Length; j++)
                {
                    dtgrdwMatrix.Rows[j].HeaderCell.Value = "z" + (j + 1).ToString();
                    for (int i = 0; i < alts.Length; i++)
                    {
                        if (j == i)
                        {
                            dtgrdwMatrix[i, i].Style.BackColor = Color.Aqua;
                            dtgrdwMatrix[j, i].ReadOnly = true;
                        }
                        else
                        {
                            dtgrdwMatrix[j, i].Value = "0";
                            dtgrdwMatrix[i, j].Value = "1";
                        }
                    }
                }
                lstbxAltList.Text=String.Empty;
                for (int i = 1; i <= alts.Length; i++)
                {
                    alts[i - 1] = "[" + i.ToString() + "] " + alts[i - 1];
                }
                lstbxAltList.Items.AddRange(alts);
               
            }
        }

        private void матрицаПредпочтенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] str = File.ReadAllLines(openFileDialog1.FileName, Encoding.Default);
                int pos = 0;
                for (int i = 0; i < dtgrdwMatrix.RowCount; i++)
                {
                    string[] buf = str[i].Split('\t');
                    for (int j = 0; j < dtgrdwMatrix.ColumnCount; j++)
                    {
                        if (str[pos] == "")
                            pos++;
                        dtgrdwMatrix[j, i].Value = str[pos];
                        pos++;
                        if (i == j)
                        {
                            dtgrdwMatrix[i, i].Value = ' ';
                            dtgrdwMatrix[i, i].ReadOnly = true;
                            dtgrdwMatrix[i, i].Style.BackColor = Color.Aqua;
                        }
                    }
                }
            }
        }

        private void btnEditing_Click(object sender, EventArgs e)
        {
            lstbxAltList.Items[lstbxAltList.SelectedIndex] = lstbxAltList.SelectedItem.ToString().Substring(0, 4) +txtbxEditing.Text;
            txtbxEditing.Text = "";
        }
    }

}
