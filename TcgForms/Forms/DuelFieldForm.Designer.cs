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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuelFieldForm));
            tableLayoutOpponentSecondary = new TableLayoutPanel();
            tableLayoutOpponentMain = new TableLayoutPanel();
            tableLayoutOpponentDeck = new TableLayoutPanel();
            buttonMyCards = new Button();
            groupDuelInfo = new GroupBox();
            labelTurn = new Label();
            labelPhase = new Label();
            labelPhasePlayer = new Label();
            groupPlayerInfo = new GroupBox();
            labelPlayerPointLife = new Label();
            labelPlayerName = new Label();
            labelOpponentPointLife = new Label();
            labelOpponentName = new Label();
            buttonNextPhase = new Button();
            tableLayoutPlayerDeck = new TableLayoutPanel();
            deckControlPlayer = new Controls.Stacks.DeckControl();
            GraveyardPlayerControl = new Controls.Stacks.StackOfCardsControl();
            tableLayoutPlayerMain = new TableLayoutPanel();
            tableLayoutPlayerSecondary = new TableLayoutPanel();
            ExtraDeckControl = new Controls.Stacks.StackOfCardsControl();
            panelDivisional = new Panel();
            backgroundWorkerBot = new System.ComponentModel.BackgroundWorker();
            groupOpponentInfo = new GroupBox();
            groupDuelInfo.SuspendLayout();
            groupPlayerInfo.SuspendLayout();
            tableLayoutPlayerDeck.SuspendLayout();
            tableLayoutPlayerSecondary.SuspendLayout();
            groupOpponentInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutOpponentSecondary
            // 
            tableLayoutOpponentSecondary.BackColor = Color.Transparent;
            tableLayoutOpponentSecondary.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutOpponentSecondary.ColumnCount = 1;
            tableLayoutOpponentSecondary.ColumnStyles.Add(new ColumnStyle());
            tableLayoutOpponentSecondary.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutOpponentSecondary.Location = new Point(1010, 20);
            tableLayoutOpponentSecondary.Name = "tableLayoutOpponentSecondary";
            tableLayoutOpponentSecondary.RowCount = 2;
            tableLayoutOpponentSecondary.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutOpponentSecondary.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutOpponentSecondary.Size = new Size(110, 300);
            tableLayoutOpponentSecondary.TabIndex = 2;
            // 
            // tableLayoutOpponentMain
            // 
            tableLayoutOpponentMain.BackColor = Color.Transparent;
            tableLayoutOpponentMain.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutOpponentMain.ColumnCount = 5;
            tableLayoutOpponentMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutOpponentMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutOpponentMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutOpponentMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutOpponentMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutOpponentMain.Location = new Point(275, 20);
            tableLayoutOpponentMain.Name = "tableLayoutOpponentMain";
            tableLayoutOpponentMain.RowCount = 2;
            tableLayoutOpponentMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutOpponentMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutOpponentMain.Size = new Size(700, 320);
            tableLayoutOpponentMain.TabIndex = 1;
            // 
            // tableLayoutOpponentDeck
            // 
            tableLayoutOpponentDeck.BackColor = Color.Transparent;
            tableLayoutOpponentDeck.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutOpponentDeck.ColumnCount = 1;
            tableLayoutOpponentDeck.ColumnStyles.Add(new ColumnStyle());
            tableLayoutOpponentDeck.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutOpponentDeck.Location = new Point(130, 20);
            tableLayoutOpponentDeck.Name = "tableLayoutOpponentDeck";
            tableLayoutOpponentDeck.RowCount = 2;
            tableLayoutOpponentDeck.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutOpponentDeck.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutOpponentDeck.Size = new Size(110, 300);
            tableLayoutOpponentDeck.TabIndex = 0;
            // 
            // buttonMyCards
            // 
            buttonMyCards.Location = new Point(25, 640);
            buttonMyCards.Name = "buttonMyCards";
            buttonMyCards.Size = new Size(60, 50);
            buttonMyCards.TabIndex = 10;
            buttonMyCards.Text = "My Cards";
            buttonMyCards.UseVisualStyleBackColor = true;
            buttonMyCards.Click += buttonMyCards_Click;
            // 
            // groupDuelInfo
            // 
            groupDuelInfo.BackColor = Color.Transparent;
            groupDuelInfo.Controls.Add(labelTurn);
            groupDuelInfo.Controls.Add(labelPhase);
            groupDuelInfo.Controls.Add(labelPhasePlayer);
            groupDuelInfo.Font = new Font("Fira Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupDuelInfo.ForeColor = Color.WhiteSmoke;
            groupDuelInfo.Location = new Point(12, 390);
            groupDuelInfo.Name = "groupDuelInfo";
            groupDuelInfo.Size = new Size(100, 150);
            groupDuelInfo.TabIndex = 9;
            groupDuelInfo.TabStop = false;
            groupDuelInfo.Text = "Duel";
            // 
            // labelTurn
            // 
            labelTurn.AutoSize = true;
            labelTurn.Font = new Font("Fira Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelTurn.ForeColor = Color.WhiteSmoke;
            labelTurn.Location = new Point(5, 89);
            labelTurn.Name = "labelTurn";
            labelTurn.Size = new Size(47, 16);
            labelTurn.TabIndex = 11;
            labelTurn.Text = "Turn:";
            // 
            // labelPhase
            // 
            labelPhase.AutoSize = true;
            labelPhase.Font = new Font("Fira Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPhase.ForeColor = Color.WhiteSmoke;
            labelPhase.Location = new Point(5, 29);
            labelPhase.Name = "labelPhase";
            labelPhase.Size = new Size(47, 16);
            labelPhase.TabIndex = 10;
            labelPhase.Text = "Phase";
            // 
            // labelPhasePlayer
            // 
            labelPhasePlayer.AutoSize = true;
            labelPhasePlayer.Font = new Font("Fira Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPhasePlayer.ForeColor = Color.WhiteSmoke;
            labelPhasePlayer.Location = new Point(5, 59);
            labelPhasePlayer.Name = "labelPhasePlayer";
            labelPhasePlayer.Size = new Size(95, 16);
            labelPhasePlayer.TabIndex = 9;
            labelPhasePlayer.Text = "PhasePlayer";
            // 
            // groupPlayerInfo
            // 
            groupPlayerInfo.BackColor = Color.Transparent;
            groupPlayerInfo.Controls.Add(labelPlayerPointLife);
            groupPlayerInfo.Controls.Add(labelPlayerName);
            groupPlayerInfo.Font = new Font("Fira Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupPlayerInfo.ForeColor = Color.WhiteSmoke;
            groupPlayerInfo.Location = new Point(1140, 554);
            groupPlayerInfo.Name = "groupPlayerInfo";
            groupPlayerInfo.Size = new Size(100, 150);
            groupPlayerInfo.TabIndex = 8;
            groupPlayerInfo.TabStop = false;
            groupPlayerInfo.Text = "Players";
            // 
            // labelPlayerPointLife
            // 
            labelPlayerPointLife.AutoSize = true;
            labelPlayerPointLife.Font = new Font("Fira Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPlayerPointLife.ForeColor = Color.WhiteSmoke;
            labelPlayerPointLife.Location = new Point(5, 59);
            labelPlayerPointLife.Name = "labelPlayerPointLife";
            labelPlayerPointLife.Size = new Size(79, 16);
            labelPlayerPointLife.TabIndex = 8;
            labelPlayerPointLife.Text = "PointLife";
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Fira Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPlayerName.ForeColor = Color.WhiteSmoke;
            labelPlayerName.Location = new Point(5, 29);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(39, 16);
            labelPlayerName.TabIndex = 7;
            labelPlayerName.Text = "Name";
            // 
            // labelOpponentPointLife
            // 
            labelOpponentPointLife.AutoSize = true;
            labelOpponentPointLife.Font = new Font("Fira Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelOpponentPointLife.ForeColor = Color.WhiteSmoke;
            labelOpponentPointLife.Location = new Point(5, 59);
            labelOpponentPointLife.Name = "labelOpponentPointLife";
            labelOpponentPointLife.Size = new Size(79, 16);
            labelOpponentPointLife.TabIndex = 10;
            labelOpponentPointLife.Text = "PointLife";
            // 
            // labelOpponentName
            // 
            labelOpponentName.AutoSize = true;
            labelOpponentName.Font = new Font("Fira Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelOpponentName.ForeColor = Color.WhiteSmoke;
            labelOpponentName.Location = new Point(5, 29);
            labelOpponentName.Name = "labelOpponentName";
            labelOpponentName.Size = new Size(39, 16);
            labelOpponentName.TabIndex = 9;
            labelOpponentName.Text = "Name";
            // 
            // buttonNextPhase
            // 
            buttonNextPhase.Enabled = false;
            buttonNextPhase.Location = new Point(25, 570);
            buttonNextPhase.Name = "buttonNextPhase";
            buttonNextPhase.Size = new Size(60, 50);
            buttonNextPhase.TabIndex = 6;
            buttonNextPhase.Text = "Next Phase";
            buttonNextPhase.UseVisualStyleBackColor = true;
            buttonNextPhase.Click += buttonNextPhase_Click;
            // 
            // tableLayoutPlayerDeck
            // 
            tableLayoutPlayerDeck.BackColor = Color.Transparent;
            tableLayoutPlayerDeck.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPlayerDeck.ColumnCount = 1;
            tableLayoutPlayerDeck.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPlayerDeck.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPlayerDeck.Controls.Add(deckControlPlayer, 0, 1);
            tableLayoutPlayerDeck.Controls.Add(GraveyardPlayerControl, 0, 0);
            tableLayoutPlayerDeck.Location = new Point(1010, 410);
            tableLayoutPlayerDeck.Name = "tableLayoutPlayerDeck";
            tableLayoutPlayerDeck.RowCount = 2;
            tableLayoutPlayerDeck.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPlayerDeck.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPlayerDeck.Size = new Size(110, 300);
            tableLayoutPlayerDeck.TabIndex = 5;
            // 
            // deckControlPlayer
            // 
            deckControlPlayer.Anchor = AnchorStyles.None;
            deckControlPlayer.BackgroundImage = (Image)resources.GetObject("deckControlPlayer.BackgroundImage");
            deckControlPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            deckControlPlayer.Location = new Point(5, 154);
            deckControlPlayer.Name = "deckControlPlayer";
            deckControlPlayer.Size = new Size(100, 140);
            deckControlPlayer.TabIndex = 0;
            // 
            // GraveyardPlayerControl
            // 
            GraveyardPlayerControl.BackgroundImage = (Image)resources.GetObject("GraveyardPlayerControl.BackgroundImage");
            GraveyardPlayerControl.BackgroundImageLayout = ImageLayout.Stretch;
            GraveyardPlayerControl.Enabled = false;
            GraveyardPlayerControl.Location = new Point(5, 5);
            GraveyardPlayerControl.Name = "GraveyardPlayerControl";
            GraveyardPlayerControl.Size = new Size(100, 140);
            GraveyardPlayerControl.TabIndex = 1;
            GraveyardPlayerControl.Visible = false;
            // 
            // tableLayoutPlayerMain
            // 
            tableLayoutPlayerMain.BackColor = Color.Transparent;
            tableLayoutPlayerMain.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPlayerMain.ColumnCount = 5;
            tableLayoutPlayerMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPlayerMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPlayerMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPlayerMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPlayerMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPlayerMain.Location = new Point(275, 390);
            tableLayoutPlayerMain.Name = "tableLayoutPlayerMain";
            tableLayoutPlayerMain.RowCount = 2;
            tableLayoutPlayerMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPlayerMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPlayerMain.Size = new Size(700, 320);
            tableLayoutPlayerMain.TabIndex = 4;
            // 
            // tableLayoutPlayerSecondary
            // 
            tableLayoutPlayerSecondary.BackColor = Color.Transparent;
            tableLayoutPlayerSecondary.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPlayerSecondary.ColumnCount = 1;
            tableLayoutPlayerSecondary.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPlayerSecondary.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPlayerSecondary.Controls.Add(ExtraDeckControl, 0, 1);
            tableLayoutPlayerSecondary.Location = new Point(130, 410);
            tableLayoutPlayerSecondary.Name = "tableLayoutPlayerSecondary";
            tableLayoutPlayerSecondary.RowCount = 2;
            tableLayoutPlayerSecondary.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPlayerSecondary.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPlayerSecondary.Size = new Size(110, 300);
            tableLayoutPlayerSecondary.TabIndex = 3;
            // 
            // ExtraDeckControl
            // 
            ExtraDeckControl.BackgroundImage = (Image)resources.GetObject("ExtraDeckControl.BackgroundImage");
            ExtraDeckControl.BackgroundImageLayout = ImageLayout.Stretch;
            ExtraDeckControl.Enabled = false;
            ExtraDeckControl.Location = new Point(5, 154);
            ExtraDeckControl.Name = "ExtraDeckControl";
            ExtraDeckControl.Size = new Size(100, 140);
            ExtraDeckControl.TabIndex = 0;
            ExtraDeckControl.Visible = false;
            // 
            // panelDivisional
            // 
            panelDivisional.BackColor = Color.Gainsboro;
            panelDivisional.ForeColor = Color.WhiteSmoke;
            panelDivisional.Location = new Point(0, 360);
            panelDivisional.Name = "panelDivisional";
            panelDivisional.Size = new Size(1280, 10);
            panelDivisional.TabIndex = 11;
            // 
            // backgroundWorkerBot
            // 
            backgroundWorkerBot.DoWork += backgroundWorkerBot_DoWork;
            // 
            // groupOpponentInfo
            // 
            groupOpponentInfo.BackColor = Color.Transparent;
            groupOpponentInfo.Controls.Add(labelOpponentPointLife);
            groupOpponentInfo.Controls.Add(labelOpponentName);
            groupOpponentInfo.Font = new Font("Fira Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupOpponentInfo.ForeColor = Color.WhiteSmoke;
            groupOpponentInfo.Location = new Point(12, 20);
            groupOpponentInfo.Name = "groupOpponentInfo";
            groupOpponentInfo.Size = new Size(100, 150);
            groupOpponentInfo.TabIndex = 12;
            groupOpponentInfo.TabStop = false;
            groupOpponentInfo.Text = "Opponent";
            // 
            // DuelFieldForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1252, 720);
            Controls.Add(groupOpponentInfo);
            Controls.Add(panelDivisional);
            Controls.Add(tableLayoutOpponentMain);
            Controls.Add(tableLayoutOpponentSecondary);
            Controls.Add(groupPlayerInfo);
            Controls.Add(groupDuelInfo);
            Controls.Add(tableLayoutOpponentDeck);
            Controls.Add(buttonMyCards);
            Controls.Add(tableLayoutPlayerDeck);
            Controls.Add(tableLayoutPlayerSecondary);
            Controls.Add(tableLayoutPlayerMain);
            Controls.Add(buttonNextPhase);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "DuelFieldForm";
            StartPosition = FormStartPosition.CenterScreen;
            groupDuelInfo.ResumeLayout(false);
            groupDuelInfo.PerformLayout();
            groupPlayerInfo.ResumeLayout(false);
            groupPlayerInfo.PerformLayout();
            tableLayoutPlayerDeck.ResumeLayout(false);
            tableLayoutPlayerSecondary.ResumeLayout(false);
            groupOpponentInfo.ResumeLayout(false);
            groupOpponentInfo.PerformLayout();
            ResumeLayout(false);
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
        private System.ComponentModel.BackgroundWorker backgroundWorkerBot;
        private GroupBox groupOpponentInfo;
    }
}