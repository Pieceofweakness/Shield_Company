namespace Shiled.Forms
{
    partial class AddNewApplication
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnAddApp = new Button();
            btnCancel = new Button();
            txtFIO = new TextBox();
            txtPhone = new TextBox();
            txtSumma = new TextBox();
            txtDiscription = new TextBox();
            cmbType = new ComboBox();
            cmbFilial = new ComboBox();
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
            label2.Location = new Point(102, 9);
            label2.Name = "label2";
            label2.Size = new Size(245, 20);
            label2.TabIndex = 1;
            label2.Text = "Подача заявки на новый договор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "ФИО";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 124);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Телефон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 179);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 4;
            label5.Text = "Вид страхования";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 223);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 5;
            label6.Text = "Страховая сумма";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 282);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 6;
            label7.Text = "Филиал";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 331);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 7;
            label8.Text = "Описание";
            // 
            // btnAddApp
            // 
            btnAddApp.Location = new Point(36, 409);
            btnAddApp.Name = "btnAddApp";
            btnAddApp.Size = new Size(125, 29);
            btnAddApp.TabIndex = 8;
            btnAddApp.Text = "Подать заявку";
            btnAddApp.UseVisualStyleBackColor = true;
            btnAddApp.Click += btnAddApp_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(236, 409);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtFIO
            // 
            txtFIO.Location = new Point(60, 84);
            txtFIO.Name = "txtFIO";
            txtFIO.Size = new Size(311, 27);
            txtFIO.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(87, 121);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(284, 27);
            txtPhone.TabIndex = 11;
            // 
            // txtSumma
            // 
            txtSumma.Location = new Point(147, 223);
            txtSumma.Name = "txtSumma";
            txtSumma.Size = new Size(224, 27);
            txtSumma.TabIndex = 12;
            // 
            // txtDiscription
            // 
            txtDiscription.Location = new Point(113, 331);
            txtDiscription.Name = "txtDiscription";
            txtDiscription.Size = new Size(258, 27);
            txtDiscription.TabIndex = 13;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(145, 176);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(226, 28);
            cmbType.TabIndex = 14;
            // 
            // cmbFilial
            // 
            cmbFilial.FormattingEnabled = true;
            cmbFilial.Location = new Point(80, 282);
            cmbFilial.Name = "cmbFilial";
            cmbFilial.Size = new Size(291, 28);
            cmbFilial.TabIndex = 15;
            // 
            // AddNewApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 464);
            Controls.Add(cmbFilial);
            Controls.Add(cmbType);
            Controls.Add(txtDiscription);
            Controls.Add(txtSumma);
            Controls.Add(txtPhone);
            Controls.Add(txtFIO);
            Controls.Add(btnCancel);
            Controls.Add(btnAddApp);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddNewApplication";
            Text = "AddNewApplication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnAddApp;
        private Button btnCancel;
        private TextBox txtFIO;
        private TextBox txtPhone;
        private TextBox txtSumma;
        private TextBox txtDiscription;
        private ComboBox cmbType;
        private ComboBox cmbFilial;
    }
}