namespace Recepta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.peselBox = new System.Windows.Forms.TextBox();
            this.prescriptionBox = new System.Windows.Forms.TextBox();
            this.medicamentsBox = new System.Windows.Forms.TextBox();
            this.viewBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.NFZBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.diseaseBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rightsBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wiek:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pesel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nr recepty:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Leki:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(105, 24);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(157, 20);
            this.nameBox.TabIndex = 6;
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(353, 24);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(157, 20);
            this.surnameBox.TabIndex = 7;
            this.surnameBox.Leave += new System.EventHandler(this.surnameBox_Leave);
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(105, 60);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(157, 20);
            this.ageBox.TabIndex = 8;
            this.ageBox.Leave += new System.EventHandler(this.ageBox_Leave);
            // 
            // peselBox
            // 
            this.peselBox.Location = new System.Drawing.Point(353, 60);
            this.peselBox.Name = "peselBox";
            this.peselBox.Size = new System.Drawing.Size(157, 20);
            this.peselBox.TabIndex = 9;
            this.peselBox.Leave += new System.EventHandler(this.peselBox_Leave);
            // 
            // prescriptionBox
            // 
            this.prescriptionBox.Location = new System.Drawing.Point(105, 99);
            this.prescriptionBox.Name = "prescriptionBox";
            this.prescriptionBox.Size = new System.Drawing.Size(157, 20);
            this.prescriptionBox.TabIndex = 10;
            this.prescriptionBox.Leave += new System.EventHandler(this.prescriptionBox_Leave);
            // 
            // medicamentsBox
            // 
            this.medicamentsBox.Location = new System.Drawing.Point(353, 99);
            this.medicamentsBox.Multiline = true;
            this.medicamentsBox.Name = "medicamentsBox";
            this.medicamentsBox.Size = new System.Drawing.Size(157, 94);
            this.medicamentsBox.TabIndex = 11;
            this.medicamentsBox.Leave += new System.EventHandler(this.medicamentsBox_Leave);
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(30, 367);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(100, 26);
            this.viewBtn.TabIndex = 12;
            this.viewBtn.Text = "Podgląd";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(136, 367);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(100, 26);
            this.printBtn.TabIndex = 13;
            this.printBtn.Text = "Drukuj";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // NFZBox
            // 
            this.NFZBox.FormattingEnabled = true;
            this.NFZBox.Items.AddRange(new object[] {
            "",
            "01 Dolnośląski NFZ",
            "02 Kujawsko-Pomorski NFZ",
            "03 Lubelski NFZ",
            "04 Lubuski NFZ",
            "05 Łódzki NFZ",
            "06 Małopolski NFZ",
            "07 Mazowiecki NFZ",
            "08 Opolski NFZ",
            "09 Podkarpacki FZ",
            "10 Podlaski NFZ",
            "11 Pomorski NFZ",
            "12 Śląski NFZ",
            "13 Świętokrzyski NFZ",
            "14 Warmińsko-Mazurski NFZ",
            "15 Wielkopolski NFZ",
            "16 Zachodniopomorski NFZ"});
            this.NFZBox.Location = new System.Drawing.Point(105, 133);
            this.NFZBox.Name = "NFZBox";
            this.NFZBox.Size = new System.Drawing.Size(157, 21);
            this.NFZBox.TabIndex = 16;
            this.NFZBox.Text = "01 Dolnośląski NFZ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Oddział NFZ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Choroby przewlekłe:";
            // 
            // diseaseBox
            // 
            this.diseaseBox.FormattingEnabled = true;
            this.diseaseBox.Items.AddRange(new object[] {
            "P"});
            this.diseaseBox.Location = new System.Drawing.Point(137, 172);
            this.diseaseBox.Name = "diseaseBox";
            this.diseaseBox.Size = new System.Drawing.Size(125, 21);
            this.diseaseBox.TabIndex = 18;
            this.diseaseBox.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Uprawnienia:";
            // 
            // rightsBox
            // 
            this.rightsBox.FormattingEnabled = true;
            this.rightsBox.Items.AddRange(new object[] {
            "AZ",
            "BW",
            "CN",
            "DN",
            "IB",
            "IW",
            "PO",
            "IN",
            "WP",
            "ZK"});
            this.rightsBox.Location = new System.Drawing.Point(105, 210);
            this.rightsBox.Name = "rightsBox";
            this.rightsBox.Size = new System.Drawing.Size(157, 21);
            this.rightsBox.TabIndex = 20;
            this.rightsBox.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 405);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rightsBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.diseaseBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NFZBox);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.medicamentsBox);
            this.Controls.Add(this.prescriptionBox);
            this.Controls.Add(this.peselBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox peselBox;
        private System.Windows.Forms.TextBox prescriptionBox;
        private System.Windows.Forms.TextBox medicamentsBox;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox NFZBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox diseaseBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox rightsBox;
    }
}

