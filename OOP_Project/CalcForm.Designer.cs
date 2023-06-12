namespace OOP_Project
{
    partial class CalcForm
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
            this.tb_totalpay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_allowance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tb_weekpay = new System.Windows.Forms.TextBox();
            this.tb_count = new System.Windows.Forms.TextBox();
            this.tb_workhours = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_totalpay
            // 
            this.tb_totalpay.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_totalpay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_totalpay.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_totalpay.Location = new System.Drawing.Point(159, 338);
            this.tb_totalpay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_totalpay.Name = "tb_totalpay";
            this.tb_totalpay.ReadOnly = true;
            this.tb_totalpay.Size = new System.Drawing.Size(175, 30);
            this.tb_totalpay.TabIndex = 80;
            this.tb_totalpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어 Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(59, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 26);
            this.label7.TabIndex = 79;
            this.label7.Text = "총 주급";
            // 
            // tb_allowance
            // 
            this.tb_allowance.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_allowance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_allowance.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_allowance.Location = new System.Drawing.Point(159, 280);
            this.tb_allowance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_allowance.Name = "tb_allowance";
            this.tb_allowance.ReadOnly = true;
            this.tb_allowance.Size = new System.Drawing.Size(175, 30);
            this.tb_allowance.TabIndex = 78;
            this.tb_allowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어 Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(59, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 26);
            this.label6.TabIndex = 77;
            this.label6.Text = "주휴수당";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_cancel.FlatAppearance.BorderSize = 3;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cancel.Location = new System.Drawing.Point(140, 422);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(114, 44);
            this.btn_cancel.TabIndex = 76;
            this.btn_cancel.Text = "뒤로가기";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tb_weekpay
            // 
            this.tb_weekpay.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_weekpay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_weekpay.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_weekpay.Location = new System.Drawing.Point(159, 232);
            this.tb_weekpay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_weekpay.Name = "tb_weekpay";
            this.tb_weekpay.ReadOnly = true;
            this.tb_weekpay.Size = new System.Drawing.Size(175, 30);
            this.tb_weekpay.TabIndex = 75;
            this.tb_weekpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_count
            // 
            this.tb_count.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_count.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_count.Location = new System.Drawing.Point(159, 184);
            this.tb_count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_count.Name = "tb_count";
            this.tb_count.ReadOnly = true;
            this.tb_count.Size = new System.Drawing.Size(175, 30);
            this.tb_count.TabIndex = 74;
            this.tb_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_workhours
            // 
            this.tb_workhours.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_workhours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_workhours.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_workhours.Location = new System.Drawing.Point(159, 136);
            this.tb_workhours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_workhours.Name = "tb_workhours";
            this.tb_workhours.ReadOnly = true;
            this.tb_workhours.Size = new System.Drawing.Size(175, 30);
            this.tb_workhours.TabIndex = 73;
            this.tb_workhours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_name.Location = new System.Drawing.Point(159, 89);
            this.tb_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(175, 30);
            this.tb_name.TabIndex = 72;
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어 Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(59, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 26);
            this.label5.TabIndex = 71;
            this.label5.Text = "주급";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어 Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(59, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 26);
            this.label4.TabIndex = 70;
            this.label4.Text = "근무횟수";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어 Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(59, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 69;
            this.label3.Text = "근무시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(59, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 68;
            this.label2.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(80, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 48);
            this.label1.TabIndex = 67;
            this.label1.Text = "주급 계산기";
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 477);
            this.Controls.Add(this.tb_totalpay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_allowance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tb_weekpay);
            this.Controls.Add(this.tb_count);
            this.Controls.Add(this.tb_workhours);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalcForm";
            this.Text = "CalcForm";
            this.Load += new System.EventHandler(this.CalcForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_totalpay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_allowance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox tb_weekpay;
        private System.Windows.Forms.TextBox tb_count;
        private System.Windows.Forms.TextBox tb_workhours;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}