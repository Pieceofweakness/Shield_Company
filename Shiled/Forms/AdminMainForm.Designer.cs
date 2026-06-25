namespace Shiled.Forms
{
    partial class AdminMainForm
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
            btnAgents = new Button();
            btnFilials = new Button();
            btnInsurances = new Button();
            btnContracts = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAgents
            // 
            btnAgents.Location = new Point(51, 145);
            btnAgents.Name = "btnAgents";
            btnAgents.Size = new Size(202, 29);
            btnAgents.TabIndex = 0;
            btnAgents.Text = "Управление агентами";
            btnAgents.UseVisualStyleBackColor = true;
            btnAgents.Click += btnAgents_Click;
            // 
            // btnFilials
            // 
            btnFilials.Location = new Point(51, 193);
            btnFilials.Name = "btnFilials";
            btnFilials.Size = new Size(202, 29);
            btnFilials.TabIndex = 1;
            btnFilials.Text = "Управление филиалами";
            btnFilials.UseVisualStyleBackColor = true;
            btnFilials.Click += btnFilials_Click;
            // 
            // btnInsurances
            // 
            btnInsurances.Location = new Point(51, 244);
            btnInsurances.Name = "btnInsurances";
            btnInsurances.Size = new Size(202, 29);
            btnInsurances.TabIndex = 2;
            btnInsurances.Text = "Виды страхования";
            btnInsurances.UseVisualStyleBackColor = true;
            btnInsurances.Click += btnInsurances_Click;
            // 
            // btnContracts
            // 
            btnContracts.Location = new Point(51, 290);
            btnContracts.Name = "btnContracts";
            btnContracts.Size = new Size(202, 29);
            btnContracts.TabIndex = 3;
            btnContracts.Text = "Просмотр договров";
            btnContracts.UseVisualStyleBackColor = true;
            btnContracts.Click += btnContracts_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(51, 343);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(202, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 26);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 5;
            label1.Text = "СК \"ЩИТ\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 24);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 6;
            label2.Text = "Главное меню";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 53);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 7;
            label3.Text = "Администратор";
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnContracts);
            Controls.Add(btnInsurances);
            Controls.Add(btnFilials);
            Controls.Add(btnAgents);
            Name = "AdminMainForm";
            Text = "AdminMainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgents;
        private Button btnFilials;
        private Button btnInsurances;
        private Button btnContracts;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}