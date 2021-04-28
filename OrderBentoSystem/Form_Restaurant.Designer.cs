
namespace OrderBentoSystem
{
    partial class Form_Restaurant
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
            this.lBox_RestaurantList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_CreateSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Addr = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBox_RestaurantList
            // 
            this.lBox_RestaurantList.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lBox_RestaurantList.FormattingEnabled = true;
            this.lBox_RestaurantList.ItemHeight = 28;
            this.lBox_RestaurantList.Location = new System.Drawing.Point(32, 104);
            this.lBox_RestaurantList.Name = "lBox_RestaurantList";
            this.lBox_RestaurantList.Size = new System.Drawing.Size(285, 368);
            this.lBox_RestaurantList.TabIndex = 0;
            this.lBox_RestaurantList.SelectedIndexChanged += new System.EventHandler(this.lBox_RestaurantList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "餐廳:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(341, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "名稱:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(341, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "代碼:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(341, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "電話:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(341, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "地址:";
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Update.Location = new System.Drawing.Point(346, 413);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(594, 59);
            this.btn_Update.TabIndex = 16;
            this.btn_Update.Text = "修改儲存";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Create.Location = new System.Drawing.Point(17, 52);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(139, 59);
            this.btn_Create.TabIndex = 17;
            this.btn_Create.Text = "新增資料";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_CreateSave
            // 
            this.btn_CreateSave.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_CreateSave.Location = new System.Drawing.Point(17, 145);
            this.btn_CreateSave.Name = "btn_CreateSave";
            this.btn_CreateSave.Size = new System.Drawing.Size(139, 59);
            this.btn_CreateSave.TabIndex = 18;
            this.btn_CreateSave.Text = "儲存資料";
            this.btn_CreateSave.UseVisualStyleBackColor = true;
            this.btn_CreateSave.Click += new System.EventHandler(this.btn_CreateSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_CreateSave);
            this.groupBox1.Controls.Add(this.btn_Create);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(764, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 234);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增餐廳";
            // 
            // txt_Code
            // 
            this.txt_Code.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Code.Location = new System.Drawing.Point(432, 101);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.ReadOnly = true;
            this.txt_Code.Size = new System.Drawing.Size(307, 41);
            this.txt_Code.TabIndex = 20;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Name.Location = new System.Drawing.Point(432, 185);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(307, 41);
            this.txt_Name.TabIndex = 21;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Phone.Location = new System.Drawing.Point(432, 261);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(307, 41);
            this.txt_Phone.TabIndex = 22;
            // 
            // txt_Addr
            // 
            this.txt_Addr.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Addr.Location = new System.Drawing.Point(432, 335);
            this.txt_Addr.Name = "txt_Addr";
            this.txt_Addr.Size = new System.Drawing.Size(508, 41);
            this.txt_Addr.TabIndex = 23;
            // 
            // Form_Restaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 499);
            this.Controls.Add(this.txt_Addr);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBox_RestaurantList);
            this.Name = "Form_Restaurant";
            this.Text = "餐廳資料";
            this.Load += new System.EventHandler(this.Form_Restaurant_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBox_RestaurantList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_CreateSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_Addr;
    }
}