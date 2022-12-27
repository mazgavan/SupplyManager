namespace SupplyManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.add_supply = new Telerik.WinControls.UI.RadButton();
            this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            this.tempStreamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supply_card4 = new SupplyManager.supply_card();
            this.supply_card3 = new SupplyManager.supply_card();
            this.supply_card2 = new SupplyManager.supply_card();
            this.supply_card1 = new SupplyManager.supply_card();
            ((System.ComponentModel.ISupportInitialize)(this.add_supply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempStreamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // add_supply
            // 
            this.add_supply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add_supply.Location = new System.Drawing.Point(13, 619);
            this.add_supply.Name = "add_supply";
            this.add_supply.Size = new System.Drawing.Size(274, 24);
            this.add_supply.TabIndex = 0;
            this.add_supply.Text = "Редактор поставщиков";
            this.add_supply.Click += new System.EventHandler(this.add_supply_Click);
            // 
            // radCalendar1
            // 
            this.radCalendar1.AllowFishEye = true;
            this.radCalendar1.AllowMultipleSelect = true;
            this.radCalendar1.AllowMultipleView = true;
            this.radCalendar1.AllowRowHeaderSelectors = true;
            this.radCalendar1.AllowViewSelector = true;
            this.radCalendar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radCalendar1.HeaderHeight = 28;
            this.radCalendar1.HeaderWidth = 28;
            this.radCalendar1.Location = new System.Drawing.Point(310, 0);
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.Size = new System.Drawing.Size(628, 655);
            this.radCalendar1.TabIndex = 0;
            this.radCalendar1.ThemeName = "Fluent";
            this.radCalendar1.SelectionChanged += new System.EventHandler(this.radCalendar1_SelectionChanged);
            // 
            // tempStreamBindingSource
            // 
            this.tempStreamBindingSource.DataSource = typeof(LiteDB.Engine.TempStream);
            // 
            // supply_card4
            // 
            this.supply_card4.BackColor = System.Drawing.Color.LightBlue;
            this.supply_card4.Location = new System.Drawing.Point(13, 463);
            this.supply_card4.Name = "supply_card4";
            this.supply_card4.Size = new System.Drawing.Size(274, 133);
            this.supply_card4.TabIndex = 6;
            this.supply_card4.Visible = false;
            this.supply_card4.Click += new System.EventHandler(this.supply_order4_Click);
            // 
            // supply_card3
            // 
            this.supply_card3.BackColor = System.Drawing.Color.LightBlue;
            this.supply_card3.Location = new System.Drawing.Point(13, 313);
            this.supply_card3.Name = "supply_card3";
            this.supply_card3.Size = new System.Drawing.Size(274, 133);
            this.supply_card3.TabIndex = 5;
            this.supply_card3.Visible = false;
            this.supply_card3.Click += new System.EventHandler(this.supply_order3_Click);
            // 
            // supply_card2
            // 
            this.supply_card2.BackColor = System.Drawing.Color.LightBlue;
            this.supply_card2.Location = new System.Drawing.Point(13, 162);
            this.supply_card2.Name = "supply_card2";
            this.supply_card2.Size = new System.Drawing.Size(274, 133);
            this.supply_card2.TabIndex = 4;
            this.supply_card2.Visible = false;
            this.supply_card2.Load += new System.EventHandler(this.supply_card2_Load);
            this.supply_card2.Click += new System.EventHandler(this.supply_order2_Click);
            // 
            // supply_card1
            // 
            this.supply_card1.BackColor = System.Drawing.Color.LightBlue;
            this.supply_card1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supply_card1.Location = new System.Drawing.Point(13, 13);
            this.supply_card1.Name = "supply_card1";
            this.supply_card1.Size = new System.Drawing.Size(274, 133);
            this.supply_card1.TabIndex = 3;
            this.supply_card1.Visible = false;
            this.supply_card1.Load += new System.EventHandler(this.supply_card1_Load);
            this.supply_card1.Click += new System.EventHandler(this.supply_order1_Click);
            this.supply_card1.DoubleClick += new System.EventHandler(this.supply_card1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 655);
            this.Controls.Add(this.supply_card4);
            this.Controls.Add(this.supply_card3);
            this.Controls.Add(this.supply_card2);
            this.Controls.Add(this.supply_card1);
            this.Controls.Add(this.radCalendar1);
            this.Controls.Add(this.add_supply);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.add_supply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempStreamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadButton add_supply;
        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private System.Windows.Forms.BindingSource tempStreamBindingSource;
        public supply_card supply_card1;
        public supply_card supply_card2;
        public supply_card supply_card3;
        public supply_card supply_card4;
    }
}

