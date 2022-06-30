namespace QR_Code
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(187, 394);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(73, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = " Scan";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 77);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(61, 16);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Camera";
            // 
            // cboDevice
            // 
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(79, 76);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(278, 21);
            this.cboDevice.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(79, 119);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(278, 269);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(363, 119);
            this.txtQRCode.Multiline = true;
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.Size = new System.Drawing.Size(161, 269);
            this.txtQRCode.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 499);
            this.Controls.Add(this.txtQRCode);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtQRCode;
        private System.Windows.Forms.Timer timer1;
    }
}

