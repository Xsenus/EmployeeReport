namespace Report
{
    partial class FormReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuItemImportExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtPathP7 = new System.Windows.Forms.TextBox();
            this.lblPathP7 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 143);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(436, 225);
            this.dataGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(436, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuItemImportExcel,
            this.btnMenuItemExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // btnMenuItemImportExcel
            // 
            this.btnMenuItemImportExcel.Name = "btnMenuItemImportExcel";
            this.btnMenuItemImportExcel.Size = new System.Drawing.Size(157, 22);
            this.btnMenuItemImportExcel.Text = "Импорт в Excel";
            this.btnMenuItemImportExcel.Click += new System.EventHandler(this.BtnMenuItemImportExcel_Click);
            // 
            // btnMenuItemExit
            // 
            this.btnMenuItemExit.Name = "btnMenuItemExit";
            this.btnMenuItemExit.Size = new System.Drawing.Size(157, 22);
            this.btnMenuItemExit.Text = "Выход";
            this.btnMenuItemExit.Click += new System.EventHandler(this.BtnMenuItemExit_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuItemSettings});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // btnMenuItemSettings
            // 
            this.btnMenuItemSettings.Name = "btnMenuItemSettings";
            this.btnMenuItemSettings.Size = new System.Drawing.Size(138, 22);
            this.btnMenuItemSettings.Text = "Параметры";
            this.btnMenuItemSettings.Click += new System.EventHandler(this.BtnMenuItemSettings_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОПрограммеToolStripMenuItem});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.информацияToolStripMenuItem.Text = "Справка";
            // 
            // информацияОПрограммеToolStripMenuItem
            // 
            this.информацияОПрограммеToolStripMenuItem.Name = "информацияОПрограммеToolStripMenuItem";
            this.информацияОПрограммеToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.информацияОПрограммеToolStripMenuItem.Text = "Информация о программе";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.txtPathP7);
            this.panel1.Controls.Add(this.lblPathP7);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.lblMonth);
            this.panel1.Controls.Add(this.cmbYear);
            this.panel1.Controls.Add(this.cmbMonth);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 119);
            this.panel1.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(56, 88);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(68, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Начать";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // txtPathP7
            // 
            this.txtPathP7.Location = new System.Drawing.Point(158, 11);
            this.txtPathP7.Name = "txtPathP7";
            this.txtPathP7.Size = new System.Drawing.Size(270, 20);
            this.txtPathP7.TabIndex = 6;
            this.txtPathP7.DoubleClick += new System.EventHandler(this.TxtPathP7_DoubleClick);
            // 
            // lblPathP7
            // 
            this.lblPathP7.AutoSize = true;
            this.lblPathP7.Location = new System.Drawing.Point(10, 14);
            this.lblPathP7.Name = "lblPathP7";
            this.lblPathP7.Size = new System.Drawing.Size(148, 13);
            this.lblPathP7.TabIndex = 5;
            this.lblPathP7.Text = "Путь к БД Парус Бюджет 7:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(23, 64);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(28, 13);
            this.lblYear.TabIndex = 11;
            this.lblYear.Text = "Год:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(10, 38);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(43, 13);
            this.lblMonth.TabIndex = 9;
            this.lblMonth.Text = "Месяц:";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbYear.Location = new System.Drawing.Point(56, 62);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(80, 21);
            this.cmbYear.TabIndex = 10;
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbMonth.Location = new System.Drawing.Point(56, 36);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(80, 21);
            this.cmbMonth.TabIndex = 8;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 368);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormReport";
            this.Text = "Отчет по сотдуникам";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtPathP7;
        private System.Windows.Forms.Label lblPathP7;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ToolStripMenuItem информацияОПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItemImportExcel;
    }
}

