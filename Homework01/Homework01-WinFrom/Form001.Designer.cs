namespace Homework01_WinFrom
{
    partial class Form001
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form001));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Height001 = new System.Windows.Forms.Label();
            this.Weight001 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Name001 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Height001
            // 
            this.Height001.AutoSize = true;
            this.Height001.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Height001.Location = new System.Drawing.Point(270, 84);
            this.Height001.Name = "Height001";
            this.Height001.Size = new System.Drawing.Size(117, 21);
            this.Height001.TabIndex = 1;
            this.Height001.Text = "Height : 2\' 04";
            // 
            // Weight001
            // 
            this.Weight001.AutoSize = true;
            this.Weight001.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Weight001.Location = new System.Drawing.Point(270, 129);
            this.Weight001.Name = "Weight001";
            this.Weight001.Size = new System.Drawing.Size(146, 21);
            this.Weight001.TabIndex = 2;
            this.Weight001.Text = "Weight : 15.2 lbs";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Type.Location = new System.Drawing.Point(270, 174);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(181, 21);
            this.Type.TabIndex = 3;
            this.Type.Text = "Type : Grass , Poison";
            // 
            // Name001
            // 
            this.Name001.AutoSize = true;
            this.Name001.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name001.Location = new System.Drawing.Point(270, 39);
            this.Name001.Name = "Name001";
            this.Name001.Size = new System.Drawing.Size(91, 21);
            this.Name001.TabIndex = 4;
            this.Name001.Text = "Bulbasaur";
            // 
            // Form001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.Name001);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Weight001);
            this.Controls.Add(this.Height001);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form001";
            this.Text = "Bulbasaur";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Height001;
        private System.Windows.Forms.Label Weight001;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Name001;
    }
}

