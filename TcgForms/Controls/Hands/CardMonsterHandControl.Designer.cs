namespace TcgForms.Controls.Hands
{
    partial class CardMonsterHandControl : CardControl
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
            this.contextMenuCardMonster = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemInvoke = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSpecialInvoke = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSet = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuCardMonster.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuCardMonster
            // 
            this.contextMenuCardMonster.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemInvoke,
            this.menuItemSpecialInvoke,
            this.menuItemSet});
            this.contextMenuCardMonster.Name = "contextMenuCardMonster";
            this.contextMenuCardMonster.Size = new System.Drawing.Size(153, 70);
            this.contextMenuCardMonster.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuCardMonster_Opening);
            // 
            // menuItemInvoke
            // 
            this.menuItemInvoke.Name = "menuItemInvoke";
            this.menuItemInvoke.Size = new System.Drawing.Size(152, 22);
            this.menuItemInvoke.Text = "Invoke";
            this.menuItemInvoke.Click += new System.EventHandler(this.menuItemInvoke_Click);
            // 
            // menuItemSpecialInvoke
            // 
            this.menuItemSpecialInvoke.Name = "menuItemSpecialInvoke";
            this.menuItemSpecialInvoke.Size = new System.Drawing.Size(152, 22);
            this.menuItemSpecialInvoke.Text = "Special Invoke ";
            this.menuItemSpecialInvoke.Click += new System.EventHandler(this.menuItemSpecialInvoke_Click);
            // 
            // menuItemSet
            // 
            this.menuItemSet.Name = "menuItemSet";
            this.menuItemSet.Size = new System.Drawing.Size(152, 22);
            this.menuItemSet.Text = "Set";
            this.menuItemSet.Click += new System.EventHandler(this.menuItemSet_Click);
            // 
            // CardMonsterHandControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuCardMonster;
            this.Name = "CardMonsterHandControl";
            this.contextMenuCardMonster.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuCardMonster;
        private ToolStripMenuItem menuItemInvoke;
        private ToolStripMenuItem menuItemSpecialInvoke;
        private ToolStripMenuItem menuItemSet;
    }
}
