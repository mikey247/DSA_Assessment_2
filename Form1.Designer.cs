namespace Assessed_Exercise_2_Solution
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.countBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customerBox = new System.Windows.Forms.ListBox();
            this.inOrderButton = new System.Windows.Forms.Button();
            this.preOrderButton = new System.Windows.Forms.Button();
            this.postOrderButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(104, 261);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(109, 23);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add Customer";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(80, 53);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(148, 20);
            this.ageBox.TabIndex = 15;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(80, 17);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(148, 20);
            this.nameBox.TabIndex = 14;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(80, 94);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(148, 103);
            this.addressBox.TabIndex = 16;
            this.addressBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Amount Owed";
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(85, 226);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(142, 20);
            this.amountBox.TabIndex = 17;
            // 
            // countBox
            // 
            this.countBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countBox.Location = new System.Drawing.Point(273, 35);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(123, 108);
            this.countBox.TabIndex = 23;
            this.countBox.Text = "";
            this.countBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Number of Items";
            // 
            // customerBox
            // 
            this.customerBox.FormattingEnabled = true;
            this.customerBox.Location = new System.Drawing.Point(428, 32);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(360, 134);
            this.customerBox.TabIndex = 25;
            // 
            // inOrderButton
            // 
            this.inOrderButton.Location = new System.Drawing.Point(445, 172);
            this.inOrderButton.Name = "inOrderButton";
            this.inOrderButton.Size = new System.Drawing.Size(89, 26);
            this.inOrderButton.TabIndex = 26;
            this.inOrderButton.Text = "in order";
            this.inOrderButton.UseVisualStyleBackColor = true;
            this.inOrderButton.Click += new System.EventHandler(this.inOrderButton_Click);
            // 
            // preOrderButton
            // 
            this.preOrderButton.Location = new System.Drawing.Point(555, 172);
            this.preOrderButton.Name = "preOrderButton";
            this.preOrderButton.Size = new System.Drawing.Size(99, 25);
            this.preOrderButton.TabIndex = 27;
            this.preOrderButton.Text = "pre order";
            this.preOrderButton.UseVisualStyleBackColor = true;
            this.preOrderButton.Click += new System.EventHandler(this.preOrderButton_Click);
            // 
            // postOrderButton
            // 
            this.postOrderButton.Location = new System.Drawing.Point(673, 172);
            this.postOrderButton.Name = "postOrderButton";
            this.postOrderButton.Size = new System.Drawing.Size(99, 25);
            this.postOrderButton.TabIndex = 28;
            this.postOrderButton.Text = "post order";
            this.postOrderButton.UseVisualStyleBackColor = true;
            this.postOrderButton.Click += new System.EventHandler(this.postOrderButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(565, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Customer List";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(458, 375);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(90, 21);
            this.searchButton.TabIndex = 30;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(326, 375);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(120, 20);
            this.searchTextBox.TabIndex = 31;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(326, 413);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(222, 70);
            this.resultTextBox.TabIndex = 32;
            this.resultTextBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Enter Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 547);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.postOrderButton);
            this.Controls.Add(this.preOrderButton);
            this.Controls.Add(this.inOrderButton);
            this.Controls.Add(this.customerBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.nameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.RichTextBox addressBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.RichTextBox countBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox customerBox;
        private System.Windows.Forms.Button inOrderButton;
        private System.Windows.Forms.Button preOrderButton;
        private System.Windows.Forms.Button postOrderButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

