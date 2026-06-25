namespace Shiled.Forms
{
    partial class ShowContractsByAgent
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
            btnDelContract = new Button();
            dgvContractsByAgent = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContractsByAgent).BeginInit();
            SuspendLayout();
            // 
            // btnDelContract
            // 
            btnDelContract.Location = new Point(467, 450);
            btnDelContract.Name = "btnDelContract";
            btnDelContract.Size = new Size(172, 29);
            btnDelContract.TabIndex = 0;
            btnDelContract.Text = "Аннулировать";
            btnDelContract.UseVisualStyleBackColor = true;
            btnDelContract.Click += btnDelContract_Click;
            // 
            // dgvContractsByAgent
            // 
            dgvContractsByAgent.AllowUserToAddRows = false;
            dgvContractsByAgent.AllowUserToDeleteRows = false;
            dgvContractsByAgent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContractsByAgent.Location = new Point(1, 91);
            dgvContractsByAgent.Name = "dgvContractsByAgent";
            dgvContractsByAgent.ReadOnly = true;
            dgvContractsByAgent.RowHeadersWidth = 51;
            dgvContractsByAgent.Size = new Size(1070, 296);
            dgvContractsByAgent.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 2;
            label1.Text = "СК \"Щит\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(436, 9);
            label2.Name = "label2";
            label2.Size = new Size(203, 20);
            label2.TabIndex = 3;
            label2.Text = "Просмотр своих договоров";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(477, 515);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Закрыть";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // ShowContractsByAgent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 571);
            Controls.Add(btnExit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvContractsByAgent);
            Controls.Add(btnDelContract);
            Name = "ShowContractsByAgent";
            Text = "ShowContractsByAgent";
            ((System.ComponentModel.ISupportInitialize)dgvContractsByAgent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelContract;
        private DataGridView dgvContractsByAgent;
        private Label label1;
        private Label label2;
        private Button btnExit;
    }
}