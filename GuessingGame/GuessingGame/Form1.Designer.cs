namespace GuessingGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelFeedback = new System.Windows.Forms.Label();
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeedback.Location = new System.Drawing.Point(251, 100);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(194, 32);
            this.labelFeedback.TabIndex = 0;
            this.labelFeedback.Text = "\r\nGuess result appears here.";
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.Location = new System.Drawing.Point(86, 110);
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.Size = new System.Drawing.Size(140, 22);
            this.textBoxGuess.TabIndex = 1;
            this.textBoxGuess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxGuess_KeyDown);
            // 
            // buttonGuess
            // 
            this.buttonGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuess.Location = new System.Drawing.Point(86, 156);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(128, 30);
            this.buttonGuess.TabIndex = 2;
            this.buttonGuess.Text = "Guess";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewGame.Location = new System.Drawing.Point(245, 156);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(131, 30);
            this.buttonNewGame.TabIndex = 3;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "     I have a number between 1 and 1000.\r\ncan you guess my number? \r\n      Enter " +
    "your Guess:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(502, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.textBoxGuess);
            this.Controls.Add(this.labelFeedback);
            this.Name = "Form1";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelFeedback;
        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Label label1;
    }
}
