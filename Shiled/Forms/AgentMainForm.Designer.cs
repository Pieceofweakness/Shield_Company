namespace Shiled.Forms
{
    partial class AgentMainForm
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
            btnNewContract = new Button();
            btnShowMyContracts = new Button();
            btnShowApplications = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 24);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "СК \"Щит\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 22);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 1;
            label2.Text = "Главное меню";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 60);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Агент";
            // 
            // btnNewContract
            // 
            btnNewContract.Location = new Point(44, 169);
            btnNewContract.Name = "btnNewContract";
            btnNewContract.Size = new Size(161, 29);
            btnNewContract.TabIndex = 3;
            btnNewContract.Text = "Новый договор";
            btnNewContract.UseVisualStyleBackColor = true;
            btnNewContract.Click += btnNewContract_Click;
            // 
            // btnShowMyContracts
            // 
            btnShowMyContracts.Location = new Point(46, 220);
            btnShowMyContracts.Name = "btnShowMyContracts";
            btnShowMyContracts.Size = new Size(159, 29);
            btnShowMyContracts.TabIndex = 4;
            btnShowMyContracts.Text = "Мои договоры";
            btnShowMyContracts.UseVisualStyleBackColor = true;
            // 
            // btnShowApplications
            // 
            btnShowApplications.Location = new Point(46, 279);
            btnShowApplications.Name = "btnShowApplications";
            btnShowApplications.Size = new Size(94, 29);
            btnShowApplications.TabIndex = 5;
            btnShowApplications.Text = "Заявки";
            btnShowApplications.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(52, 329);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // AgentMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnShowApplications);
            Controls.Add(btnShowMyContracts);
            Controls.Add(btnNewContract);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgentMainForm";
            Text = "AgentMainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnNewContract;
        private Button btnShowMyContracts;
        private Button btnShowApplications;
        private Button btnExit;
    }
}