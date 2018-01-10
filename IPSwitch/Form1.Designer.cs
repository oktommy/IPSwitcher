namespace IPSwitch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSwitch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIPInfo = new System.Windows.Forms.Label();
            this.cboNic = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGateway = new System.Windows.Forms.ComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GatewayStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chinaTeleComToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chinaUniComToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(327, 210);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch.TabIndex = 0;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gateway";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIPInfo);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 102);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP Info";
            // 
            // lblIPInfo
            // 
            this.lblIPInfo.AutoSize = true;
            this.lblIPInfo.Location = new System.Drawing.Point(15, 27);
            this.lblIPInfo.Name = "lblIPInfo";
            this.lblIPInfo.Size = new System.Drawing.Size(0, 13);
            this.lblIPInfo.TabIndex = 0;
            // 
            // cboNic
            // 
            this.cboNic.FormattingEnabled = true;
            this.cboNic.Location = new System.Drawing.Point(109, 151);
            this.cboNic.Name = "cboNic";
            this.cboNic.Size = new System.Drawing.Size(191, 21);
            this.cboNic.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NIC";
            // 
            // cboGateway
            // 
            this.cboGateway.FormattingEnabled = true;
            this.cboGateway.Items.AddRange(new object[] {
            "10.169.1.1",
            "10.169.1.2"});
            this.cboGateway.Location = new System.Drawing.Point(109, 210);
            this.cboGateway.Name = "cboGateway";
            this.cboGateway.Size = new System.Drawing.Size(191, 21);
            this.cboGateway.TabIndex = 3;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Switch Gateway";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "IP Switch";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NicToolStripMenuItem,
            this.GatewayStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // GatewayStripMenuItem1
            // 
            this.GatewayStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chinaTeleComToolStripMenuItem,
            this.chinaUniComToolStripMenuItem});
            this.GatewayStripMenuItem1.Name = "GatewayStripMenuItem1";
            this.GatewayStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.GatewayStripMenuItem1.Text = "Gateways";
            // 
            // chinaTeleComToolStripMenuItem
            // 
            this.chinaTeleComToolStripMenuItem.Name = "chinaTeleComToolStripMenuItem";
            this.chinaTeleComToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.chinaTeleComToolStripMenuItem.Text = "China TeleCom";
            // 
            // chinaUniComToolStripMenuItem
            // 
            this.chinaUniComToolStripMenuItem.Name = "chinaUniComToolStripMenuItem";
            this.chinaUniComToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.chinaUniComToolStripMenuItem.Text = "China UniCom";
            // 
            // NicToolStripMenuItem
            // 
            this.NicToolStripMenuItem.Name = "NicToolStripMenuItem";
            this.NicToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.NicToolStripMenuItem.Text = "NIC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 282);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboGateway);
            this.Controls.Add(this.cboNic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSwitch);
            this.Name = "Form1";
            this.Text = "IP Switch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIPInfo;
        private System.Windows.Forms.ComboBox cboNic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboGateway;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GatewayStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chinaTeleComToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chinaUniComToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NicToolStripMenuItem;
    }
}

