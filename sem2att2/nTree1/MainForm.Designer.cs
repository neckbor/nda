namespace nTree1
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buildTreeBtn = new System.Windows.Forms.Button();
            this.deepInTb = new System.Windows.Forms.TextBox();
            this.labelDeep = new System.Windows.Forms.Label();
            this.getWayBtn = new System.Windows.Forms.Button();
            this.radioButtonFile = new System.Windows.Forms.RadioButton();
            this.radioButtonMsg = new System.Windows.Forms.RadioButton();
            this.radioBtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(39, 87);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(669, 399);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // buildTreeBtn
            // 
            this.buildTreeBtn.Location = new System.Drawing.Point(133, 34);
            this.buildTreeBtn.Name = "buildTreeBtn";
            this.buildTreeBtn.Size = new System.Drawing.Size(144, 30);
            this.buildTreeBtn.TabIndex = 2;
            this.buildTreeBtn.Text = "Построить дерево";
            this.buildTreeBtn.UseVisualStyleBackColor = true;
            this.buildTreeBtn.Click += new System.EventHandler(this.buildTreeBtn_Click);
            // 
            // deepInTb
            // 
            this.deepInTb.Location = new System.Drawing.Point(12, 38);
            this.deepInTb.Name = "deepInTb";
            this.deepInTb.Size = new System.Drawing.Size(100, 22);
            this.deepInTb.TabIndex = 0;
            // 
            // labelDeep
            // 
            this.labelDeep.AutoSize = true;
            this.labelDeep.Location = new System.Drawing.Point(13, 7);
            this.labelDeep.Name = "labelDeep";
            this.labelDeep.Size = new System.Drawing.Size(114, 17);
            this.labelDeep.TabIndex = 3;
            this.labelDeep.Text = "Глубина дерева";
            // 
            // getWayBtn
            // 
            this.getWayBtn.Location = new System.Drawing.Point(490, 7);
            this.getWayBtn.Name = "getWayBtn";
            this.getWayBtn.Size = new System.Drawing.Size(151, 32);
            this.getWayBtn.TabIndex = 4;
            this.getWayBtn.Text = "Найти нулевой путь";
            this.getWayBtn.UseVisualStyleBackColor = true;
            this.getWayBtn.Click += new System.EventHandler(this.getWayBtn_Click);
            // 
            // radioButtonFile
            // 
            this.radioButtonFile.AutoSize = true;
            this.radioButtonFile.Location = new System.Drawing.Point(490, 39);
            this.radioButtonFile.Name = "radioButtonFile";
            this.radioButtonFile.Size = new System.Drawing.Size(51, 21);
            this.radioButtonFile.TabIndex = 5;
            this.radioButtonFile.TabStop = true;
            this.radioButtonFile.Text = "File";
            this.radioButtonFile.UseVisualStyleBackColor = true;
            // 
            // radioButtonMsg
            // 
            this.radioButtonMsg.AutoSize = true;
            this.radioButtonMsg.Location = new System.Drawing.Point(569, 39);
            this.radioButtonMsg.Name = "radioButtonMsg";
            this.radioButtonMsg.Size = new System.Drawing.Size(109, 21);
            this.radioButtonMsg.TabIndex = 6;
            this.radioButtonMsg.TabStop = true;
            this.radioButtonMsg.Text = "MessageBox";
            this.radioButtonMsg.UseVisualStyleBackColor = true;
            // 
            // radioBtn
            // 
            this.radioBtn.AutoSize = true;
            this.radioBtn.Location = new System.Drawing.Point(39, 67);
            this.radioBtn.Name = "radioBtn";
            this.radioBtn.Size = new System.Drawing.Size(98, 21);
            this.radioBtn.TabIndex = 7;
            this.radioBtn.TabStop = true;
            this.radioBtn.Text = "Задание 2";
            this.radioBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 498);
            this.Controls.Add(this.radioBtn);
            this.Controls.Add(this.radioButtonMsg);
            this.Controls.Add(this.radioButtonFile);
            this.Controls.Add(this.getWayBtn);
            this.Controls.Add(this.labelDeep);
            this.Controls.Add(this.deepInTb);
            this.Controls.Add(this.buildTreeBtn);
            this.Controls.Add(this.pictureBox);
            this.Name = "MainForm";
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buildTreeBtn;
        private System.Windows.Forms.TextBox deepInTb;
        private System.Windows.Forms.Label labelDeep;
        private System.Windows.Forms.Button getWayBtn;
        private System.Windows.Forms.RadioButton radioButtonFile;
        private System.Windows.Forms.RadioButton radioButtonMsg;
        private System.Windows.Forms.RadioButton radioBtn;
    }
}

