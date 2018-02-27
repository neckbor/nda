namespace _9._13
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
            this.mtxGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxZZ = new System.Windows.Forms.CheckBox();
            this.checkBoxSnake = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxGrid
            // 
            this.mtxGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mtxGrid.Location = new System.Drawing.Point(13, 13);
            this.mtxGrid.Name = "mtxGrid";
            this.mtxGrid.RowTemplate.Height = 24;
            this.mtxGrid.Size = new System.Drawing.Size(339, 263);
            this.mtxGrid.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 143);
            this.button1.TabIndex = 1;
            this.button1.Text = "Проверить последовательности";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxZZ
            // 
            this.checkBoxZZ.AutoSize = true;
            this.checkBoxZZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxZZ.Location = new System.Drawing.Point(13, 297);
            this.checkBoxZZ.Name = "checkBoxZZ";
            this.checkBoxZZ.Size = new System.Drawing.Size(112, 29);
            this.checkBoxZZ.TabIndex = 3;
            this.checkBoxZZ.Text = "Спираль";
            this.checkBoxZZ.UseVisualStyleBackColor = true;
            // 
            // checkBoxSnake
            // 
            this.checkBoxSnake.AutoSize = true;
            this.checkBoxSnake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSnake.Location = new System.Drawing.Point(246, 297);
            this.checkBoxSnake.Name = "checkBoxSnake";
            this.checkBoxSnake.Size = new System.Drawing.Size(106, 29);
            this.checkBoxSnake.TabIndex = 4;
            this.checkBoxSnake.Text = "Змейка";
            this.checkBoxSnake.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 338);
            this.Controls.Add(this.checkBoxSnake);
            this.Controls.Add(this.checkBoxZZ);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mtxGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mtxGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mtxGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxZZ;
        private System.Windows.Forms.CheckBox checkBoxSnake;
    }
}

