namespace Shiled.Forms
{
    partial class VIewApplications
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
            dgvApplications = new DataGridView();
            btnAccept = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvApplications).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "СК \"Щит\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 9);
            label2.Name = "label2";
            label2.Size = new Size(199, 20);
            label2.TabIndex = 1;
            label2.Text = "Просмотр заявок клиентов";
            // 
            // dgvApplications
            // 
            dgvApplications.AllowUserToAddRows = false;
            dgvApplications.AllowUserToDeleteRows = false;
            dgvApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplications.Location = new Point(15, 43);
            dgvApplications.Name = "dgvApplications";
            dgvApplications.ReadOnly = true;
            dgvApplications.RowHeadersWidth = 51;
            dgvApplications.Size = new Size(894, 206);
            dgvApplications.TabIndex = 2;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(385, 285);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(147, 42);
            btnAccept.TabIndex = 3;
            btnAccept.Text = "Принять";
            btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(385, 378);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(147, 42);
            btnExit.TabIndex = 4;
            btnExit.Text = "Закрыть";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // VIewApplications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 450);
            Controls.Add(btnExit);
            Controls.Add(btnAccept);
            Controls.Add(dgvApplications);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VIewApplications";
            Text = "VIewApplications";
            ((System.ComponentModel.ISupportInitialize)dgvApplications).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvApplications;
        private Button btnAccept;
        private Button btnExit;
    }
}