﻿using System;
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
        private String alterntaiv; //= new string[] {
        //    "[1]Замена всего медицинского оборудования, отработавшего нормативный срок, на новое.",
        //    "[2]Открытие дневных стационаров при поликлиниках.",
        //    "[3]Создание единой электронной справочной медицинских заведений города.",
        //    "[4]Строительство специализированных медицинских центров.",
        //    "[5]Покупка и установка дорогостоящего современного оборудования в специализированных центрах и диспансерах.",
        //    "[6]Строительство поликлиник в густонаселенных микрорайонах.",
        //    "[7]Строительство наркологического центра.",
        //    "[8]Увеличение парка машин скорой помощи."};//это вот тоже надо убрать, тк у нас из файла будет в лист бокс альтернативы попадать
        string[] alt = new string[8];
        bool flag = false;
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)// проверь работает ли с любыми матрицами
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string[] str = sr.ReadToEnd().Split(new Char[] { ' ', '\r', '\n', '\t' });
                int pos = 0;
                for (int i = 0; i < dtgrdwMatrix.RowCount; i++)
                {
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
                sr.Close();
            }
        }

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
            if (!check())
            {
                return;
            }
            float R = 0;
            for (int i = 0; i < lstbxAltList.Items.Count; i++)
                C[i] = 0;

            for (int i = 0; i < dtgrdwMatrix.Rows.Count; i++)
            {
                for (int j = 0; j < dtgrdwMatrix.Columns.Count; j++)
                {
                    if (j != i)
                    {
                        C[i] += Convert.ToSingle(dtgrdwMatrix[j, i].Value);
                        R += Convert.ToSingle(dtgrdwMatrix[j, i].Value);
                    }
                }
                C[i] = C[i] / R;
            }
            BubbleSort(C);
            lstbxAltList.Items.Clear();
            for (int i = 0; i < C.Length; i++)
                lstbxAltList.Items.Add(alterntaiv[i]);
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
            for (int i = 0; i < dtgrdwMatrix.Rows.Count; ++i)
            {

                for (int j = 0; j < dtgrdwMatrix.Columns.Count; ++j)
                {

                    if (i!=j)
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
            for (var i = 0; i < lstbxAltList.Items.Count; i++)
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

            for (int i = 0; i < dtgrdwMatrix.Rows.Count; i++)
            {
                for (int j = 0; j < dtgrdwMatrix.Columns.Count; j++)
                {
                    if (i != j)
                        if ((!el.Contains(dtgrdwMatrix[i, j].Value)))
                        {
                            MessageBox.Show("Неверно задана матрица предпочтений!");
                            dtgrdwMatrix[i, j].Value = "0";
                            dtgrdwMatrix[j, i].Value = "1";
                            return false;
                        }
                        else
                        {
                            if (Convert.ToSingle(dtgrdwMatrix[i, j].Value) + Convert.ToSingle(dtgrdwMatrix[j, i].Value) != 1)
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

        private void Add_altern_Click(object sender, EventArgs e)//добавить альтернативу

        {
            int alt = lstbxAltList.Items.Count; 
            if (txtbxAddAlt.Text != "")
            {
                lstbxAltList.Items.Add(txtbxAddAlt.Text);
                txtbxAddAlt.Text = "";
                dtgrdwMatrix.Columns.Add("z" + alt.ToString(), "z" + alt.ToString());
                dtgrdwMatrix.Rows.Add();
                dtgrdwMatrix.Rows[alt].HeaderCell.Value = "z" + alt.ToString();
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
                            dtgrdwMatrix[i, j].Value = "0";
                            dtgrdwMatrix[j, i].Value = "1";
                        }

                }
            }

        }
        private void Del_altern_Click(object sender, EventArgs e)//удаление выбранных альтернатив
        {
            if (lstbxAltList.Items.Count != 0)
            {
                dtgrdwMatrix.Rows.RemoveAt(lstbxAltList.SelectedIndex);
                dtgrdwMatrix.Columns.RemoveAt(lstbxAltList.SelectedIndex);
                lstbxAltList.Items.RemoveAt(lstbxAltList.SelectedIndex);
                for (int i = 0; i < lstbxAltList.Items.Count; i++)
                {
                    dtgrdwMatrix.Rows[i].HeaderCell.Value = "z" + i.ToString();
                    dtgrdwMatrix.Columns[i].HeaderText = "z" + i.ToString();
                }
            }
        }

        private void Del_All_Click(object sender, EventArgs e)//очистить все
        {
            dtgrdwMatrix.Rows.Clear();
            dtgrdwMatrix.Columns.Clear();
            lstbxAltList.Items.Clear();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)//автоподстановка
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

        private void списокАльтернативToolStripMenuItem_Click(object sender, EventArgs e)//сохранение в файл
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
                StreamReader altFile = new StreamReader(openFileDialog1.FileName);
                string[] alts = altFile.ReadToEnd().Split('\n');
                int pos = 0;
                dt

                for (int i = 0; i < dtgrdwMatrix.RowCount; i++)
                {
                    for (int j = 0; j < dtgrdwMatrix.ColumnCount; j++)
                    {
                        if (alts[pos] == "")
                            pos++;
                        dtgrdwMatrix[j, i].Value = alts[pos];
                        pos++;
                        if (i == j)
                        {
                            dtgrdwMatrix[i, i].Value = ' ';
                            dtgrdwMatrix[i, i].ReadOnly = true;
                            dtgrdwMatrix[i, i].Style.BackColor = Color.Aqua;
                        }
                    }
                }
                altFile.Close();
            }
    }
}
