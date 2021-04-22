
namespace OrderBentoSystem
{
    partial class Form_Order
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
            this.btn_MenuWrite = new System.Windows.Forms.Button();
            this.btn_OpenOrder = new System.Windows.Forms.Button();
            this.btn_AddOrder = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Subtotal = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lBox_Add = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lBox_Menu = new System.Windows.Forms.ListBox();
            this.cBox_Restaurant = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_OnDuty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBox_Student = new System.Windows.Forms.ComboBox();
            this.cBox_Class = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_MenuWrite
            // 
            this.btn_MenuWrite.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_MenuWrite.Location = new System.Drawing.Point(668, 21);
            this.btn_MenuWrite.Name = "btn_MenuWrite";
            this.btn_MenuWrite.Size = new System.Drawing.Size(114, 80);
            this.btn_MenuWrite.TabIndex = 66;
            this.btn_MenuWrite.Text = "讀取\r\n品項檔";
            this.btn_MenuWrite.UseVisualStyleBackColor = true;
            // 
            // btn_OpenOrder
            // 
            this.btn_OpenOrder.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_OpenOrder.Location = new System.Drawing.Point(668, 415);
            this.btn_OpenOrder.Name = "btn_OpenOrder";
            this.btn_OpenOrder.Size = new System.Drawing.Size(114, 80);
            this.btn_OpenOrder.TabIndex = 65;
            this.btn_OpenOrder.Text = "開啟\r\n訂單";
            this.btn_OpenOrder.UseVisualStyleBackColor = true;
            // 
            // btn_AddOrder
            // 
            this.btn_AddOrder.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_AddOrder.Location = new System.Drawing.Point(540, 415);
            this.btn_AddOrder.Name = "btn_AddOrder";
            this.btn_AddOrder.Size = new System.Drawing.Size(114, 80);
            this.btn_AddOrder.TabIndex = 64;
            this.btn_AddOrder.Text = "訂購";
            this.btn_AddOrder.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(553, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 24);
            this.label10.TabIndex = 63;
            this.label10.Text = "總價:";
            // 
            // txt_Subtotal
            // 
            this.txt_Subtotal.Enabled = false;
            this.txt_Subtotal.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Subtotal.Location = new System.Drawing.Point(632, 355);
            this.txt_Subtotal.Name = "txt_Subtotal";
            this.txt_Subtotal.Size = new System.Drawing.Size(150, 36);
            this.txt_Subtotal.TabIndex = 62;
            // 
            // txt_Price
            // 
            this.txt_Price.Enabled = false;
            this.txt_Price.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Price.Location = new System.Drawing.Point(632, 288);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(150, 36);
            this.txt_Price.TabIndex = 61;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Quantity.Location = new System.Drawing.Point(632, 227);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(150, 36);
            this.txt_Quantity.TabIndex = 60;
            this.txt_Quantity.Text = "1";
            this.txt_Quantity.TextChanged += new System.EventHandler(this.txt_Quantity_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(553, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 24);
            this.label9.TabIndex = 59;
            this.label9.Text = "單價:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(553, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 24);
            this.label8.TabIndex = 58;
            this.label8.Text = "數量:";
            // 
            // lBox_Add
            // 
            this.lBox_Add.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lBox_Add.FormattingEnabled = true;
            this.lBox_Add.ItemHeight = 24;
            this.lBox_Add.Location = new System.Drawing.Point(358, 227);
            this.lBox_Add.Name = "lBox_Add";
            this.lBox_Add.Size = new System.Drawing.Size(163, 268);
            this.lBox_Add.TabIndex = 57;
            this.lBox_Add.SelectedIndexChanged += new System.EventHandler(this.lBox_Add_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(23, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(500, 2);
            this.label7.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(19, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 55;
            this.label6.Text = "菜單:";
            // 
            // lBox_Menu
            // 
            this.lBox_Menu.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lBox_Menu.FormattingEnabled = true;
            this.lBox_Menu.ItemHeight = 24;
            this.lBox_Menu.Location = new System.Drawing.Point(23, 227);
            this.lBox_Menu.Name = "lBox_Menu";
            this.lBox_Menu.Size = new System.Drawing.Size(316, 268);
            this.lBox_Menu.TabIndex = 54;
            this.lBox_Menu.SelectedIndexChanged += new System.EventHandler(this.lBox_Menu_SelectedIndexChanged);
            // 
            // cBox_Restaurant
            // 
            this.cBox_Restaurant.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBox_Restaurant.FormattingEnabled = true;
            this.cBox_Restaurant.Location = new System.Drawing.Point(98, 129);
            this.cBox_Restaurant.Name = "cBox_Restaurant";
            this.cBox_Restaurant.Size = new System.Drawing.Size(241, 32);
            this.cBox_Restaurant.TabIndex = 53;
            this.cBox_Restaurant.SelectedIndexChanged += new System.EventHandler(this.cBox_Restaurant_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(19, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 52;
            this.label5.Text = "店家:";
            // 
            // lab_OnDuty
            // 
            this.lab_OnDuty.AutoSize = true;
            this.lab_OnDuty.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_OnDuty.Location = new System.Drawing.Point(474, 23);
            this.lab_OnDuty.Name = "lab_OnDuty";
            this.lab_OnDuty.Size = new System.Drawing.Size(125, 24);
            this.lab_OnDuty.TabIndex = 51;
            this.lab_OnDuty.Text = "這是Label";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(379, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "負責人:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(334, -45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 32);
            this.label3.TabIndex = 49;
            this.label3.Text = "訂便當系統";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "學生:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "班級:";
            // 
            // cBox_Student
            // 
            this.cBox_Student.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBox_Student.FormattingEnabled = true;
            this.cBox_Student.Location = new System.Drawing.Point(98, 59);
            this.cBox_Student.Name = "cBox_Student";
            this.cBox_Student.Size = new System.Drawing.Size(241, 32);
            this.cBox_Student.TabIndex = 46;
            this.cBox_Student.SelectedIndexChanged += new System.EventHandler(this.cBox_Student_SelectedIndexChanged);
            // 
            // cBox_Class
            // 
            this.cBox_Class.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBox_Class.FormattingEnabled = true;
            this.cBox_Class.Location = new System.Drawing.Point(98, 15);
            this.cBox_Class.Name = "cBox_Class";
            this.cBox_Class.Size = new System.Drawing.Size(241, 32);
            this.cBox_Class.TabIndex = 45;
            this.cBox_Class.SelectedIndexChanged += new System.EventHandler(this.cBox_Class_SelectedIndexChanged);
            // 
            // Form_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 514);
            this.Controls.Add(this.btn_MenuWrite);
            this.Controls.Add(this.btn_OpenOrder);
            this.Controls.Add(this.btn_AddOrder);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Subtotal);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lBox_Add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lBox_Menu);
            this.Controls.Add(this.cBox_Restaurant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lab_OnDuty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBox_Student);
            this.Controls.Add(this.cBox_Class);
            this.Name = "Form_Order";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.Form_Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MenuWrite;
        private System.Windows.Forms.Button btn_OpenOrder;
        private System.Windows.Forms.Button btn_AddOrder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Subtotal;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lBox_Add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lBox_Menu;
        private System.Windows.Forms.ComboBox cBox_Restaurant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_OnDuty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBox_Student;
        private System.Windows.Forms.ComboBox cBox_Class;
    }
}