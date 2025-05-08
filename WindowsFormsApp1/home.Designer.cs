namespace WindowsFormsApp1
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.butpos = new System.Windows.Forms.Button();
            this.butbackoffice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butpos
            // 
            this.butpos.BackColor = System.Drawing.Color.PaleGreen;
            this.butpos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butpos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butpos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butpos.Location = new System.Drawing.Point(2, 3);
            this.butpos.Name = "butpos";
            this.butpos.Size = new System.Drawing.Size(416, 164);
            this.butpos.TabIndex = 0;
            this.butpos.Text = "POS";
            this.butpos.UseVisualStyleBackColor = false;
            this.butpos.Click += new System.EventHandler(this.butpos_Click);
            // 
            // butbackoffice
            // 
            this.butbackoffice.BackColor = System.Drawing.Color.PaleGreen;
            this.butbackoffice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butbackoffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butbackoffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butbackoffice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butbackoffice.Location = new System.Drawing.Point(2, 169);
            this.butbackoffice.Name = "butbackoffice";
            this.butbackoffice.Size = new System.Drawing.Size(416, 164);
            this.butbackoffice.TabIndex = 1;
            this.butbackoffice.Text = "BackOffice";
            this.butbackoffice.UseVisualStyleBackColor = false;
            this.butbackoffice.Click += new System.EventHandler(this.butbackoffice_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(422, 336);
            this.Controls.Add(this.butbackoffice);
            this.Controls.Add(this.butpos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butpos;
        private System.Windows.Forms.Button butbackoffice;
    }
}

