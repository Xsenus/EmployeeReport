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
            this.panelConnect = new System.Windows.Forms.Panel();
            this.btnConnectParus = new System.Windows.Forms.Button();
            this.txtPathP7 = new System.Windows.Forms.TextBox();
            this.lblPathP7 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.panelReportPrint = new System.Windows.Forms.Panel();
            this.checkIsAllEmployees = new System.Windows.Forms.CheckBox();
            this.checkIsRegion = new System.Windows.Forms.CheckBox();
            this.checkBoxZeroCharges = new System.Windows.Forms.CheckBox();
            this.groupBoxReport = new System.Windows.Forms.GroupBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBool = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuItemImportExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelConnect.SuspendLayout();
            this.panelReportPrint.SuspendLayout();
            this.groupBoxReport.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.Location = new System.Drawing.Point(0, 118);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(784, 371);
            this.dataGridView.TabIndex = 0;
            // 
            // panelConnect
            // 
            this.panelConnect.Controls.Add(this.btnConnectParus);
            this.panelConnect.Controls.Add(this.txtPathP7);
            this.panelConnect.Controls.Add(this.lblPathP7);
            this.panelConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConnect.Location = new System.Drawing.Point(0, 24);
            this.panelConnect.Margin = new System.Windows.Forms.Padding(2);
            this.panelConnect.Name = "panelConnect";
            this.panelConnect.Size = new System.Drawing.Size(784, 26);
            this.panelConnect.TabIndex = 8;
            // 
            // btnConnectParus
            // 
            this.btnConnectParus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnConnectParus.Location = new System.Drawing.Point(691, 1);
            this.btnConnectParus.Name = "btnConnectParus";
            this.btnConnectParus.Size = new System.Drawing.Size(81, 23);
            this.btnConnectParus.TabIndex = 12;
            this.btnConnectParus.Text = "Соединиться";
            this.btnConnectParus.UseVisualStyleBackColor = true;
            this.btnConnectParus.Click += new System.EventHandler(this.btnConnectParus_Click);
            // 
            // txtPathP7
            // 
            this.txtPathP7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathP7.Location = new System.Drawing.Point(111, 3);
            this.txtPathP7.Name = "txtPathP7";
            this.txtPathP7.Size = new System.Drawing.Size(574, 20);
            this.txtPathP7.TabIndex = 6;
            this.txtPathP7.DoubleClick += new System.EventHandler(this.TxtPathP7_DoubleClick);
            // 
            // lblPathP7
            // 
            this.lblPathP7.AutoSize = true;
            this.lblPathP7.Location = new System.Drawing.Point(12, 6);
            this.lblPathP7.Name = "lblPathP7";
            this.lblPathP7.Size = new System.Drawing.Size(93, 13);
            this.lblPathP7.TabIndex = 5;
            this.lblPathP7.Text = "Парус Бюджет 7:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(273, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(115, 45);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Предварительный просмотр";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(224, 22);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(25, 13);
            this.lblYear.TabIndex = 11;
            this.lblYear.Text = "Год";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(92, 22);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(40, 13);
            this.lblMonth.TabIndex = 9;
            this.lblMonth.Text = "Месяц";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbYear.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cmbYear.Location = new System.Drawing.Point(138, 19);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(80, 21);
            this.cmbYear.TabIndex = 10;
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbMonth.Location = new System.Drawing.Point(6, 19);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(80, 21);
            this.cmbMonth.TabIndex = 8;
            // 
            // panelReportPrint
            // 
            this.panelReportPrint.Controls.Add(this.checkIsAllEmployees);
            this.panelReportPrint.Controls.Add(this.checkIsRegion);
            this.panelReportPrint.Controls.Add(this.checkBoxZeroCharges);
            this.panelReportPrint.Controls.Add(this.btnStart);
            this.panelReportPrint.Controls.Add(this.groupBoxReport);
            this.panelReportPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReportPrint.Location = new System.Drawing.Point(0, 50);
            this.panelReportPrint.Margin = new System.Windows.Forms.Padding(2);
            this.panelReportPrint.Name = "panelReportPrint";
            this.panelReportPrint.Size = new System.Drawing.Size(784, 68);
            this.panelReportPrint.TabIndex = 12;
            // 
            // checkIsAllEmployees
            // 
            this.checkIsAllEmployees.AutoSize = true;
            this.checkIsAllEmployees.Location = new System.Drawing.Point(637, 38);
            this.checkIsAllEmployees.Name = "checkIsAllEmployees";
            this.checkIsAllEmployees.Size = new System.Drawing.Size(106, 17);
            this.checkIsAllEmployees.TabIndex = 15;
            this.checkIsAllEmployees.Text = "Все сотрудники";
            this.checkIsAllEmployees.UseVisualStyleBackColor = true;
            // 
            // checkIsRegion
            // 
            this.checkIsRegion.AutoSize = true;
            this.checkIsRegion.Location = new System.Drawing.Point(394, 15);
            this.checkIsRegion.Name = "checkIsRegion";
            this.checkIsRegion.Size = new System.Drawing.Size(135, 17);
            this.checkIsRegion.TabIndex = 14;
            this.checkIsRegion.Text = "Региональная форма";
            this.checkIsRegion.UseVisualStyleBackColor = true;
            this.checkIsRegion.CheckedChanged += new System.EventHandler(this.checkIsRegion_CheckedChanged);
            // 
            // checkBoxZeroCharges
            // 
            this.checkBoxZeroCharges.AutoSize = true;
            this.checkBoxZeroCharges.Location = new System.Drawing.Point(394, 38);
            this.checkBoxZeroCharges.Name = "checkBoxZeroCharges";
            this.checkBoxZeroCharges.Size = new System.Drawing.Size(200, 17);
            this.checkBoxZeroCharges.TabIndex = 13;
            this.checkBoxZeroCharges.Text = "Не выводить нулевые начисления";
            this.checkBoxZeroCharges.UseVisualStyleBackColor = true;
            // 
            // groupBoxReport
            // 
            this.groupBoxReport.Controls.Add(this.lblMonth);
            this.groupBoxReport.Controls.Add(this.cmbMonth);
            this.groupBoxReport.Controls.Add(this.lblYear);
            this.groupBoxReport.Controls.Add(this.cmbYear);
            this.groupBoxReport.Location = new System.Drawing.Point(12, 5);
            this.groupBoxReport.Name = "groupBoxReport";
            this.groupBoxReport.Size = new System.Drawing.Size(255, 50);
            this.groupBoxReport.TabIndex = 12;
            this.groupBoxReport.TabStop = false;
            this.groupBoxReport.Text = "Временной интервал";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabelBool,
            this.toolStripStatusLabel1,
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 489);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 13;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabel.Text = "Соединение:";
            // 
            // toolStripStatusLabelBool
            // 
            this.toolStripStatusLabelBool.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripStatusLabelBool.Name = "toolStripStatusLabelBool";
            this.toolStripStatusLabelBool.Size = new System.Drawing.Size(64, 17);
            this.toolStripStatusLabelBool.Text = "неактивно";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(628, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Step = 1;
            this.toolStripProgressBar.Visible = false;
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
            this.btnMenuItemInfo});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.информацияToolStripMenuItem.Text = "Справка";
            // 
            // btnMenuItemInfo
            // 
            this.btnMenuItemInfo.Name = "btnMenuItemInfo";
            this.btnMenuItemInfo.Size = new System.Drawing.Size(224, 22);
            this.btnMenuItemInfo.Text = "Информация о программе";
            this.btnMenuItemInfo.Click += new System.EventHandler(this.btnMenuItemInfo_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panelReportPrint);
            this.Controls.Add(this.panelConnect);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormReport";
            this.Text = "Мониторинг оплаты труда медработников";
            this.Resize += new System.EventHandler(this.FormReport_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelConnect.ResumeLayout(false);
            this.panelConnect.PerformLayout();
            this.panelReportPrint.ResumeLayout(false);
            this.panelReportPrint.PerformLayout();
            this.groupBoxReport.ResumeLayout(false);
            this.groupBoxReport.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panelConnect;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtPathP7;
        private System.Windows.Forms.Label lblPathP7;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Panel panelReportPrint;
        private System.Windows.Forms.Button btnConnectParus;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBool;
        private System.Windows.Forms.GroupBox groupBoxReport;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItemImportExcel;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItemInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox checkBoxZeroCharges;
        private System.Windows.Forms.CheckBox checkIsRegion;
        private System.Windows.Forms.CheckBox checkIsAllEmployees;
    }
}

