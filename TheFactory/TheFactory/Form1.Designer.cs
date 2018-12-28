namespace TheFactory
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
            this.components = new System.ComponentModel.Container();
            this.addConveyor_btn = new System.Windows.Forms.Button();
            this.startFactory_btn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addConveyor_btn
            // 
            this.addConveyor_btn.Location = new System.Drawing.Point(13, 13);
            this.addConveyor_btn.Name = "addConveyor_btn";
            this.addConveyor_btn.Size = new System.Drawing.Size(117, 25);
            this.addConveyor_btn.TabIndex = 0;
            this.addConveyor_btn.Text = "Добавить станок";
            this.addConveyor_btn.UseVisualStyleBackColor = true;
            this.addConveyor_btn.Click += new System.EventHandler(this.addConveyor_btn_Click);
            // 
            // startFactory_btn
            // 
            this.startFactory_btn.Location = new System.Drawing.Point(136, 13);
            this.startFactory_btn.Name = "startFactory_btn";
            this.startFactory_btn.Size = new System.Drawing.Size(117, 25);
            this.startFactory_btn.TabIndex = 1;
            this.startFactory_btn.Text = "Запустить фабрику";
            this.startFactory_btn.UseVisualStyleBackColor = true;
            this.startFactory_btn.Click += new System.EventHandler(this.startFactory_btn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 44);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(881, 875);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 924);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.startFactory_btn);
            this.Controls.Add(this.addConveyor_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addConveyor_btn;
        private System.Windows.Forms.Button startFactory_btn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer timer;
    }
}

