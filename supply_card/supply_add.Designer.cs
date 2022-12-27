namespace supply_card
{
    partial class supply_add
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.supply_name = new System.Windows.Forms.Label();
            this.supply_link = new System.Windows.Forms.Label();
            this.supply_email = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.add_new_supply = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // supply_name
            // 
            this.supply_name.AutoSize = true;
            this.supply_name.Location = new System.Drawing.Point(13, 13);
            this.supply_name.Name = "supply_name";
            this.supply_name.Size = new System.Drawing.Size(94, 13);
            this.supply_name.TabIndex = 1;
            this.supply_name.Text = "Имя поставщика";
            // 
            // supply_link
            // 
            this.supply_link.AutoSize = true;
            this.supply_link.Location = new System.Drawing.Point(13, 75);
            this.supply_link.Name = "supply_link";
            this.supply_link.Size = new System.Drawing.Size(126, 13);
            this.supply_link.TabIndex = 2;
            this.supply_link.Text = "Ccылка на поставщика";
            this.supply_link.Click += new System.EventHandler(this.supply_link_Click);
            // 
            // supply_email
            // 
            this.supply_email.AutoSize = true;
            this.supply_email.Location = new System.Drawing.Point(13, 142);
            this.supply_email.Name = "supply_email";
            this.supply_email.Size = new System.Drawing.Size(34, 13);
            this.supply_email.TabIndex = 3;
            this.supply_email.Text = "e-mail";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(39, 173);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // add_new_supply
            // 
            this.add_new_supply.Location = new System.Drawing.Point(16, 210);
            this.add_new_supply.Name = "add_new_supply";
            this.add_new_supply.Size = new System.Drawing.Size(75, 23);
            this.add_new_supply.TabIndex = 6;
            this.add_new_supply.Text = "button1";
            this.add_new_supply.UseVisualStyleBackColor = true;
            this.add_new_supply.Click += new System.EventHandler(this.add_new_supply_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(53, 252);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 82);
            this.listBox1.TabIndex = 7;
            // 
            // supply_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 245);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.add_new_supply);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.supply_email);
            this.Controls.Add(this.supply_link);
            this.Controls.Add(this.supply_name);
            this.Controls.Add(this.textBox1);
            this.Name = "supply_add";
            this.Text = "supply_add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label supply_name;
        private System.Windows.Forms.Label supply_link;
        private System.Windows.Forms.Label supply_email;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button add_new_supply;
        private System.Windows.Forms.ListBox listBox1;
    }
}