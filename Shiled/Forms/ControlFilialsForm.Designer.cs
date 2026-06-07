namespace Shiled.Forms
{
    partial class ControlFilialsForm
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
            dgvFilials = new DataGridView();
            btnAddFilial = new Button();
            btnEditFilial = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFilials).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 14);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "СК \"Щит\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 14);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Филиалы";
            // 
            // dgvFilials
            // 
            dgvFilials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilials.Location = new Point(21, 60);
            dgvFilials.Name = "dgvFilials";
            dgvFilials.RowHeadersWidth = 51;
            dgvFilials.Size = new Size(607, 188);
            dgvFilials.TabIndex = 2;
            // 
            // btnAddFilial
            // 
            btnAddFilial.Location = new Point(21, 277);
            btnAddFilial.Name = "btnAddFilial";
            btnAddFilial.Size = new Size(94, 29);
            btnAddFilial.TabIndex = 3;
            btnAddFilial.Text = "Добавить";
            btnAddFilial.UseVisualStyleBackColor = true;
            // 
            // btnEditFilial
            // 
            btnEditFilial.Location = new Point(222, 277);
            btnEditFilial.Name = "btnEditFilial";
            btnEditFilial.Size = new Size(166, 29);
            btnEditFilial.TabIndex = 4;
            btnEditFilial.Text = "Редактировать";
            btnEditFilial.UseVisualStyleBackColor = true;
            btnEditFilial.Click += btnEditFilial_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(474, 277);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(154, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Закрыть";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // ControlFilialsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 334);
            Controls.Add(btnExit);
            Controls.Add(btnEditFilial);
            Controls.Add(btnAddFilial);
            Controls.Add(dgvFilials);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ControlFilialsForm";
            Text = "ControlFilialsForm";
            ((System.ComponentModel.ISupportInitialize)dgvFilials).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvFilials;
        private Button btnAddFilial;
        private Button btnEditFilial;
        private Button btnExit;
    }
}