﻿namespace Project_4
{
    partial class ResetPassword
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
            this.new_pass_label = new System.Windows.Forms.Label();
            this.ver_new_pass = new System.Windows.Forms.Label();
            this.txtResetPass = new System.Windows.Forms.TextBox();
            this.txtResetPassVer = new System.Windows.Forms.TextBox();
            this.button_reset_pass = new System.Windows.Forms.Button();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.recoverMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // new_pass_label
            // 
            this.new_pass_label.AutoSize = true;
            this.new_pass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_pass_label.Location = new System.Drawing.Point(362, 355);
            this.new_pass_label.Name = "new_pass_label";
            this.new_pass_label.Size = new System.Drawing.Size(108, 20);
            this.new_pass_label.TabIndex = 0;
            this.new_pass_label.Text = "Νέος Κωδικός";
            // 
            // ver_new_pass
            // 
            this.ver_new_pass.AutoSize = true;
            this.ver_new_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ver_new_pass.Location = new System.Drawing.Point(362, 389);
            this.ver_new_pass.Name = "ver_new_pass";
            this.ver_new_pass.Size = new System.Drawing.Size(202, 20);
            this.ver_new_pass.TabIndex = 1;
            this.ver_new_pass.Text = "Επιβεβαίωση Νέου Κωδικού";
            // 
            // txtResetPass
            // 
            this.txtResetPass.Location = new System.Drawing.Point(592, 355);
            this.txtResetPass.Name = "txtResetPass";
            this.txtResetPass.PasswordChar = '*';
            this.txtResetPass.Size = new System.Drawing.Size(169, 20);
            this.txtResetPass.TabIndex = 2;
            // 
            // txtResetPassVer
            // 
            this.txtResetPassVer.Location = new System.Drawing.Point(592, 389);
            this.txtResetPassVer.Name = "txtResetPassVer";
            this.txtResetPassVer.PasswordChar = '*';
            this.txtResetPassVer.Size = new System.Drawing.Size(169, 20);
            this.txtResetPassVer.TabIndex = 3;
            // 
            // button_reset_pass
            // 
            this.button_reset_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset_pass.Location = new System.Drawing.Point(487, 444);
            this.button_reset_pass.Name = "button_reset_pass";
            this.button_reset_pass.Size = new System.Drawing.Size(139, 41);
            this.button_reset_pass.TabIndex = 4;
            this.button_reset_pass.Text = "Επαναφορά";
            this.button_reset_pass.UseVisualStyleBackColor = true;
            this.button_reset_pass.Click += new System.EventHandler(this.button_reset_pass_Click);
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Location = new System.Drawing.Point(765, 355);
            this.showPass.Margin = new System.Windows.Forms.Padding(2);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(111, 17);
            this.showPass.TabIndex = 6;
            this.showPass.Text = "Προβολή Κωδικού";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // recoverMsg
            // 
            this.recoverMsg.AutoSize = true;
            this.recoverMsg.Location = new System.Drawing.Point(267, 301);
            this.recoverMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.recoverMsg.Name = "recoverMsg";
            this.recoverMsg.Size = new System.Drawing.Size(0, 13);
            this.recoverMsg.TabIndex = 7;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.recoverMsg);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.button_reset_pass);
            this.Controls.Add(this.txtResetPassVer);
            this.Controls.Add(this.txtResetPass);
            this.Controls.Add(this.ver_new_pass);
            this.Controls.Add(this.new_pass_label);
            this.Name = "ResetPassword";
            this.Size = new System.Drawing.Size(1233, 784);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label new_pass_label;
        private System.Windows.Forms.Label ver_new_pass;
        private System.Windows.Forms.TextBox txtResetPass;
        private System.Windows.Forms.TextBox txtResetPassVer;
        private System.Windows.Forms.Button button_reset_pass;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.Label recoverMsg;
    }
}
