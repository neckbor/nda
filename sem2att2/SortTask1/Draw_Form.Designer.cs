namespace SortTask1
{
    partial class Draw_Form
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton_Simple = new System.Windows.Forms.RadioButton();
            this.radioButton_Nature = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(2, 31);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(726, 521);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton_Simple
            // 
            this.radioButton_Simple.AutoSize = true;
            this.radioButton_Simple.Location = new System.Drawing.Point(13, 12);
            this.radioButton_Simple.Name = "radioButton_Simple";
            this.radioButton_Simple.Size = new System.Drawing.Size(105, 17);
            this.radioButton_Simple.TabIndex = 2;
            this.radioButton_Simple.Text = "SimpleMergeSort";
            this.radioButton_Simple.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nature
            // 
            this.radioButton_Nature.AutoSize = true;
            this.radioButton_Nature.Checked = true;
            this.radioButton_Nature.Location = new System.Drawing.Point(266, 12);
            this.radioButton_Nature.Name = "radioButton_Nature";
            this.radioButton_Nature.Size = new System.Drawing.Size(106, 17);
            this.radioButton_Nature.TabIndex = 3;
            this.radioButton_Nature.TabStop = true;
            this.radioButton_Nature.Text = "NatureMergeSort";
            this.radioButton_Nature.UseVisualStyleBackColor = true;
            // 
            // Draw_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 548);
            this.Controls.Add(this.radioButton_Nature);
            this.Controls.Add(this.radioButton_Simple);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Draw_Form";
            this.Text = "Visualization";
            this.Load += new System.EventHandler(this.Draw_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton_Simple;
        private System.Windows.Forms.RadioButton radioButton_Nature;
    }
}