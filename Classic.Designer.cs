namespace _2048
{
    partial class Classic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Classic));
            this.label1 = new System.Windows.Forms.Label();
            this.imgboard = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMoves = new System.Windows.Forms.Label();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgboard)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Clear Sans", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Classic Mode";
            // 
            // imgboard
            // 
            this.imgboard.Image = global::_2048.Properties.Resources.grid;
            this.imgboard.Location = new System.Drawing.Point(43, 68);
            this.imgboard.Name = "imgboard";
            this.imgboard.Size = new System.Drawing.Size(300, 300);
            this.imgboard.TabIndex = 2;
            this.imgboard.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(96)))), ((int)(((byte)(58)))));
            this.label2.Font = new System.Drawing.Font("Clear Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(363, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 60);
            this.label2.TabIndex = 3;
            this.label2.Text = "Score";
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(96)))), ((int)(((byte)(58)))));
            this.lblScore.Font = new System.Drawing.Font("Clear Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(363, 91);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(77, 37);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(229)))));
            this.label3.Font = new System.Drawing.Font("Clear Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(363, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 60);
            this.label3.TabIndex = 5;
            this.label3.Text = "Moves";
            // 
            // lblMoves
            // 
            this.lblMoves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(229)))));
            this.lblMoves.Font = new System.Drawing.Font("Clear Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoves.ForeColor = System.Drawing.Color.White;
            this.lblMoves.Location = new System.Drawing.Point(363, 164);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(77, 37);
            this.lblMoves.TabIndex = 6;
            this.lblMoves.Text = "0";
            this.lblMoves.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBestScore
            // 
            this.lblBestScore.AutoSize = true;
            this.lblBestScore.Font = new System.Drawing.Font("Clear Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestScore.ForeColor = System.Drawing.Color.Gray;
            this.lblBestScore.Location = new System.Drawing.Point(258, 24);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(111, 36);
            this.lblBestScore.TabIndex = 7;
            this.lblBestScore.Text = "Best Score: 0\r\nLeast Moves: N/A\r\n";
            // 
            // btnRetry
            // 
            this.btnRetry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(192)))), ((int)(((byte)(44)))));
            this.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetry.Font = new System.Drawing.Font("Clear Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetry.ForeColor = System.Drawing.Color.White;
            this.btnRetry.Location = new System.Drawing.Point(364, 274);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(76, 43);
            this.btnRetry.TabIndex = 9;
            this.btnRetry.Text = "Retry";
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Black;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Clear Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(364, 325);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(76, 43);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(197)))));
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Font = new System.Drawing.Font("Clear Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.Color.Gray;
            this.btnUndo.Location = new System.Drawing.Point(364, 222);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(76, 43);
            this.btnUndo.TabIndex = 11;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // Classic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(464, 391);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.lblBestScore);
            this.Controls.Add(this.lblMoves);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgboard);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Classic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048 Game: Classic Mode";
            ((System.ComponentModel.ISupportInitialize)(this.imgboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnUndo;
    }
}