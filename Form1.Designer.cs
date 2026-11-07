namespace LuckyCoffee
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedStudent = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioJuice = new System.Windows.Forms.RadioButton();
            this.radioCoffee = new System.Windows.Forms.RadioButton();
            this.radioTea = new System.Windows.Forms.RadioButton();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listorder = new System.Windows.Forms.ListBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnsaveFile = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbllucky = new System.Windows.Forms.Label();
            this.btnload = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lucky Cafe Order";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkedStudent);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtcustomername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 411);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(91, 341);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(88, 26);
            this.txtQuantity.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity:";
            // 
            // checkedStudent
            // 
            this.checkedStudent.AutoSize = true;
            this.checkedStudent.Location = new System.Drawing.Point(218, 343);
            this.checkedStudent.Name = "checkedStudent";
            this.checkedStudent.Size = new System.Drawing.Size(226, 24);
            this.checkedStudent.TabIndex = 6;
            this.checkedStudent.Text = "Student Member (10% Off)";
            this.checkedStudent.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioJuice);
            this.groupBox2.Controls.Add(this.radioCoffee);
            this.groupBox2.Controls.Add(this.radioTea);
            this.groupBox2.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox2.Location = new System.Drawing.Point(17, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 167);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "  Drink Type    ";
            // 
            // radioJuice
            // 
            this.radioJuice.AutoSize = true;
            this.radioJuice.ForeColor = System.Drawing.Color.Black;
            this.radioJuice.Location = new System.Drawing.Point(35, 111);
            this.radioJuice.Name = "radioJuice";
            this.radioJuice.Size = new System.Drawing.Size(103, 24);
            this.radioJuice.TabIndex = 2;
            this.radioJuice.TabStop = true;
            this.radioJuice.Text = "Juice ($3)";
            this.radioJuice.UseVisualStyleBackColor = true;
            this.radioJuice.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioCoffee
            // 
            this.radioCoffee.AutoSize = true;
            this.radioCoffee.ForeColor = System.Drawing.Color.Black;
            this.radioCoffee.Location = new System.Drawing.Point(35, 81);
            this.radioCoffee.Name = "radioCoffee";
            this.radioCoffee.Size = new System.Drawing.Size(114, 24);
            this.radioCoffee.TabIndex = 1;
            this.radioCoffee.TabStop = true;
            this.radioCoffee.Text = "Coffee ($2)";
            this.radioCoffee.UseVisualStyleBackColor = true;
            // 
            // radioTea
            // 
            this.radioTea.AutoSize = true;
            this.radioTea.ForeColor = System.Drawing.Color.Black;
            this.radioTea.Location = new System.Drawing.Point(35, 51);
            this.radioTea.Name = "radioTea";
            this.radioTea.Size = new System.Drawing.Size(93, 24);
            this.radioTea.TabIndex = 0;
            this.radioTea.TabStop = true;
            this.radioTea.Text = "Tea ($1)";
            this.radioTea.UseVisualStyleBackColor = true;
            // 
            // txtcustomername
            // 
            this.txtcustomername.Location = new System.Drawing.Point(10, 97);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(347, 26);
            this.txtcustomername.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Information";
            // 
            // listorder
            // 
            this.listorder.FormattingEnabled = true;
            this.listorder.ItemHeight = 20;
            this.listorder.Location = new System.Drawing.Point(570, 84);
            this.listorder.Name = "listorder";
            this.listorder.Size = new System.Drawing.Size(503, 384);
            this.listorder.TabIndex = 2;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.BackColor = System.Drawing.Color.Gray;
            this.BtnCalculate.Location = new System.Drawing.Point(38, 502);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(232, 46);
            this.BtnCalculate.TabIndex = 3;
            this.BtnCalculate.Text = "Calculate Order";
            this.BtnCalculate.UseVisualStyleBackColor = false;
            this.BtnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnsaveFile
            // 
            this.BtnsaveFile.BackColor = System.Drawing.Color.Gray;
            this.BtnsaveFile.Location = new System.Drawing.Point(315, 502);
            this.BtnsaveFile.Name = "BtnsaveFile";
            this.BtnsaveFile.Size = new System.Drawing.Size(245, 46);
            this.BtnsaveFile.TabIndex = 4;
            this.BtnsaveFile.Text = "Save to File";
            this.BtnsaveFile.UseVisualStyleBackColor = false;
            this.BtnsaveFile.Click += new System.EventHandler(this.BtnsaveFile_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.BackColor = System.Drawing.Color.White;
            this.lbltotal.ForeColor = System.Drawing.Color.Navy;
            this.lbltotal.Location = new System.Drawing.Point(35, 580);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(961, 37);
            this.lbltotal.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(570, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(503, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Order List";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbllucky
            // 
            this.lbllucky.BackColor = System.Drawing.Color.White;
            this.lbllucky.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbllucky.Location = new System.Drawing.Point(35, 616);
            this.lbllucky.Name = "lbllucky";
            this.lbllucky.Size = new System.Drawing.Size(961, 37);
            this.lbllucky.TabIndex = 9;
            // 
            // btnload
            // 
            this.btnload.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnload.Location = new System.Drawing.Point(617, 502);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(215, 46);
            this.btnload.TabIndex = 10;
            this.btnload.Text = "Load From File";
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Click += new System.EventHandler(this.btnload_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnClear.Location = new System.Drawing.Point(872, 502);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(201, 46);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1166, 677);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.lbllucky);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.BtnsaveFile);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.listorder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioJuice;
        private System.Windows.Forms.RadioButton radioCoffee;
        private System.Windows.Forms.RadioButton radioTea;
        private System.Windows.Forms.CheckBox checkedStudent;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listorder;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnsaveFile;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbllucky;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnClear;
    }
}

