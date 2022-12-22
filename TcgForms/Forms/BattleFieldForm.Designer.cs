using TcgForms.Controls;

namespace TcgForms.Forms
{
    partial class BattleFieldForm
    {
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.CreateBattleField();

            // BattleFieldForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 383);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BattleFieldForm";
            this.Text = "Battle Field";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.AddControlsForm();
            this.ResumeLayout(false);
        }

        private void AddControlsForm()
        {
            this.Controls.Add(this.tableLayoutDivisional);
        }

        private void CreateBattleField()
        {
            // tableLayoutDivisional
            this.tableLayoutDivisional = new System.Windows.Forms.TableLayoutPanel();
            
            this.tableLayoutDivisional.ColumnCount = 1;
            this.tableLayoutDivisional.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutDivisional.Location = new System.Drawing.Point(12, 2);
            this.tableLayoutDivisional.Name = "tableLayoutDivisional";
            this.tableLayoutDivisional.RowCount = 2;
            this.tableLayoutDivisional.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.88733F));
            this.tableLayoutDivisional.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.11267F));
            this.tableLayoutDivisional.Size = new System.Drawing.Size(787, 523);
            this.tableLayoutDivisional.TabIndex = 1;
            this.tableLayoutDivisional.BackColor = Color.Black;
        }

        #endregion
        private TableLayoutPanel tableLayoutDivisional;
    }
}