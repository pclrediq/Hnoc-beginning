
namespace DDF
{
    partial class ysuConfirm
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
            this.lbl_Yset = new System.Windows.Forms.Label();
            this.btn_confirm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Yset
            // 
            this.lbl_Yset.AutoSize = true;
            this.lbl_Yset.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Yset.Location = new System.Drawing.Point(71, 24);
            this.lbl_Yset.Name = "lbl_Yset";
            this.lbl_Yset.Size = new System.Drawing.Size(115, 13);
            this.lbl_Yset.TabIndex = 1;
            this.lbl_Yset.Text = "Y setup complete";
            // 
            // btn_confirm2
            // 
            this.btn_confirm2.Location = new System.Drawing.Point(91, 56);
            this.btn_confirm2.Name = "btn_confirm2";
            this.btn_confirm2.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm2.TabIndex = 2;
            this.btn_confirm2.Text = "Confirm";
            this.btn_confirm2.UseVisualStyleBackColor = true;
            this.btn_confirm2.Click += new System.EventHandler(this.btn_confirm2_Click);
            // 
            // ysuConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 91);
            this.Controls.Add(this.btn_confirm2);
            this.Controls.Add(this.lbl_Yset);
            this.Name = "ysuConfirm";
            this.Text = "Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Yset;
        private System.Windows.Forms.Button btn_confirm2;
    }
}