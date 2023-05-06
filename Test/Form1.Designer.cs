namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_FindFile_Load = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialogLoad = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogOpen = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.openFileDialogDelete = new System.Windows.Forms.OpenFileDialog();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.button_Key = new System.Windows.Forms.Button();
            this.label_Key = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // button_FindFile_Load
            // 
            this.button_FindFile_Load.Location = new System.Drawing.Point(201, 41);
            this.button_FindFile_Load.Name = "button_FindFile_Load";
            this.button_FindFile_Load.Size = new System.Drawing.Size(97, 23);
            this.button_FindFile_Load.TabIndex = 1;
            this.button_FindFile_Load.Text = "Найти ключ";
            this.button_FindFile_Load.UseVisualStyleBackColor = true;
            this.button_FindFile_Load.Visible = false;
            this.button_FindFile_Load.Click += new System.EventHandler(this.button_FindFile_Load_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(691, 415);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(97, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(12, 83);
            this.textBoxValue.Multiline = true;
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(776, 316);
            this.textBoxValue.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Содержание файла";
            // 
            // openFileDialogLoad
            // 
            this.openFileDialogLoad.FileName = "openFileDialog1";
            // 
            // openFileDialogOpen
            // 
            this.openFileDialogOpen.FileName = "openFileDialog2";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(15, 44);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(180, 20);
            this.textBoxFileName.TabIndex = 6;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(12, 28);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(92, 13);
            this.labelFileName.TabIndex = 7;
            this.labelFileName.Text = "Название файла";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name.Location = new System.Drawing.Point(314, 39);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(60, 24);
            this.label_Name.TabIndex = 8;
            this.label_Name.Text = "label2";
            // 
            // openFileDialogDelete
            // 
            this.openFileDialogDelete.FileName = "openFileDialog3";
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(523, 43);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(162, 20);
            this.textBox_Key.TabIndex = 9;
            this.textBox_Key.Visible = false;
            // 
            // button_Key
            // 
            this.button_Key.Location = new System.Drawing.Point(691, 41);
            this.button_Key.Name = "button_Key";
            this.button_Key.Size = new System.Drawing.Size(95, 23);
            this.button_Key.TabIndex = 10;
            this.button_Key.Text = "Открыть";
            this.button_Key.UseVisualStyleBackColor = true;
            this.button_Key.Visible = false;
            this.button_Key.Click += new System.EventHandler(this.button_Key_Click);
            // 
            // label_Key
            // 
            this.label_Key.AutoSize = true;
            this.label_Key.Location = new System.Drawing.Point(520, 28);
            this.label_Key.Name = "label_Key";
            this.label_Key.Size = new System.Drawing.Size(33, 13);
            this.label_Key.TabIndex = 11;
            this.label_Key.Text = "Ключ";
            this.label_Key.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Key);
            this.Controls.Add(this.button_Key);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.button_FindFile_Load);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Button button_FindFile_Load;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialogLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialogOpen;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.OpenFileDialog openFileDialogDelete;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.Button button_Key;
        private System.Windows.Forms.Label label_Key;
    }
}

