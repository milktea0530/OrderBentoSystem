
namespace OrderBentoSystem
{
    partial class Form_OrderDetail
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
            this.btn_OrderDetailAllClear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_OrderFinish = new System.Windows.Forms.Button();
            this.btn_OrderDetailClear = new System.Windows.Forms.Button();
            this.btn_OrderSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lBox_Statistics = new System.Windows.Forms.ListBox();
            this.lBox_OrderDetail = new System.Windows.Forms.ListBox();
            this.lbl_OrderDate = new System.Windows.Forms.Label();
            this.lab_OnDuty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBox_Class = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_OrderDetailAllClear
            // 
            this.btn_OrderDetailAllClear.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_OrderDetailAllClear.Location = new System.Drawing.Point(584, 368);
            this.btn_OrderDetailAllClear.Name = "btn_OrderDetailAllClear";
            this.btn_OrderDetailAllClear.Size = new System.Drawing.Size(176, 80);
            this.btn_OrderDetailAllClear.TabIndex = 73;
            this.btn_OrderDetailAllClear.Text = "清空全部明細";
            this.btn_OrderDetailAllClear.UseVisualStyleBackColor = true;
            this.btn_OrderDetailAllClear.Click += new System.EventHandler(this.btn_OrderDetailAllClear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(38, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 24);
            this.label8.TabIndex = 72;
            this.label8.Text = "訂單總價:";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Amount.Location = new System.Drawing.Point(175, 414);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(36, 24);
            this.lbl_Amount.TabIndex = 71;
            this.lbl_Amount.Text = "$$";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(40, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(577, 2);
            this.label2.TabIndex = 70;
            // 
            // btn_OrderFinish
            // 
            this.btn_OrderFinish.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_OrderFinish.Location = new System.Drawing.Point(630, 606);
            this.btn_OrderFinish.Name = "btn_OrderFinish";
            this.btn_OrderFinish.Size = new System.Drawing.Size(136, 80);
            this.btn_OrderFinish.TabIndex = 69;
            this.btn_OrderFinish.Text = "訂購單\r\n完成";
            this.btn_OrderFinish.UseVisualStyleBackColor = true;
            this.btn_OrderFinish.Click += new System.EventHandler(this.btn_OrderFinish_Click);
            // 
            // btn_OrderDetailClear
            // 
            this.btn_OrderDetailClear.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_OrderDetailClear.Location = new System.Drawing.Point(388, 368);
            this.btn_OrderDetailClear.Name = "btn_OrderDetailClear";
            this.btn_OrderDetailClear.Size = new System.Drawing.Size(180, 80);
            this.btn_OrderDetailClear.TabIndex = 68;
            this.btn_OrderDetailClear.Text = "移除單筆明細";
            this.btn_OrderDetailClear.UseVisualStyleBackColor = true;
            this.btn_OrderDetailClear.Click += new System.EventHandler(this.btn_OrderDetailClear_Click);
            // 
            // btn_OrderSave
            // 
            this.btn_OrderSave.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_OrderSave.Location = new System.Drawing.Point(630, 520);
            this.btn_OrderSave.Name = "btn_OrderSave";
            this.btn_OrderSave.Size = new System.Drawing.Size(136, 80);
            this.btn_OrderSave.TabIndex = 67;
            this.btn_OrderSave.Text = "訂購單\r\n存檔";
            this.btn_OrderSave.UseVisualStyleBackColor = true;
            this.btn_OrderSave.Click += new System.EventHandler(this.btn_OrderSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(32, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 66;
            this.label7.Text = "訂單明細";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(32, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 65;
            this.label6.Text = "統計列表";
            // 
            // lBox_Statistics
            // 
            this.lBox_Statistics.Font = new System.Drawing.Font("標楷體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lBox_Statistics.FormattingEnabled = true;
            this.lBox_Statistics.ItemHeight = 20;
            this.lBox_Statistics.Location = new System.Drawing.Point(40, 522);
            this.lBox_Statistics.Name = "lBox_Statistics";
            this.lBox_Statistics.Size = new System.Drawing.Size(555, 164);
            this.lBox_Statistics.TabIndex = 64;
            // 
            // lBox_OrderDetail
            // 
            this.lBox_OrderDetail.Font = new System.Drawing.Font("標楷體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lBox_OrderDetail.FormattingEnabled = true;
            this.lBox_OrderDetail.ItemHeight = 20;
            this.lBox_OrderDetail.Location = new System.Drawing.Point(40, 128);
            this.lBox_OrderDetail.Name = "lBox_OrderDetail";
            this.lBox_OrderDetail.Size = new System.Drawing.Size(726, 224);
            this.lBox_OrderDetail.TabIndex = 63;
            // 
            // lbl_OrderDate
            // 
            this.lbl_OrderDate.AutoSize = true;
            this.lbl_OrderDate.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_OrderDate.Location = new System.Drawing.Point(38, 368);
            this.lbl_OrderDate.Name = "lbl_OrderDate";
            this.lbl_OrderDate.Size = new System.Drawing.Size(0, 24);
            this.lbl_OrderDate.TabIndex = 62;
            // 
            // lab_OnDuty
            // 
            this.lab_OnDuty.AutoSize = true;
            this.lab_OnDuty.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_OnDuty.Location = new System.Drawing.Point(522, 25);
            this.lab_OnDuty.Name = "lab_OnDuty";
            this.lab_OnDuty.Size = new System.Drawing.Size(0, 24);
            this.lab_OnDuty.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(427, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 58;
            this.label4.Text = "負責人:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 57;
            this.label1.Text = "班級:";
            // 
            // cBox_Class
            // 
            this.cBox_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Class.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBox_Class.FormattingEnabled = true;
            this.cBox_Class.Location = new System.Drawing.Point(111, 22);
            this.cBox_Class.Name = "cBox_Class";
            this.cBox_Class.Size = new System.Drawing.Size(121, 32);
            this.cBox_Class.TabIndex = 56;
            this.cBox_Class.SelectedIndexChanged += new System.EventHandler(this.cBox_Class_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(48, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(712, 2);
            this.label3.TabIndex = 74;
            // 
            // Form_OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 699);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_OrderDetailAllClear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_OrderFinish);
            this.Controls.Add(this.btn_OrderDetailClear);
            this.Controls.Add(this.btn_OrderSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lBox_Statistics);
            this.Controls.Add(this.lBox_OrderDetail);
            this.Controls.Add(this.lbl_OrderDate);
            this.Controls.Add(this.lab_OnDuty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBox_Class);
            this.Name = "Form_OrderDetail";
            this.Text = "Form_OrderDetail";
            this.Load += new System.EventHandler(this.Form_OrderDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OrderDetailAllClear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_OrderFinish;
        private System.Windows.Forms.Button btn_OrderDetailClear;
        private System.Windows.Forms.Button btn_OrderSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lBox_Statistics;
        private System.Windows.Forms.ListBox lBox_OrderDetail;
        private System.Windows.Forms.Label lbl_OrderDate;
        private System.Windows.Forms.Label lab_OnDuty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBox_Class;
        private System.Windows.Forms.Label label3;
    }
}