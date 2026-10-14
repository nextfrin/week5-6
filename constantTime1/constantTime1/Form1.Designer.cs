namespace constantTime1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbNumbers = new ComboBox();
            btnConfirm = new Button();
            lblNumber = new Label();
            SuspendLayout();
            // 
            // cbNumbers
            // 
            cbNumbers.FormattingEnabled = true;
            cbNumbers.Items.AddRange(new object[] { "10", "20", "30", "40", "50" });
            cbNumbers.Location = new Point(83, 60);
            cbNumbers.Name = "cbNumbers";
            cbNumbers.Size = new Size(151, 28);
            cbNumbers.TabIndex = 0;
            cbNumbers.Text = "choose a number";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(83, 94);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += button1_Click;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(240, 63);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(124, 20);
            lblNumber.TabIndex = 2;
            lblNumber.Text = "Selected number:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNumber);
            Controls.Add(btnConfirm);
            Controls.Add(cbNumbers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbNumbers;
        private Button btnConfirm;
        private Label lblNumber;
    }
}
