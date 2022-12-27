using System.Drawing;

namespace SupplyManager
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.supply_name = new System.Windows.Forms.Label();
            this.supply_link = new System.Windows.Forms.Label();
            this.supply_email = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radColorBox1 = new Telerik.WinControls.UI.RadColorBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.gridRefresh = new System.Windows.Forms.Button();
            this.save_supply = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.add_new_supply = new System.Windows.Forms.Button();
            this.setResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firebaseClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radColorBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setResponseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firebaseClientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 0;
            // 
            // supply_name
            // 
            this.supply_name.AutoSize = true;
            this.supply_name.Location = new System.Drawing.Point(243, 65);
            this.supply_name.Name = "supply_name";
            this.supply_name.Size = new System.Drawing.Size(94, 13);
            this.supply_name.TabIndex = 1;
            this.supply_name.Text = "Имя поставщика";
            // 
            // supply_link
            // 
            this.supply_link.AutoSize = true;
            this.supply_link.Location = new System.Drawing.Point(242, 15);
            this.supply_link.Name = "supply_link";
            this.supply_link.Size = new System.Drawing.Size(126, 13);
            this.supply_link.TabIndex = 2;
            this.supply_link.Text = "Ccылка на поставщика";
            this.supply_link.Click += new System.EventHandler(this.supply_link_Click);
            // 
            // supply_email
            // 
            this.supply_email.AutoSize = true;
            this.supply_email.Location = new System.Drawing.Point(9, 65);
            this.supply_email.Name = "supply_email";
            this.supply_email.Size = new System.Drawing.Size(34, 13);
            this.supply_email.TabIndex = 3;
            this.supply_email.Text = "e-mail";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(246, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // radColorBox1
            // 
            this.radColorBox1.Location = new System.Drawing.Point(110, 28);
            this.radColorBox1.Name = "radColorBox1";
            this.radColorBox1.Size = new System.Drawing.Size(67, 20);
            this.radColorBox1.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 28);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(80, 20);
            this.textBox4.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "№ поставщика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Маркер";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(506, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(563, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 25;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 105;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Link";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Color";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 105;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Orders";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 25;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(535, 175);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(48, 29);
            this.textBox5.TabIndex = 26;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(10, 112);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(45, 92);
            this.trackBar1.TabIndex = 27;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "ID:";
            // 
            // gridRefresh
            // 
            this.gridRefresh.BackgroundImage = global::SupplyManager.Properties.Resources.icons8_обновить_64;
            this.gridRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gridRefresh.Location = new System.Drawing.Point(431, 119);
            this.gridRefresh.Name = "gridRefresh";
            this.gridRefresh.Size = new System.Drawing.Size(45, 45);
            this.gridRefresh.TabIndex = 24;
            this.gridRefresh.UseVisualStyleBackColor = true;
            this.gridRefresh.Click += new System.EventHandler(this.gridRefresh_Click);
            // 
            // save_supply
            // 
            this.save_supply.BackgroundImage = global::SupplyManager.Properties.Resources.icons8_поиск_64;
            this.save_supply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.save_supply.Location = new System.Drawing.Point(589, 175);
            this.save_supply.Name = "save_supply";
            this.save_supply.Size = new System.Drawing.Size(29, 29);
            this.save_supply.TabIndex = 14;
            this.save_supply.UseVisualStyleBackColor = true;
            this.save_supply.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.BackgroundImage = global::SupplyManager.Properties.Resources.icons8_удалить_навсегда_48;
            this.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Delete.Location = new System.Drawing.Point(431, 14);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(45, 45);
            this.Delete.TabIndex = 9;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // add_new_supply
            // 
            this.add_new_supply.BackgroundImage = global::SupplyManager.Properties.Resources.icons8_плюс_2_30;
            this.add_new_supply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_new_supply.Location = new System.Drawing.Point(431, 68);
            this.add_new_supply.Name = "add_new_supply";
            this.add_new_supply.Size = new System.Drawing.Size(45, 45);
            this.add_new_supply.TabIndex = 6;
            this.add_new_supply.UseVisualStyleBackColor = true;
            this.add_new_supply.Click += new System.EventHandler(this.add_new_supply_Click);
            // 
            // setResponseBindingSource
            // 
            this.setResponseBindingSource.DataSource = typeof(FireSharp.Response.SetResponse);
            // 
            // supplyBindingSource
            // 
            this.supplyBindingSource.CurrentChanged += new System.EventHandler(this.supplyBindingSource_CurrentChanged);
            // 
            // firebaseClientBindingSource
            // 
            this.firebaseClientBindingSource.DataSource = typeof(FireSharp.FirebaseClient);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(33, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 75);
            this.label4.TabIndex = 29;
            this.label4.Text = "Поставка по запросу\r\nПоставка раз в месяц\r\nПоставка через день\r\nПоставка каждый д" +
    "ень\r\nПоставка по понедельникам\r\n";
            // 
            // supply_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 222);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.gridRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.radColorBox1);
            this.Controls.Add(this.save_supply);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.add_new_supply);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.supply_email);
            this.Controls.Add(this.supply_link);
            this.Controls.Add(this.supply_name);
            this.Controls.Add(this.textBox1);
            this.Name = "supply_add";
            this.Text = "supply_add";
            this.Load += new System.EventHandler(this.supply_add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radColorBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setResponseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firebaseClientBindingSource)).EndInit();
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
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button save_supply;
        private Telerik.WinControls.UI.RadColorBox radColorBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.BindingSource setResponseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource supplyBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource firebaseClientBindingSource;
        private System.Windows.Forms.Button gridRefresh;
        public System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}