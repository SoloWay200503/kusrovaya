namespace KURSACH_OP
{
    partial class FormReg
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
            this.RegLogin = new System.Windows.Forms.TextBox();
            this.RegPass = new System.Windows.Forms.TextBox();
            this.buttonCancel2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RegPass2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRegYes = new System.Windows.Forms.Button();
            this.checkBoxPass12 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // RegLogin
            // 
            this.RegLogin.Location = new System.Drawing.Point(67, 23);
            this.RegLogin.Name = "RegLogin";
            this.RegLogin.Size = new System.Drawing.Size(148, 20);
            this.RegLogin.TabIndex = 0;
            // 
            // RegPass
            // 
            this.RegPass.Location = new System.Drawing.Point(67, 61);
            this.RegPass.Name = "RegPass";
            this.RegPass.PasswordChar = '*';
            this.RegPass.Size = new System.Drawing.Size(148, 20);
            this.RegPass.TabIndex = 1;
            // 
            // buttonCancel2
            // 
            this.buttonCancel2.Location = new System.Drawing.Point(104, 176);
            this.buttonCancel2.Name = "buttonCancel2";
            this.buttonCancel2.Size = new System.Drawing.Size(63, 20);
            this.buttonCancel2.TabIndex = 3;
            this.buttonCancel2.Text = "Отмена";
            this.buttonCancel2.UseVisualStyleBackColor = true;
            this.buttonCancel2.Click += new System.EventHandler(this.buttonCancel2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите логин:";
            // 
            // RegPass2
            // 
            this.RegPass2.Location = new System.Drawing.Point(67, 100);
            this.RegPass2.Name = "RegPass2";
            this.RegPass2.PasswordChar = '*';
            this.RegPass2.Size = new System.Drawing.Size(148, 20);
            this.RegPass2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите пароль:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Повторите пароль:";
            // 
            // buttonRegYes
            // 
            this.buttonRegYes.Location = new System.Drawing.Point(67, 147);
            this.buttonRegYes.Name = "buttonRegYes";
            this.buttonRegYes.Size = new System.Drawing.Size(148, 23);
            this.buttonRegYes.TabIndex = 10;
            this.buttonRegYes.Text = "Зарегистрироваться";
            this.buttonRegYes.UseVisualStyleBackColor = true;
            this.buttonRegYes.Click += new System.EventHandler(this.buttonRegYes_Click);
            // 
            // checkBoxPass12
            // 
            this.checkBoxPass12.AutoSize = true;
            this.checkBoxPass12.Location = new System.Drawing.Point(83, 126);
            this.checkBoxPass12.Name = "checkBoxPass12";
            this.checkBoxPass12.Size = new System.Drawing.Size(114, 17);
            this.checkBoxPass12.TabIndex = 11;
            this.checkBoxPass12.Text = "Показать пароль";
            this.checkBoxPass12.UseVisualStyleBackColor = true;
            this.checkBoxPass12.CheckedChanged += new System.EventHandler(this.checkBoxPass12_CheckedChanged);
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 202);
            this.Controls.Add(this.checkBoxPass12);
            this.Controls.Add(this.buttonRegYes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RegPass2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel2);
            this.Controls.Add(this.RegPass);
            this.Controls.Add(this.RegLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.FormReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RegLogin;
        private System.Windows.Forms.TextBox RegPass;
        private System.Windows.Forms.Button buttonCancel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RegPass2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRegYes;
        private System.Windows.Forms.CheckBox checkBoxPass12;
    }
}