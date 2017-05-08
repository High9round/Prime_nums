namespace Prime_nums
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown_maxNum = new System.Windows.Forms.NumericUpDown();
            this.button_excute = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxNum)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_maxNum
            // 
            this.numericUpDown_maxNum.Location = new System.Drawing.Point(25, 37);
            this.numericUpDown_maxNum.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_maxNum.Name = "numericUpDown_maxNum";
            this.numericUpDown_maxNum.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown_maxNum.TabIndex = 0;
            // 
            // button_excute
            // 
            this.button_excute.Location = new System.Drawing.Point(185, 37);
            this.button_excute.Name = "button_excute";
            this.button_excute.Size = new System.Drawing.Size(75, 23);
            this.button_excute.TabIndex = 1;
            this.button_excute.Text = "EXCUTE";
            this.button_excute.UseVisualStyleBackColor = true;
            this.button_excute.Click += new System.EventHandler(this.button_excute_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(12, 94);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_result.Size = new System.Drawing.Size(640, 355);
            this.textBox_result.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 461);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_excute);
            this.Controls.Add(this.numericUpDown_maxNum);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_maxNum;
        private System.Windows.Forms.Button button_excute;
        private System.Windows.Forms.TextBox textBox_result;
    }
}

