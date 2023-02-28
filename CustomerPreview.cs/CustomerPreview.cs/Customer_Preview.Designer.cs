namespace CustomerPreview.cs
{
    partial class Customer_Preview
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            txtcustomername = new TextBox();
            rdbmale = new RadioButton();
            groupBox1 = new GroupBox();
            rdbfemale = new RadioButton();
            label1 = new Label();
            cbreading = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            cbeating = new CheckBox();
            groupBox2 = new GroupBox();
            rdbmarried = new RadioButton();
            rdbsingle = new RadioButton();
            btnpreview = new Button();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Philippines", "Japan", "Thailand", "Korea", "China" });
            comboBox1.Location = new Point(331, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 28);
            comboBox1.TabIndex = 0;
            // 
            // txtcustomername
            // 
            txtcustomername.Location = new Point(331, 26);
            txtcustomername.Multiline = true;
            txtcustomername.Name = "txtcustomername";
            txtcustomername.Size = new Size(228, 33);
            txtcustomername.TabIndex = 1;
            // 
            // rdbmale
            // 
            rdbmale.AutoSize = true;
            rdbmale.Location = new Point(39, 47);
            rdbmale.Name = "rdbmale";
            rdbmale.Size = new Size(84, 37);
            rdbmale.TabIndex = 2;
            rdbmale.TabStop = true;
            rdbmale.Text = "Male";
            rdbmale.UseVisualStyleBackColor = true;
            rdbmale.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(rdbfemale);
            groupBox1.Controls.Add(rdbmale);
            groupBox1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(96, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 125);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender";
            // 
            // rdbfemale
            // 
            rdbfemale.AutoSize = true;
            rdbfemale.Location = new Point(185, 47);
            rdbfemale.Name = "rdbfemale";
            rdbfemale.Size = new Size(112, 37);
            rdbfemale.TabIndex = 3;
            rdbfemale.TabStop = true;
            rdbfemale.Text = "Female";
            rdbfemale.UseVisualStyleBackColor = true;
            rdbfemale.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(96, 26);
            label1.Name = "label1";
            label1.Size = new Size(190, 33);
            label1.TabIndex = 4;
            label1.Text = "Customer Name:";
            label1.Click += label1_Click;
            // 
            // cbreading
            // 
            cbreading.AutoSize = true;
            cbreading.BackColor = Color.Silver;
            cbreading.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbreading.Location = new Point(207, 277);
            cbreading.Name = "cbreading";
            cbreading.Size = new Size(121, 37);
            cbreading.TabIndex = 5;
            cbreading.Text = "Reading";
            cbreading.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(96, 71);
            label3.Name = "label3";
            label3.Size = new Size(102, 33);
            label3.TabIndex = 7;
            label3.Text = "Country:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(96, 277);
            label2.Name = "label2";
            label2.Size = new Size(105, 33);
            label2.TabIndex = 8;
            label2.Text = "Hobbies:";
            label2.Click += label2_Click;
            // 
            // cbeating
            // 
            cbeating.AutoSize = true;
            cbeating.BackColor = Color.Silver;
            cbeating.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbeating.Location = new Point(350, 277);
            cbeating.Name = "cbeating";
            cbeating.Size = new Size(99, 37);
            cbeating.TabIndex = 9;
            cbeating.Text = "Eating";
            cbeating.UseVisualStyleBackColor = false;
            cbeating.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Silver;
            groupBox2.Controls.Add(rdbmarried);
            groupBox2.Controls.Add(rdbsingle);
            groupBox2.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(96, 359);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 125);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Status";
            // 
            // rdbmarried
            // 
            rdbmarried.AutoSize = true;
            rdbmarried.Location = new Point(185, 47);
            rdbmarried.Name = "rdbmarried";
            rdbmarried.Size = new Size(113, 37);
            rdbmarried.TabIndex = 3;
            rdbmarried.TabStop = true;
            rdbmarried.Text = "Married";
            rdbmarried.UseVisualStyleBackColor = true;
            // 
            // rdbsingle
            // 
            rdbsingle.AutoSize = true;
            rdbsingle.Location = new Point(39, 47);
            rdbsingle.Name = "rdbsingle";
            rdbsingle.Size = new Size(97, 37);
            rdbsingle.TabIndex = 2;
            rdbsingle.TabStop = true;
            rdbsingle.Text = "Single";
            rdbsingle.UseVisualStyleBackColor = true;
            // 
            // btnpreview
            // 
            btnpreview.BackColor = SystemColors.ActiveBorder;
            btnpreview.Location = new Point(705, 211);
            btnpreview.Name = "btnpreview";
            btnpreview.Size = new Size(157, 64);
            btnpreview.TabIndex = 10;
            btnpreview.Text = "Preview";
            btnpreview.UseVisualStyleBackColor = false;
            btnpreview.Click += btnpreview_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(74, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 483);
            panel1.TabIndex = 11;
            // 
            // Customer_Preview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 507);
            Controls.Add(btnpreview);
            Controls.Add(groupBox2);
            Controls.Add(cbeating);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(cbreading);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(txtcustomername);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Name = "Customer_Preview";
            Text = "Customer Data Entry";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox txtcustomername;
        private RadioButton rdbmale;
        private GroupBox groupBox1;
        private Label label1;
        private CheckBox cbreading;
        private Label label3;
        private RadioButton rdbfemale;
        private Label label2;
        private CheckBox cbeating;
        private GroupBox groupBox2;
        private RadioButton rdbmarried;
        private RadioButton rdbsingle;
        private Button btnpreview;
        private Panel panel1;
    }
}