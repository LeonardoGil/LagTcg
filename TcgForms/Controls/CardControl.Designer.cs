namespace TcgForms.Controls
{
    partial class CardControl 
    {

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardControl));
            this.contextMenuStripCard = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripCard
            // 
            this.contextMenuStripCard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemZoom});
            this.contextMenuStripCard.Name = "contextMenuStripCard";
            this.contextMenuStripCard.Size = new System.Drawing.Size(181, 48);
            // 
            // menuItemZoom
            // 
            this.menuItemZoom.Name = "menuItemZoom";
            this.menuItemZoom.Size = new System.Drawing.Size(180, 22);
            this.menuItemZoom.Text = "Zoom";
            this.menuItemZoom.Click += new System.EventHandler(this.menuItemZoom_Click);
            // 
            // CardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.CardFront")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContextMenuStrip = this.contextMenuStripCard;
            this.Name = "CardControl";
            this.Size = new System.Drawing.Size(100, 140);
            this.DoubleClick += new System.EventHandler(this.CardControl_DoubleClick);
            this.contextMenuStripCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuStripCard;
        private System.ComponentModel.IContainer components;
        private ToolStripMenuItem menuItemZoom;
    }
}
