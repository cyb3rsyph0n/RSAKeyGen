namespace RSAKeyGen
{
    partial class frmMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKeySize = new System.Windows.Forms.Label();
            this.lstKeySize = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grpPrivate = new System.Windows.Forms.GroupBox();
            this.txtPrivate = new System.Windows.Forms.RichTextBox();
            this.grpPublic = new System.Windows.Forms.GroupBox();
            this.txtPublic = new System.Windows.Forms.RichTextBox();
            this.grpTest = new System.Windows.Forms.GroupBox();
            this.txtTest = new System.Windows.Forms.RichTextBox();
            this.txtSample = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressWorker = new System.Windows.Forms.ToolStripProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.grpPrivate.SuspendLayout();
            this.grpPublic.SuspendLayout();
            this.grpTest.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 703);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblKeySize);
            this.panel1.Controls.Add(this.lstKeySize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 28);
            this.panel1.TabIndex = 1;
            // 
            // lblKeySize
            // 
            this.lblKeySize.AutoSize = true;
            this.lblKeySize.Location = new System.Drawing.Point(9, 6);
            this.lblKeySize.Name = "lblKeySize";
            this.lblKeySize.Size = new System.Drawing.Size(48, 13);
            this.lblKeySize.TabIndex = 4;
            this.lblKeySize.Text = "Key Size";
            // 
            // lstKeySize
            // 
            this.lstKeySize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstKeySize.FormattingEnabled = true;
            this.lstKeySize.Items.AddRange(new object[] {
            "1024",
            "2048",
            "4096",
            "8192",
            "16384"});
            this.lstKeySize.Location = new System.Drawing.Point(63, 3);
            this.lstKeySize.Name = "lstKeySize";
            this.lstKeySize.Size = new System.Drawing.Size(154, 21);
            this.lstKeySize.TabIndex = 3;
            this.lstKeySize.SelectedIndexChanged += new System.EventHandler(this.lstKeySize_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 37);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpTest);
            this.splitContainer1.Size = new System.Drawing.Size(754, 663);
            this.splitContainer1.SplitterDistance = 463;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grpPrivate);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grpPublic);
            this.splitContainer2.Size = new System.Drawing.Size(754, 463);
            this.splitContainer2.SplitterDistance = 210;
            this.splitContainer2.TabIndex = 1;
            // 
            // grpPrivate
            // 
            this.grpPrivate.Controls.Add(this.txtPrivate);
            this.grpPrivate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPrivate.Location = new System.Drawing.Point(0, 0);
            this.grpPrivate.Name = "grpPrivate";
            this.grpPrivate.Size = new System.Drawing.Size(754, 210);
            this.grpPrivate.TabIndex = 3;
            this.grpPrivate.TabStop = false;
            this.grpPrivate.Text = "Private Key";
            // 
            // txtPrivate
            // 
            this.txtPrivate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrivate.Location = new System.Drawing.Point(3, 16);
            this.txtPrivate.Name = "txtPrivate";
            this.txtPrivate.ReadOnly = true;
            this.txtPrivate.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtPrivate.Size = new System.Drawing.Size(748, 191);
            this.txtPrivate.TabIndex = 1;
            this.txtPrivate.Text = "";
            // 
            // grpPublic
            // 
            this.grpPublic.Controls.Add(this.txtPublic);
            this.grpPublic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPublic.Location = new System.Drawing.Point(0, 0);
            this.grpPublic.Name = "grpPublic";
            this.grpPublic.Size = new System.Drawing.Size(754, 249);
            this.grpPublic.TabIndex = 2;
            this.grpPublic.TabStop = false;
            this.grpPublic.Text = "Public Key";
            // 
            // txtPublic
            // 
            this.txtPublic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPublic.Location = new System.Drawing.Point(3, 16);
            this.txtPublic.Name = "txtPublic";
            this.txtPublic.ReadOnly = true;
            this.txtPublic.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtPublic.Size = new System.Drawing.Size(748, 230);
            this.txtPublic.TabIndex = 0;
            this.txtPublic.Text = "";
            // 
            // grpTest
            // 
            this.grpTest.Controls.Add(this.txtTest);
            this.grpTest.Controls.Add(this.txtSample);
            this.grpTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTest.Location = new System.Drawing.Point(0, 0);
            this.grpTest.Name = "grpTest";
            this.grpTest.Size = new System.Drawing.Size(754, 196);
            this.grpTest.TabIndex = 4;
            this.grpTest.TabStop = false;
            this.grpTest.Text = "Key Test";
            // 
            // txtTest
            // 
            this.txtTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTest.Location = new System.Drawing.Point(3, 36);
            this.txtTest.Name = "txtTest";
            this.txtTest.ReadOnly = true;
            this.txtTest.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtTest.Size = new System.Drawing.Size(748, 157);
            this.txtTest.TabIndex = 4;
            this.txtTest.Text = "";
            // 
            // txtSample
            // 
            this.txtSample.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSample.Location = new System.Drawing.Point(3, 16);
            this.txtSample.Name = "txtSample";
            this.txtSample.Size = new System.Drawing.Size(748, 20);
            this.txtSample.TabIndex = 5;
            this.txtSample.Text = "Hello, World!";
            this.txtSample.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSample_KeyUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressWorker,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 703);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(760, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(87, 17);
            this.lblStatus.Text = "Generating Key";
            this.lblStatus.Visible = false;
            // 
            // progressWorker
            // 
            this.progressWorker.Name = "progressWorker";
            this.progressWorker.Size = new System.Drawing.Size(100, 16);
            this.progressWorker.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressWorker.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 725);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "RSA Key Generator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.grpPrivate.ResumeLayout(false);
            this.grpPublic.ResumeLayout(false);
            this.grpTest.ResumeLayout(false);
            this.grpTest.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblKeySize;
        private System.Windows.Forms.ComboBox lstKeySize;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox grpPrivate;
        private System.Windows.Forms.RichTextBox txtPrivate;
        private System.Windows.Forms.GroupBox grpPublic;
        private System.Windows.Forms.RichTextBox txtPublic;
        private System.Windows.Forms.GroupBox grpTest;
        private System.Windows.Forms.RichTextBox txtTest;
        private System.Windows.Forms.TextBox txtSample;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressWorker;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

