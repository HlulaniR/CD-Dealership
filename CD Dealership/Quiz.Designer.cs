
namespace CD_Dealership
{
	partial class Quiz
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
			this.label1 = new System.Windows.Forms.Label();
			this.quizAnswer = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.lblQuestion = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label1.Location = new System.Drawing.Point(113, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quiz ";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// quizAnswer
			// 
			this.quizAnswer.Location = new System.Drawing.Point(159, 47);
			this.quizAnswer.Name = "quizAnswer";
			this.quizAnswer.Size = new System.Drawing.Size(130, 22);
			this.quizAnswer.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(100, 75);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 31);
			this.button1.TabIndex = 2;
			this.button1.Text = "Continue";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblQuestion
			// 
			this.lblQuestion.AutoSize = true;
			this.lblQuestion.Location = new System.Drawing.Point(49, 50);
			this.lblQuestion.Name = "lblQuestion";
			this.lblQuestion.Size = new System.Drawing.Size(46, 17);
			this.lblQuestion.TabIndex = 3;
			this.lblQuestion.Text = "label2";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// Quiz
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(308, 123);
			this.Controls.Add(this.lblQuestion);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.quizAnswer);
			this.Controls.Add(this.label1);
			this.Name = "Quiz";
			this.Text = "Quiz";
			this.Load += new System.EventHandler(this.Quiz_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox quizAnswer;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblQuestion;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}