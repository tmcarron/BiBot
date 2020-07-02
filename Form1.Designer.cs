namespace BiBot
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
            this.Initiate_Button = new System.Windows.Forms.Button();
            this.MousePositionXbox = new System.Windows.Forms.TextBox();
            this.MousePositionYbox = new System.Windows.Forms.TextBox();
            this.reporterBGWorker = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SequenceBGWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Initiate_Button
            // 
            this.Initiate_Button.Location = new System.Drawing.Point(190, 36);
            this.Initiate_Button.Name = "Initiate_Button";
            this.Initiate_Button.Size = new System.Drawing.Size(75, 23);
            this.Initiate_Button.TabIndex = 0;
            this.Initiate_Button.Text = "Initiate";
            this.Initiate_Button.UseVisualStyleBackColor = true;
            this.Initiate_Button.Click += new System.EventHandler(this.Initiate_Button_Click);
            // 
            // MousePositionXbox
            // 
            this.MousePositionXbox.Location = new System.Drawing.Point(12, 12);
            this.MousePositionXbox.Name = "MousePositionXbox";
            this.MousePositionXbox.Size = new System.Drawing.Size(161, 20);
            this.MousePositionXbox.TabIndex = 1;
            // 
            // MousePositionYbox
            // 
            this.MousePositionYbox.Location = new System.Drawing.Point(12, 38);
            this.MousePositionYbox.Name = "MousePositionYbox";
            this.MousePositionYbox.Size = new System.Drawing.Size(161, 20);
            this.MousePositionYbox.TabIndex = 2;
            // 
            // reporterBGWorker
            // 
            this.reporterBGWorker.WorkerSupportsCancellation = true;
            this.reporterBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.reporterBGWorker_DoWork);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 3;
            // 
            // SequenceBGWorker
            // 
            this.SequenceBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SequenceBGWorker_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 146);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MousePositionYbox);
            this.Controls.Add(this.MousePositionXbox);
            this.Controls.Add(this.Initiate_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Initiate_Button;
        private System.Windows.Forms.TextBox MousePositionXbox;
        private System.Windows.Forms.TextBox MousePositionYbox;
        private System.ComponentModel.BackgroundWorker reporterBGWorker;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker SequenceBGWorker;
    }
}

