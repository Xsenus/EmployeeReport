namespace Report
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.btnSave = new System.Windows.Forms.Button();
            this.propertyGridSettings = new System.Windows.Forms.PropertyGrid();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblINN = new System.Windows.Forms.Label();
            this.txtINN = new System.Windows.Forms.TextBox();
            this.txtOrganization = new System.Windows.Forms.TextBox();
            this.lblOrganization = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.panelBot = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkedListPositions = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkedListTypeOfCalculations = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTypeOfCalculations = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelBot.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(316, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 63;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // propertyGridSettings
            // 
            this.propertyGridSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridSettings.HelpBackColor = System.Drawing.SystemColors.Info;
            this.propertyGridSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.propertyGridSettings.Location = new System.Drawing.Point(3, 3);
            this.propertyGridSettings.Margin = new System.Windows.Forms.Padding(2);
            this.propertyGridSettings.Name = "propertyGridSettings";
            this.propertyGridSettings.Size = new System.Drawing.Size(470, 363);
            this.propertyGridSettings.TabIndex = 68;
            this.propertyGridSettings.ToolbarVisible = false;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblINN);
            this.panelTop.Controls.Add(this.txtINN);
            this.panelTop.Controls.Add(this.txtOrganization);
            this.panelTop.Controls.Add(this.lblOrganization);
            this.panelTop.Controls.Add(this.txtRegion);
            this.panelTop.Controls.Add(this.lblRegion);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(484, 121);
            this.panelTop.TabIndex = 69;
            // 
            // lblINN
            // 
            this.lblINN.AutoSize = true;
            this.lblINN.Location = new System.Drawing.Point(71, 95);
            this.lblINN.Name = "lblINN";
            this.lblINN.Size = new System.Drawing.Size(34, 13);
            this.lblINN.TabIndex = 5;
            this.lblINN.Text = "ИНН:";
            // 
            // txtINN
            // 
            this.txtINN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtINN.Location = new System.Drawing.Point(111, 92);
            this.txtINN.Name = "txtINN";
            this.txtINN.Size = new System.Drawing.Size(361, 20);
            this.txtINN.TabIndex = 4;
            // 
            // txtOrganization
            // 
            this.txtOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrganization.Location = new System.Drawing.Point(111, 41);
            this.txtOrganization.Multiline = true;
            this.txtOrganization.Name = "txtOrganization";
            this.txtOrganization.Size = new System.Drawing.Size(361, 45);
            this.txtOrganization.TabIndex = 3;
            // 
            // lblOrganization
            // 
            this.lblOrganization.AutoSize = true;
            this.lblOrganization.Location = new System.Drawing.Point(28, 44);
            this.lblOrganization.Name = "lblOrganization";
            this.lblOrganization.Size = new System.Drawing.Size(77, 13);
            this.lblOrganization.TabIndex = 2;
            this.lblOrganization.Text = "Организация:";
            // 
            // txtRegion
            // 
            this.txtRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegion.Location = new System.Drawing.Point(111, 15);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(361, 20);
            this.txtRegion.TabIndex = 1;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(59, 18);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(46, 13);
            this.lblRegion.TabIndex = 0;
            this.lblRegion.Text = "Регион:";
            // 
            // panelBot
            // 
            this.panelBot.Controls.Add(this.btnCancel);
            this.panelBot.Controls.Add(this.btnSave);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(0, 516);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(484, 45);
            this.panelBot.TabIndex = 70;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(397, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 121);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(484, 395);
            this.tabControl.TabIndex = 71;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.propertyGridSettings);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(476, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Выплаты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkedListPositions);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(476, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Должности";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkedListPositions
            // 
            this.checkedListPositions.CheckOnClick = true;
            this.checkedListPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListPositions.FormattingEnabled = true;
            this.checkedListPositions.Location = new System.Drawing.Point(3, 3);
            this.checkedListPositions.Name = "checkedListPositions";
            this.checkedListPositions.Size = new System.Drawing.Size(470, 363);
            this.checkedListPositions.Sorted = true;
            this.checkedListPositions.TabIndex = 0;
            this.checkedListPositions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListPositions_ItemCheck);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkedListTypeOfCalculations);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(476, 369);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Виды расчета";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkedListTypeOfCalculations
            // 
            this.checkedListTypeOfCalculations.CheckOnClick = true;
            this.checkedListTypeOfCalculations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListTypeOfCalculations.FormattingEnabled = true;
            this.checkedListTypeOfCalculations.Location = new System.Drawing.Point(3, 37);
            this.checkedListTypeOfCalculations.Name = "checkedListTypeOfCalculations";
            this.checkedListTypeOfCalculations.Size = new System.Drawing.Size(470, 329);
            this.checkedListTypeOfCalculations.TabIndex = 0;
            this.checkedListTypeOfCalculations.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListTypeOfCalculations_ItemCheck);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTypeOfCalculations);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 34);
            this.panel1.TabIndex = 1;
            // 
            // lblTypeOfCalculations
            // 
            this.lblTypeOfCalculations.AutoSize = true;
            this.lblTypeOfCalculations.Location = new System.Drawing.Point(5, 10);
            this.lblTypeOfCalculations.Name = "lblTypeOfCalculations";
            this.lblTypeOfCalculations.Size = new System.Drawing.Size(384, 13);
            this.lblTypeOfCalculations.TabIndex = 0;
            this.lblTypeOfCalculations.Text = "Указанные виды расчета будут установлены в отчете отдельной строкой.\r\n";
            // 
            // FormSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "FormSettings";
            this.Text = "Настройки отчета";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBot.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PropertyGrid propertyGridSettings;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtOrganization;
        private System.Windows.Forms.Label lblOrganization;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblINN;
        private System.Windows.Forms.TextBox txtINN;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckedListBox checkedListPositions;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckedListBox checkedListTypeOfCalculations;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTypeOfCalculations;
    }
}