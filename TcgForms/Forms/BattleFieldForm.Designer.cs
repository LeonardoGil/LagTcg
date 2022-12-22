using TcgForms.Controls;

namespace TcgForms.Forms
{
    partial class BattleFieldForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CardInHandTest = new CardInHandControl();
            this.SuspendLayout();
            // 
            // CardInHandTest
            // 
            this.CardInHandTest.Location = new System.Drawing.Point(57, 301);
            this.CardInHandTest.Name = "CardInHandTest";
            this.CardInHandTest.Size = new System.Drawing.Size(89, 129);
            this.CardInHandTest.TabIndex = 0;
            // 
            // BattleFieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "BattleFieldForm";
            this.Text = "Battle Field";
            this.ResumeLayout(false);

            this.Controls.Add(this.CardInHandTest);

        }

        #endregion

        private CardInHandControl CardInHandTest;
    }
}