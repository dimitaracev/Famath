namespace Famath
{
    partial class FamathWindow
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
            this.components = new System.ComponentModel.Container();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.expression = new System.Windows.Forms.Label();
            this.time_left = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.current_score = new System.Windows.Forms.Label();
            this.tryAgain = new System.Windows.Forms.Button();
            this.eq = new System.Windows.Forms.Label();
            this.gameOver = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // expression
            // 
            this.expression.AutoSize = true;
            this.expression.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expression.ForeColor = System.Drawing.Color.White;
            this.expression.Location = new System.Drawing.Point(132, 163);
            this.expression.Name = "expression";
            this.expression.Size = new System.Drawing.Size(0, 36);
            this.expression.TabIndex = 0;
            // 
            // time_left
            // 
            this.time_left.AutoSize = true;
            this.time_left.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_left.ForeColor = System.Drawing.Color.White;
            this.time_left.Location = new System.Drawing.Point(384, 404);
            this.time_left.Name = "time_left";
            this.time_left.Size = new System.Drawing.Size(0, 36);
            this.time_left.TabIndex = 2;
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(559, 166);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(100, 44);
            this.answer.TabIndex = 3;
            this.answer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.answer_KeyPress);
            // 
            // current_score
            // 
            this.current_score.AutoSize = true;
            this.current_score.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_score.ForeColor = System.Drawing.Color.White;
            this.current_score.Location = new System.Drawing.Point(339, 9);
            this.current_score.Name = "current_score";
            this.current_score.Size = new System.Drawing.Size(133, 36);
            this.current_score.TabIndex = 4;
            this.current_score.Text = "Score: 0";
            // 
            // tryAgain
            // 
            this.tryAgain.BackColor = System.Drawing.Color.Teal;
            this.tryAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tryAgain.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryAgain.ForeColor = System.Drawing.Color.White;
            this.tryAgain.Location = new System.Drawing.Point(330, 273);
            this.tryAgain.Name = "tryAgain";
            this.tryAgain.Size = new System.Drawing.Size(175, 56);
            this.tryAgain.TabIndex = 5;
            this.tryAgain.Text = "Try Again?";
            this.tryAgain.UseVisualStyleBackColor = false;
            this.tryAgain.Click += new System.EventHandler(this.tryAgain_Click);
            // 
            // eq
            // 
            this.eq.AutoSize = true;
            this.eq.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eq.ForeColor = System.Drawing.Color.White;
            this.eq.Location = new System.Drawing.Point(438, 174);
            this.eq.Name = "eq";
            this.eq.Size = new System.Drawing.Size(34, 36);
            this.eq.TabIndex = 6;
            this.eq.Text = "=";
            // 
            // gameOver
            // 
            this.gameOver.AutoSize = true;
            this.gameOver.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver.ForeColor = System.Drawing.Color.White;
            this.gameOver.Location = new System.Drawing.Point(235, 174);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(365, 72);
            this.gameOver.TabIndex = 7;
            this.gameOver.Text = "Game Over";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Teal;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(647, 392);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(101, 36);
            this.back.TabIndex = 8;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // FamathWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.back);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.eq);
            this.Controls.Add(this.tryAgain);
            this.Controls.Add(this.current_score);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.time_left);
            this.Controls.Add(this.expression);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FamathWindow";
            this.Text = "Famath";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FamathWindow_FormClosed);
            this.Load += new System.EventHandler(this.FamathWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label expression;
        private System.Windows.Forms.Label time_left;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label current_score;
        private System.Windows.Forms.Button tryAgain;
        private System.Windows.Forms.Label eq;
        private System.Windows.Forms.Label gameOver;
        private System.Windows.Forms.Button back;
    }
}

