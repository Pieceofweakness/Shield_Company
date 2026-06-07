namespace Shiled.Forms
{
    partial class EditFilialForm
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
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(103, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(232, 27);
            txtName.TabIndex = 0;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(103, 128);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(232, 27);
            txtAddress.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(103, 172);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(232, 27);
            txtPhone.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(32, 225);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(219, 225);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 84);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 5;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 6;
            label2.Text = "Адрес";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 175);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 7;
            label3.Text = "Телефон";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 11);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 8;
            label4.Text = "СК \"Щит\"";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 11);
            label5.Name = "label5";
            label5.Size = new Size(187, 20);
            label5.TabIndex = 9;
            label5.Text = "Редактирование филиала";
            // 
            // EditFilialForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 282);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Name = "EditFilialForm";
            Text = "EditFilialForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}