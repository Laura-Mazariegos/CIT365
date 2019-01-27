namespace MegaDesk_3_LauraMazariegos
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.addNewQuote = new System.Windows.Forms.Label();
            this.viewQuotes = new System.Windows.Forms.Label();
            this.searchQuote = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.deskPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.deskPic)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewQuote
            // 
            this.addNewQuote.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addNewQuote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addNewQuote.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewQuote.Location = new System.Drawing.Point(106, 52);
            this.addNewQuote.Name = "addNewQuote";
            this.addNewQuote.Size = new System.Drawing.Size(200, 50);
            this.addNewQuote.TabIndex = 0;
            this.addNewQuote.Text = "Add New Quote";
            this.addNewQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addNewQuote.Click += new System.EventHandler(this.addNewQuote_Click);
            // 
            // viewQuotes
            // 
            this.viewQuotes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.viewQuotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewQuotes.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuotes.Location = new System.Drawing.Point(106, 150);
            this.viewQuotes.Name = "viewQuotes";
            this.viewQuotes.Size = new System.Drawing.Size(200, 50);
            this.viewQuotes.TabIndex = 1;
            this.viewQuotes.Text = "View Quotes";
            this.viewQuotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewQuotes.Click += new System.EventHandler(this.viewQuotes_Click);
            // 
            // searchQuote
            // 
            this.searchQuote.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchQuote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchQuote.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuote.Location = new System.Drawing.Point(106, 244);
            this.searchQuote.Name = "searchQuote";
            this.searchQuote.Size = new System.Drawing.Size(200, 50);
            this.searchQuote.TabIndex = 2;
            this.searchQuote.Text = "Search Quotes";
            this.searchQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchQuote.Click += new System.EventHandler(this.searchQuote_Click);
            // 
            // exitLabel
            // 
            this.exitLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exitLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exitLabel.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.Location = new System.Drawing.Point(106, 337);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(200, 50);
            this.exitLabel.TabIndex = 3;
            this.exitLabel.Text = "Exit";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // deskPic
            // 
            this.deskPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deskPic.Image = ((System.Drawing.Image)(resources.GetObject("deskPic.Image")));
            this.deskPic.InitialImage = null;
            this.deskPic.Location = new System.Drawing.Point(351, 30);
            this.deskPic.Name = "deskPic";
            this.deskPic.Size = new System.Drawing.Size(416, 390);
            this.deskPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.deskPic.TabIndex = 4;
            this.deskPic.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deskPic);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.searchQuote);
            this.Controls.Add(this.viewQuotes);
            this.Controls.Add(this.addNewQuote);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.deskPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label addNewQuote;
        private System.Windows.Forms.Label viewQuotes;
        private System.Windows.Forms.Label searchQuote;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.PictureBox deskPic;
    }
}

