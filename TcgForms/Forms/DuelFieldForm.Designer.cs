namespace TcgForms.Forms
{
    partial class DuelFieldForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.panelFieldOpponent = new System.Windows.Forms.Panel();
            this.tableLayoutOpponentSecondary = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutOpponentMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutOpponentDeck = new System.Windows.Forms.TableLayoutPanel();
            this.panelFieldPlayer = new System.Windows.Forms.Panel();
            this.tableLayoutPlayerDeck = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPlayerMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPlayerSecondary = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.flowPanelHands = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFieldOpponent.SuspendLayout();
            this.panelFieldPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFieldOpponent
            // 
            this.panelFieldOpponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelFieldOpponent.Controls.Add(this.tableLayoutOpponentSecondary);
            this.panelFieldOpponent.Controls.Add(this.tableLayoutOpponentMain);
            this.panelFieldOpponent.Controls.Add(this.tableLayoutOpponentDeck);
            this.panelFieldOpponent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFieldOpponent.Location = new System.Drawing.Point(0, 0);
            this.panelFieldOpponent.Name = "panelFieldOpponent";
            this.panelFieldOpponent.Size = new System.Drawing.Size(1280, 288);
            this.panelFieldOpponent.TabIndex = 0;
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
            // panelFieldPlayer
            // 
            this.panelFieldPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelFieldPlayer.Controls.Add(this.tableLayoutPlayerDeck);
            this.panelFieldPlayer.Controls.Add(this.tableLayoutPlayerMain);
            this.panelFieldPlayer.Controls.Add(this.tableLayoutPlayerSecondary);
            this.panelFieldPlayer.Controls.Add(this.buttonDraw);
            this.panelFieldPlayer.Controls.Add(this.flowPanelHands);
            this.panelFieldPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFieldPlayer.Location = new System.Drawing.Point(0, 292);
            this.panelFieldPlayer.Name = "panelFieldPlayer";
            this.panelFieldPlayer.Size = new System.Drawing.Size(1280, 428);
            this.panelFieldPlayer.TabIndex = 1;
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
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(1141, 288);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(85, 140);
            this.buttonDraw.TabIndex = 1;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.ButtonDraw_Click);
            // 
            // flowPanelHands
            // 
            this.flowPanelHands.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowPanelHands.BackColor = System.Drawing.Color.Black;
            this.flowPanelHands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPanelHands.Location = new System.Drawing.Point(145, 288);
            this.flowPanelHands.Name = "flowPanelHands";
            this.flowPanelHands.Size = new System.Drawing.Size(990, 140);
            this.flowPanelHands.TabIndex = 0;
            // 
            // DuelFieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelFieldPlayer);
            this.Controls.Add(this.panelFieldOpponent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DuelFieldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duel Field";
            this.panelFieldOpponent.ResumeLayout(false);
            this.panelFieldPlayer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelFieldOpponent;
        private Panel panelFieldPlayer;
        private FlowLayoutPanel flowPanelHands;
        private Button buttonDraw;
        private TableLayoutPanel tableLayoutOpponentDeck;
        private TableLayoutPanel tableLayoutOpponentSecondary;
        private TableLayoutPanel tableLayoutOpponentMain;
        private TableLayoutPanel tableLayoutPlayerDeck;
        private TableLayoutPanel tableLayoutPlayerMain;
        private TableLayoutPanel tableLayoutPlayerSecondary;
    }
}