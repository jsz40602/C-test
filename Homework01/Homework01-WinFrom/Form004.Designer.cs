namespace Homework01_WinFrom
{
    partial class Form004
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form004));
            this.Name004 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Weight004 = new System.Windows.Forms.Label();
            this.Height004 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name004
            // 
            this.Name004.AutoSize = true;
            this.Name004.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name004.Location = new System.Drawing.Point(270, 39);
            this.Name004.Name = "Name004";
            this.Name004.Size = new System.Drawing.Size(109, 21);
            this.Name004.TabIndex = 9;
            this.Name004.Text = "Charmander";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Type.Location = new System.Drawing.Point(270, 174);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(98, 21);
            this.Type.TabIndex = 8;
            this.Type.Text = "Type : Fire";
            // 
            // Weight004
            // 
            this.Weight004.AutoSize = true;
            this.Weight004.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Weight004.Location = new System.Drawing.Point(270, 129);
            this.Weight004.Name = "Weight004";
            this.Weight004.Size = new System.Drawing.Size(146, 21);
            this.Weight004.TabIndex = 7;
            this.Weight004.Text = "Weight : 18.7 lbs";
            // 
            // Height004
            // 
            this.Height004.AutoSize = true;
            this.Height004.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Height004.Location = new System.Drawing.Point(270, 84);
            this.Height004.Name = "Height004";
            this.Height004.Size = new System.Drawing.Size(117, 21);
            this.Height004.TabIndex = 6;
            this.Height004.Text = "Height : 2\' 00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.Name004);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Weight004);
            this.Controls.Add(this.Height004);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form004";
            this.Text = "Form004";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name004;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Weight004;
        private System.Windows.Forms.Label Height004;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}