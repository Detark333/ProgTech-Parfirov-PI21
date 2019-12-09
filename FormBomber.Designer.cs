namespace WindowsFormsPlains
{
    partial class FormBomber
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreateBomber = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.pictureBoxPlainGo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlainGo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateBomber
            // 
            this.buttonCreateBomber.Location = new System.Drawing.Point(0, 0);
            this.buttonCreateBomber.Name = "buttonCreateBomber";
            this.buttonCreateBomber.Size = new System.Drawing.Size(66, 36);
            this.buttonCreateBomber.TabIndex = 1;
            this.buttonCreateBomber.Text = "Create Bomber";
            this.buttonCreateBomber.UseVisualStyleBackColor = true;
            this.buttonCreateBomber.Click += new System.EventHandler(this.ButtonCreateBomber_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = global::WindowsFormsPlains.Properties.Resources.strelka;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(552, 383);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(52, 29);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = global::WindowsFormsPlains.Properties.Resources.kisspng_arrow_computer_icons_clip_art_right_arrow_5acd1ace7a7a52_9997753315233911825017;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(622, 379);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(44, 33);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = global::WindowsFormsPlains.Properties.Resources._1kisspng_computer_icons_arrow_5af6c198f285c3_3358351615261208569934;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(483, 379);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(50, 33);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = global::WindowsFormsPlains.Properties.Resources.UpButton;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(554, 343);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(50, 34);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // pictureBoxPlainGo
            // 
            this.pictureBoxPlainGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPlainGo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPlainGo.Name = "pictureBoxPlainGo";
            this.pictureBoxPlainGo.Size = new System.Drawing.Size(695, 412);
            this.pictureBoxPlainGo.TabIndex = 0;
            this.pictureBoxPlainGo.TabStop = false;
            // 
            // FormBomber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 412);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreateBomber);
            this.Controls.Add(this.pictureBoxPlainGo);
            this.Name = "FormBomber";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlainGo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlainGo;
        private System.Windows.Forms.Button buttonCreateBomber;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
    }
}

