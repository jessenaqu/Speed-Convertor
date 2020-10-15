namespace Speed_Convertor
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
            this.btnDisplaySpeed = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listBoxMiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDisplaySpeed
            // 
            this.btnDisplaySpeed.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDisplaySpeed.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplaySpeed.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnDisplaySpeed.Location = new System.Drawing.Point(212, 352);
            this.btnDisplaySpeed.Name = "btnDisplaySpeed";
            this.btnDisplaySpeed.Size = new System.Drawing.Size(203, 36);
            this.btnDisplaySpeed.TabIndex = 0;
            this.btnDisplaySpeed.Text = "Display Speed";
            this.btnDisplaySpeed.UseVisualStyleBackColor = false;
            this.btnDisplaySpeed.Click += new System.EventHandler(this.btnDisplaySpeed_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnExit.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnExit.Location = new System.Drawing.Point(421, 352);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listBoxMiles
            // 
            this.listBoxMiles.FormattingEnabled = true;
            this.listBoxMiles.ItemHeight = 16;
            this.listBoxMiles.Location = new System.Drawing.Point(183, 70);
            this.listBoxMiles.Name = "listBoxMiles";
            this.listBoxMiles.Size = new System.Drawing.Size(403, 276);
            this.listBoxMiles.TabIndex = 2;
            this.listBoxMiles.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxMiles);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplaySpeed);
            this.Name = "Form1";
            this.Text = "Speed Convertor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplaySpeed;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBoxMiles;
    }
}

