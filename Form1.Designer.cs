namespace BD20202SqliteMK
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbStatusText = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbStatusText
            // 
            this.lbStatusText.AutoSize = true;
            this.lbStatusText.Location = new System.Drawing.Point(23, 510);
            this.lbStatusText.Name = "lbStatusText";
            this.lbStatusText.Size = new System.Drawing.Size(35, 13);
            this.lbStatusText.TabIndex = 1;
            this.lbStatusText.Text = "label1";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(160, 57);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Подключиться к бд";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // Table
            // 
            this.Table.AutoSize = true;
            this.Table.Location = new System.Drawing.Point(448, 12);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(67, 13);
            this.Table.TabIndex = 3;
            this.Table.Text = "Данных нет";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 548);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lbStatusText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbStatusText;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label Table;
    }
}

