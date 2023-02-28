namespace CustomerPreview.cs
{
    partial class CustomerPreview
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
            linkLabel1 = new LinkLabel();
            txtcustomername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtcountry = new TextBox();
            label3 = new Label();
            txtgender = new TextBox();
            label4 = new Label();
            txthobbies = new TextBox();
            label5 = new Label();
            txtstatus = new TextBox();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(115, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(76, 20);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // txtcustomername
            // 
            txtcustomername.Location = new Point(276, 80);
            txtcustomername.Multiline = true;
            txtcustomername.Name = "txtcustomername";
            txtcustomername.Size = new Size(228, 33);
            txtcustomername.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(57, 80);
            label1.Name = "label1";
            label1.Size = new Size(190, 33);
            label1.TabIndex = 5;
            label1.Text = "Customer Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(57, 142);
            label2.Name = "label2";
            label2.Size = new Size(96, 33);
            label2.TabIndex = 7;
            label2.Text = "Country";
            label2.Click += label2_Click;
            // 
            // txtcountry
            // 
            txtcountry.Location = new Point(276, 142);
            txtcountry.Multiline = true;
            txtcountry.Name = "txtcountry";
            txtcountry.Size = new Size(228, 33);
            txtcountry.TabIndex = 6;
            txtcountry.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(57, 212);
            label3.Name = "label3";
            label3.Size = new Size(93, 33);
            label3.TabIndex = 9;
            label3.Text = "Gender";
            // 
            // txtgender
            // 
            txtgender.Location = new Point(276, 212);
            txtgender.Multiline = true;
            txtgender.Name = "txtgender";
            txtgender.Size = new Size(228, 33);
            txtgender.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(57, 282);
            label4.Name = "label4";
            label4.Size = new Size(99, 33);
            label4.TabIndex = 11;
            label4.Text = "Hobbies";
            // 
            // txthobbies
            // 
            txthobbies.Location = new Point(276, 282);
            txthobbies.Multiline = true;
            txthobbies.Name = "txthobbies";
            txthobbies.Size = new Size(228, 33);
            txthobbies.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(57, 347);
            label5.Name = "label5";
            label5.Size = new Size(78, 33);
            label5.TabIndex = 13;
            label5.Text = "Status";
            label5.Click += label5_Click;
            // 
            // txtstatus
            // 
            txtstatus.Location = new Point(276, 347);
            txtstatus.Multiline = true;
            txtstatus.Name = "txtstatus";
            txtstatus.Size = new Size(228, 33);
            txtstatus.TabIndex = 12;
            // 
            // CustomerPreview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txtstatus);
            Controls.Add(label4);
            Controls.Add(txthobbies);
            Controls.Add(label3);
            Controls.Add(txtgender);
            Controls.Add(label2);
            Controls.Add(txtcountry);
            Controls.Add(label1);
            Controls.Add(txtcustomername);
            Controls.Add(linkLabel1);
            Name = "CustomerPreview";
            Text = "CustomerPreview";
            Load += CustomerPreview_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private TextBox txtcustomername;
        private Label label1;
        private Label label2;
        private TextBox txtcountry;
        private Label label3;
        private TextBox txtgender;
        private Label label4;
        private TextBox txthobbies;
        private Label label5;
        private TextBox txtstatus;
    }
}