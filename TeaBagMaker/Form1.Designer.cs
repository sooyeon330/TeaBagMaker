namespace TeaBagMaker
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            this.combobox = new System.Windows.Forms.ComboBox();
            this.timelb = new System.Windows.Forms.Label();
            this.btn_go = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // combobox
            // 
            this.combobox.Font = new System.Drawing.Font("굴림", 10F);
            this.combobox.FormattingEnabled = true;
            this.combobox.Location = new System.Drawing.Point(31, 25);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(351, 21);
            this.combobox.TabIndex = 0;
            this.combobox.SelectedIndexChanged += new System.EventHandler(this.Combobox_SelectedIndexChanged);
            // 
            // timelb
            // 
            this.timelb.AutoSize = true;
            this.timelb.Font = new System.Drawing.Font("굴림", 13F);
            this.timelb.Location = new System.Drawing.Point(31, 61);
            this.timelb.Name = "timelb";
            this.timelb.Size = new System.Drawing.Size(62, 18);
            this.timelb.TabIndex = 1;
            this.timelb.Text = "시간 : ";
            // 
            // btn_go
            // 
            this.btn_go.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_go.Location = new System.Drawing.Point(31, 94);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(351, 44);
            this.btn_go.TabIndex = 2;
            this.btn_go.Text = "담그기";
            this.btn_go.UseVisualStyleBackColor = false;
            this.btn_go.Click += new System.EventHandler(this.Btn_go_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "2019 05 21 - 3616 채수연";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 224);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.timelb);
            this.Controls.Add(this.combobox);
            this.Name = "Form";
            this.Text = "TeaBagMaker";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox;
        private System.Windows.Forms.Label timelb;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Timer;
    }
}

