namespace Cookie_Clicker
{
    partial class Clicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clicker));
            this.cookie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClickCount = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cookie
            // 
            this.cookie.BackColor = System.Drawing.Color.Transparent;
            this.cookie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cookie.BackgroundImage")));
            this.cookie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cookie.FlatAppearance.BorderSize = 0;
            this.cookie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cookie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cookie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cookie.ForeColor = System.Drawing.Color.Transparent;
            this.cookie.Location = new System.Drawing.Point(1, 240);
            this.cookie.Name = "cookie";
            this.cookie.Size = new System.Drawing.Size(157, 169);
            this.cookie.TabIndex = 0;
            this.cookie.UseVisualStyleBackColor = false;
            this.cookie.Click += new System.EventHandler(this.cookie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Count: ";
            // 
            // ClickCount
            // 
            this.ClickCount.AutoSize = true;
            this.ClickCount.BackColor = System.Drawing.Color.Transparent;
            this.ClickCount.Font = new System.Drawing.Font("Comfortaa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClickCount.ForeColor = System.Drawing.Color.Black;
            this.ClickCount.Location = new System.Drawing.Point(113, 13);
            this.ClickCount.Name = "ClickCount";
            this.ClickCount.Size = new System.Drawing.Size(37, 47);
            this.ClickCount.TabIndex = 2;
            this.ClickCount.Text = "0";
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Transparent;
            this.reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reset.BackgroundImage")));
            this.reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reset.FlatAppearance.BorderSize = 0;
            this.reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.ForeColor = System.Drawing.Color.Transparent;
            this.reset.Location = new System.Drawing.Point(240, 334);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(77, 75);
            this.reset.TabIndex = 3;
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(315, 408);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.ClickCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cookie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cookie Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cookie;
        private Label label1;
        private Label ClickCount;
        private Button reset;
    }
}