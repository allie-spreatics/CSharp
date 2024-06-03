namespace Calculator
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
            this.result_text = new System.Windows.Forms.TextBox();
            this.input_text = new System.Windows.Forms.TextBox();
            this.plus_btn = new System.Windows.Forms.Button();
            this.minus_btn = new System.Windows.Forms.Button();
            this.multi_btn = new System.Windows.Forms.Button();
            this.divide_btn = new System.Windows.Forms.Button();
            this.remain_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.do_calc_btn = new System.Windows.Forms.Button();
            this.check_history_btn = new System.Windows.Forms.Button();
            this.nega_posi_btn = new System.Windows.Forms.Button();
            this.dd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // result_text
            // 
            this.result_text.Location = new System.Drawing.Point(251, 142);
            this.result_text.Name = "result_text";
            this.result_text.Size = new System.Drawing.Size(338, 21);
            this.result_text.TabIndex = 1;
            // 
            // input_text
            // 
            this.input_text.Location = new System.Drawing.Point(190, 198);
            this.input_text.Name = "input_text";
            this.input_text.Size = new System.Drawing.Size(318, 21);
            this.input_text.TabIndex = 2;
            // 
            // plus_btn
            // 
            this.plus_btn.Location = new System.Drawing.Point(190, 169);
            this.plus_btn.Name = "plus_btn";
            this.plus_btn.Size = new System.Drawing.Size(75, 23);
            this.plus_btn.TabIndex = 3;
            this.plus_btn.Text = "+";
            this.plus_btn.UseVisualStyleBackColor = true;
            // 
            // minus_btn
            // 
            this.minus_btn.Location = new System.Drawing.Point(271, 169);
            this.minus_btn.Name = "minus_btn";
            this.minus_btn.Size = new System.Drawing.Size(75, 23);
            this.minus_btn.TabIndex = 4;
            this.minus_btn.Text = "-";
            this.minus_btn.UseVisualStyleBackColor = true;
            this.minus_btn.Click += new System.EventHandler(this.minus_Click);
            // 
            // multi_btn
            // 
            this.multi_btn.Location = new System.Drawing.Point(352, 169);
            this.multi_btn.Name = "multi_btn";
            this.multi_btn.Size = new System.Drawing.Size(75, 23);
            this.multi_btn.TabIndex = 5;
            this.multi_btn.Text = "x";
            this.multi_btn.UseVisualStyleBackColor = true;
            this.multi_btn.Click += new System.EventHandler(this.multi_btn_Click);
            // 
            // divide_btn
            // 
            this.divide_btn.Location = new System.Drawing.Point(433, 169);
            this.divide_btn.Name = "divide_btn";
            this.divide_btn.Size = new System.Drawing.Size(75, 23);
            this.divide_btn.TabIndex = 6;
            this.divide_btn.Text = "/";
            this.divide_btn.UseVisualStyleBackColor = true;
            this.divide_btn.Click += new System.EventHandler(this.divide_btn_Click);
            // 
            // remain_btn
            // 
            this.remain_btn.Location = new System.Drawing.Point(514, 169);
            this.remain_btn.Name = "remain_btn";
            this.remain_btn.Size = new System.Drawing.Size(75, 23);
            this.remain_btn.TabIndex = 7;
            this.remain_btn.Text = "%";
            this.remain_btn.UseVisualStyleBackColor = true;
            this.remain_btn.Click += new System.EventHandler(this.remain_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(190, 255);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(104, 23);
            this.reset_btn.TabIndex = 8;
            this.reset_btn.Text = "초기화";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(300, 255);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(91, 23);
            this.del_btn.TabIndex = 9;
            this.del_btn.Text = "한글자 지우기";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // do_calc_btn
            // 
            this.do_calc_btn.Location = new System.Drawing.Point(190, 226);
            this.do_calc_btn.Name = "do_calc_btn";
            this.do_calc_btn.Size = new System.Drawing.Size(399, 23);
            this.do_calc_btn.TabIndex = 10;
            this.do_calc_btn.Text = "연산 실행";
            this.do_calc_btn.UseVisualStyleBackColor = true;
            this.do_calc_btn.Click += new System.EventHandler(this.do_calc_btn_Click);
            // 
            // check_history_btn
            // 
            this.check_history_btn.Location = new System.Drawing.Point(397, 255);
            this.check_history_btn.Name = "check_history_btn";
            this.check_history_btn.Size = new System.Drawing.Size(192, 23);
            this.check_history_btn.TabIndex = 11;
            this.check_history_btn.Text = "연산 내역 확인";
            this.check_history_btn.UseVisualStyleBackColor = true;
            this.check_history_btn.Click += new System.EventHandler(this.check_history_Click);
            // 
            // nega_posi_btn
            // 
            this.nega_posi_btn.Location = new System.Drawing.Point(514, 198);
            this.nega_posi_btn.Name = "nega_posi_btn";
            this.nega_posi_btn.Size = new System.Drawing.Size(75, 23);
            this.nega_posi_btn.TabIndex = 12;
            this.nega_posi_btn.Text = "음/양";
            this.nega_posi_btn.UseVisualStyleBackColor = true;
            this.nega_posi_btn.Click += new System.EventHandler(this.nega_posi_btn_Click);
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.Location = new System.Drawing.Point(191, 146);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(57, 12);
            this.dd.TabIndex = 13;
            this.dd.Text = "연산 결과";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.nega_posi_btn);
            this.Controls.Add(this.check_history_btn);
            this.Controls.Add(this.do_calc_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.remain_btn);
            this.Controls.Add(this.divide_btn);
            this.Controls.Add(this.multi_btn);
            this.Controls.Add(this.minus_btn);
            this.Controls.Add(this.plus_btn);
            this.Controls.Add(this.input_text);
            this.Controls.Add(this.result_text);
            this.Name = "Form1";
            this.Text = "calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox result_text;
        private System.Windows.Forms.TextBox input_text;
        private System.Windows.Forms.Button plus_btn;
        private System.Windows.Forms.Button minus_btn;
        private System.Windows.Forms.Button multi_btn;
        private System.Windows.Forms.Button divide_btn;
        private System.Windows.Forms.Button remain_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button do_calc_btn;
        private System.Windows.Forms.Button check_history_btn;
        private System.Windows.Forms.Button nega_posi_btn;
        private System.Windows.Forms.Label dd;
    }
}

