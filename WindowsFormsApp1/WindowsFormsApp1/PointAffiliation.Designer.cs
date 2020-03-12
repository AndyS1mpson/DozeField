namespace WindowsFormsApp1
{
    partial class PointAffiliation
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
            this.verticeX = new System.Windows.Forms.TextBox();
            this.verticeY = new System.Windows.Forms.TextBox();
            this.FieldCoordinates = new System.Windows.Forms.Button();
            this.pointX = new System.Windows.Forms.TextBox();
            this.pointY = new System.Windows.Forms.TextBox();
            this.PointCoordinates = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.PointInField = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(-2, 1);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(523, 358);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // verticeX
            // 
            this.verticeX.Location = new System.Drawing.Point(554, 12);
            this.verticeX.Name = "verticeX";
            this.verticeX.Size = new System.Drawing.Size(222, 22);
            this.verticeX.TabIndex = 1;
            // 
            // verticeY
            // 
            this.verticeY.Location = new System.Drawing.Point(554, 40);
            this.verticeY.Name = "verticeY";
            this.verticeY.Size = new System.Drawing.Size(222, 22);
            this.verticeY.TabIndex = 2;
            // 
            // FieldCoordinates
            // 
            this.FieldCoordinates.Location = new System.Drawing.Point(609, 83);
            this.FieldCoordinates.Name = "FieldCoordinates";
            this.FieldCoordinates.Size = new System.Drawing.Size(94, 66);
            this.FieldCoordinates.TabIndex = 3;
            this.FieldCoordinates.Text = "Enter the field vertice coordinates and show";
            this.FieldCoordinates.UseVisualStyleBackColor = true;
            this.FieldCoordinates.Click += new System.EventHandler(this.FieldCoordinates_Click);
            // 
            // pointX
            // 
            this.pointX.Location = new System.Drawing.Point(554, 172);
            this.pointX.Name = "pointX";
            this.pointX.Size = new System.Drawing.Size(222, 22);
            this.pointX.TabIndex = 4;
            // 
            // pointY
            // 
            this.pointY.Location = new System.Drawing.Point(554, 200);
            this.pointY.Name = "pointY";
            this.pointY.Size = new System.Drawing.Size(222, 22);
            this.pointY.TabIndex = 5;
            // 
            // PointCoordinates
            // 
            this.PointCoordinates.Location = new System.Drawing.Point(609, 249);
            this.PointCoordinates.Name = "PointCoordinates";
            this.PointCoordinates.Size = new System.Drawing.Size(94, 61);
            this.PointCoordinates.TabIndex = 6;
            this.PointCoordinates.Text = "Enter point coordinates";
            this.PointCoordinates.UseVisualStyleBackColor = true;
            this.PointCoordinates.Click += new System.EventHandler(this.PointCoordinates_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y:";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(27, 389);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(72, 24);
            this.Result.TabIndex = 11;
            this.Result.Text = "Result :";
            // 
            // PointInField
            // 
            this.PointInField.Location = new System.Drawing.Point(591, 389);
            this.PointInField.Name = "PointInField";
            this.PointInField.Size = new System.Drawing.Size(129, 23);
            this.PointInField.TabIndex = 12;
            this.PointInField.Text = "Is Point in Field?";
            this.PointInField.UseVisualStyleBackColor = true;
            this.PointInField.Click += new System.EventHandler(this.PointInField_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(105, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 60);
            this.label5.TabIndex = 13;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PointAffiliation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PointInField);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PointCoordinates);
            this.Controls.Add(this.pointY);
            this.Controls.Add(this.pointX);
            this.Controls.Add(this.FieldCoordinates);
            this.Controls.Add(this.verticeY);
            this.Controls.Add(this.verticeX);
            this.Controls.Add(this.picture);
            this.Name = "PointAffiliation";
            this.Text = "PointAffiliation";
            this.Load += new System.EventHandler(this.PointAffiliation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TextBox verticeX;
        private System.Windows.Forms.TextBox verticeY;
        private System.Windows.Forms.Button FieldCoordinates;
        private System.Windows.Forms.TextBox pointX;
        private System.Windows.Forms.TextBox pointY;
        private System.Windows.Forms.Button PointCoordinates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button PointInField;
        private System.Windows.Forms.Label label5;
    }
}