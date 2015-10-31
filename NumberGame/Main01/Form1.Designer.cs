namespace Main01
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
            this.AnswerList = new System.Windows.Forms.ListBox();
            this.LabelAnswer = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonExe = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AnswerList
            // 
            this.AnswerList.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AnswerList.FormattingEnabled = true;
            this.AnswerList.ItemHeight = 21;
            this.AnswerList.Location = new System.Drawing.Point(308, 97);
            this.AnswerList.Name = "AnswerList";
            this.AnswerList.Size = new System.Drawing.Size(253, 319);
            this.AnswerList.TabIndex = 2;
            // 
            // LabelAnswer
            // 
            this.LabelAnswer.AutoSize = true;
            this.LabelAnswer.BackColor = System.Drawing.Color.White;
            this.LabelAnswer.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelAnswer.Location = new System.Drawing.Point(398, 38);
            this.LabelAnswer.Name = "LabelAnswer";
            this.LabelAnswer.Size = new System.Drawing.Size(91, 37);
            this.LabelAnswer.TabIndex = 4;
            this.LabelAnswer.Text = "答案";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Font = new System.Drawing.Font("SketchFlow Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRestart.Location = new System.Drawing.Point(12, 12);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(127, 39);
            this.buttonRestart.TabIndex = 3;
            this.buttonRestart.Text = "重新開始";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonExe
            // 
            this.buttonExe.Font = new System.Drawing.Font("SketchFlow Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExe.ForeColor = System.Drawing.Color.Coral;
            this.buttonExe.Location = new System.Drawing.Point(98, 325);
            this.buttonExe.Name = "buttonExe";
            this.buttonExe.Size = new System.Drawing.Size(192, 58);
            this.buttonExe.TabIndex = 3;
            this.buttonExe.Text = "OK";
            this.buttonExe.UseVisualStyleBackColor = true;
            this.buttonExe.Click += new System.EventHandler(this.buttonExe_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(98, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(589, 524);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LabelAnswer);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonExe);
            this.Controls.Add(this.AnswerList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox AnswerList;
        private System.Windows.Forms.Label LabelAnswer;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonExe;
        private System.Windows.Forms.TextBox textBox1;
    }
}

