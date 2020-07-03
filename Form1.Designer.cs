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
            this.smallRadio = new System.Windows.Forms.RadioButton();
            this.medRadio = new System.Windows.Forms.RadioButton();
            this.largeRadio = new System.Windows.Forms.RadioButton();
            this.xlRadio = new System.Windows.Forms.RadioButton();
            this.xxlRadio = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Initiate_Button
            // 
            this.Initiate_Button.Location = new System.Drawing.Point(190, 12);
            this.Initiate_Button.Name = "Initiate_Button";
            this.Initiate_Button.Size = new System.Drawing.Size(93, 46);
            this.Initiate_Button.TabIndex = 0;
            this.Initiate_Button.Text = "Initiate";
            this.Initiate_Button.UseVisualStyleBackColor = true;
            this.Initiate_Button.Click += new System.EventHandler(this.Initiate_Button_Click);
            // 
            // MousePositionXbox
            // 
            this.MousePositionXbox.Location = new System.Drawing.Point(12, 12);
            this.MousePositionXbox.Name = "MousePositionXbox";
            this.MousePositionXbox.Size = new System.Drawing.Size(172, 20);
            this.MousePositionXbox.TabIndex = 1;
            // 
            // MousePositionYbox
            // 
            this.MousePositionYbox.Location = new System.Drawing.Point(12, 38);
            this.MousePositionYbox.Name = "MousePositionYbox";
            this.MousePositionYbox.Size = new System.Drawing.Size(172, 20);
            this.MousePositionYbox.TabIndex = 2;
            // 
            // reporterBGWorker
            // 
            this.reporterBGWorker.WorkerSupportsCancellation = true;
            this.reporterBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.reporterBGWorker_DoWork);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(27, 20);
            this.textBox1.TabIndex = 3;
            // 
            // SequenceBGWorker
            // 
            this.SequenceBGWorker.WorkerSupportsCancellation = true;
            this.SequenceBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SequenceBGWorker_DoWork);
            // 
            // smallRadio
            // 
            this.smallRadio.AutoSize = true;
            this.smallRadio.Location = new System.Drawing.Point(87, 65);
            this.smallRadio.Name = "smallRadio";
            this.smallRadio.Size = new System.Drawing.Size(50, 17);
            this.smallRadio.TabIndex = 4;
            this.smallRadio.TabStop = true;
            this.smallRadio.Text = "Small";
            this.smallRadio.UseVisualStyleBackColor = true;
            // 
            // medRadio
            // 
            this.medRadio.AutoSize = true;
            this.medRadio.Location = new System.Drawing.Point(174, 65);
            this.medRadio.Name = "medRadio";
            this.medRadio.Size = new System.Drawing.Size(62, 17);
            this.medRadio.TabIndex = 5;
            this.medRadio.TabStop = true;
            this.medRadio.Text = "Medium";
            this.medRadio.UseVisualStyleBackColor = true;
            // 
            // largeRadio
            // 
            this.largeRadio.AutoSize = true;
            this.largeRadio.Location = new System.Drawing.Point(87, 88);
            this.largeRadio.Name = "largeRadio";
            this.largeRadio.Size = new System.Drawing.Size(52, 17);
            this.largeRadio.TabIndex = 6;
            this.largeRadio.TabStop = true;
            this.largeRadio.Text = "Large";
            this.largeRadio.UseVisualStyleBackColor = true;
            // 
            // xlRadio
            // 
            this.xlRadio.AutoSize = true;
            this.xlRadio.Location = new System.Drawing.Point(174, 88);
            this.xlRadio.Name = "xlRadio";
            this.xlRadio.Size = new System.Drawing.Size(38, 17);
            this.xlRadio.TabIndex = 7;
            this.xlRadio.TabStop = true;
            this.xlRadio.Text = "XL";
            this.xlRadio.UseVisualStyleBackColor = true;
            // 
            // xxlRadio
            // 
            this.xxlRadio.AutoSize = true;
            this.xxlRadio.Location = new System.Drawing.Point(87, 111);
            this.xxlRadio.Name = "xxlRadio";
            this.xxlRadio.Size = new System.Drawing.Size(45, 17);
            this.xxlRadio.TabIndex = 8;
            this.xxlRadio.TabStop = true;
            this.xxlRadio.Text = "XXL";
            this.xxlRadio.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(289, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 125);
            this.textBox2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 153);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.xxlRadio);
            this.Controls.Add(this.xlRadio);
            this.Controls.Add(this.largeRadio);
            this.Controls.Add(this.medRadio);
            this.Controls.Add(this.smallRadio);
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
        private System.Windows.Forms.RadioButton smallRadio;
        private System.Windows.Forms.RadioButton medRadio;
        private System.Windows.Forms.RadioButton largeRadio;
        private System.Windows.Forms.RadioButton xlRadio;
        private System.Windows.Forms.RadioButton xxlRadio;
        private System.Windows.Forms.TextBox textBox2;
    }
}

