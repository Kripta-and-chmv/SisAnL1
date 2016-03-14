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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.альтернативаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрицаПредпочтенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.list_Alt = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.add_alt = new System.Windows.Forms.TextBox();
            this.Add_altern = new System.Windows.Forms.Button();
            this.Del_altern = new System.Windows.Forms.Button();
            this.Del_All = new System.Windows.Forms.Button();
            this.матрицаПредпочтенийToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.списокАльтернативToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(473, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
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
            // альтернативаToolStripMenuItem
            // 
            this.альтернативаToolStripMenuItem.Name = "альтернативаToolStripMenuItem";
            this.альтернативаToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.альтернативаToolStripMenuItem.Text = "Список альтернатив";
            // 
            // матрицаПредпочтенийToolStripMenuItem
            // 
            this.матрицаПредпочтенийToolStripMenuItem.Name = "матрицаПредпочтенийToolStripMenuItem";
            this.матрицаПредпочтенийToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.матрицаПредпочтенийToolStripMenuItem.Text = "Матрица предпочтений";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.матрицаПредпочтенийToolStripMenuItem1,
            this.списокАльтернативToolStripMenuItem});
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
            // list_Alt
            // 
            this.list_Alt.FormattingEnabled = true;
            this.list_Alt.Location = new System.Drawing.Point(12, 300);
            this.list_Alt.Name = "list_Alt";
            this.list_Alt.Size = new System.Drawing.Size(607, 121);
            this.list_Alt.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Упорядочить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Проблема:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(820, 20);
            this.textBox1.TabIndex = 5;
            // 
            // add_alt
            // 
            this.add_alt.Location = new System.Drawing.Point(12, 437);
            this.add_alt.Multiline = true;
            this.add_alt.Name = "add_alt";
            this.add_alt.Size = new System.Drawing.Size(397, 41);
            this.add_alt.TabIndex = 6;
            // 
            // Add_altern
            // 
            this.Add_altern.Location = new System.Drawing.Point(415, 437);
            this.Add_altern.Name = "Add_altern";
            this.Add_altern.Size = new System.Drawing.Size(100, 40);
            this.Add_altern.TabIndex = 7;
            this.Add_altern.Text = "Добавить альтернативу\r\n";
            this.Add_altern.UseVisualStyleBackColor = true;
            this.Add_altern.Click += new System.EventHandler(this.Add_altern_Click);
            // 
            // Del_altern
            // 
            this.Del_altern.Location = new System.Drawing.Point(521, 437);
            this.Del_altern.Name = "Del_altern";
            this.Del_altern.Size = new System.Drawing.Size(100, 40);
            this.Del_altern.TabIndex = 8;
            this.Del_altern.Text = "Удалить альтернативу";
            this.Del_altern.UseVisualStyleBackColor = true;
            this.Del_altern.Click += new System.EventHandler(this.Del_altern_Click);
            // 
            // Del_All
            // 
            this.Del_All.Location = new System.Drawing.Point(415, 483);
            this.Del_All.Name = "Del_All";
            this.Del_All.Size = new System.Drawing.Size(100, 41);
            this.Del_All.TabIndex = 9;
            this.Del_All.Text = "Очистить все\r\n";
            this.Del_All.UseVisualStyleBackColor = true;
            this.Del_All.Click += new System.EventHandler(this.Del_All_Click);
            // 
            // матрицаПредпочтенийToolStripMenuItem1
            // 
            this.матрицаПредпочтенийToolStripMenuItem1.Name = "матрицаПредпочтенийToolStripMenuItem1";
            this.матрицаПредпочтенийToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.матрицаПредпочтенийToolStripMenuItem1.Text = "Матрица предпочтений";
            this.матрицаПредпочтенийToolStripMenuItem1.Click += new System.EventHandler(this.матрицаПредпочтенийToolStripMenuItem1_Click);
            // 
            // списокАльтернативToolStripMenuItem
            // 
            this.списокАльтернативToolStripMenuItem.Name = "списокАльтернативToolStripMenuItem";
            this.списокАльтернативToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.списокАльтернативToolStripMenuItem.Text = "Список альтернатив";
            this.списокАльтернативToolStripMenuItem.Click += new System.EventHandler(this.списокАльтернативToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 536);
            this.Controls.Add(this.Del_All);
            this.Controls.Add(this.Del_altern);
            this.Controls.Add(this.Add_altern);
            this.Controls.Add(this.add_alt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.list_Alt);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox list_Alt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem альтернативаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрицаПредпочтенийToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox add_alt;
        private System.Windows.Forms.Button Add_altern;
        private System.Windows.Forms.Button Del_altern;
        private System.Windows.Forms.Button Del_All;
        private System.Windows.Forms.ToolStripMenuItem матрицаПредпочтенийToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem списокАльтернативToolStripMenuItem;
    }
}

