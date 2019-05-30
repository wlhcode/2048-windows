namespace _2048
{
    partial class TitleScr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleScr));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnclassic = new System.Windows.Forms.Button();
            this.btnoptions = new System.Windows.Forms.Button();
            this.btnnoob = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Clear Sans", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "2048 Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(141)))), ((int)(((byte)(83)))));
            this.label2.Font = new System.Drawing.Font("Clear Sans", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Windows PC Port";
            // 
            // btnclassic
            // 
            this.btnclassic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(192)))), ((int)(((byte)(44)))));
            this.btnclassic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclassic.Font = new System.Drawing.Font("Clear Sans", 14.25F);
            this.btnclassic.ForeColor = System.Drawing.Color.White;
            this.btnclassic.Location = new System.Drawing.Point(53, 126);
            this.btnclassic.Name = "btnclassic";
            this.btnclassic.Size = new System.Drawing.Size(356, 45);
            this.btnclassic.TabIndex = 2;
            this.btnclassic.Text = "Classic Mode";
            this.btnclassic.UseVisualStyleBackColor = false;
            this.btnclassic.Click += new System.EventHandler(this.btnclassic_Click);
            // 
            // btnoptions
            // 
            this.btnoptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(96)))), ((int)(((byte)(58)))));
            this.btnoptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnoptions.Font = new System.Drawing.Font("Clear Sans", 14.25F);
            this.btnoptions.ForeColor = System.Drawing.Color.White;
            this.btnoptions.Location = new System.Drawing.Point(53, 191);
            this.btnoptions.Name = "btnoptions";
            this.btnoptions.Size = new System.Drawing.Size(356, 45);
            this.btnoptions.TabIndex = 4;
            this.btnoptions.Text = "Options";
            this.btnoptions.UseVisualStyleBackColor = false;
            // 
            // btnnoob
            // 
            this.btnnoob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(229)))));
            this.btnnoob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnoob.Font = new System.Drawing.Font("Clear Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnoob.ForeColor = System.Drawing.Color.White;
            this.btnnoob.Location = new System.Drawing.Point(53, 256);
            this.btnnoob.Name = "btnnoob";
            this.btnnoob.Size = new System.Drawing.Size(356, 45);
            this.btnnoob.TabIndex = 5;
            this.btnnoob.Text = "How to Play";
            this.btnnoob.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Clear Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "© 2014 Gabriele Cirulli, 2019 wlhode";
            // 
            // TitleScr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(464, 391);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnnoob);
            this.Controls.Add(this.btnoptions);
            this.Controls.Add(this.btnclassic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TitleScr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048 Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnclassic;
        private System.Windows.Forms.Button btnoptions;
        private System.Windows.Forms.Button btnnoob;
        private System.Windows.Forms.Label label3;
    }
}

