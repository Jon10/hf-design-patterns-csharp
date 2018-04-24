namespace DJView
{
    partial class DJViewForm
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
            this.dJControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bpmBar = new System.Windows.Forms.ProgressBar();
            this.enterBPMLabel = new System.Windows.Forms.Label();
            this.bpmText = new System.Windows.Forms.TextBox();
            this.setButton = new System.Windows.Forms.Button();
            this.decreaseButton = new System.Windows.Forms.Button();
            this.increaseButton = new System.Windows.Forms.Button();
            this.currentBPMLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dJControlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(256, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dJControlToolStripMenuItem
            // 
            this.dJControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.dJControlToolStripMenuItem.Name = "dJControlToolStripMenuItem";
            this.dJControlToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.dJControlToolStripMenuItem.Text = "DJ Control";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // bpmBar
            // 
            this.bpmBar.Location = new System.Drawing.Point(12, 167);
            this.bpmBar.Name = "bpmBar";
            this.bpmBar.Size = new System.Drawing.Size(231, 33);
            this.bpmBar.TabIndex = 1;
            // 
            // enterBPMLabel
            // 
            this.enterBPMLabel.AutoSize = true;
            this.enterBPMLabel.Location = new System.Drawing.Point(12, 46);
            this.enterBPMLabel.Name = "enterBPMLabel";
            this.enterBPMLabel.Size = new System.Drawing.Size(90, 20);
            this.enterBPMLabel.TabIndex = 2;
            this.enterBPMLabel.Text = "Enter BPM:";
            this.enterBPMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bpmText
            // 
            this.bpmText.Location = new System.Drawing.Point(108, 43);
            this.bpmText.Name = "bpmText";
            this.bpmText.Size = new System.Drawing.Size(135, 26);
            this.bpmText.TabIndex = 3;
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(12, 81);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(231, 33);
            this.setButton.TabIndex = 4;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            // 
            // decreaseButton
            // 
            this.decreaseButton.Location = new System.Drawing.Point(12, 120);
            this.decreaseButton.Name = "decreaseButton";
            this.decreaseButton.Size = new System.Drawing.Size(112, 32);
            this.decreaseButton.TabIndex = 5;
            this.decreaseButton.Text = "< <";
            this.decreaseButton.UseVisualStyleBackColor = true;
            // 
            // increaseButton
            // 
            this.increaseButton.Location = new System.Drawing.Point(131, 120);
            this.increaseButton.Name = "increaseButton";
            this.increaseButton.Size = new System.Drawing.Size(112, 32);
            this.increaseButton.TabIndex = 6;
            this.increaseButton.Text = "> >";
            this.increaseButton.UseVisualStyleBackColor = true;
            // 
            // currentBPMLabel
            // 
            this.currentBPMLabel.Location = new System.Drawing.Point(12, 203);
            this.currentBPMLabel.Name = "currentBPMLabel";
            this.currentBPMLabel.Size = new System.Drawing.Size(231, 20);
            this.currentBPMLabel.TabIndex = 7;
            this.currentBPMLabel.Text = "Current BPM:   ";
            this.currentBPMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DJViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 235);
            this.Controls.Add(this.currentBPMLabel);
            this.Controls.Add(this.increaseButton);
            this.Controls.Add(this.decreaseButton);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.bpmText);
            this.Controls.Add(this.enterBPMLabel);
            this.Controls.Add(this.bpmBar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DJViewForm";
            this.Text = "DJ View";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dJControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ProgressBar bpmBar;
        private System.Windows.Forms.Label enterBPMLabel;
        private System.Windows.Forms.TextBox bpmText;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button decreaseButton;
        private System.Windows.Forms.Button increaseButton;
        private System.Windows.Forms.Label currentBPMLabel;
    }
}