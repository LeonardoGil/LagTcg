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
            this.tableLayoutOpponentDeck = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutOpponentMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutOpponentSecondary = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPlayerDeck = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPlayerMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPlayerSecondary = new System.Windows.Forms.TableLayoutPanel();
            this.FieldOpponentPanel.SuspendLayout();
            this.FieldPlayerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FieldOpponentPanel
            // 
            this.FieldOpponentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FieldOpponentPanel.Controls.Add(this.tableLayoutOpponentSecondary);
            this.FieldOpponentPanel.Controls.Add(this.tableLayoutOpponentMain);
            this.FieldOpponentPanel.Controls.Add(this.tableLayoutOpponentDeck);
            this.FieldOpponentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FieldOpponentPanel.Location = new System.Drawing.Point(0, 0);
            this.FieldOpponentPanel.Name = "FieldOpponentPanel";
            this.FieldOpponentPanel.Size = new System.Drawing.Size(1280, 288);
            this.FieldOpponentPanel.TabIndex = 0;
            // 
            // FieldPlayerPanel
            // 
            this.FieldPlayerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FieldPlayerPanel.Controls.Add(this.tableLayoutPlayerDeck);
            this.FieldPlayerPanel.Controls.Add(this.tableLayoutPlayerMain);
            this.FieldPlayerPanel.Controls.Add(this.tableLayoutPlayerSecondary);
            this.FieldPlayerPanel.Controls.Add(this.DrawButton);
            this.FieldPlayerPanel.Controls.Add(this.MyHandsFlowPanel);
            this.FieldPlayerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FieldPlayerPanel.Location = new System.Drawing.Point(0, 292);
            this.FieldPlayerPanel.Name = "FieldPlayerPanel";
            this.FieldPlayerPanel.Size = new System.Drawing.Size(1280, 428);
            this.FieldPlayerPanel.TabIndex = 1;
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(1141, 288);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(85, 140);
            this.DrawButton.TabIndex = 1;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // MyHandsFlowPanel
            // 
            this.MyHandsFlowPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MyHandsFlowPanel.BackColor = System.Drawing.Color.Black;
            this.MyHandsFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyHandsFlowPanel.Location = new System.Drawing.Point(145, 288);
            this.MyHandsFlowPanel.Name = "MyHandsFlowPanel";
            this.MyHandsFlowPanel.Size = new System.Drawing.Size(990, 140);
            this.MyHandsFlowPanel.TabIndex = 0;
            // 
            // tableLayoutOpponentDeck
            // 
            this.tableLayoutOpponentDeck.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutOpponentDeck.ColumnCount = 1;
            this.tableLayoutOpponentDeck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutOpponentDeck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutOpponentDeck.Location = new System.Drawing.Point(145, 4);
            this.tableLayoutOpponentDeck.Name = "tableLayoutOpponentDeck";
            this.tableLayoutOpponentDeck.RowCount = 2;
            this.tableLayoutOpponentDeck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOpponentDeck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOpponentDeck.Size = new System.Drawing.Size(100, 280);
            this.tableLayoutOpponentDeck.TabIndex = 0;
            // 
            // tableLayoutOpponentMain
            // 
            this.tableLayoutOpponentMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutOpponentMain.ColumnCount = 5;
            this.tableLayoutOpponentMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutOpponentMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutOpponentMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutOpponentMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutOpponentMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutOpponentMain.Location = new System.Drawing.Point(390, 4);
            this.tableLayoutOpponentMain.Name = "tableLayoutOpponentMain";
            this.tableLayoutOpponentMain.RowCount = 2;
            this.tableLayoutOpponentMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOpponentMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOpponentMain.Size = new System.Drawing.Size(500, 280);
            this.tableLayoutOpponentMain.TabIndex = 1;
            // 
            // tableLayoutOpponentSecondary
            // 
            this.tableLayoutOpponentSecondary.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutOpponentSecondary.ColumnCount = 1;
            this.tableLayoutOpponentSecondary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutOpponentSecondary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutOpponentSecondary.Location = new System.Drawing.Point(1035, 4);
            this.tableLayoutOpponentSecondary.Name = "tableLayoutOpponentSecondary";
            this.tableLayoutOpponentSecondary.RowCount = 2;
            this.tableLayoutOpponentSecondary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOpponentSecondary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOpponentSecondary.Size = new System.Drawing.Size(100, 280);
            this.tableLayoutOpponentSecondary.TabIndex = 2;
            // 
            // tableLayoutPlayerDeck
            // 
            this.tableLayoutPlayerDeck.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPlayerDeck.ColumnCount = 1;
            this.tableLayoutPlayerDeck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPlayerDeck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPlayerDeck.Location = new System.Drawing.Point(1035, 4);
            this.tableLayoutPlayerDeck.Name = "tableLayoutPlayerDeck";
            this.tableLayoutPlayerDeck.RowCount = 2;
            this.tableLayoutPlayerDeck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPlayerDeck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPlayerDeck.Size = new System.Drawing.Size(100, 280);
            this.tableLayoutPlayerDeck.TabIndex = 5;
            // 
            // tableLayoutPlayerMain
            // 
            this.tableLayoutPlayerMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPlayerMain.ColumnCount = 5;
            this.tableLayoutPlayerMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPlayerMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPlayerMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPlayerMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPlayerMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPlayerMain.Location = new System.Drawing.Point(390, 4);
            this.tableLayoutPlayerMain.Name = "tableLayoutPlayerMain";
            this.tableLayoutPlayerMain.RowCount = 2;
            this.tableLayoutPlayerMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPlayerMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPlayerMain.Size = new System.Drawing.Size(500, 280);
            this.tableLayoutPlayerMain.TabIndex = 4;
            // 
            // tableLayoutPlayerSecondary
            // 
            this.tableLayoutPlayerSecondary.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPlayerSecondary.ColumnCount = 1;
            this.tableLayoutPlayerSecondary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPlayerSecondary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPlayerSecondary.Location = new System.Drawing.Point(145, 4);
            this.tableLayoutPlayerSecondary.Name = "tableLayoutPlayerSecondary";
            this.tableLayoutPlayerSecondary.RowCount = 2;
            this.tableLayoutPlayerSecondary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPlayerSecondary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPlayerSecondary.Size = new System.Drawing.Size(100, 280);
            this.tableLayoutPlayerSecondary.TabIndex = 3;
            // 
            // DuelFieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.FieldPlayerPanel);
            this.Controls.Add(this.FieldOpponentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DuelFieldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duel Field";
            this.FieldOpponentPanel.ResumeLayout(false);
            this.FieldPlayerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel FieldOpponentPanel;
        private Panel FieldPlayerPanel;
        private FlowLayoutPanel MyHandsFlowPanel;
        private Button DrawButton;
        private TableLayoutPanel tableLayoutOpponentDeck;
        private TableLayoutPanel tableLayoutOpponentSecondary;
        private TableLayoutPanel tableLayoutOpponentMain;
        private TableLayoutPanel tableLayoutPlayerDeck;
        private TableLayoutPanel tableLayoutPlayerMain;
        private TableLayoutPanel tableLayoutPlayerSecondary;
    }
}