namespace EBP_WinForms
{
    partial class MainForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.txtDestinationText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTypeTransformation = new System.Windows.Forms.ComboBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtOriginalText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(550, 384);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtDestinationText
            // 
            this.txtDestinationText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDestinationText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtDestinationText.Location = new System.Drawing.Point(113, 206);
            this.txtDestinationText.Multiline = true;
            this.txtDestinationText.Name = "txtDestinationText";
            this.txtDestinationText.Size = new System.Drawing.Size(393, 97);
            this.txtDestinationText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Source text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type transformation:";
            // 
            // comboTypeTransformation
            // 
            this.comboTypeTransformation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTypeTransformation.FormattingEnabled = true;
            this.comboTypeTransformation.Location = new System.Drawing.Point(113, 322);
            this.comboTypeTransformation.Name = "comboTypeTransformation";
            this.comboTypeTransformation.Size = new System.Drawing.Size(186, 21);
            this.comboTypeTransformation.TabIndex = 6;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(47, 375);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(279, 38);
            this.btnExecute.TabIndex = 7;
            this.btnExecute.Text = "&Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtOriginalText
            // 
            this.txtOriginalText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtOriginalText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtOriginalText.Location = new System.Drawing.Point(113, 81);
            this.txtOriginalText.Multiline = true;
            this.txtOriginalText.Name = "txtOriginalText";
            this.txtOriginalText.Size = new System.Drawing.Size(393, 97);
            this.txtOriginalText.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 457);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.comboTypeTransformation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDestinationText);
            this.Controls.Add(this.txtOriginalText);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "EBP - Informatique";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtDestinationText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTypeTransformation;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtOriginalText;
    }
}

