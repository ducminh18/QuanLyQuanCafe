
namespace QuanLyQuanCF
{
    partial class fTableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.nmAddFood = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new DevComponents.DotNetBar.ButtonX();
            this.cmxFood = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxCategory = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.cbxSwitchTable = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnxSwitchTable = new DevComponents.DotNetBar.ButtonX();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnxDiscount = new DevComponents.DotNetBar.ButtonX();
            this.btnxCheckOut = new DevComponents.DotNetBar.ButtonX();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.lsvxBill = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.menuStrip1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAddFood)).BeginInit();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.panelEx3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1314, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(13, 32);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(736, 691);
            this.flpTable.TabIndex = 5;
            // 
            // panelEx1
            // 
            this.panelEx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.nmAddFood);
            this.panelEx1.Controls.Add(this.btnAddFood);
            this.panelEx1.Controls.Add(this.cmxFood);
            this.panelEx1.Controls.Add(this.cbxCategory);
            this.panelEx1.Location = new System.Drawing.Point(755, 32);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(547, 76);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 6;
            // 
            // nmAddFood
            // 
            this.nmAddFood.Location = new System.Drawing.Point(486, 30);
            this.nmAddFood.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmAddFood.Name = "nmAddFood";
            this.nmAddFood.Size = new System.Drawing.Size(54, 22);
            this.nmAddFood.TabIndex = 7;
            this.nmAddFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmAddFood.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddFood
            // 
            this.btnAddFood.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddFood.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Location = new System.Drawing.Point(321, 7);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(159, 63);
            this.btnAddFood.TabIndex = 6;
            this.btnAddFood.Text = "THÊM MÓN";
            // 
            // cmxFood
            // 
            this.cmxFood.DisplayMember = "Text";
            this.cmxFood.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmxFood.FormattingEnabled = true;
            this.cmxFood.Location = new System.Drawing.Point(6, 47);
            this.cmxFood.Name = "cmxFood";
            this.cmxFood.Size = new System.Drawing.Size(309, 23);
            this.cmxFood.TabIndex = 5;
            // 
            // cbxCategory
            // 
            this.cbxCategory.DisplayMember = "Text";
            this.cbxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(6, 7);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(309, 23);
            this.cbxCategory.TabIndex = 4;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.Controls.Add(this.cbxSwitchTable);
            this.panelEx2.Controls.Add(this.btnxSwitchTable);
            this.panelEx2.Controls.Add(this.nmDiscount);
            this.panelEx2.Controls.Add(this.btnxDiscount);
            this.panelEx2.Controls.Add(this.btnxCheckOut);
            this.panelEx2.Location = new System.Drawing.Point(756, 648);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(546, 75);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 7;
            // 
            // cbxSwitchTable
            // 
            this.cbxSwitchTable.DisplayMember = "Text";
            this.cbxSwitchTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxSwitchTable.FormattingEnabled = true;
            this.cbxSwitchTable.Location = new System.Drawing.Point(6, 44);
            this.cbxSwitchTable.Name = "cbxSwitchTable";
            this.cbxSwitchTable.Size = new System.Drawing.Size(191, 23);
            this.cbxSwitchTable.TabIndex = 12;
            // 
            // btnxSwitchTable
            // 
            this.btnxSwitchTable.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxSwitchTable.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxSwitchTable.Location = new System.Drawing.Point(6, 6);
            this.btnxSwitchTable.Name = "btnxSwitchTable";
            this.btnxSwitchTable.Size = new System.Drawing.Size(191, 32);
            this.btnxSwitchTable.TabIndex = 11;
            this.btnxSwitchTable.Text = "CHUYỂN BÀN";
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(203, 44);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(172, 22);
            this.nmDiscount.TabIndex = 10;
            this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnxDiscount
            // 
            this.btnxDiscount.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxDiscount.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxDiscount.Location = new System.Drawing.Point(203, 6);
            this.btnxDiscount.Name = "btnxDiscount";
            this.btnxDiscount.Size = new System.Drawing.Size(172, 32);
            this.btnxDiscount.TabIndex = 9;
            this.btnxDiscount.Text = "GIẢM GIÁ";
            // 
            // btnxCheckOut
            // 
            this.btnxCheckOut.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxCheckOut.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxCheckOut.Location = new System.Drawing.Point(381, 6);
            this.btnxCheckOut.Name = "btnxCheckOut";
            this.btnxCheckOut.Size = new System.Drawing.Size(159, 63);
            this.btnxCheckOut.TabIndex = 8;
            this.btnxCheckOut.Text = "THANH TOÁN";
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.Controls.Add(this.lsvxBill);
            this.panelEx3.Location = new System.Drawing.Point(755, 115);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(547, 527);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 8;
            // 
            // lsvxBill
            // 
            // 
            // 
            // 
            this.lsvxBill.Border.Class = "ListViewBorder";
            this.lsvxBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvxBill.Location = new System.Drawing.Point(0, 0);
            this.lsvxBill.Name = "lsvxBill";
            this.lsvxBill.Size = new System.Drawing.Size(547, 527);
            this.lsvxBill.TabIndex = 1;
            this.lsvxBill.UseCompatibleStateImageBehavior = false;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 735);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ QUÁN CAFE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmAddFood)).EndInit();
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.panelEx3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.NumericUpDown nmAddFood;
        private DevComponents.DotNetBar.ButtonX btnAddFood;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmxFood;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxCategory;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxSwitchTable;
        private DevComponents.DotNetBar.ButtonX btnxSwitchTable;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private DevComponents.DotNetBar.ButtonX btnxDiscount;
        private DevComponents.DotNetBar.ButtonX btnxCheckOut;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.Controls.ListViewEx lsvxBill;
    }
}