namespace guiPractice
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.symbolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsName = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtFuncInput = new System.Windows.Forms.TextBox();
            this.btnDerive = new System.Windows.Forms.Button();
            this.stsAbout = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblInputVerify = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblOutputVerify = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnIntegrate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.macrosToolStripMenuItem,
            this.symbolsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // macrosToolStripMenuItem
            // 
            this.macrosToolStripMenuItem.Name = "macrosToolStripMenuItem";
            this.macrosToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.macrosToolStripMenuItem.Text = "Macros";
            // 
            // symbolsToolStripMenuItem
            // 
            this.symbolsToolStripMenuItem.Name = "symbolsToolStripMenuItem";
            this.symbolsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.symbolsToolStripMenuItem.Text = "Symbols";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsName,
            this.stsAbout});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(682, 25);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stsName
            // 
            this.stsName.Name = "stsName";
            this.stsName.Size = new System.Drawing.Size(105, 20);
            this.stsName.Text = "<component>";
            // 
            // txtFuncInput
            // 
            this.txtFuncInput.Location = new System.Drawing.Point(6, 37);
            this.txtFuncInput.Multiline = true;
            this.txtFuncInput.Name = "txtFuncInput";
            this.txtFuncInput.Size = new System.Drawing.Size(290, 22);
            this.txtFuncInput.TabIndex = 6;
            // 
            // btnDerive
            // 
            this.btnDerive.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDerive.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDerive.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDerive.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDerive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerive.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDerive.Location = new System.Drawing.Point(96, 107);
            this.btnDerive.Name = "btnDerive";
            this.btnDerive.Size = new System.Drawing.Size(100, 36);
            this.btnDerive.TabIndex = 9;
            this.btnDerive.Text = "Derive";
            this.btnDerive.UseVisualStyleBackColor = false;
            this.btnDerive.Click += new System.EventHandler(this.btnDerive_Click);
            // 
            // stsAbout
            // 
            this.stsAbout.Name = "stsAbout";
            this.stsAbout.Size = new System.Drawing.Size(70, 20);
            this.stsAbout.Text = "<About>";
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.lblInputVerify);
            this.grpInput.Controls.Add(this.txtFuncInput);
            this.grpInput.Controls.Add(this.btnDerive);
            this.grpInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInput.Location = new System.Drawing.Point(22, 30);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(635, 245);
            this.grpInput.TabIndex = 12;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Function";
            // 
            // lblInputVerify
            // 
            this.lblInputVerify.AutoSize = true;
            this.lblInputVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputVerify.Location = new System.Drawing.Point(331, 38);
            this.lblInputVerify.Name = "lblInputVerify";
            this.lblInputVerify.Size = new System.Drawing.Size(75, 24);
            this.lblInputVerify.TabIndex = 10;
            this.lblInputVerify.Text = "<verify>";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lblOutputVerify);
            this.grpOutput.Controls.Add(this.txtOutput);
            this.grpOutput.Controls.Add(this.btnIntegrate);
            this.grpOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOutput.Location = new System.Drawing.Point(22, 281);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(635, 244);
            this.grpOutput.TabIndex = 13;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Derivative";
            // 
            // lblOutputVerify
            // 
            this.lblOutputVerify.AutoSize = true;
            this.lblOutputVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputVerify.Location = new System.Drawing.Point(331, 38);
            this.lblOutputVerify.Name = "lblOutputVerify";
            this.lblOutputVerify.Size = new System.Drawing.Size(75, 24);
            this.lblOutputVerify.TabIndex = 10;
            this.lblOutputVerify.Text = "<verify>";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(6, 37);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(290, 38);
            this.txtOutput.TabIndex = 6;
            // 
            // btnIntegrate
            // 
            this.btnIntegrate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIntegrate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIntegrate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIntegrate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnIntegrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntegrate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnIntegrate.Location = new System.Drawing.Point(96, 107);
            this.btnIntegrate.Name = "btnIntegrate";
            this.btnIntegrate.Size = new System.Drawing.Size(100, 36);
            this.btnIntegrate.TabIndex = 9;
            this.btnIntegrate.Text = "Derive";
            this.btnIntegrate.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.LightSlateGray;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(700, 600);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "frmMain";
            this.Text = "Practice";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem macrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem symbolsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsName;
        private System.Windows.Forms.TextBox txtFuncInput;
        private System.Windows.Forms.Button btnDerive;
        private System.Windows.Forms.ToolStripStatusLabel stsAbout;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblInputVerify;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label lblOutputVerify;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnIntegrate;
    }
}

