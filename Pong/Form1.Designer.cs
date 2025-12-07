namespace Pong
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
            this.components = new System.ComponentModel.Container();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.Movement = new System.Windows.Forms.Timer(this.components);
            this.Score = new System.Windows.Forms.Label();
            this.Players_movement = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.player2.Location = new System.Drawing.Point(12, 152);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(30, 241);
            this.player2.TabIndex = 0;
            this.player2.TabStop = false;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.player1.Location = new System.Drawing.Point(1373, 152);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(30, 241);
            this.player1.TabIndex = 1;
            this.player1.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ball.Location = new System.Drawing.Point(-7, 461);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(49, 46);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // Movement
            // 
            this.Movement.Interval = 10;
            this.Movement.Tick += new System.EventHandler(this.Movement_Tick);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Score.Font = new System.Drawing.Font("Courier New", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Score.Location = new System.Drawing.Point(588, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(221, 110);
            this.Score.TabIndex = 3;
            this.Score.Text = "0:0";
            // 
            // Players_movement
            // 
            this.Players_movement.Interval = 10;
            this.Players_movement.Tick += new System.EventHandler(this.Players_movement_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1415, 774);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.player2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer Movement;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer Players_movement;
    }
}

