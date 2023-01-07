namespace TcgForms.Controls.Fields
{
    partial class CardMonsterFieldControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuMonsterCard = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemAttack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemChangePosition = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuMonsterCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuMonsterCard
            // 
            this.contextMenuMonsterCard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAttack,
            this.menuItemChangePosition});
            this.contextMenuMonsterCard.Name = "contextMenuMonsterCard";
            this.contextMenuMonsterCard.Size = new System.Drawing.Size(181, 70);
            this.contextMenuMonsterCard.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuMonsterCard_Opening);
            // 
            // menuItemAttack
            // 
            this.menuItemAttack.Name = "menuItemAttack";
            this.menuItemAttack.Size = new System.Drawing.Size(180, 22);
            this.menuItemAttack.Text = "Attack";
            this.menuItemAttack.Click += new System.EventHandler(this.menuItemAttack_Click);
            // 
            // menuItemChangePosition
            // 
            this.menuItemChangePosition.Name = "menuItemChangePosition";
            this.menuItemChangePosition.Size = new System.Drawing.Size(180, 22);
            this.menuItemChangePosition.Text = "Change Position";
            this.menuItemChangePosition.Click += new System.EventHandler(this.menuItemChangePosition_Click);
            // 
            // CardMonsterFieldControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuMonsterCard;
            this.Name = "CardMonsterFieldControl";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CardMonsterFieldControl_Paint);
            this.contextMenuMonsterCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuMonsterCard;
        private ToolStripMenuItem menuItemAttack;
        private ToolStripMenuItem menuItemChangePosition;
    }
}
