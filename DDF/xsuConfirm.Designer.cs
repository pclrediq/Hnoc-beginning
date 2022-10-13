
namespace DDF
{
    partial class xsuConfirm
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
            this.lbl_Xset = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Xset
            // 
            this.lbl_Xset.AutoSize = true;
            this.lbl_Xset.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Xset.Location = new System.Drawing.Point(68, 24);
            this.lbl_Xset.Name = "lbl_Xset";
            this.lbl_Xset.Size = new System.Drawing.Size(115, 13);
            this.lbl_Xset.TabIndex = 0;
            this.lbl_Xset.Text = "X setup complete";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(86, 54);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 1;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // xsuConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 89);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.lbl_Xset);
            this.Name = "xsuConfirm";
            this.Text = "Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Xset;
        private System.Windows.Forms.Button btn_confirm;
    }
}