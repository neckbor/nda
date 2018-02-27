namespace _10._13
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputX1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputX2 = new System.Windows.Forms.TextBox();
            this.inputX3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.runBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.outY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nY1out = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Множоство Х1";
            // 
            // inputX1
            // 
            this.inputX1.Location = new System.Drawing.Point(13, 34);
            this.inputX1.Name = "inputX1";
            this.inputX1.Size = new System.Drawing.Size(539, 22);
            this.inputX1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Множество Х2";
            // 
            // inputX2
            // 
            this.inputX2.Location = new System.Drawing.Point(13, 84);
            this.inputX2.Name = "inputX2";
            this.inputX2.Size = new System.Drawing.Size(539, 22);
            this.inputX2.TabIndex = 3;
            // 
            // inputX3
            // 
            this.inputX3.Location = new System.Drawing.Point(13, 137);
            this.inputX3.Name = "inputX3";
            this.inputX3.Size = new System.Drawing.Size(539, 22);
            this.inputX3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Множоство Х3";
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(173, 165);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(210, 42);
            this.runBtn.TabIndex = 6;
            this.runBtn.Text = "Рассчитать множество У";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Множество У";
            // 
            // outY
            // 
            this.outY.Location = new System.Drawing.Point(13, 235);
            this.outY.Name = "outY";
            this.outY.Size = new System.Drawing.Size(539, 22);
            this.outY.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Мощность множества У1:";
            // 
            // nY1out
            // 
            this.nY1out.AutoSize = true;
            this.nY1out.Location = new System.Drawing.Point(192, 275);
            this.nY1out.Name = "nY1out";
            this.nY1out.Size = new System.Drawing.Size(46, 17);
            this.nY1out.TabIndex = 10;
            this.nY1out.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 313);
            this.Controls.Add(this.nY1out);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.outY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.inputX3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputX2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputX1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputX1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputX2;
        private System.Windows.Forms.TextBox inputX3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nY1out;
    }
}

