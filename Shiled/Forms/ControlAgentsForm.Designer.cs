namespace Shiled.Forms
{
    partial class ControlAgentsForm
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
            btnAddAgent = new Button();
            btnDelAgent = new Button();
            btnUnDelAgent = new Button();
            btnRedactAgent = new Button();
            btnExit = new Button();
            dgvAgents = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAgents).BeginInit();
            SuspendLayout();
            // 
            // btnAddAgent
            // 
            btnAddAgent.Location = new Point(28, 276);
            btnAddAgent.Name = "btnAddAgent";
            btnAddAgent.Size = new Size(129, 56);
            btnAddAgent.TabIndex = 0;
            btnAddAgent.Text = "Добавить";
            btnAddAgent.UseVisualStyleBackColor = true;
            // 
            // btnDelAgent
            // 
            btnDelAgent.Location = new Point(196, 276);
            btnDelAgent.Name = "btnDelAgent";
            btnDelAgent.Size = new Size(128, 56);
            btnDelAgent.TabIndex = 1;
            btnDelAgent.Text = "Аннулировать";
            btnDelAgent.UseVisualStyleBackColor = true;
            // 
            // btnUnDelAgent
            // 
            btnUnDelAgent.Location = new Point(373, 276);
            btnUnDelAgent.Name = "btnUnDelAgent";
            btnUnDelAgent.Size = new Size(128, 56);
            btnUnDelAgent.TabIndex = 2;
            btnUnDelAgent.Text = "Восстановить";
            btnUnDelAgent.UseVisualStyleBackColor = true;
            // 
            // btnRedactAgent
            // 
            btnRedactAgent.Location = new Point(545, 276);
            btnRedactAgent.Name = "btnRedactAgent";
            btnRedactAgent.Size = new Size(137, 56);
            btnRedactAgent.TabIndex = 3;
            btnRedactAgent.Text = "Редактировать";
            btnRedactAgent.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(291, 349);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(135, 56);
            btnExit.TabIndex = 4;
            btnExit.Text = "Закрыть";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvAgents
            // 
            dgvAgents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgents.Location = new Point(3, 41);
            dgvAgents.Name = "dgvAgents";
            dgvAgents.RowHeadersWidth = 51;
            dgvAgents.Size = new Size(712, 214);
            dgvAgents.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 6;
            label1.Text = "СК \"Щит\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 9);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 7;
            label2.Text = "Управление агентами";
            // 
            // ControlAgentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 427);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvAgents);
            Controls.Add(btnExit);
            Controls.Add(btnRedactAgent);
            Controls.Add(btnUnDelAgent);
            Controls.Add(btnDelAgent);
            Controls.Add(btnAddAgent);
            Name = "ControlAgentsForm";
            Text = "ControlAgentsForm";
            ((System.ComponentModel.ISupportInitialize)dgvAgents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddAgent;
        private Button btnDelAgent;
        private Button btnUnDelAgent;
        private Button btnRedactAgent;
        private Button btnExit;
        private DataGridView dgvAgents;
        private Label label1;
        private Label label2;
    }
}