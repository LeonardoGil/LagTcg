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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuelFieldForm));
            this.tableLayoutOpponentSecondary = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutOpponentMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutOpponentDeck = new System.Windows.Forms.TableLayoutPanel();
            this.buttonMyCards = new System.Windows.Forms.Button();
            this.groupDuelInfo = new System.Windows.Forms.GroupBox();
            this.labelTurn = new System.Windows.Forms.Label();
            this.labelPhase = new System.Windows.Forms.Label();
            this.labelPhasePlayer = new System.Windows.Forms.Label();
            this.groupPlayerInfo = new System.Windows.Forms.GroupBox();
            this.labelPlayerPointLife = new System.Windows.Forms.Label();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.buttonNextPhase = new System.Windows.Forms.Button();
            this.tableLayoutPlayerDeck = new System.Windows.Forms.TableLayoutPanel();
            this.deckControlPlayer = new TcgForms.Controls.Stacks.DeckControl();
            this.GraveyardPlayerControl = new TcgForms.Controls.Stacks.StackOfCardsControl();
            this.tableLayoutPlayerMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPlayerSecondary = new System.Windows.Forms.TableLayoutPanel();
            this.ExtraDeckControl = new TcgForms.Controls.Stacks.StackOfCardsControl();
            this.panelDivisional = new System.Windows.Forms.Panel();
            this.labelOpponentPointLife = new System.Windows.Forms.Label();
            this.labelOpponentName = new System.Windows.Forms.Label();
            this.groupDuelInfo.SuspendLayout();
            this.groupPlayerInfo.SuspendLayout();
            this.tableLayoutPlayerDeck.SuspendLayout();
            this.tableLayoutPlayerSecondary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutOpponentSecondary
            // 
            this.tableLayoutOpponentSecondary.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutOpponentSecondary.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutOpponentSecondary.ColumnCount = 1;
            this.tableLayoutOpponentSecondary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutOpponentSecondary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutOpponentSecondary.Location = new System.Drawing.Point(1030, 20);
            this.tableLayoutOpponentSecondary.Name = "tableLayoutOpponentSecondary";
            this.tableLayoutOpponentSecondary.RowCount = 2;
            this.tableLayoutOpponentSecondary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOpponentSecondary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOpponentSecondary.Size = new System.Drawing.Size(110, 300);
            this.tableLayoutOpponentSecondary.TabIndex = 2;
            // 
            // tableLayoutOpponentMain
            // 
            this.tableLayoutOpponentMain.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutOpponentMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutOpponentMain.ColumnCount = 5;
            this.tableLayoutOpponentMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutOpponentMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutOpponentMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutOpponentMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutOpponentMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutOpponentMain.Location = new System.Drawing.Point(275, 20);
            this.tableLayoutOpponentMain.Name = "tableLayoutOpponentMain";
            this.tableLayoutOpponentMain.RowCount = 2;
            this.tableLayoutOpponentMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOpponentMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOpponentMain.Size = new System.Drawing.Size(700, 320);
            this.tableLayoutOpponentMain.TabIndex = 1;
            // 
            // tableLayoutOpponentDeck
            // 
            this.tableLayoutOpponentDeck.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutOpponentDeck.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutOpponentDeck.ColumnCount = 1;
            this.tableLayoutOpponentDeck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutOpponentDeck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutOpponentDeck.Location = new System.Drawing.Point(110, 20);
            this.tableLayoutOpponentDeck.Name = "tableLayoutOpponentDeck";
            this.tableLayoutOpponentDeck.RowCount = 2;
            this.tableLayoutOpponentDeck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOpponentDeck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOpponentDeck.Size = new System.Drawing.Size(110, 300);
            this.tableLayoutOpponentDeck.TabIndex = 0;
            // 
            // buttonMyCards
            // 
            this.buttonMyCards.Location = new System.Drawing.Point(25, 640);
            this.buttonMyCards.Name = "buttonMyCards";
            this.buttonMyCards.Size = new System.Drawing.Size(60, 50);
            this.buttonMyCards.TabIndex = 10;
            this.buttonMyCards.Text = "My Cards";
            this.buttonMyCards.UseVisualStyleBackColor = true;
            this.buttonMyCards.Click += new System.EventHandler(this.buttonMyCards_Click);
            // 
            // groupDuelInfo
            // 
            this.groupDuelInfo.BackColor = System.Drawing.Color.Transparent;
            this.groupDuelInfo.Controls.Add(this.labelTurn);
            this.groupDuelInfo.Controls.Add(this.labelPhase);
            this.groupDuelInfo.Controls.Add(this.labelPhasePlayer);
            this.groupDuelInfo.Font = new System.Drawing.Font("Fira Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupDuelInfo.ForeColor = System.Drawing.Color.White;
            this.groupDuelInfo.Location = new System.Drawing.Point(1165, 550);
            this.groupDuelInfo.Name = "groupDuelInfo";
            this.groupDuelInfo.Size = new System.Drawing.Size(100, 150);
            this.groupDuelInfo.TabIndex = 9;
            this.groupDuelInfo.TabStop = false;
            this.groupDuelInfo.Text = "Duel";
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.Font = new System.Drawing.Font("Fira Code SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTurn.Location = new System.Drawing.Point(5, 89);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(42, 13);
            this.labelTurn.TabIndex = 11;
            this.labelTurn.Text = "Turn:";
            // 
            // labelPhase
            // 
            this.labelPhase.AutoSize = true;
            this.labelPhase.Font = new System.Drawing.Font("Fira Code SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPhase.Location = new System.Drawing.Point(5, 29);
            this.labelPhase.Name = "labelPhase";
            this.labelPhase.Size = new System.Drawing.Size(42, 13);
            this.labelPhase.TabIndex = 10;
            this.labelPhase.Text = "Phase";
            // 
            // labelPhasePlayer
            // 
            this.labelPhasePlayer.AutoSize = true;
            this.labelPhasePlayer.Font = new System.Drawing.Font("Fira Code SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPhasePlayer.Location = new System.Drawing.Point(5, 59);
            this.labelPhasePlayer.Name = "labelPhasePlayer";
            this.labelPhasePlayer.Size = new System.Drawing.Size(84, 13);
            this.labelPhasePlayer.TabIndex = 9;
            this.labelPhasePlayer.Text = "PhasePlayer";
            // 
            // groupPlayerInfo
            // 
            this.groupPlayerInfo.BackColor = System.Drawing.Color.Transparent;
            this.groupPlayerInfo.Controls.Add(this.labelOpponentPointLife);
            this.groupPlayerInfo.Controls.Add(this.labelOpponentName);
            this.groupPlayerInfo.Controls.Add(this.labelPlayerPointLife);
            this.groupPlayerInfo.Controls.Add(this.labelPlayerName);
            this.groupPlayerInfo.Font = new System.Drawing.Font("Fira Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupPlayerInfo.ForeColor = System.Drawing.Color.White;
            this.groupPlayerInfo.Location = new System.Drawing.Point(1165, 390);
            this.groupPlayerInfo.Name = "groupPlayerInfo";
            this.groupPlayerInfo.Size = new System.Drawing.Size(100, 150);
            this.groupPlayerInfo.TabIndex = 8;
            this.groupPlayerInfo.TabStop = false;
            this.groupPlayerInfo.Text = "Players";
            // 
            // labelPlayerPointLife
            // 
            this.labelPlayerPointLife.AutoSize = true;
            this.labelPlayerPointLife.Font = new System.Drawing.Font("Fira Code SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerPointLife.Location = new System.Drawing.Point(5, 59);
            this.labelPlayerPointLife.Name = "labelPlayerPointLife";
            this.labelPlayerPointLife.Size = new System.Drawing.Size(70, 13);
            this.labelPlayerPointLife.TabIndex = 8;
            this.labelPlayerPointLife.Text = "PointLife";
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Font = new System.Drawing.Font("Fira Code SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerName.Location = new System.Drawing.Point(5, 29);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(35, 13);
            this.labelPlayerName.TabIndex = 7;
            this.labelPlayerName.Text = "Name";
            // 
            // buttonNextPhase
            // 
            this.buttonNextPhase.Enabled = false;
            this.buttonNextPhase.Location = new System.Drawing.Point(25, 570);
            this.buttonNextPhase.Name = "buttonNextPhase";
            this.buttonNextPhase.Size = new System.Drawing.Size(60, 50);
            this.buttonNextPhase.TabIndex = 6;
            this.buttonNextPhase.Text = "Next Phase";
            this.buttonNextPhase.UseVisualStyleBackColor = true;
            this.buttonNextPhase.Click += new System.EventHandler(this.buttonNextPhase_Click);
            // 
            // tableLayoutPlayerDeck
            // 
            this.tableLayoutPlayerDeck.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPlayerDeck.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPlayerDeck.ColumnCount = 1;
            this.tableLayoutPlayerDeck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPlayerDeck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPlayerDeck.Controls.Add(this.deckControlPlayer, 0, 1);
            this.tableLayoutPlayerDeck.Controls.Add(this.GraveyardPlayerControl, 0, 0);
            this.tableLayoutPlayerDeck.Location = new System.Drawing.Point(1030, 410);
            this.tableLayoutPlayerDeck.Name = "tableLayoutPlayerDeck";
            this.tableLayoutPlayerDeck.RowCount = 2;
            this.tableLayoutPlayerDeck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPlayerDeck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPlayerDeck.Size = new System.Drawing.Size(110, 300);
            this.tableLayoutPlayerDeck.TabIndex = 5;
            // 
            // deckControlPlayer
            // 
            this.deckControlPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deckControlPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deckControlPlayer.BackgroundImage")));
            this.deckControlPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deckControlPlayer.Location = new System.Drawing.Point(5, 154);
            this.deckControlPlayer.Name = "deckControlPlayer";
            this.deckControlPlayer.Size = new System.Drawing.Size(100, 140);
            this.deckControlPlayer.TabIndex = 0;
            // 
            // GraveyardPlayerControl
            // 
            this.GraveyardPlayerControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GraveyardPlayerControl.BackgroundImage")));
            this.GraveyardPlayerControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GraveyardPlayerControl.Enabled = false;
            this.GraveyardPlayerControl.Location = new System.Drawing.Point(5, 5);
            this.GraveyardPlayerControl.Name = "GraveyardPlayerControl";
            this.GraveyardPlayerControl.Size = new System.Drawing.Size(100, 140);
            this.GraveyardPlayerControl.TabIndex = 1;
            this.GraveyardPlayerControl.Visible = false;
            // 
            // tableLayoutPlayerMain
            // 
            this.tableLayoutPlayerMain.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPlayerMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPlayerMain.ColumnCount = 5;
            this.tableLayoutPlayerMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPlayerMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPlayerMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPlayerMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPlayerMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPlayerMain.Location = new System.Drawing.Point(275, 390);
            this.tableLayoutPlayerMain.Name = "tableLayoutPlayerMain";
            this.tableLayoutPlayerMain.RowCount = 2;
            this.tableLayoutPlayerMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPlayerMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPlayerMain.Size = new System.Drawing.Size(700, 320);
            this.tableLayoutPlayerMain.TabIndex = 4;
            // 
            // tableLayoutPlayerSecondary
            // 
            this.tableLayoutPlayerSecondary.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPlayerSecondary.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPlayerSecondary.ColumnCount = 1;
            this.tableLayoutPlayerSecondary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPlayerSecondary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPlayerSecondary.Controls.Add(this.ExtraDeckControl, 0, 1);
            this.tableLayoutPlayerSecondary.Location = new System.Drawing.Point(110, 410);
            this.tableLayoutPlayerSecondary.Name = "tableLayoutPlayerSecondary";
            this.tableLayoutPlayerSecondary.RowCount = 2;
            this.tableLayoutPlayerSecondary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPlayerSecondary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPlayerSecondary.Size = new System.Drawing.Size(110, 300);
            this.tableLayoutPlayerSecondary.TabIndex = 3;
            // 
            // ExtraDeckControl
            // 
            this.ExtraDeckControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExtraDeckControl.BackgroundImage")));
            this.ExtraDeckControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExtraDeckControl.Enabled = false;
            this.ExtraDeckControl.Location = new System.Drawing.Point(5, 154);
            this.ExtraDeckControl.Name = "ExtraDeckControl";
            this.ExtraDeckControl.Size = new System.Drawing.Size(100, 140);
            this.ExtraDeckControl.TabIndex = 0;
            this.ExtraDeckControl.Visible = false;
            // 
            // panelDivisional
            // 
            this.panelDivisional.BackColor = System.Drawing.Color.White;
            this.panelDivisional.Location = new System.Drawing.Point(0, 360);
            this.panelDivisional.Name = "panelDivisional";
            this.panelDivisional.Size = new System.Drawing.Size(1280, 10);
            this.panelDivisional.TabIndex = 11;
            // 
            // labelOpponentPointLife
            // 
            this.labelOpponentPointLife.AutoSize = true;
            this.labelOpponentPointLife.Font = new System.Drawing.Font("Fira Code SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOpponentPointLife.Location = new System.Drawing.Point(5, 119);
            this.labelOpponentPointLife.Name = "labelOpponentPointLife";
            this.labelOpponentPointLife.Size = new System.Drawing.Size(70, 13);
            this.labelOpponentPointLife.TabIndex = 10;
            this.labelOpponentPointLife.Text = "PointLife";
            // 
            // labelOpponentName
            // 
            this.labelOpponentName.AutoSize = true;
            this.labelOpponentName.Font = new System.Drawing.Font("Fira Code SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOpponentName.Location = new System.Drawing.Point(5, 89);
            this.labelOpponentName.Name = "labelOpponentName";
            this.labelOpponentName.Size = new System.Drawing.Size(35, 13);
            this.labelOpponentName.TabIndex = 9;
            this.labelOpponentName.Text = "Name";
            // 
            // DuelFieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelDivisional);
            this.Controls.Add(this.tableLayoutOpponentMain);
            this.Controls.Add(this.tableLayoutOpponentSecondary);
            this.Controls.Add(this.groupPlayerInfo);
            this.Controls.Add(this.groupDuelInfo);
            this.Controls.Add(this.tableLayoutOpponentDeck);
            this.Controls.Add(this.buttonMyCards);
            this.Controls.Add(this.tableLayoutPlayerDeck);
            this.Controls.Add(this.tableLayoutPlayerSecondary);
            this.Controls.Add(this.tableLayoutPlayerMain);
            this.Controls.Add(this.buttonNextPhase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DuelFieldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duel Field";
            this.groupDuelInfo.ResumeLayout(false);
            this.groupDuelInfo.PerformLayout();
            this.groupPlayerInfo.ResumeLayout(false);
            this.groupPlayerInfo.PerformLayout();
            this.tableLayoutPlayerDeck.ResumeLayout(false);
            this.tableLayoutPlayerSecondary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutOpponentDeck;
        private TableLayoutPanel tableLayoutOpponentSecondary;
        private TableLayoutPanel tableLayoutOpponentMain;
        private TableLayoutPanel tableLayoutPlayerDeck;
        private TableLayoutPanel tableLayoutPlayerMain;
        private TableLayoutPanel tableLayoutPlayerSecondary;
        private Button buttonNextPhase;
        private Label labelPlayerName;
        private Label labelPlayerPointLife;
        private Label labelPhase;
        private Label labelPhasePlayer;
        private GroupBox groupPlayerInfo;
        private GroupBox groupDuelInfo;
        private Button buttonMyCards;
        private Panel panelDivisional;
        private Label labelTurn;
        private Controls.Stacks.DeckControl deckControlPlayer;
        private Controls.Stacks.StackOfCardsControl GraveyardPlayerControl;
        private Controls.Stacks.StackOfCardsControl ExtraDeckControl;
        private Label labelOpponentPointLife;
        private Label labelOpponentName;
    }
}