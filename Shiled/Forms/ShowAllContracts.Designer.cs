namespace Shiled.Forms
{
    partial class ShowAllContracts
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
            dgvContracts = new DataGridView();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvContracts).BeginInit();
            SuspendLayout();
            // 
            // dgvContracts
            // 
            dgvContracts.AllowUserToAddRows = false;
            dgvContracts.AllowUserToDeleteRows = false;
            dgvContracts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContracts.Location = new Point(2, 52);
            dgvContracts.Name = "dgvContracts";
            dgvContracts.ReadOnly = true;
            dgvContracts.RowHeadersWidth = 51;
            dgvContracts.Size = new Size(1045, 251);
            dgvContracts.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(437, 331);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(165, 61);
            btnExit.TabIndex = 1;
            btnExit.Text = "Закрыть";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
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
            label2.Location = new Point(443, 9);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 3;
            label2.Text = "Просмотр договоров";
            // 
            // ShowAllContracts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 413);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(dgvContracts);
            Name = "ShowAllContracts";
            Text = "ShowAllContracts";
            ((System.ComponentModel.ISupportInitialize)dgvContracts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvContracts;
        private Button btnExit;
        private Label label1;
        private Label label2;
    }
}