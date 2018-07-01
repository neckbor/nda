namespace SortTask2
{
    partial class MainForm
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
            this.xInputTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.aInputTb = new System.Windows.Forms.TextBox();
            this.gridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // xInputTb
            // 
            this.xInputTb.Location = new System.Drawing.Point(12, 12);
            this.xInputTb.Name = "xInputTb";
            this.xInputTb.Size = new System.Drawing.Size(148, 22);
            this.xInputTb.TabIndex = 0;
            this.xInputTb.Text = "x[]";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Рассчитать и отсортировать результаты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aInputTb
            // 
            this.aInputTb.Location = new System.Drawing.Point(12, 52);
            this.aInputTb.Name = "aInputTb";
            this.aInputTb.Size = new System.Drawing.Size(148, 22);
            this.aInputTb.TabIndex = 1;
            this.aInputTb.Text = "a";
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(193, 12);
            this.gridView.Name = "gridView";
            this.gridView.RowTemplate.Height = 24;
            this.gridView.Size = new System.Drawing.Size(412, 156);
            this.gridView.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 193);
            this.Controls.Add(this.aInputTb);
            this.Controls.Add(this.xInputTb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridView);
            this.Name = "MainForm";
            this.Text = "Главный экран";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xInputTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox aInputTb;
        private System.Windows.Forms.DataGridView gridView;
    }
}

