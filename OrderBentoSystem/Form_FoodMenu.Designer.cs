
namespace OrderBentoSystem
{
    partial class Form_FoodMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_Restaurant = new System.Windows.Forms.ComboBox();
            this.lBox_FoodMenu = new System.Windows.Forms.ListBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_Add = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_CreateSave = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "餐廳:";
            // 
            // cbb_Restaurant
            // 
            this.cbb_Restaurant.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbb_Restaurant.FormattingEnabled = true;
            this.cbb_Restaurant.Location = new System.Drawing.Point(117, 43);
            this.cbb_Restaurant.Name = "cbb_Restaurant";
            this.cbb_Restaurant.Size = new System.Drawing.Size(255, 36);
            this.cbb_Restaurant.TabIndex = 13;
            this.cbb_Restaurant.SelectedIndexChanged += new System.EventHandler(this.cbb_Restaurant_SelectedIndexChanged);
            // 
            // lBox_FoodMenu
            // 
            this.lBox_FoodMenu.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lBox_FoodMenu.FormattingEnabled = true;
            this.lBox_FoodMenu.ItemHeight = 28;
            this.lBox_FoodMenu.Location = new System.Drawing.Point(31, 171);
            this.lBox_FoodMenu.Name = "lBox_FoodMenu";
            this.lBox_FoodMenu.Size = new System.Drawing.Size(341, 312);
            this.lBox_FoodMenu.TabIndex = 14;
            this.lBox_FoodMenu.SelectedIndexChanged += new System.EventHandler(this.lBox_FoodMenu_SelectedIndexChanged);
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Price.Location = new System.Drawing.Point(493, 275);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(263, 41);
            this.txt_Price.TabIndex = 28;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Name.Location = new System.Drawing.Point(493, 204);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(258, 41);
            this.txt_Name.TabIndex = 27;
            // 
            // txt_Code
            // 
            this.txt_Code.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Code.Location = new System.Drawing.Point(493, 125);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.ReadOnly = true;
            this.txt_Code.Size = new System.Drawing.Size(258, 41);
            this.txt_Code.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(402, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "單價:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(402, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "代碼:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(402, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "品項:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(402, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 28);
            this.label5.TabIndex = 29;
            this.label5.Text = "加購項目:";
            // 
            // cbb_Add
            // 
            this.cbb_Add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Add.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbb_Add.FormattingEnabled = true;
            this.cbb_Add.Location = new System.Drawing.Point(407, 408);
            this.cbb_Add.Name = "cbb_Add";
            this.cbb_Add.Size = new System.Drawing.Size(344, 36);
            this.cbb_Add.TabIndex = 30;
            this.cbb_Add.SelectedIndexChanged += new System.EventHandler(this.cbb_Add_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_CreateSave);
            this.groupBox1.Controls.Add(this.btn_Create);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(799, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 215);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增品項";
            // 
            // btn_CreateSave
            // 
            this.btn_CreateSave.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_CreateSave.Location = new System.Drawing.Point(49, 141);
            this.btn_CreateSave.Name = "btn_CreateSave";
            this.btn_CreateSave.Size = new System.Drawing.Size(139, 59);
            this.btn_CreateSave.TabIndex = 18;
            this.btn_CreateSave.Text = "儲存資料";
            this.btn_CreateSave.UseVisualStyleBackColor = true;
            this.btn_CreateSave.Click += new System.EventHandler(this.btn_CreateSave_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Create.Location = new System.Drawing.Point(49, 48);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(139, 59);
            this.btn_Create.TabIndex = 17;
            this.btn_Create.Text = "新增資料";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Update.Location = new System.Drawing.Point(799, 379);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(227, 104);
            this.btn_Update.TabIndex = 32;
            this.btn_Update.Text = "修改儲存";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(26, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 28);
            this.label6.TabIndex = 33;
            this.label6.Text = "菜單:";
            // 
            // Form_FoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 526);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbb_Add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lBox_FoodMenu);
            this.Controls.Add(this.cbb_Restaurant);
            this.Controls.Add(this.label1);
            this.Name = "Form_FoodMenu";
            this.Text = "菜單維護";
            this.Load += new System.EventHandler(this.Form_FoodMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_Restaurant;
        private System.Windows.Forms.ListBox lBox_FoodMenu;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_Add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_CreateSave;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label6;
    }
}