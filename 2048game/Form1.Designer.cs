namespace _2048game
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scorelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hscorelabel = new System.Windows.Forms.Label();
            this.retrylabel = new System.Windows.Forms.Label();
            this.gameoverlabel = new System.Windows.Forms.Label();
            this.logolabel = new System.Windows.Forms.Label();
            this.backlogo = new System.Windows.Forms.PictureBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.loadbutton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(285, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "current score";
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.scorelabel.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelabel.ForeColor = System.Drawing.Color.White;
            this.scorelabel.Location = new System.Drawing.Point(66, 294);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(28, 31);
            this.scorelabel.TabIndex = 1;
            this.scorelabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "highest score";
            // 
            // hscorelabel
            // 
            this.hscorelabel.AutoSize = true;
            this.hscorelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.hscorelabel.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hscorelabel.ForeColor = System.Drawing.Color.White;
            this.hscorelabel.Location = new System.Drawing.Point(66, 219);
            this.hscorelabel.Name = "hscorelabel";
            this.hscorelabel.Size = new System.Drawing.Size(28, 31);
            this.hscorelabel.TabIndex = 1;
            this.hscorelabel.Text = "0";
            // 
            // retrylabel
            // 
            this.retrylabel.AutoSize = true;
            this.retrylabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.retrylabel.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrylabel.ForeColor = System.Drawing.Color.White;
            this.retrylabel.Location = new System.Drawing.Point(549, 338);
            this.retrylabel.Name = "retrylabel";
            this.retrylabel.Size = new System.Drawing.Size(85, 35);
            this.retrylabel.TabIndex = 2;
            this.retrylabel.Text = "Retry";
            this.retrylabel.Visible = false;
            this.retrylabel.Click += new System.EventHandler(this.retrylabel_Click);
            // 
            // gameoverlabel
            // 
            this.gameoverlabel.AutoSize = true;
            this.gameoverlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gameoverlabel.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameoverlabel.ForeColor = System.Drawing.Color.White;
            this.gameoverlabel.Location = new System.Drawing.Point(466, 263);
            this.gameoverlabel.Name = "gameoverlabel";
            this.gameoverlabel.Size = new System.Drawing.Size(253, 49);
            this.gameoverlabel.TabIndex = 3;
            this.gameoverlabel.Text = "GAME OVER!";
            this.gameoverlabel.Visible = false;
            // 
            // logolabel
            // 
            this.logolabel.AutoSize = true;
            this.logolabel.BackColor = System.Drawing.Color.Gold;
            this.logolabel.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logolabel.ForeColor = System.Drawing.Color.White;
            this.logolabel.Location = new System.Drawing.Point(100, 53);
            this.logolabel.Name = "logolabel";
            this.logolabel.Size = new System.Drawing.Size(114, 51);
            this.logolabel.TabIndex = 4;
            this.logolabel.Text = "2048";
            // 
            // backlogo
            // 
            this.backlogo.BackColor = System.Drawing.Color.Gold;
            this.backlogo.Location = new System.Drawing.Point(61, 29);
            this.backlogo.Name = "backlogo";
            this.backlogo.Size = new System.Drawing.Size(188, 95);
            this.backlogo.TabIndex = 5;
            this.backlogo.TabStop = false;
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.SandyBrown;
            this.savebutton.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.ForeColor = System.Drawing.Color.White;
            this.savebutton.Location = new System.Drawing.Point(61, 135);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(91, 36);
            this.savebutton.TabIndex = 6;
            this.savebutton.Text = "save";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // loadbutton
            // 
            this.loadbutton.BackColor = System.Drawing.Color.SandyBrown;
            this.loadbutton.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadbutton.ForeColor = System.Drawing.Color.White;
            this.loadbutton.Location = new System.Drawing.Point(158, 135);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.Size = new System.Drawing.Size(91, 36);
            this.loadbutton.TabIndex = 6;
            this.loadbutton.Text = "load";
            this.loadbutton.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(906, 645);
            this.Controls.Add(this.loadbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.logolabel);
            this.Controls.Add(this.gameoverlabel);
            this.Controls.Add(this.retrylabel);
            this.Controls.Add(this.hscorelabel);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backlogo);
            this.Name = "Form1";
            this.Text = "2048";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hscorelabel;
        private System.Windows.Forms.Label retrylabel;
        private System.Windows.Forms.Label gameoverlabel;
        private System.Windows.Forms.Label logolabel;
        private System.Windows.Forms.PictureBox backlogo;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button loadbutton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

