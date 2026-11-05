namespace BicycleMushroomApp
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblChoose = new System.Windows.Forms.Label();
            this.rbBicycle = new System.Windows.Forms.RadioButton();
            this.rbMushroom = new System.Windows.Forms.RadioButton();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblChoose
            //
            this.lblChoose.AutoSize = true;
            this.lblChoose.Location = new System.Drawing.Point(20, 15);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Text = "Choose an option:";
            //
            // rbBicycle
            //
            this.rbBicycle.AutoSize = true;
            this.rbBicycle.Checked = true;
            this.rbBicycle.Location = new System.Drawing.Point(40, 40);
            this.rbBicycle.Name = "rbBicycle";
            this.rbBicycle.TabIndex = 0;
            this.rbBicycle.TabStop = true;
            this.rbBicycle.Text = "Bicycle Rental";
            this.rbBicycle.UseVisualStyleBackColor = true;
            //
            // rbMushroom
            //
            this.rbMushroom.AutoSize = true;
            this.rbMushroom.Location = new System.Drawing.Point(40, 75);
            this.rbMushroom.Name = "rbMushroom";
            this.rbMushroom.TabIndex = 1;
            this.rbMushroom.Text = "Mushroom Identifier";
            this.rbMushroom.UseVisualStyleBackColor = true;
            //
            // btnOpen
            //
            this.btnOpen.Location = new System.Drawing.Point(40, 115);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 30);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            //
            // btnClose
            //
            this.btnClose.Location = new System.Drawing.Point(150, 115);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // MenuForm
            //
            this.AcceptButton = this.btnOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 170);
            this.ControlBox = false;
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.rbBicycle);
            this.Controls.Add(this.rbMushroom);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.RadioButton rbBicycle;
        private System.Windows.Forms.RadioButton rbMushroom;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
    }
}
