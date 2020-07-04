namespace Apteka
{
    partial class Reg
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
            this.labelPassCopy = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxPassCopy = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName1 = new System.Windows.Forms.TextBox();
            this.textBoxPassCopy1 = new System.Windows.Forms.TextBox();
            this.textBoxLastName1 = new System.Windows.Forms.TextBox();
            this.textBoxPass1 = new System.Windows.Forms.TextBox();
            this.textBoxFirstName1 = new System.Windows.Forms.TextBox();
            this.textBoxLog1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPassCopy
            // 
            this.labelPassCopy.AutoSize = true;
            this.labelPassCopy.Location = new System.Drawing.Point(10, 139);
            this.labelPassCopy.Name = "labelPassCopy";
            this.labelPassCopy.Size = new System.Drawing.Size(100, 13);
            this.labelPassCopy.TabIndex = 24;
            this.labelPassCopy.Text = "Повторите пароль";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonAdd.Location = new System.Drawing.Point(13, 237);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(243, 49);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "Зарегистрироваться";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(10, 54);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(38, 13);
            this.labelLogin.TabIndex = 17;
            this.labelLogin.Text = "Логин";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(10, 97);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(45, 13);
            this.labelPass.TabIndex = 16;
            this.labelPass.Text = "Пароль";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(153, 54);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 15;
            this.labelFirstName.Text = "Имя";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(153, 97);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 14;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(153, 142);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(113, 13);
            this.labelMiddleName.TabIndex = 13;
            this.labelMiddleName.Text = "Отчество (если есть)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Почта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Телефон";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Покупатель",
            "Фармацевт"});
            this.comboBoxType.Location = new System.Drawing.Point(10, 30);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(246, 21);
            this.comboBoxType.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Вы Покупатель или Фармацевт?";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(156, 70);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 32;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(13, 74);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(100, 20);
            this.textBoxLog.TabIndex = 33;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(13, 199);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 34;
            // 
            // textBoxPassCopy
            // 
            this.textBoxPassCopy.Location = new System.Drawing.Point(13, 158);
            this.textBoxPassCopy.Name = "textBoxPassCopy";
            this.textBoxPassCopy.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassCopy.TabIndex = 35;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(13, 116);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 36;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(156, 119);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 37;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(156, 158);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMiddleName.TabIndex = 38;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(156, 199);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 39;
            // 
            // textBoxMiddleName1
            // 
            this.textBoxMiddleName1.Location = new System.Drawing.Point(423, 158);
            this.textBoxMiddleName1.Name = "textBoxMiddleName1";
            this.textBoxMiddleName1.Size = new System.Drawing.Size(100, 20);
            this.textBoxMiddleName1.TabIndex = 40;
            // 
            // textBoxPassCopy1
            // 
            this.textBoxPassCopy1.Location = new System.Drawing.Point(293, 158);
            this.textBoxPassCopy1.Name = "textBoxPassCopy1";
            this.textBoxPassCopy1.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassCopy1.TabIndex = 41;
            // 
            // textBoxLastName1
            // 
            this.textBoxLastName1.Location = new System.Drawing.Point(423, 116);
            this.textBoxLastName1.Name = "textBoxLastName1";
            this.textBoxLastName1.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName1.TabIndex = 42;
            // 
            // textBoxPass1
            // 
            this.textBoxPass1.Location = new System.Drawing.Point(293, 119);
            this.textBoxPass1.Name = "textBoxPass1";
            this.textBoxPass1.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass1.TabIndex = 43;
            // 
            // textBoxFirstName1
            // 
            this.textBoxFirstName1.Location = new System.Drawing.Point(423, 70);
            this.textBoxFirstName1.Name = "textBoxFirstName1";
            this.textBoxFirstName1.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName1.TabIndex = 44;
            // 
            // textBoxLog1
            // 
            this.textBoxLog1.Location = new System.Drawing.Point(293, 70);
            this.textBoxLog1.Name = "textBoxLog1";
            this.textBoxLog1.Size = new System.Drawing.Size(100, 20);
            this.textBoxLog1.TabIndex = 45;
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(535, 295);
            this.Controls.Add(this.textBoxLog1);
            this.Controls.Add(this.textBoxFirstName1);
            this.Controls.Add(this.textBoxPass1);
            this.Controls.Add(this.textBoxLastName1);
            this.Controls.Add(this.textBoxPassCopy1);
            this.Controls.Add(this.textBoxMiddleName1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxPassCopy);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPassCopy);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMiddleName);
            this.Name = "Reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPassCopy;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxPassCopy;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxMiddleName1;
        private System.Windows.Forms.TextBox textBoxPassCopy1;
        private System.Windows.Forms.TextBox textBoxLastName1;
        private System.Windows.Forms.TextBox textBoxPass1;
        private System.Windows.Forms.TextBox textBoxFirstName1;
        private System.Windows.Forms.TextBox textBoxLog1;
    }
}