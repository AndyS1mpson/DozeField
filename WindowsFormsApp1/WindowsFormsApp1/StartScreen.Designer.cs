namespace WindowsFormsApp1
{
    partial class StartScreen
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
            this.ClippingLine = new System.Windows.Forms.Button();
            this.IsPointInField = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClippingLine
            // 
            this.ClippingLine.Location = new System.Drawing.Point(482, 140);
            this.ClippingLine.Name = "ClippingLine";
            this.ClippingLine.Size = new System.Drawing.Size(188, 149);
            this.ClippingLine.TabIndex = 0;
            this.ClippingLine.Text = "Clip of line";
            this.ClippingLine.UseVisualStyleBackColor = true;
            this.ClippingLine.Click += new System.EventHandler(this.ClippingLine_Click);
            // 
            // IsPointInField
            // 
            this.IsPointInField.Location = new System.Drawing.Point(122, 140);
            this.IsPointInField.Name = "IsPointInField";
            this.IsPointInField.Size = new System.Drawing.Size(181, 149);
            this.IsPointInField.TabIndex = 1;
            this.IsPointInField.Text = "Check point is in field";
            this.IsPointInField.UseVisualStyleBackColor = true;
            this.IsPointInField.Click += new System.EventHandler(this.IsPointInField_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IsPointInField);
            this.Controls.Add(this.ClippingLine);
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClippingLine;
        private System.Windows.Forms.Button IsPointInField;
    }
}