namespace RobotClean
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.quadrantA = new System.Windows.Forms.Label();
            this.quadrantB = new System.Windows.Forms.Label();
            this.quadrantC = new System.Windows.Forms.Label();
            this.quadrantD = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(120, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 1000);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // quadrantA
            // 
            this.quadrantA.AutoSize = true;
            this.quadrantA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quadrantA.Location = new System.Drawing.Point(120, 50);
            this.quadrantA.Name = "quadrantA";
            this.quadrantA.Size = new System.Drawing.Size(24, 24);
            this.quadrantA.TabIndex = 3;
            this.quadrantA.Text = "A";
            // 
            // quadrantB
            // 
            this.quadrantB.AutoSize = true;
            this.quadrantB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quadrantB.Location = new System.Drawing.Point(396, 62);
            this.quadrantB.Name = "quadrantB";
            this.quadrantB.Size = new System.Drawing.Size(66, 24);
            this.quadrantB.TabIndex = 4;
            this.quadrantB.Text = "label3";
            // 
            // quadrantC
            // 
            this.quadrantC.AutoSize = true;
            this.quadrantC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quadrantC.Location = new System.Drawing.Point(263, 62);
            this.quadrantC.Name = "quadrantC";
            this.quadrantC.Size = new System.Drawing.Size(66, 24);
            this.quadrantC.TabIndex = 5;
            this.quadrantC.Text = "label3";
            // 
            // quadrantD
            // 
            this.quadrantD.AutoSize = true;
            this.quadrantD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quadrantD.Location = new System.Drawing.Point(161, 93);
            this.quadrantD.Name = "quadrantD";
            this.quadrantD.Size = new System.Drawing.Size(66, 24);
            this.quadrantD.TabIndex = 6;
            this.quadrantD.Text = "label3";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(658, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quadrantD);
            this.Controls.Add(this.quadrantC);
            this.Controls.Add(this.quadrantB);
            this.Controls.Add(this.quadrantA);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label quadrantA;
        private System.Windows.Forms.Label quadrantB;
        private System.Windows.Forms.Label quadrantC;
        private System.Windows.Forms.Label quadrantD;
        private System.Windows.Forms.Button button1;
    }
}

