namespace _8._13
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
            this.runBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sumMainlbl = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.resultDownlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxGrid
            // 
            this.mtxGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mtxGrid.Location = new System.Drawing.Point(12, 12);
            this.mtxGrid.Name = "mtxGrid";
            this.mtxGrid.RowTemplate.Height = 24;
            this.mtxGrid.Size = new System.Drawing.Size(330, 263);
            this.mtxGrid.TabIndex = 0;
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(348, 67);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(152, 58);
            this.runBtn.TabIndex = 1;
            this.runBtn.Text = "Обработать массив";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сумма главной диагонали:";
            // 
            // sumMainlbl
            // 
            this.sumMainlbl.AutoSize = true;
            this.sumMainlbl.Location = new System.Drawing.Point(192, 297);
            this.sumMainlbl.Name = "sumMainlbl";
            this.sumMainlbl.Size = new System.Drawing.Size(0, 17);
            this.sumMainlbl.TabIndex = 3;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(284, 297);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(195, 17);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Сумма побочной диагонали:";
            // 
            // resultDownlbl
            // 
            this.resultDownlbl.AutoSize = true;
            this.resultDownlbl.Location = new System.Drawing.Point(479, 297);
            this.resultDownlbl.Name = "resultDownlbl";
            this.resultDownlbl.Size = new System.Drawing.Size(0, 17);
            this.resultDownlbl.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 323);
            this.Controls.Add(this.resultDownlbl);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.sumMainlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.mtxGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mtxGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mtxGrid;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sumMainlbl;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label resultDownlbl;
    }
}

