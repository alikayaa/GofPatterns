namespace Mediator
{
    partial class contactForm
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
            this.contactList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // contactList
            // 
            this.contactList.FormattingEnabled = true;
            this.contactList.Location = new System.Drawing.Point(1, -1);
            this.contactList.Name = "contactList";
            this.contactList.Size = new System.Drawing.Size(591, 329);
            this.contactList.TabIndex = 0;
            this.contactList.SelectedIndexChanged += new System.EventHandler(this.contactList_SelectedIndexChanged);
            // 
            // contactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 328);
            this.Controls.Add(this.contactList);
            this.Name = "contactForm";
            this.Text = "Kişiler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox contactList;
    }
}

