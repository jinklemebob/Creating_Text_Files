namespace _05_LabExer_1
{
    partial class FrmFileName
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
            label1 = new Label();
            txtFileName = new TextBox();
            btnOkay = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 43);
            label1.Name = "label1";
            label1.Size = new Size(165, 30);
            label1.TabIndex = 0;
            label1.Text = "Enter File Name:";
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(29, 76);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(349, 23);
            txtFileName.TabIndex = 1;
            // 
            // btnOkay
            // 
            btnOkay.Location = new Point(152, 130);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(105, 40);
            btnOkay.TabIndex = 2;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += btnOkay_Click;
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 216);
            Controls.Add(btnOkay);
            Controls.Add(txtFileName);
            Controls.Add(label1);
            Name = "FrmFileName";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFileName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFileName;
        private Button btnOkay;
    }
}