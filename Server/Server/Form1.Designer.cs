namespace Server
{
    partial class ServerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.portNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.chatTexBox = new System.Windows.Forms.TextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Port:";
            // 
            // portNumericUpDown
            // 
            this.portNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.portNumericUpDown.Location = new System.Drawing.Point(257, 10);
            this.portNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.portNumericUpDown.Name = "portNumericUpDown";
            this.portNumericUpDown.Size = new System.Drawing.Size(276, 50);
            this.portNumericUpDown.TabIndex = 1;
            this.portNumericUpDown.Value = new decimal(new int[] {
            8080,
            0,
            0,
            0});
            // 
            // chatTexBox
            // 
            this.chatTexBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chatTexBox.Location = new System.Drawing.Point(23, 87);
            this.chatTexBox.Multiline = true;
            this.chatTexBox.Name = "chatTexBox";
            this.chatTexBox.ReadOnly = true;
            this.chatTexBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chatTexBox.Size = new System.Drawing.Size(618, 519);
            this.chatTexBox.TabIndex = 2;
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.stopButton.Enabled = false;
            this.stopButton.FlatAppearance.BorderSize = 4;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stopButton.Location = new System.Drawing.Point(23, 643);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(243, 62);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.startButton.FlatAppearance.BorderSize = 4;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(388, 643);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(253, 62);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(653, 717);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.chatTexBox);
            this.Controls.Add(this.portNumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "ServerForm";
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown portNumericUpDown;
        private Button stopButton;
        private Button startButton;
        public TextBox chatTexBox;
    }
}