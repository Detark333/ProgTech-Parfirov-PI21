namespace WindowsFormsPlains
{
    partial class FormPlainConfig
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAddThePlain = new System.Windows.Forms.Button();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlueWhite = new System.Windows.Forms.Panel();
            this.panelGreyDark = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelGrey = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelPlane = new System.Windows.Forms.Panel();
            this.pictureBoxThePlain = new System.Windows.Forms.PictureBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.groupBoxChoice = new System.Windows.Forms.GroupBox();
            this.labelBomber = new System.Windows.Forms.Label();
            this.labelPlain = new System.Windows.Forms.Label();
            this.panelPlane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThePlain)).BeginInit();
            this.groupBoxChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(204, 266);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 19;
            this.buttonClose.Text = "Cancel";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonAddThePlain
            // 
            this.buttonAddThePlain.Location = new System.Drawing.Point(85, 266);
            this.buttonAddThePlain.Name = "buttonAddThePlain";
            this.buttonAddThePlain.Size = new System.Drawing.Size(75, 23);
            this.buttonAddThePlain.TabIndex = 18;
            this.buttonAddThePlain.Text = "Add";
            this.buttonAddThePlain.UseVisualStyleBackColor = true;
            this.buttonAddThePlain.Click += new System.EventHandler(this.ButtonAddThePlain_Click);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelBlack.Location = new System.Drawing.Point(522, 336);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(43, 36);
            this.panelBlack.TabIndex = 11;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelWhite.Location = new System.Drawing.Point(522, 294);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(43, 36);
            this.panelWhite.TabIndex = 12;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseDown);
            // 
            // panelBlueWhite
            // 
            this.panelBlueWhite.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelBlueWhite.Location = new System.Drawing.Point(571, 336);
            this.panelBlueWhite.Name = "panelBlueWhite";
            this.panelBlueWhite.Size = new System.Drawing.Size(43, 36);
            this.panelBlueWhite.TabIndex = 13;
            this.panelBlueWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseDown);
            // 
            // panelGreyDark
            // 
            this.panelGreyDark.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelGreyDark.Location = new System.Drawing.Point(571, 294);
            this.panelGreyDark.Name = "panelGreyDark";
            this.panelGreyDark.Size = new System.Drawing.Size(43, 36);
            this.panelGreyDark.TabIndex = 14;
            this.panelGreyDark.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(620, 336);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(43, 36);
            this.panelRed.TabIndex = 15;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseDown);
            // 
            // panelGrey
            // 
            this.panelGrey.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelGrey.Location = new System.Drawing.Point(620, 294);
            this.panelGrey.Name = "panelGrey";
            this.panelGrey.Size = new System.Drawing.Size(43, 36);
            this.panelGrey.TabIndex = 16;
            this.panelGrey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.DarkBlue;
            this.panelBlue.Location = new System.Drawing.Point(669, 294);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(43, 36);
            this.panelBlue.TabIndex = 17;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Gold;
            this.panelYellow.Location = new System.Drawing.Point(669, 336);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(43, 36);
            this.panelYellow.TabIndex = 9;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseDown);
            // 
            // panelPlane
            // 
            this.panelPlane.AllowDrop = true;
            this.panelPlane.Controls.Add(this.pictureBoxThePlain);
            this.panelPlane.Controls.Add(this.labelColor);
            this.panelPlane.Controls.Add(this.labelDopColor);
            this.panelPlane.Location = new System.Drawing.Point(342, 62);
            this.panelPlane.Name = "panelPlane";
            this.panelPlane.Size = new System.Drawing.Size(439, 198);
            this.panelPlane.TabIndex = 10;
            this.panelPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPlain_DragDrop);
            this.panelPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPlain_DragEnter);
            // 
            // pictureBoxThePlain
            // 
            this.pictureBoxThePlain.Location = new System.Drawing.Point(34, 12);
            this.pictureBoxThePlain.Name = "pictureBoxThePlain";
            this.pictureBoxThePlain.Size = new System.Drawing.Size(319, 183);
            this.pictureBoxThePlain.TabIndex = 0;
            this.pictureBoxThePlain.TabStop = false;
            // 
            // labelColor
            // 
            this.labelColor.AllowDrop = true;
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(359, 41);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(77, 13);
            this.labelColor.TabIndex = 5;
            this.labelColor.Text = "Оновной цвет";
            this.labelColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelColor_DragDrop);
            this.labelColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.AutoSize = true;
            this.labelDopColor.Location = new System.Drawing.Point(368, 112);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(54, 13);
            this.labelDopColor.TabIndex = 4;
            this.labelDopColor.Text = "Доп цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // groupBoxChoice
            // 
            this.groupBoxChoice.Controls.Add(this.labelBomber);
            this.groupBoxChoice.Controls.Add(this.labelPlain);
            this.groupBoxChoice.Location = new System.Drawing.Point(79, 87);
            this.groupBoxChoice.Name = "groupBoxChoice";
            this.groupBoxChoice.Size = new System.Drawing.Size(200, 100);
            this.groupBoxChoice.TabIndex = 8;
            this.groupBoxChoice.TabStop = false;
            // 
            // labelBomber
            // 
            this.labelBomber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBomber.Location = new System.Drawing.Point(6, 54);
            this.labelBomber.Name = "labelBomber";
            this.labelBomber.Size = new System.Drawing.Size(100, 23);
            this.labelBomber.TabIndex = 1;
            this.labelBomber.Text = "Bomber";
            this.labelBomber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBomber_MouseDown);
            // 
            // labelPlain
            // 
            this.labelPlain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlain.Location = new System.Drawing.Point(6, 16);
            this.labelPlain.Name = "labelPlain";
            this.labelPlain.Size = new System.Drawing.Size(100, 23);
            this.labelPlain.TabIndex = 0;
            this.labelPlain.Text = "Plain";
            this.labelPlain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPlain_MouseDown);
            // 
            // FormPlainConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 435);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAddThePlain);
            this.Controls.Add(this.panelBlack);
            this.Controls.Add(this.panelWhite);
            this.Controls.Add(this.panelBlueWhite);
            this.Controls.Add(this.panelGreyDark);
            this.Controls.Add(this.panelRed);
            this.Controls.Add(this.panelGrey);
            this.Controls.Add(this.panelBlue);
            this.Controls.Add(this.panelYellow);
            this.Controls.Add(this.panelPlane);
            this.Controls.Add(this.groupBoxChoice);
            this.Name = "FormPlainConfig";
            this.Text = "ChoicePlain";
            this.panelPlane.ResumeLayout(false);
            this.panelPlane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThePlain)).EndInit();
            this.groupBoxChoice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAddThePlain;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlueWhite;
        private System.Windows.Forms.Panel panelGreyDark;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelGrey;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelPlane;
        private System.Windows.Forms.PictureBox pictureBoxThePlain;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.GroupBox groupBoxChoice;
        private System.Windows.Forms.Label labelBomber;
        private System.Windows.Forms.Label labelPlain;
    }
}