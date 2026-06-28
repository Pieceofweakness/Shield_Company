namespace Shiled.Forms
{
    partial class ClientMainForm
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
            label2 = new Label();
            label3 = new Label();
            btnApplication = new Button();
            btnMyContracts = new Button();
            btnChangeInfo = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "СК \"Щит\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 15);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 1;
            label2.Text = "Главное меню";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 57);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Клиент";
            // 
            // btnApplication
            // 
            btnApplication.Location = new Point(62, 120);
            btnApplication.Name = "btnApplication";
            btnApplication.Size = new Size(146, 29);
            btnApplication.TabIndex = 3;
            btnApplication.Text = "Подать заявку";
            btnApplication.UseVisualStyleBackColor = true;
            btnApplication.Click += btnApplication_Click;
            // 
            // btnMyContracts
            // 
            btnMyContracts.Location = new Point(62, 166);
            btnMyContracts.Name = "btnMyContracts";
            btnMyContracts.Size = new Size(146, 29);
            btnMyContracts.TabIndex = 4;
            btnMyContracts.Text = "Мои договоры";
            btnMyContracts.UseVisualStyleBackColor = true;
            btnMyContracts.Click += btnMyContracts_Click;
            // 
            // btnChangeInfo
            // 
            btnChangeInfo.Location = new Point(62, 212);
            btnChangeInfo.Name = "btnChangeInfo";
            btnChangeInfo.Size = new Size(146, 29);
            btnChangeInfo.TabIndex = 5;
            btnChangeInfo.Text = "Изменить данные";
            btnChangeInfo.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(62, 262);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(146, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // ClientMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 315);
            Controls.Add(btnExit);
            Controls.Add(btnChangeInfo);
            Controls.Add(btnMyContracts);
            Controls.Add(btnApplication);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClientMainForm";
            Text = "ClientMainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnApplication;
        private Button btnMyContracts;
        private Button btnChangeInfo;
        private Button btnExit;
    }
}