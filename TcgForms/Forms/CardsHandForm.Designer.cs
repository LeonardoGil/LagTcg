namespace TcgForms.Forms
{
    partial class CardsHandForm
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
            this.flowLayoutPanelHands = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelHands
            // 
            this.flowLayoutPanelHands.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanelHands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelHands.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanelHands.Name = "flowLayoutPanelHands";
            this.flowLayoutPanelHands.Size = new System.Drawing.Size(745, 295);
            this.flowLayoutPanelHands.TabIndex = 1;
            this.flowLayoutPanelHands.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardsHandForm_MouseDown);
            this.flowLayoutPanelHands.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CardsHandForm_MouseMove);
            // 
            // CardsHandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = global::TcgForms.Properties.Resources.BackgroundDigitalDuel;
            this.ClientSize = new System.Drawing.Size(765, 315);
            this.Controls.Add(this.flowLayoutPanelHands);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CardsHandForm";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CardsHandForm_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardsHandForm_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardsHandForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CardsHandForm_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelHands;
    }
}