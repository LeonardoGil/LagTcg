namespace TcgForms.Controls
{
    partial class CardControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.contextMenuCard = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemInvokeNormalCard = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuCard
            // 
            this.contextMenuCard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemInvokeNormalCard});
            this.contextMenuCard.Name = "contextMenuCard";
            this.contextMenuCard.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuCard.Size = new System.Drawing.Size(110, 26);
            // 
            // MenuItemInvokeNormalCard
            // 
            this.MenuItemInvokeNormalCard.Name = "MenuItemInvokeNormalCard";
            this.MenuItemInvokeNormalCard.Size = new System.Drawing.Size(109, 22);
            this.MenuItemInvokeNormalCard.Text = "Invoke";
            this.MenuItemInvokeNormalCard.Click += new System.EventHandler(this.MenuItemInvokeNormalCard_Click);
            // 
            // CardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContextMenuStrip = this.contextMenuCard;
            this.Name = "CardControl";
            this.Size = new System.Drawing.Size(80, 120);
            this.contextMenuCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuCard;
        private ToolStripMenuItem MenuItemInvokeNormalCard;
    }
}
