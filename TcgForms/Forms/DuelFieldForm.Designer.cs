using TcgForms.Controls;

namespace TcgForms.Forms
{
    partial class DuelFieldForm
    {
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

        private void InitializeComponent()
        {
            this.FieldOpponentPanel = new System.Windows.Forms.Panel();
            this.FieldPlayerPanel = new System.Windows.Forms.Panel();
            this.DrawButton = new System.Windows.Forms.Button();
            this.MyHandsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FieldPlayerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FieldOpponentPanel
            // 
            this.FieldOpponentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FieldOpponentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FieldOpponentPanel.Location = new System.Drawing.Point(0, 0);
            this.FieldOpponentPanel.Name = "FieldOpponentPanel";
            this.FieldOpponentPanel.Size = new System.Drawing.Size(1366, 380);
            this.FieldOpponentPanel.TabIndex = 0;
            // 
            // FieldPlayerPanel
            // 
            this.FieldPlayerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FieldPlayerPanel.Controls.Add(this.DrawButton);
            this.FieldPlayerPanel.Controls.Add(this.MyHandsFlowPanel);
            this.FieldPlayerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FieldPlayerPanel.Location = new System.Drawing.Point(0, 388);
            this.FieldPlayerPanel.Name = "FieldPlayerPanel";
            this.FieldPlayerPanel.Size = new System.Drawing.Size(1366, 380);
            this.FieldPlayerPanel.TabIndex = 1;
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(1172, 260);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(182, 108);
            this.DrawButton.TabIndex = 1;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // MyHandsFlowPanel
            // 
            this.MyHandsFlowPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MyHandsFlowPanel.BackColor = System.Drawing.Color.Black;
            this.MyHandsFlowPanel.Location = new System.Drawing.Point(200, 260);
            this.MyHandsFlowPanel.Name = "MyHandsFlowPanel";
            this.MyHandsFlowPanel.Size = new System.Drawing.Size(966, 120);
            this.MyHandsFlowPanel.TabIndex = 0;
            // 
            // BattleFieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.FieldPlayerPanel);
            this.Controls.Add(this.FieldOpponentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DuelFieldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duel Field";
            this.FieldPlayerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel FieldOpponentPanel;
        private Panel FieldPlayerPanel;
        private FlowLayoutPanel MyHandsFlowPanel;
        private Button DrawButton;
    }
}