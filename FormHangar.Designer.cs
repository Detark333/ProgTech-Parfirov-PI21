namespace WindowsFormsPlains
{
    partial class FormHangar
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
            this.pictureBoxHangar = new System.Windows.Forms.PictureBox();
            this.buttonParkThePlain = new System.Windows.Forms.Button();
            this.buttonParkTheBomber = new System.Windows.Forms.Button();
            this.groupBoxForInsert = new System.Windows.Forms.GroupBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.pictureBoxTakePlain = new System.Windows.Forms.PictureBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelTakePlain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).BeginInit();
            this.groupBoxForInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakePlain)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHangar
            // 
            this.pictureBoxHangar.Location = new System.Drawing.Point(12, 23);
            this.pictureBoxHangar.Name = "pictureBoxHangar";
            this.pictureBoxHangar.Size = new System.Drawing.Size(785, 810);
            this.pictureBoxHangar.TabIndex = 0;
            this.pictureBoxHangar.TabStop = false;
            // 
            // buttonParkThePlain
            // 
            this.buttonParkThePlain.Location = new System.Drawing.Point(826, 23);
            this.buttonParkThePlain.Name = "buttonParkThePlain";
            this.buttonParkThePlain.Size = new System.Drawing.Size(128, 43);
            this.buttonParkThePlain.TabIndex = 2;
            this.buttonParkThePlain.Text = "Park The Plain";
            this.buttonParkThePlain.UseVisualStyleBackColor = true;
            this.buttonParkThePlain.Click += new System.EventHandler(this.ButtonParkThePlain_Click);
            // 
            // buttonParkTheBomber
            // 
            this.buttonParkTheBomber.Location = new System.Drawing.Point(826, 90);
            this.buttonParkTheBomber.Name = "buttonParkTheBomber";
            this.buttonParkTheBomber.Size = new System.Drawing.Size(128, 42);
            this.buttonParkTheBomber.TabIndex = 3;
            this.buttonParkTheBomber.Text = "Park The Bomber";
            this.buttonParkTheBomber.UseVisualStyleBackColor = true;
            this.buttonParkTheBomber.Click += new System.EventHandler(this.ButtonParkTheBomber_Click);
            // 
            // groupBoxForInsert
            // 
            this.groupBoxForInsert.Controls.Add(this.labelPlace);
            this.groupBoxForInsert.Controls.Add(this.pictureBoxTakePlain);
            this.groupBoxForInsert.Controls.Add(this.buttonTake);
            this.groupBoxForInsert.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxForInsert.Controls.Add(this.labelTakePlain);
            this.groupBoxForInsert.Location = new System.Drawing.Point(826, 160);
            this.groupBoxForInsert.Name = "groupBoxForInsert";
            this.groupBoxForInsert.Size = new System.Drawing.Size(330, 311);
            this.groupBoxForInsert.TabIndex = 4;
            this.groupBoxForInsert.TabStop = false;
            // 
            // labelPlace
            // 
            this.labelPlace.Location = new System.Drawing.Point(13, 48);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(45, 23);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Place";
            // 
            // pictureBoxTakePlain
            // 
            this.pictureBoxTakePlain.Location = new System.Drawing.Point(6, 130);
            this.pictureBoxTakePlain.Name = "pictureBoxTakePlain";
            this.pictureBoxTakePlain.Size = new System.Drawing.Size(304, 145);
            this.pictureBoxTakePlain.TabIndex = 3;
            this.pictureBoxTakePlain.TabStop = false;
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(6, 82);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(75, 23);
            this.buttonTake.TabIndex = 2;
            this.buttonTake.Text = "Take";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.ButtonTake_Click);
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(64, 45);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(26, 20);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // labelTakePlain
            // 
            this.labelTakePlain.AutoSize = true;
            this.labelTakePlain.Location = new System.Drawing.Point(6, 23);
            this.labelTakePlain.Name = "labelTakePlain";
            this.labelTakePlain.Size = new System.Drawing.Size(75, 13);
            this.labelTakePlain.TabIndex = 0;
            this.labelTakePlain.Text = "Take the plain";
            // 
            // FormHangar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 845);
            this.Controls.Add(this.groupBoxForInsert);
            this.Controls.Add(this.buttonParkTheBomber);
            this.Controls.Add(this.buttonParkThePlain);
            this.Controls.Add(this.pictureBoxHangar);
            this.Name = "FormHangar";
            this.Text = "Hangar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).EndInit();
            this.groupBoxForInsert.ResumeLayout(false);
            this.groupBoxForInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakePlain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHangar;
        private System.Windows.Forms.Button buttonParkThePlain;
        private System.Windows.Forms.Button buttonParkTheBomber;
        private System.Windows.Forms.GroupBox groupBoxForInsert;
        private System.Windows.Forms.PictureBox pictureBoxTakePlain;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelTakePlain;
        private System.Windows.Forms.Label labelPlace;
    }
}