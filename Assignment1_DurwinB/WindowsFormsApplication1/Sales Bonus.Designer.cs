namespace WindowsFormsApplication1
{
    partial class SalesBonusForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesBonusForm));
            this.LangGbox = new System.Windows.Forms.GroupBox();
            this.FrenchRadioBttn = new System.Windows.Forms.RadioButton();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.EmpNameTxtBox = new System.Windows.Forms.TextBox();
            this.EmpIdTxtBox = new System.Windows.Forms.TextBox();
            this.HrsWorkedTxtBox = new System.Windows.Forms.TextBox();
            this.TotalSalesTxtBox = new System.Windows.Forms.TextBox();
            this.SalesBonusTxtBox = new System.Windows.Forms.TextBox();
            this.EmpNameLbl = new System.Windows.Forms.Label();
            this.EmpIdLbl = new System.Windows.Forms.Label();
            this.HrsWorkedLbl = new System.Windows.Forms.Label();
            this.TotalSalesLbl = new System.Windows.Forms.Label();
            this.SalesBonusLbl = new System.Windows.Forms.Label();
            this.PrintBttn = new System.Windows.Forms.Button();
            this.CalcBttn = new System.Windows.Forms.Button();
            this.NextBttn = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.LangGbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LangGbox
            // 
            this.LangGbox.Controls.Add(this.FrenchRadioBttn);
            this.LangGbox.Controls.Add(this.EnglishRadioButton);
            this.LangGbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LangGbox.Location = new System.Drawing.Point(177, 12);
            this.LangGbox.Name = "LangGbox";
            this.LangGbox.Size = new System.Drawing.Size(183, 112);
            this.LangGbox.TabIndex = 0;
            this.LangGbox.TabStop = false;
            this.LangGbox.Text = "Language";
            // 
            // FrenchRadioBttn
            // 
            this.FrenchRadioBttn.AutoSize = true;
            this.FrenchRadioBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrenchRadioBttn.Location = new System.Drawing.Point(39, 59);
            this.FrenchRadioBttn.Name = "FrenchRadioBttn";
            this.FrenchRadioBttn.Size = new System.Drawing.Size(72, 19);
            this.FrenchRadioBttn.TabIndex = 1;
            this.FrenchRadioBttn.Text = "Français";
            this.FrenchRadioBttn.UseVisualStyleBackColor = true;
            this.FrenchRadioBttn.CheckedChanged += new System.EventHandler(this.FrenchRadioBttn_CheckedChanged);
            // 
            // EnglishRadioButton
            // 
            this.EnglishRadioButton.AutoSize = true;
            this.EnglishRadioButton.Checked = true;
            this.EnglishRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnglishRadioButton.Location = new System.Drawing.Point(39, 36);
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.Size = new System.Drawing.Size(66, 19);
            this.EnglishRadioButton.TabIndex = 0;
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.Text = "English";
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            this.EnglishRadioButton.CheckedChanged += new System.EventHandler(this.EnglishRadioButton_CheckedChanged);
            // 
            // EmpNameTxtBox
            // 
            this.EmpNameTxtBox.Location = new System.Drawing.Point(188, 171);
            this.EmpNameTxtBox.Name = "EmpNameTxtBox";
            this.EmpNameTxtBox.Size = new System.Drawing.Size(167, 20);
            this.EmpNameTxtBox.TabIndex = 1;
            // 
            // EmpIdTxtBox
            // 
            this.EmpIdTxtBox.Location = new System.Drawing.Point(188, 198);
            this.EmpIdTxtBox.Name = "EmpIdTxtBox";
            this.EmpIdTxtBox.Size = new System.Drawing.Size(100, 20);
            this.EmpIdTxtBox.TabIndex = 2;
            // 
            // HrsWorkedTxtBox
            // 
            this.HrsWorkedTxtBox.Location = new System.Drawing.Point(188, 236);
            this.HrsWorkedTxtBox.Name = "HrsWorkedTxtBox";
            this.HrsWorkedTxtBox.Size = new System.Drawing.Size(100, 20);
            this.HrsWorkedTxtBox.TabIndex = 3;
            this.HrsWorkedTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HrsWorkedTxtBox_TextChanged);
            // 
            // TotalSalesTxtBox
            // 
            this.TotalSalesTxtBox.Location = new System.Drawing.Point(188, 262);
            this.TotalSalesTxtBox.Name = "TotalSalesTxtBox";
            this.TotalSalesTxtBox.Size = new System.Drawing.Size(100, 20);
            this.TotalSalesTxtBox.TabIndex = 4;
            this.TotalSalesTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalSalesTxtBox_TextChanged);
            // 
            // SalesBonusTxtBox
            // 
            this.SalesBonusTxtBox.Location = new System.Drawing.Point(188, 288);
            this.SalesBonusTxtBox.Name = "SalesBonusTxtBox";
            this.SalesBonusTxtBox.ReadOnly = true;
            this.SalesBonusTxtBox.Size = new System.Drawing.Size(100, 20);
            this.SalesBonusTxtBox.TabIndex = 5;
            // 
            // EmpNameLbl
            // 
            this.EmpNameLbl.AutoSize = true;
            this.EmpNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameLbl.Location = new System.Drawing.Point(32, 171);
            this.EmpNameLbl.Name = "EmpNameLbl";
            this.EmpNameLbl.Size = new System.Drawing.Size(102, 15);
            this.EmpNameLbl.TabIndex = 6;
            this.EmpNameLbl.Text = "Employee Name:";
            // 
            // EmpIdLbl
            // 
            this.EmpIdLbl.AutoSize = true;
            this.EmpIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpIdLbl.Location = new System.Drawing.Point(51, 198);
            this.EmpIdLbl.Name = "EmpIdLbl";
            this.EmpIdLbl.Size = new System.Drawing.Size(80, 15);
            this.EmpIdLbl.TabIndex = 7;
            this.EmpIdLbl.Text = "Employee ID:";
            // 
            // HrsWorkedLbl
            // 
            this.HrsWorkedLbl.AutoSize = true;
            this.HrsWorkedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HrsWorkedLbl.Location = new System.Drawing.Point(41, 236);
            this.HrsWorkedLbl.Name = "HrsWorkedLbl";
            this.HrsWorkedLbl.Size = new System.Drawing.Size(88, 15);
            this.HrsWorkedLbl.TabIndex = 8;
            this.HrsWorkedLbl.Text = "Hours Worked:";
            // 
            // TotalSalesLbl
            // 
            this.TotalSalesLbl.AutoSize = true;
            this.TotalSalesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalesLbl.Location = new System.Drawing.Point(58, 262);
            this.TotalSalesLbl.Name = "TotalSalesLbl";
            this.TotalSalesLbl.Size = new System.Drawing.Size(71, 15);
            this.TotalSalesLbl.TabIndex = 9;
            this.TotalSalesLbl.Text = "Total Sales:";
            // 
            // SalesBonusLbl
            // 
            this.SalesBonusLbl.AutoSize = true;
            this.SalesBonusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBonusLbl.Location = new System.Drawing.Point(52, 288);
            this.SalesBonusLbl.Name = "SalesBonusLbl";
            this.SalesBonusLbl.Size = new System.Drawing.Size(79, 15);
            this.SalesBonusLbl.TabIndex = 10;
            this.SalesBonusLbl.Text = "Sales Bonus:";
            // 
            // PrintBttn
            // 
            this.PrintBttn.Location = new System.Drawing.Point(35, 325);
            this.PrintBttn.Name = "PrintBttn";
            this.PrintBttn.Size = new System.Drawing.Size(75, 23);
            this.PrintBttn.TabIndex = 11;
            this.PrintBttn.Text = "Print";
            this.PrintBttn.UseVisualStyleBackColor = true;
            this.PrintBttn.Click += new System.EventHandler(this.PrintBttn_Click);
            // 
            // CalcBttn
            // 
            this.CalcBttn.Location = new System.Drawing.Point(177, 325);
            this.CalcBttn.Name = "CalcBttn";
            this.CalcBttn.Size = new System.Drawing.Size(75, 23);
            this.CalcBttn.TabIndex = 12;
            this.CalcBttn.Text = "Calculate";
            this.CalcBttn.UseVisualStyleBackColor = true;
            this.CalcBttn.Click += new System.EventHandler(this.CalcBttn_Click);
            // 
            // NextBttn
            // 
            this.NextBttn.Location = new System.Drawing.Point(285, 325);
            this.NextBttn.Name = "NextBttn";
            this.NextBttn.Size = new System.Drawing.Size(75, 23);
            this.NextBttn.TabIndex = 13;
            this.NextBttn.Text = "Next";
            this.NextBttn.UseVisualStyleBackColor = true;
            this.NextBttn.Click += new System.EventHandler(this.NextBttn_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.ErrorImage = null;
            this.LogoBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoBox.Image")));
            this.LogoBox.Location = new System.Drawing.Point(12, 12);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(150, 140);
            this.LogoBox.TabIndex = 14;
            this.LogoBox.TabStop = false;
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // SalesBonusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 364);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.NextBttn);
            this.Controls.Add(this.CalcBttn);
            this.Controls.Add(this.PrintBttn);
            this.Controls.Add(this.SalesBonusLbl);
            this.Controls.Add(this.TotalSalesLbl);
            this.Controls.Add(this.HrsWorkedLbl);
            this.Controls.Add(this.EmpIdLbl);
            this.Controls.Add(this.EmpNameLbl);
            this.Controls.Add(this.SalesBonusTxtBox);
            this.Controls.Add(this.TotalSalesTxtBox);
            this.Controls.Add(this.HrsWorkedTxtBox);
            this.Controls.Add(this.EmpIdTxtBox);
            this.Controls.Add(this.EmpNameTxtBox);
            this.Controls.Add(this.LangGbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesBonusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Bonus";
            this.LangGbox.ResumeLayout(false);
            this.LangGbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox LangGbox;
        private System.Windows.Forms.RadioButton FrenchRadioBttn;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.TextBox EmpNameTxtBox;
        private System.Windows.Forms.TextBox EmpIdTxtBox;
        private System.Windows.Forms.TextBox HrsWorkedTxtBox;
        private System.Windows.Forms.TextBox TotalSalesTxtBox;
        private System.Windows.Forms.TextBox SalesBonusTxtBox;
        private System.Windows.Forms.Label EmpNameLbl;
        private System.Windows.Forms.Label EmpIdLbl;
        private System.Windows.Forms.Label HrsWorkedLbl;
        private System.Windows.Forms.Label TotalSalesLbl;
        private System.Windows.Forms.Label SalesBonusLbl;
        private System.Windows.Forms.Button PrintBttn;
        private System.Windows.Forms.Button CalcBttn;
        private System.Windows.Forms.Button NextBttn;
        private System.Windows.Forms.PictureBox LogoBox;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}

