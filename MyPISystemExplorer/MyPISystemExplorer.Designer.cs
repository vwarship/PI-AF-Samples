namespace Elements
{
    partial class MyPISystemExplorer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPISystemExplorer));
            this.label = new System.Windows.Forms.Label();
            this.piSystemPicker = new OSIsoft.AF.UI.PISystemPicker();
            this.afTreeView = new OSIsoft.AF.UI.AFTreeView();
            this.afDatabasePicker = new OSIsoft.AF.UI.AFDatabasePicker();
            this.afViewControl = new OSIsoft.AF.UI.AFViewControl();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(15, 15);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(68, 12);
            this.label.TabIndex = 0;
            this.label.Text = "PI System";
            // 
            // piSystemPicker
            // 
            this.piSystemPicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.piSystemPicker.EnableBegin = false;
            this.piSystemPicker.EnableConnect = true;
            this.piSystemPicker.EnableDelete = false;
            this.piSystemPicker.EnableEnd = false;
            this.piSystemPicker.EnableNavigation = false;
            this.piSystemPicker.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.piSystemPicker.Location = new System.Drawing.Point(103, 12);
            this.piSystemPicker.Name = "piSystemPicker";
            this.piSystemPicker.ShowBegin = false;
            this.piSystemPicker.ShowDelete = false;
            this.piSystemPicker.ShowEnd = false;
            this.piSystemPicker.ShowFind = false;
            this.piSystemPicker.ShowNavigation = false;
            this.piSystemPicker.ShowNew = false;
            this.piSystemPicker.ShowNext = false;
            this.piSystemPicker.ShowPrevious = false;
            this.piSystemPicker.Size = new System.Drawing.Size(427, 20);
            this.piSystemPicker.TabIndex = 2;
            // 
            // afTreeView
            // 
            this.afTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.afTreeView.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.afTreeView.HideSelection = false;
            this.afTreeView.Location = new System.Drawing.Point(0, 0);
            this.afTreeView.Name = "afTreeView";
            this.afTreeView.ShowNodeToolTips = true;
            this.afTreeView.Size = new System.Drawing.Size(256, 490);
            this.afTreeView.TabIndex = 3;
            this.afTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.afTreeView_AfterSelect);
            // 
            // afDatabasePicker
            // 
            this.afDatabasePicker.EnableNavigation = false;
            this.afDatabasePicker.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.afDatabasePicker.Location = new System.Drawing.Point(103, 38);
            this.afDatabasePicker.Name = "afDatabasePicker";
            this.afDatabasePicker.ShowBegin = false;
            this.afDatabasePicker.ShowDelete = false;
            this.afDatabasePicker.ShowEnd = false;
            this.afDatabasePicker.ShowFind = false;
            this.afDatabasePicker.ShowNavigation = false;
            this.afDatabasePicker.ShowNew = false;
            this.afDatabasePicker.ShowNext = false;
            this.afDatabasePicker.ShowPrevious = false;
            this.afDatabasePicker.Size = new System.Drawing.Size(427, 20);
            this.afDatabasePicker.TabIndex = 6;
            this.afDatabasePicker.SelectionChange += new OSIsoft.AF.UI.SelectionChangeEventHandler(this.afDatabasePicker_SelectionChange);
            // 
            // afViewControl
            // 
            this.afViewControl.BackColor = System.Drawing.Color.Transparent;
            this.afViewControl.DisplayPathLabel = false;
            this.afViewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.afViewControl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.afViewControl.HelpContext = ((long)(0));
            this.afViewControl.Location = new System.Drawing.Point(0, 0);
            this.afViewControl.Name = "afViewControl";
            this.afViewControl.Size = new System.Drawing.Size(508, 490);
            this.afViewControl.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "AF Database";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 64);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.afTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.afViewControl);
            this.splitContainer1.Size = new System.Drawing.Size(768, 490);
            this.splitContainer1.SplitterDistance = 256;
            this.splitContainer1.TabIndex = 9;
            // 
            // MyPISystemExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.afDatabasePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.piSystemPicker);
            this.Controls.Add(this.label);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyPISystemExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My PI System Explorer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private OSIsoft.AF.UI.PISystemPicker piSystemPicker;
        private OSIsoft.AF.UI.AFTreeView afTreeView;
        private OSIsoft.AF.UI.AFDatabasePicker afDatabasePicker;
        private OSIsoft.AF.UI.AFViewControl afViewControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

