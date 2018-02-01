namespace Homework
{
    partial class Form1
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
            this.number1TextBox = new System.Windows.Forms.TextBox();
            this.number2TextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.execButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number1TextBox
            // 
            this.number1TextBox.Location = new System.Drawing.Point(36, 28);
            this.number1TextBox.Name = "number1TextBox";
            this.number1TextBox.Size = new System.Drawing.Size(82, 22);
            this.number1TextBox.TabIndex = 0;
            // 
            // number2TextBox
            // 
            this.number2TextBox.Location = new System.Drawing.Point(202, 28);
            this.number2TextBox.Name = "number2TextBox";
            this.number2TextBox.Size = new System.Drawing.Size(82, 22);
            this.number2TextBox.TabIndex = 1;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(364, 28);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(82, 22);
            this.resultTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "=";
            // 
            // execButton
            // 
            this.execButton.Location = new System.Drawing.Point(36, 67);
            this.execButton.Name = "execButton";
            this.execButton.Size = new System.Drawing.Size(409, 26);
            this.execButton.TabIndex = 5;
            this.execButton.Text = "執行";
            this.execButton.UseVisualStyleBackColor = true;
            this.execButton.Click += new System.EventHandler(this.execButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 219);
            this.Controls.Add(this.execButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.number2TextBox);
            this.Controls.Add(this.number1TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number1TextBox;
        private System.Windows.Forms.TextBox number2TextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button execButton;
    }
}

