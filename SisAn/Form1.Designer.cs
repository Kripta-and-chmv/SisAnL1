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
            this.dtgrdwMatrix = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.альтернативаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрицаПредпочтенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрицаПредпочтенийToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.списокАльтернативToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lstbxAltList = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxProblem = new System.Windows.Forms.TextBox();
            this.txtbxAddAlt = new System.Windows.Forms.TextBox();
            this.btnAddAlt = new System.Windows.Forms.Button();
            this.btnDelAlt = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnEditing = new System.Windows.Forms.Button();
            this.txtbxEditing = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdwMatrix)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrdwMatrix
            // 
            this.dtgrdwMatrix.AllowUserToOrderColumns = true;
            this.dtgrdwMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdwMatrix.Location = new System.Drawing.Point(12, 82);
            this.dtgrdwMatrix.Name = "dtgrdwMatrix";
            this.dtgrdwMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgrdwMatrix.Size = new System.Drawing.Size(473, 199);
            this.dtgrdwMatrix.TabIndex = 0;
            this.dtgrdwMatrix.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
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
            // 
            // альтернативаToolStripMenuItem
            // 
            this.альтернативаToolStripMenuItem.Name = "альтернативаToolStripMenuItem";
            this.альтернативаToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.альтернативаToolStripMenuItem.Text = "Список альтернатив";
            this.альтернативаToolStripMenuItem.Click += new System.EventHandler(this.альтернативаToolStripMenuItem_Click);
            // 
            // матрицаПредпочтенийToolStripMenuItem
            // 
            this.матрицаПредпочтенийToolStripMenuItem.Name = "матрицаПредпочтенийToolStripMenuItem";
            this.матрицаПредпочтенийToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.матрицаПредпочтенийToolStripMenuItem.Text = "Матрица предпочтений";
            this.матрицаПредпочтенийToolStripMenuItem.Click += new System.EventHandler(this.матрицаПредпочтенийToolStripMenuItem_Click);
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
            // lstbxAltList
            // 
            this.lstbxAltList.FormattingEnabled = true;
            this.lstbxAltList.Location = new System.Drawing.Point(12, 300);
            this.lstbxAltList.Name = "lstbxAltList";
            this.lstbxAltList.Size = new System.Drawing.Size(607, 121);
            this.lstbxAltList.TabIndex = 2;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(521, 82);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(98, 53);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Упорядочить";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.button1_Click);
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
            // txtbxProblem
            // 
            this.txtbxProblem.Location = new System.Drawing.Point(12, 45);
            this.txtbxProblem.Multiline = true;
            this.txtbxProblem.Name = "txtbxProblem";
            this.txtbxProblem.Size = new System.Drawing.Size(820, 20);
            this.txtbxProblem.TabIndex = 5;
            // 
            // txtbxAddAlt
            // 
            this.txtbxAddAlt.Location = new System.Drawing.Point(12, 437);
            this.txtbxAddAlt.Multiline = true;
            this.txtbxAddAlt.Name = "txtbxAddAlt";
            this.txtbxAddAlt.Size = new System.Drawing.Size(397, 41);
            this.txtbxAddAlt.TabIndex = 6;
            // 
            // btnAddAlt
            // 
            this.btnAddAlt.Location = new System.Drawing.Point(415, 437);
            this.btnAddAlt.Name = "btnAddAlt";
            this.btnAddAlt.Size = new System.Drawing.Size(100, 40);
            this.btnAddAlt.TabIndex = 7;
            this.btnAddAlt.Text = "Добавить альтернативу\r\n";
            this.btnAddAlt.UseVisualStyleBackColor = true;
            this.btnAddAlt.Click += new System.EventHandler(this.Add_altern_Click);
            // 
            // btnDelAlt
            // 
            this.btnDelAlt.Location = new System.Drawing.Point(521, 437);
            this.btnDelAlt.Name = "btnDelAlt";
            this.btnDelAlt.Size = new System.Drawing.Size(100, 40);
            this.btnDelAlt.TabIndex = 8;
            this.btnDelAlt.Text = "Удалить альтернативу";
            this.btnDelAlt.UseVisualStyleBackColor = true;
            this.btnDelAlt.Click += new System.EventHandler(this.Del_altern_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.Location = new System.Drawing.Point(415, 483);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(100, 41);
            this.btnDelAll.TabIndex = 9;
            this.btnDelAll.Text = "Очистить все\r\n";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.Del_All_Click);
            // 
            // btnEditing
            // 
            this.btnEditing.Location = new System.Drawing.Point(625, 365);
            this.btnEditing.Name = "btnEditing";
            this.btnEditing.Size = new System.Drawing.Size(100, 23);
            this.btnEditing.TabIndex = 10;
            this.btnEditing.Text = "Редактировать";
            this.btnEditing.UseVisualStyleBackColor = true;
            this.btnEditing.Click += new System.EventHandler(this.btnEditing_Click);
            // 
            // txtbxEditing
            // 
            this.txtbxEditing.Location = new System.Drawing.Point(625, 339);
            this.txtbxEditing.Name = "txtbxEditing";
            this.txtbxEditing.Size = new System.Drawing.Size(100, 20);
            this.txtbxEditing.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 536);
            this.Controls.Add(this.txtbxEditing);
            this.Controls.Add(this.btnEditing);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.btnDelAlt);
            this.Controls.Add(this.btnAddAlt);
            this.Controls.Add(this.txtbxAddAlt);
            this.Controls.Add(this.txtbxProblem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lstbxAltList);
            this.Controls.Add(this.dtgrdwMatrix);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdwMatrix)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdwMatrix;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox lstbxAltList;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ToolStripMenuItem альтернативаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрицаПредпочтенийToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxProblem;
        private System.Windows.Forms.TextBox txtbxAddAlt;
        private System.Windows.Forms.Button btnAddAlt;
        private System.Windows.Forms.Button btnDelAlt;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.ToolStripMenuItem матрицаПредпочтенийToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem списокАльтернативToolStripMenuItem;
        private System.Windows.Forms.Button btnEditing;
        private System.Windows.Forms.TextBox txtbxEditing;
    }
}

