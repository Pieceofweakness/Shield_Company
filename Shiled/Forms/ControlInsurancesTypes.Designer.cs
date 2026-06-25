namespace Shiled.Forms
{
    partial class ControlInsurancesTypes
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
            btnAddInsuranceType = new Button();
            btnRedactInsuranceeType = new Button();
            btnExit = new Button();
            dgvInsurancesTypes = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInsurancesTypes).BeginInit();
            SuspendLayout();
            // 
            // btnAddInsuranceType
            // 
            btnAddInsuranceType.Location = new Point(63, 261);
            btnAddInsuranceType.Name = "btnAddInsuranceType";
            btnAddInsuranceType.Size = new Size(174, 53);
            btnAddInsuranceType.TabIndex = 0;
            btnAddInsuranceType.Text = "Добавить";
            btnAddInsuranceType.UseVisualStyleBackColor = true;
            // 
            // btnRedactInsuranceeType
            // 
            btnRedactInsuranceeType.Location = new Point(315, 261);
            btnRedactInsuranceeType.Name = "btnRedactInsuranceeType";
            btnRedactInsuranceeType.Size = new Size(180, 53);
            btnRedactInsuranceeType.TabIndex = 1;
            btnRedactInsuranceeType.Text = "Редактировать";
            btnRedactInsuranceeType.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(541, 261);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(182, 53);
            btnExit.TabIndex = 2;
            btnExit.Text = "Закрыть";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvInsurancesTypes
            // 
            dgvInsurancesTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInsurancesTypes.Location = new Point(1, 56);
            dgvInsurancesTypes.Name = "dgvInsurancesTypes";
            dgvInsurancesTypes.RowHeadersWidth = 51;
            dgvInsurancesTypes.Size = new Size(803, 188);
            dgvInsurancesTypes.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 4;
            label1.Text = "СК \"Щит\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 15);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 5;
            label2.Text = "Виды страхования";
            // 
            // ControlInsurancesTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 337);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvInsurancesTypes);
            Controls.Add(btnExit);
            Controls.Add(btnRedactInsuranceeType);
            Controls.Add(btnAddInsuranceType);
            Name = "ControlInsurancesTypes";
            Text = "ControlInsurancesTypes";
            ((System.ComponentModel.ISupportInitialize)dgvInsurancesTypes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddInsuranceType;
        private Button btnRedactInsuranceeType;
        private Button btnExit;
        private DataGridView dgvInsurancesTypes;
        private Label label1;
        private Label label2;
    }
}