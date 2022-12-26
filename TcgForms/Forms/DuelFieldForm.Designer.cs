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
            this.tableLayoutOpponentSecondary = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutOpponentMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutOpponentDeck = new System.Windows.Forms.TableLayoutPanel();
            this.buttonMyCards = new System.Windows.Forms.Button();
            this.groupDuelInfo = new System.Windows.Forms.GroupBox();
            this.labelPhase = new System.Windows.Forms.Label();
            this.labelPhasePlayer = new System.Windows.Forms.Label();
            this.groupPlayerInfo = new System.Windows.Forms.GroupBox();
            this.labelPlayerPointLife = new System.Windows.Forms.Label();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.buttonNextPhase = new System.Windows.Forms.Button();
            this.tableLayoutPlayerDeck = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPlayerMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPlayerSecondary = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupDuelInfo.SuspendLayout();
            this.groupPlayerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutOpponentSecondary
            // 
            this.tableLayoutOpponentSecondary.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutOpponentSecondary.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutOpponentSecondary.ColumnCount = 1;
            this.tableLayoutOpponentSecondary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutOpponentSecondary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutOpponentSecondary.Location = new System.Drawing.Point(1050, 40);
            this.tableLayoutOpponentSecondary.Name = "tableLayoutOpponentSecondary";
            this.tableLayoutOpponentSecondary.RowCount = 2;
            this.tableLayoutOpponentSecondary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOpponentSecondary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOpponentSecondary.Size = new System.Drawing.Size(100, 280);
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
            this.tableLayoutOpponentMain.Location = new System.Drawing.Point(270, 20);
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
            this.tableLayoutOpponentDeck.Location = new System.Drawing.Point(110, 40);
            this.tableLayoutOpponentDeck.Name = "tableLayoutOpponentDeck";
            this.tableLayoutOpponentDeck.RowCount = 2;
            this.tableLayoutOpponentDeck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOpponentDeck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOpponentDeck.Size = new System.Drawing.Size(100, 280);
            this.tableLayoutOpponentDeck.TabIndex = 0;
            // 
            // buttonMyCards
            // 
            this.buttonMyCards.Location = new System.Drawing.Point(25, 530);
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
            this.groupPlayerInfo.Controls.Add(this.labelPlayerPointLife);
            this.groupPlayerInfo.Controls.Add(this.labelPlayerName);
            this.groupPlayerInfo.Font = new System.Drawing.Font("Fira Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupPlayerInfo.ForeColor = System.Drawing.Color.White;
            this.groupPlayerInfo.Location = new System.Drawing.Point(1165, 390);
            this.groupPlayerInfo.Name = "groupPlayerInfo";
            this.groupPlayerInfo.Size = new System.Drawing.Size(100, 150);
            this.groupPlayerInfo.TabIndex = 8;
            this.groupPlayerInfo.TabStop = false;
            this.groupPlayerInfo.Text = "Player";
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
            this.buttonNextPhase.Location = new System.Drawing.Point(25, 460);
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
            this.tableLayoutPlayerDeck.Location = new System.Drawing.Point(1050, 410);
            this.tableLayoutPlayerDeck.Name = "tableLayoutPlayerDeck";
            this.tableLayoutPlayerDeck.RowCount = 2;
            this.tableLayoutPlayerDeck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPlayerDeck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPlayerDeck.Size = new System.Drawing.Size(100, 280);
            this.tableLayoutPlayerDeck.TabIndex = 5;
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
            this.tableLayoutPlayerMain.Location = new System.Drawing.Point(270, 390);
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
            this.tableLayoutPlayerSecondary.Location = new System.Drawing.Point(110, 410);
            this.tableLayoutPlayerSecondary.Name = "tableLayoutPlayerSecondary";
            this.tableLayoutPlayerSecondary.RowCount = 2;
            this.tableLayoutPlayerSecondary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPlayerSecondary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPlayerSecondary.Size = new System.Drawing.Size(100, 280);
            this.tableLayoutPlayerSecondary.TabIndex = 3;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(25, 390);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(60, 50);
            this.buttonDraw.TabIndex = 1;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.ButtonDraw_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 10);
            this.panel1.TabIndex = 11;
            // 
            // DuelFieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
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
            this.Controls.Add(this.buttonDraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DuelFieldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duel Field";
            this.groupDuelInfo.ResumeLayout(false);
            this.groupDuelInfo.PerformLayout();
            this.groupPlayerInfo.ResumeLayout(false);
            this.groupPlayerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutOpponentDeck;
        private TableLayoutPanel tableLayoutOpponentSecondary;
        private TableLayoutPanel tableLayoutOpponentMain;
        private TableLayoutPanel tableLayoutPlayerDeck;
        private TableLayoutPanel tableLayoutPlayerMain;
        private TableLayoutPanel tableLayoutPlayerSecondary;
        private Button buttonDraw;
        private Button buttonNextPhase;
        private Label labelPlayerName;
        private Label labelPlayerPointLife;
        private Label labelPhase;
        private Label labelPhasePlayer;
        private GroupBox groupPlayerInfo;
        private GroupBox groupDuelInfo;
        private Button buttonMyCards;
        private Panel panel1;
    }
}