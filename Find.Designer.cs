namespace TextEditor
{
    partial class Find
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
            this.txtFind = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchDown_radioBtn = new System.Windows.Forms.RadioButton();
            this.searchUp_radioBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(119, 28);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(172, 20);
            this.txtFind.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text to find";
            // 
            // searchDown_radioBtn
            // 
            this.searchDown_radioBtn.AutoSize = true;
            this.searchDown_radioBtn.Location = new System.Drawing.Point(17, 78);
            this.searchDown_radioBtn.Name = "searchDown_radioBtn";
            this.searchDown_radioBtn.Size = new System.Drawing.Size(88, 17);
            this.searchDown_radioBtn.TabIndex = 4;
            this.searchDown_radioBtn.TabStop = true;
            this.searchDown_radioBtn.Text = "Search down";
            this.searchDown_radioBtn.UseVisualStyleBackColor = true;
            // 
            // searchUp_radioBtn
            // 
            this.searchUp_radioBtn.AutoSize = true;
            this.searchUp_radioBtn.Location = new System.Drawing.Point(17, 107);
            this.searchUp_radioBtn.Name = "searchUp_radioBtn";
            this.searchUp_radioBtn.Size = new System.Drawing.Size(74, 17);
            this.searchUp_radioBtn.TabIndex = 5;
            this.searchUp_radioBtn.TabStop = true;
            this.searchUp_radioBtn.Text = "Search up";
            this.searchUp_radioBtn.UseVisualStyleBackColor = true;
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 144);
            this.Controls.Add(this.searchUp_radioBtn);
            this.Controls.Add(this.searchDown_radioBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFind);
            this.Name = "Find";
            this.Text = "Find";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton searchDown_radioBtn;
        private System.Windows.Forms.RadioButton searchUp_radioBtn;
    }
}