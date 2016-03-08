namespace SisAn
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.z1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.альтернативаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрицаПредпочтенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.z1,
            this.z2,
            this.z3,
            this.z4,
            this.z5,
            this.z6,
            this.z7,
            this.z8});
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(473, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // z1
            // 
            this.z1.Frozen = true;
            this.z1.HeaderText = "z1";
            this.z1.Name = "z1";
            this.z1.Width = 50;
            // 
            // z2
            // 
            this.z2.Frozen = true;
            this.z2.HeaderText = "z2";
            this.z2.Name = "z2";
            this.z2.Width = 50;
            // 
            // z3
            // 
            this.z3.Frozen = true;
            this.z3.HeaderText = "z3";
            this.z3.Name = "z3";
            this.z3.Width = 50;
            // 
            // z4
            // 
            this.z4.Frozen = true;
            this.z4.HeaderText = "z4";
            this.z4.Name = "z4";
            this.z4.Width = 50;
            // 
            // z5
            // 
            this.z5.Frozen = true;
            this.z5.HeaderText = "z5";
            this.z5.Name = "z5";
            this.z5.Width = 50;
            // 
            // z6
            // 
            this.z6.Frozen = true;
            this.z6.HeaderText = "z6";
            this.z6.Name = "z6";
            this.z6.Width = 50;
            // 
            // z7
            // 
            this.z7.Frozen = true;
            this.z7.HeaderText = "z7";
            this.z7.Name = "z7";
            this.z7.Width = 50;
            // 
            // z8
            // 
            this.z8.Frozen = true;
            this.z8.HeaderText = "z8";
            this.z8.Name = "z8";
            this.z8.Width = 50;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.альтернативаToolStripMenuItem,
            this.матрицаПредпочтенийToolStripMenuItem});
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "[1]Замена всего медицинского оборудования, отработавшего нормативный срок, на нов" +
                "ое.",
            "[2]Открытие дневных стационаров при поликлиниках.",
            "[3]Создание единой электронной справочной медицинских заведений города.",
            "[4]Строительство специализированных медицинских центров.",
            "[5]Покупка и установка дорогостоящего современного оборудования в специализирован" +
                "ных центрах и диспансерах.",
            "[6]Строительство поликлиник в густонаселенных микрорайонах.",
            "[7]Строительство наркологического центра.",
            "[8]Увеличение парка машин скорой помощи."});
            this.listBox1.Location = new System.Drawing.Point(12, 270);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(595, 121);
            this.listBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Упорядочить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // альтернативаToolStripMenuItem
            // 
            this.альтернативаToolStripMenuItem.Name = "альтернативаToolStripMenuItem";
            this.альтернативаToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.альтернативаToolStripMenuItem.Text = "Альтернатива";
            // 
            // матрицаПредпочтенийToolStripMenuItem
            // 
            this.матрицаПредпочтенийToolStripMenuItem.Name = "матрицаПредпочтенийToolStripMenuItem";
            this.матрицаПредпочтенийToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.матрицаПредпочтенийToolStripMenuItem.Text = "Матрица предпочтений";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn z1;
        private System.Windows.Forms.DataGridViewTextBoxColumn z2;
        private System.Windows.Forms.DataGridViewTextBoxColumn z3;
        private System.Windows.Forms.DataGridViewTextBoxColumn z4;
        private System.Windows.Forms.DataGridViewTextBoxColumn z5;
        private System.Windows.Forms.DataGridViewTextBoxColumn z6;
        private System.Windows.Forms.DataGridViewTextBoxColumn z7;
        private System.Windows.Forms.DataGridViewTextBoxColumn z8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem альтернативаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрицаПредпочтенийToolStripMenuItem;
    }
}

