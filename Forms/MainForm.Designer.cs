namespace FCGG.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.iconToolStripToggleRunButton = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStripSeparatorMain = new System.Windows.Forms.ToolStripSeparator();
            this.iconToolStripButtonAddChannel = new FontAwesome.Sharp.IconToolStripButton();
            this.iconToolStripButtonRemoveChannel = new FontAwesome.Sharp.IconToolStripButton();
            this.flowLayoutPanelChannels = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconToolStripToggleRunButton,
            this.toolStripSeparatorMain,
            this.iconToolStripButtonAddChannel,
            this.iconToolStripButtonRemoveChannel});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(800, 34);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // iconToolStripToggleRunButton
            // 
            this.iconToolStripToggleRunButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconToolStripToggleRunButton.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.iconToolStripToggleRunButton.IconColor = System.Drawing.Color.Green;
            this.iconToolStripToggleRunButton.IconSize = 20;
            this.iconToolStripToggleRunButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconToolStripToggleRunButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconToolStripToggleRunButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconToolStripToggleRunButton.Name = "iconToolStripToggleRunButton";
            this.iconToolStripToggleRunButton.Rotation = 0D;
            this.iconToolStripToggleRunButton.Size = new System.Drawing.Size(72, 29);
            this.iconToolStripToggleRunButton.Text = "Start";
            // 
            // toolStripSeparatorMain
            // 
            this.toolStripSeparatorMain.Name = "toolStripSeparatorMain";
            this.toolStripSeparatorMain.Size = new System.Drawing.Size(6, 34);
            // 
            // iconToolStripButtonAddChannel
            // 
            this.iconToolStripButtonAddChannel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconToolStripButtonAddChannel.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iconToolStripButtonAddChannel.IconColor = System.Drawing.Color.Green;
            this.iconToolStripButtonAddChannel.IconSize = 20;
            this.iconToolStripButtonAddChannel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconToolStripButtonAddChannel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconToolStripButtonAddChannel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconToolStripButtonAddChannel.Name = "iconToolStripButtonAddChannel";
            this.iconToolStripButtonAddChannel.Rotation = 0D;
            this.iconToolStripButtonAddChannel.Size = new System.Drawing.Size(138, 29);
            this.iconToolStripButtonAddChannel.Text = "Add Channel";
            this.iconToolStripButtonAddChannel.ToolTipText = "Add Channel";
            // 
            // iconToolStripButtonRemoveChannel
            // 
            this.iconToolStripButtonRemoveChannel.Enabled = false;
            this.iconToolStripButtonRemoveChannel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconToolStripButtonRemoveChannel.IconChar = FontAwesome.Sharp.IconChar.MinusSquare;
            this.iconToolStripButtonRemoveChannel.IconColor = System.Drawing.Color.Red;
            this.iconToolStripButtonRemoveChannel.IconSize = 20;
            this.iconToolStripButtonRemoveChannel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconToolStripButtonRemoveChannel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconToolStripButtonRemoveChannel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconToolStripButtonRemoveChannel.Name = "iconToolStripButtonRemoveChannel";
            this.iconToolStripButtonRemoveChannel.Rotation = 0D;
            this.iconToolStripButtonRemoveChannel.Size = new System.Drawing.Size(168, 29);
            this.iconToolStripButtonRemoveChannel.Text = "Remove Channel";
            this.iconToolStripButtonRemoveChannel.ToolTipText = "Remove Channel";
            // 
            // flowLayoutPanelChannels
            // 
            this.flowLayoutPanelChannels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelChannels.AutoScroll = true;
            this.flowLayoutPanelChannels.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanelChannels.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelChannels.Location = new System.Drawing.Point(0, 34);
            this.flowLayoutPanelChannels.Name = "flowLayoutPanelChannels";
            this.flowLayoutPanelChannels.Size = new System.Drawing.Size(800, 416);
            this.flowLayoutPanelChannels.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanelChannels);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "MainForm";
            this.Text = "FoxCouncil Graphics Generator";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripToggleRunButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorMain;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButtonAddChannel;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButtonRemoveChannel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChannels;
    }
}

