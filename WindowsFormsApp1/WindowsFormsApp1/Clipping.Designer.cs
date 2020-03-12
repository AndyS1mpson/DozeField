namespace WindowsFormsApp1
{
    partial class Clipping
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.FieldCoordinates = new System.Windows.Forms.Button();
            this.verticeX = new System.Windows.Forms.TextBox();
            this.verticeY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endX = new System.Windows.Forms.TextBox();
            this.endY = new System.Windows.Forms.TextBox();
            this.EnterLineCoordinates = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Clip = new System.Windows.Forms.Button();
            this.startY = new System.Windows.Forms.TextBox();
            this.startX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(-5, 1);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(466, 450);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // FieldCoordinates
            // 
            this.FieldCoordinates.Location = new System.Drawing.Point(556, 95);
            this.FieldCoordinates.Name = "FieldCoordinates";
            this.FieldCoordinates.Size = new System.Drawing.Size(232, 47);
            this.FieldCoordinates.TabIndex = 1;
            this.FieldCoordinates.Text = "Enter the field vertice coordinates and show";
            this.FieldCoordinates.UseVisualStyleBackColor = true;
            this.FieldCoordinates.Click += new System.EventHandler(this.ShowPolygon_Click);
            // 
            // verticeX
            // 
            this.verticeX.Location = new System.Drawing.Point(556, 22);
            this.verticeX.Name = "verticeX";
            this.verticeX.Size = new System.Drawing.Size(232, 22);
            this.verticeX.TabIndex = 2;
            // 
            // verticeY
            // 
            this.verticeY.Location = new System.Drawing.Point(556, 56);
            this.verticeY.Name = "verticeY";
            this.verticeY.Size = new System.Drawing.Size(232, 22);
            this.verticeY.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y:";
            // 
            // endX
            // 
            this.endX.Location = new System.Drawing.Point(558, 253);
            this.endX.Name = "endX";
            this.endX.Size = new System.Drawing.Size(232, 22);
            this.endX.TabIndex = 6;
            // 
            // endY
            // 
            this.endY.Location = new System.Drawing.Point(558, 281);
            this.endY.Name = "endY";
            this.endY.Size = new System.Drawing.Size(232, 22);
            this.endY.TabIndex = 7;
            this.endY.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // EnterLineCoordinates
            // 
            this.EnterLineCoordinates.Location = new System.Drawing.Point(558, 319);
            this.EnterLineCoordinates.Name = "EnterLineCoordinates";
            this.EnterLineCoordinates.Size = new System.Drawing.Size(232, 54);
            this.EnterLineCoordinates.TabIndex = 8;
            this.EnterLineCoordinates.Text = "Enter the coordinates of the ends \r\nof the segment and show";
            this.EnterLineCoordinates.UseVisualStyleBackColor = true;
            this.EnterLineCoordinates.Click += new System.EventHandler(this.ShowLine_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "end X:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "end Y:";
            // 
            // Clip
            // 
            this.Clip.Location = new System.Drawing.Point(625, 415);
            this.Clip.Name = "Clip";
            this.Clip.Size = new System.Drawing.Size(104, 23);
            this.Clip.TabIndex = 12;
            this.Clip.Text = "Clip";
            this.Clip.UseVisualStyleBackColor = true;
            this.Clip.Click += new System.EventHandler(this.Clip_Click);
            // 
            // startY
            // 
            this.startY.Location = new System.Drawing.Point(556, 209);
            this.startY.Name = "startY";
            this.startY.Size = new System.Drawing.Size(232, 22);
            this.startY.TabIndex = 13;
            // 
            // startX
            // 
            this.startX.Location = new System.Drawing.Point(556, 181);
            this.startX.Name = "startX";
            this.startX.Size = new System.Drawing.Size(232, 22);
            this.startX.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "start X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "start Y:";
            // 
            // Clipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startX);
            this.Controls.Add(this.startY);
            this.Controls.Add(this.Clip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EnterLineCoordinates);
            this.Controls.Add(this.endY);
            this.Controls.Add(this.endX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verticeY);
            this.Controls.Add(this.verticeX);
            this.Controls.Add(this.FieldCoordinates);
            this.Controls.Add(this.picture);
            this.Name = "Clipping";
            this.Text = "Clipping";
            this.Load += new System.EventHandler(this.Clipping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button FieldCoordinates;
        private System.Windows.Forms.TextBox verticeX;
        private System.Windows.Forms.TextBox verticeY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox endX;
        private System.Windows.Forms.TextBox endY;
        private System.Windows.Forms.Button EnterLineCoordinates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Clip;
        private System.Windows.Forms.TextBox startY;
        private System.Windows.Forms.TextBox startX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

