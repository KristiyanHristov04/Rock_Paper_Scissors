namespace Rock_Paper_Scissors_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerQuestionImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.enemyQuestionImage = new System.Windows.Forms.PictureBox();
            this.playerPaperImage = new System.Windows.Forms.PictureBox();
            this.enemyPaperImage = new System.Windows.Forms.PictureBox();
            this.playerRockImage = new System.Windows.Forms.PictureBox();
            this.enemyRockImage = new System.Windows.Forms.PictureBox();
            this.playerScissorsImage = new System.Windows.Forms.PictureBox();
            this.enemyScissorsImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scoreTextBox2 = new System.Windows.Forms.TextBox();
            this.scoreTextBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerQuestionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyQuestionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPaperImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPaperImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRockImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyRockImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerScissorsImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyScissorsImage)).BeginInit();
            this.SuspendLayout();
            // 
            // playerQuestionImage
            // 
            this.playerQuestionImage.Image = ((System.Drawing.Image)(resources.GetObject("playerQuestionImage.Image")));
            this.playerQuestionImage.Location = new System.Drawing.Point(21, 121);
            this.playerQuestionImage.Name = "playerQuestionImage";
            this.playerQuestionImage.Size = new System.Drawing.Size(298, 299);
            this.playerQuestionImage.TabIndex = 0;
            this.playerQuestionImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(21, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "ROCK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(305, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "PAPER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(584, 506);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "SCISSORS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // enemyQuestionImage
            // 
            this.enemyQuestionImage.Image = ((System.Drawing.Image)(resources.GetObject("enemyQuestionImage.Image")));
            this.enemyQuestionImage.Location = new System.Drawing.Point(461, 121);
            this.enemyQuestionImage.Name = "enemyQuestionImage";
            this.enemyQuestionImage.Size = new System.Drawing.Size(298, 299);
            this.enemyQuestionImage.TabIndex = 4;
            this.enemyQuestionImage.TabStop = false;
            // 
            // playerPaperImage
            // 
            this.playerPaperImage.Image = ((System.Drawing.Image)(resources.GetObject("playerPaperImage.Image")));
            this.playerPaperImage.Location = new System.Drawing.Point(21, 121);
            this.playerPaperImage.Name = "playerPaperImage";
            this.playerPaperImage.Size = new System.Drawing.Size(298, 299);
            this.playerPaperImage.TabIndex = 5;
            this.playerPaperImage.TabStop = false;
            this.playerPaperImage.Visible = false;
            // 
            // enemyPaperImage
            // 
            this.enemyPaperImage.Image = ((System.Drawing.Image)(resources.GetObject("enemyPaperImage.Image")));
            this.enemyPaperImage.Location = new System.Drawing.Point(461, 121);
            this.enemyPaperImage.Name = "enemyPaperImage";
            this.enemyPaperImage.Size = new System.Drawing.Size(298, 299);
            this.enemyPaperImage.TabIndex = 6;
            this.enemyPaperImage.TabStop = false;
            this.enemyPaperImage.Visible = false;
            // 
            // playerRockImage
            // 
            this.playerRockImage.Image = ((System.Drawing.Image)(resources.GetObject("playerRockImage.Image")));
            this.playerRockImage.Location = new System.Drawing.Point(21, 121);
            this.playerRockImage.Name = "playerRockImage";
            this.playerRockImage.Size = new System.Drawing.Size(298, 299);
            this.playerRockImage.TabIndex = 7;
            this.playerRockImage.TabStop = false;
            this.playerRockImage.Visible = false;
            // 
            // enemyRockImage
            // 
            this.enemyRockImage.Image = ((System.Drawing.Image)(resources.GetObject("enemyRockImage.Image")));
            this.enemyRockImage.Location = new System.Drawing.Point(461, 121);
            this.enemyRockImage.Name = "enemyRockImage";
            this.enemyRockImage.Size = new System.Drawing.Size(298, 299);
            this.enemyRockImage.TabIndex = 8;
            this.enemyRockImage.TabStop = false;
            this.enemyRockImage.Visible = false;
            // 
            // playerScissorsImage
            // 
            this.playerScissorsImage.Image = ((System.Drawing.Image)(resources.GetObject("playerScissorsImage.Image")));
            this.playerScissorsImage.Location = new System.Drawing.Point(21, 121);
            this.playerScissorsImage.Name = "playerScissorsImage";
            this.playerScissorsImage.Size = new System.Drawing.Size(298, 299);
            this.playerScissorsImage.TabIndex = 9;
            this.playerScissorsImage.TabStop = false;
            this.playerScissorsImage.Visible = false;
            // 
            // enemyScissorsImage
            // 
            this.enemyScissorsImage.Image = ((System.Drawing.Image)(resources.GetObject("enemyScissorsImage.Image")));
            this.enemyScissorsImage.Location = new System.Drawing.Point(461, 121);
            this.enemyScissorsImage.Name = "enemyScissorsImage";
            this.enemyScissorsImage.Size = new System.Drawing.Size(298, 299);
            this.enemyScissorsImage.TabIndex = 10;
            this.enemyScissorsImage.TabStop = false;
            this.enemyScissorsImage.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(376, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 40);
            this.label2.TabIndex = 12;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(81, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 40);
            this.label1.TabIndex = 14;
            this.label1.Text = "Player 1(You)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(520, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 40);
            this.label3.TabIndex = 15;
            this.label3.Text = "Player 2(AI)";
            // 
            // scoreTextBox2
            // 
            this.scoreTextBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.scoreTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoreTextBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.scoreTextBox2.Font = new System.Drawing.Font("Comic Sans MS", 21.75F);
            this.scoreTextBox2.Location = new System.Drawing.Point(404, 251);
            this.scoreTextBox2.Name = "scoreTextBox2";
            this.scoreTextBox2.ReadOnly = true;
            this.scoreTextBox2.Size = new System.Drawing.Size(51, 41);
            this.scoreTextBox2.TabIndex = 16;
            this.scoreTextBox2.Text = "0";
            this.scoreTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // scoreTextBox1
            // 
            this.scoreTextBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.scoreTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoreTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.scoreTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F);
            this.scoreTextBox1.Location = new System.Drawing.Point(325, 251);
            this.scoreTextBox1.Name = "scoreTextBox1";
            this.scoreTextBox1.ReadOnly = true;
            this.scoreTextBox1.Size = new System.Drawing.Size(51, 41);
            this.scoreTextBox1.TabIndex = 17;
            this.scoreTextBox1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(781, 634);
            this.Controls.Add(this.scoreTextBox1);
            this.Controls.Add(this.scoreTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enemyScissorsImage);
            this.Controls.Add(this.playerScissorsImage);
            this.Controls.Add(this.enemyRockImage);
            this.Controls.Add(this.playerRockImage);
            this.Controls.Add(this.enemyPaperImage);
            this.Controls.Add(this.playerPaperImage);
            this.Controls.Add(this.enemyQuestionImage);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playerQuestionImage);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerQuestionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyQuestionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPaperImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPaperImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRockImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyRockImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerScissorsImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyScissorsImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerQuestionImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox enemyQuestionImage;
        private System.Windows.Forms.PictureBox playerPaperImage;
        private System.Windows.Forms.PictureBox enemyPaperImage;
        private System.Windows.Forms.PictureBox playerRockImage;
        private System.Windows.Forms.PictureBox enemyRockImage;
        private System.Windows.Forms.PictureBox playerScissorsImage;
        private System.Windows.Forms.PictureBox enemyScissorsImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox scoreTextBox2;
        private System.Windows.Forms.TextBox scoreTextBox1;
    }
}

