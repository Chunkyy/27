namespace _27
{
    partial class Bobs_27
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
            this.oneBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.boardNumber = new System.Windows.Forms.Label();
            this.dblValue = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.scoreValue = new System.Windows.Forms.Label();
            this.missBtn = new System.Windows.Forms.Button();
            this.ngBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oneBtn
            // 
            this.oneBtn.Location = new System.Drawing.Point(7, 104);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(131, 61);
            this.oneBtn.TabIndex = 0;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;
            this.oneBtn.Click += new System.EventHandler(this.oneBtn_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.Location = new System.Drawing.Point(144, 104);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(131, 61);
            this.twoBtn.TabIndex = 1;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = true;
            this.twoBtn.Click += new System.EventHandler(this.twoBtn_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.Location = new System.Drawing.Point(281, 104);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(131, 61);
            this.threeBtn.TabIndex = 2;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;
            this.threeBtn.Click += new System.EventHandler(this.threeBtn_Click);
            // 
            // boardNumber
            // 
            this.boardNumber.AutoSize = true;
            this.boardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boardNumber.Location = new System.Drawing.Point(35, 9);
            this.boardNumber.Name = "boardNumber";
            this.boardNumber.Size = new System.Drawing.Size(81, 26);
            this.boardNumber.TabIndex = 3;
            this.boardNumber.Text = "Double";
            // 
            // dblValue
            // 
            this.dblValue.AutoSize = true;
            this.dblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dblValue.Location = new System.Drawing.Point(31, 35);
            this.dblValue.Name = "dblValue";
            this.dblValue.Size = new System.Drawing.Size(46, 51);
            this.dblValue.TabIndex = 4;
            this.dblValue.Text = "1";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(307, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(69, 26);
            this.score.TabIndex = 5;
            this.score.Text = "Score";
            // 
            // scoreValue
            // 
            this.scoreValue.AutoSize = true;
            this.scoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreValue.Location = new System.Drawing.Point(294, 35);
            this.scoreValue.Name = "scoreValue";
            this.scoreValue.Size = new System.Drawing.Size(70, 51);
            this.scoreValue.TabIndex = 6;
            this.scoreValue.Text = "27";
            // 
            // missBtn
            // 
            this.missBtn.Location = new System.Drawing.Point(144, 35);
            this.missBtn.Name = "missBtn";
            this.missBtn.Size = new System.Drawing.Size(131, 61);
            this.missBtn.TabIndex = 7;
            this.missBtn.Text = "Miss";
            this.missBtn.UseVisualStyleBackColor = true;
            this.missBtn.Click += new System.EventHandler(this.missBtn_Click);
            // 
            // ngBtn
            // 
            this.ngBtn.Location = new System.Drawing.Point(175, 6);
            this.ngBtn.Name = "ngBtn";
            this.ngBtn.Size = new System.Drawing.Size(75, 23);
            this.ngBtn.TabIndex = 8;
            this.ngBtn.Text = "New Game";
            this.ngBtn.UseVisualStyleBackColor = true;
            this.ngBtn.Click += new System.EventHandler(this.NgBtn_Click);
            // 
            // Bobs_27
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 173);
            this.Controls.Add(this.ngBtn);
            this.Controls.Add(this.missBtn);
            this.Controls.Add(this.scoreValue);
            this.Controls.Add(this.score);
            this.Controls.Add(this.dblValue);
            this.Controls.Add(this.boardNumber);
            this.Controls.Add(this.threeBtn);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.oneBtn);
            this.Name = "Bobs_27";
            this.Text = "27";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Label boardNumber;
        private System.Windows.Forms.Label dblValue;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label scoreValue;
        private System.Windows.Forms.Button missBtn;
        private System.Windows.Forms.Button ngBtn;
    }
}

