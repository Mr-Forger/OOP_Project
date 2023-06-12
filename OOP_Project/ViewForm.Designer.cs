namespace OOP_Project
{
    partial class ViewForm
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
            this.btn_gowork = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.list_member = new System.Windows.Forms.ListView();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_gowork
            // 
            this.btn_gowork.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_gowork.FlatAppearance.BorderSize = 3;
            this.btn_gowork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gowork.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_gowork.Location = new System.Drawing.Point(257, 463);
            this.btn_gowork.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_gowork.Name = "btn_gowork";
            this.btn_gowork.Size = new System.Drawing.Size(61, 41);
            this.btn_gowork.TabIndex = 11;
            this.btn_gowork.Text = "출근";
            this.btn_gowork.UseVisualStyleBackColor = false;
            this.btn_gowork.Click += new System.EventHandler(this.btn_gowork_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_calc.FlatAppearance.BorderSize = 3;
            this.btn_calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calc.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_calc.Location = new System.Drawing.Point(526, 463);
            this.btn_calc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(102, 41);
            this.btn_calc.TabIndex = 10;
            this.btn_calc.Text = "주급 계산";
            this.btn_calc.UseVisualStyleBackColor = false;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(341, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "근무 현황";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_member
            // 
            this.list_member.BackColor = System.Drawing.Color.Gainsboro;
            this.list_member.HideSelection = false;
            this.list_member.Location = new System.Drawing.Point(12, 112);
            this.list_member.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.list_member.Name = "list_member";
            this.list_member.Size = new System.Drawing.Size(845, 300);
            this.list_member.TabIndex = 8;
            this.list_member.UseCompatibleStateImageBehavior = false;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_reset.FlatAppearance.BorderSize = 3;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_reset.Location = new System.Drawing.Point(361, 463);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(119, 41);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "주급 초기화";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 539);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_gowork);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_member);
            this.Name = "ViewForm";
            this.Text = "근무 현황";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gowork;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView list_member;
        private System.Windows.Forms.Button btn_reset;
    }
}