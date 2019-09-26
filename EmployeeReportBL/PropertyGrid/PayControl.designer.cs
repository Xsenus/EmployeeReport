namespace EmployeeReportBL.PropertyGrid
{
   partial class PayControl
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.checkedListPay = new System.Windows.Forms.CheckedListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListPay
            // 
            this.checkedListPay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListPay.BackColor = System.Drawing.Color.AntiqueWhite;
            this.checkedListPay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListPay.CheckOnClick = true;
            this.checkedListPay.Font = new System.Drawing.Font("Tahoma", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListPay.FormattingEnabled = true;
            this.checkedListPay.Location = new System.Drawing.Point(0, 0);
            this.checkedListPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListPay.Name = "checkedListPay";
            this.checkedListPay.Size = new System.Drawing.Size(150, 170);
            this.checkedListPay.Sorted = true;
            this.checkedListPay.TabIndex = 0;
            this.checkedListPay.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListPay_ItemCheck);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOK.Location = new System.Drawing.Point(91, 172);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(54, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // PayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.checkedListPay);
            this.Font = new System.Drawing.Font("Tahoma", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PayControl";
            this.Size = new System.Drawing.Size(150, 200);
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.CheckedListBox checkedListPay;
      private System.Windows.Forms.Button btnOK;
   }
}
