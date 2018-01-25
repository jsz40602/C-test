namespace Homework01_WinFrom
{
    partial class Form007
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form007));
            this.Name007 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Weight007 = new System.Windows.Forms.Label();
            this.Height007 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name007
            // 
            this.Name007.AutoSize = true;
            this.Name007.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name007.Location = new System.Drawing.Point(270, 39);
            this.Name007.Name = "Name007";
            this.Name007.Size = new System.Drawing.Size(72, 21);
            this.Name007.TabIndex = 9;
            this.Name007.Text = "Squirtle";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Type.Location = new System.Drawing.Point(270, 174);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(115, 21);
            this.Type.TabIndex = 8;
            this.Type.Text = "Type : Water";
            // 
            // Weight007
            // 
            this.Weight007.AutoSize = true;
            this.Weight007.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Weight007.Location = new System.Drawing.Point(270, 129);
            this.Weight007.Name = "Weight007";
            this.Weight007.Size = new System.Drawing.Size(146, 21);
            this.Weight007.TabIndex = 7;
            this.Weight007.Text = "Weight : 19.8 lbs";
            // 
            // Height007
            // 
            this.Height007.AutoSize = true;
            this.Height007.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Height007.Location = new System.Drawing.Point(270, 84);
            this.Height007.Name = "Height007";
            this.Height007.Size = new System.Drawing.Size(117, 21);
            this.Height007.TabIndex = 6;
            this.Height007.Text = "Height : 1\' 08";
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
            // Form007
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.Name007);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Weight007);
            this.Controls.Add(this.Height007);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form007";
            this.Text = "Form007";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name007;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Weight007;
        private System.Windows.Forms.Label Height007;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}