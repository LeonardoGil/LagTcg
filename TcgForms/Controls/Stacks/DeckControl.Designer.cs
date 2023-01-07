namespace TcgForms.Controls.Stacks
{
    partial class DeckControl
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
            this.contextMenuDeck = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemDraw = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuDeck.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuDeck
            // 
            this.contextMenuDeck.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDraw});
            this.contextMenuDeck.Name = "contextMenuDeck";
            this.contextMenuDeck.Size = new System.Drawing.Size(102, 26);
            this.contextMenuDeck.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuDeck_Opening);
            // 
            // menuItemDraw
            // 
            this.menuItemDraw.Name = "menuItemDraw";
            this.menuItemDraw.Size = new System.Drawing.Size(180, 22);
            this.menuItemDraw.Text = "DrawCard";
            this.menuItemDraw.Click += new System.EventHandler(this.menuItemDraw_Click);
            // 
            // DeckControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuDeck;
            this.Name = "DeckControl";
            this.contextMenuDeck.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuDeck;
        private ToolStripMenuItem menuItemDraw;
    }
}
