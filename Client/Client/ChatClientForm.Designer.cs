namespace Client
{
    partial class ClientForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.generalChatTextBox = new System.Windows.Forms.TextBox();
            this.myMessegeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sendBtm = new System.Windows.Forms.Button();
            this.connectBtm = new System.Windows.Forms.Button();
            this.disconnectBtm = new System.Windows.Forms.Button();
            this.portNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ipComboBox = new System.Windows.Forms.ComboBox();
            this.portLocalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portLocalNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "PortS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // generalChatTextBox
            // 
            this.generalChatTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.generalChatTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generalChatTextBox.Location = new System.Drawing.Point(14, 261);
            this.generalChatTextBox.Multiline = true;
            this.generalChatTextBox.Name = "generalChatTextBox";
            this.generalChatTextBox.ReadOnly = true;
            this.generalChatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.generalChatTextBox.Size = new System.Drawing.Size(699, 317);
            this.generalChatTextBox.TabIndex = 3;
            // 
            // myMessegeTextBox
            // 
            this.myMessegeTextBox.Location = new System.Drawing.Point(14, 592);
            this.myMessegeTextBox.Multiline = true;
            this.myMessegeTextBox.Name = "myMessegeTextBox";
            this.myMessegeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.myMessegeTextBox.Size = new System.Drawing.Size(699, 67);
            this.myMessegeTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 686);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(709, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "_____________________________________________________";
            // 
            // sendBtm
            // 
            this.sendBtm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sendBtm.Enabled = false;
            this.sendBtm.FlatAppearance.BorderSize = 3;
            this.sendBtm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sendBtm.Location = new System.Drawing.Point(14, 665);
            this.sendBtm.Name = "sendBtm";
            this.sendBtm.Size = new System.Drawing.Size(150, 46);
            this.sendBtm.TabIndex = 6;
            this.sendBtm.Text = "Send";
            this.sendBtm.UseVisualStyleBackColor = false;
            this.sendBtm.Visible = false;
            this.sendBtm.Click += new System.EventHandler(this.sendBtm_Click);
            // 
            // connectBtm
            // 
            this.connectBtm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.connectBtm.FlatAppearance.BorderSize = 3;
            this.connectBtm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectBtm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.connectBtm.Location = new System.Drawing.Point(14, 746);
            this.connectBtm.Name = "connectBtm";
            this.connectBtm.Size = new System.Drawing.Size(244, 46);
            this.connectBtm.TabIndex = 7;
            this.connectBtm.Text = "Connect";
            this.connectBtm.UseVisualStyleBackColor = false;
            this.connectBtm.Click += new System.EventHandler(this.connectBtm_Click);
            // 
            // disconnectBtm
            // 
            this.disconnectBtm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.disconnectBtm.Enabled = false;
            this.disconnectBtm.FlatAppearance.BorderSize = 3;
            this.disconnectBtm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnectBtm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.disconnectBtm.Location = new System.Drawing.Point(469, 746);
            this.disconnectBtm.Name = "disconnectBtm";
            this.disconnectBtm.Size = new System.Drawing.Size(244, 46);
            this.disconnectBtm.TabIndex = 8;
            this.disconnectBtm.Text = "Disconnect";
            this.disconnectBtm.UseVisualStyleBackColor = false;
            this.disconnectBtm.Visible = false;
            this.disconnectBtm.Click += new System.EventHandler(this.disconnectBtm_Click);
            // 
            // portNumericUpDown
            // 
            this.portNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.portNumericUpDown.Location = new System.Drawing.Point(126, 40);
            this.portNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.portNumericUpDown.Name = "portNumericUpDown";
            this.portNumericUpDown.Size = new System.Drawing.Size(240, 50);
            this.portNumericUpDown.TabIndex = 9;
            this.portNumericUpDown.Value = new decimal(new int[] {
            8080,
            0,
            0,
            0});
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(126, 181);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(587, 50);
            this.nameTextBox.TabIndex = 11;
            // 
            // ipComboBox
            // 
            this.ipComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ipComboBox.FormattingEnabled = true;
            this.ipComboBox.Items.AddRange(new object[] {
            "127.0.0.1"});
            this.ipComboBox.Location = new System.Drawing.Point(126, 110);
            this.ipComboBox.Name = "ipComboBox";
            this.ipComboBox.Size = new System.Drawing.Size(587, 53);
            this.ipComboBox.TabIndex = 12;
            // 
            // portLocalNumericUpDown
            // 
            this.portLocalNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.portLocalNumericUpDown.Location = new System.Drawing.Point(478, 40);
            this.portLocalNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.portLocalNumericUpDown.Name = "portLocalNumericUpDown";
            this.portLocalNumericUpDown.Size = new System.Drawing.Size(240, 50);
            this.portLocalNumericUpDown.TabIndex = 14;
            this.portLocalNumericUpDown.Value = new decimal(new int[] {
            1234,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(359, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 45);
            this.label5.TabIndex = 13;
            this.label5.Text = "PortM:";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(725, 804);
            this.Controls.Add(this.portLocalNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ipComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.portNumericUpDown);
            this.Controls.Add(this.disconnectBtm);
            this.Controls.Add(this.connectBtm);
            this.Controls.Add(this.sendBtm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.myMessegeTextBox);
            this.Controls.Add(this.generalChatTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientForm";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portLocalNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox myMessegeTextBox;
        private Label label4;
        private Button sendBtm;
        private Button connectBtm;
        private Button disconnectBtm;
        private NumericUpDown portNumericUpDown;
        private TextBox nameTextBox;
        private ComboBox ipComboBox;
        private NumericUpDown portLocalNumericUpDown;
        private Label label5;
        public TextBox generalChatTextBox;
    }
}