namespace MainProgram.UCs
{
    partial class ucStart
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
            this.lblGuide1 = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGuide1
            // 
            this.lblGuide1.AutoSize = true;
            this.lblGuide1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuide1.Location = new System.Drawing.Point(96, 95);
            this.lblGuide1.Name = "lblGuide1";
            this.lblGuide1.Size = new System.Drawing.Size(736, 20);
            this.lblGuide1.TabIndex = 0;
            this.lblGuide1.Text = "Nếu bạn là khách muốn thuê phòng, hãy bấm vào nút dưới đây để đăng ký thuê phòng " +
    "và đăng ký tài khoản khách hàng";
            // 
            // btnSignup
            // 
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSignup.Location = new System.Drawing.Point(330, 223);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(245, 55);
            this.btnSignup.TabIndex = 1;
            this.btnSignup.Text = "Đăng ký";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // ucStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.lblGuide1);
            this.Name = "ucStart";
            this.Size = new System.Drawing.Size(898, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuide1;
        private System.Windows.Forms.Button btnSignup;
    }
}
