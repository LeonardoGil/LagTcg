namespace TcgForms.Forms
{
    partial class SelectCardForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelCards = new System.Windows.Forms.FlowLayoutPanel();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelCards
            // 
            this.flowLayoutPanelCards.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelCards.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanelCards.Location = new System.Drawing.Point(4, 40);
            this.flowLayoutPanelCards.Name = "flowLayoutPanelCards";
            this.flowLayoutPanelCards.Size = new System.Drawing.Size(750, 140);
            this.flowLayoutPanelCards.TabIndex = 0;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.BackColor = System.Drawing.Color.Transparent;
            this.labelText.Font = new System.Drawing.Font("Fira Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelText.ForeColor = System.Drawing.Color.White;
            this.labelText.Location = new System.Drawing.Point(5, 10);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(70, 24);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "TESTE";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(720, 5);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(35, 30);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // SelectCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::TcgForms.Properties.Resources.BackgroundDigitalDuel;
            this.ClientSize = new System.Drawing.Size(760, 185);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.flowLayoutPanelCards);
            this.Controls.Add(this.labelText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectCardForm";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SelectCardForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectCardForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectCardForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelCards;
        private Label labelText;
        private Button buttonOk;
    }
}