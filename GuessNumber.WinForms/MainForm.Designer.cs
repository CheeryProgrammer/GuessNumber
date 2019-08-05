namespace GuessNumber.WinForms
{
	partial class MainForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnStartGame = new System.Windows.Forms.Button();
			this.tbSuggestion = new System.Windows.Forms.TextBox();
			this.btnLess = new System.Windows.Forms.Button();
			this.btnGuessed = new System.Windows.Forms.Button();
			this.btnGreater = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(133, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(186, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Приветствую в игре Загадай число";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(121, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(210, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Загадай число от 1 до 1023 и нажми ОК";
			// 
			// btnStartGame
			// 
			this.btnStartGame.Location = new System.Drawing.Point(186, 74);
			this.btnStartGame.Name = "btnStartGame";
			this.btnStartGame.Size = new System.Drawing.Size(75, 23);
			this.btnStartGame.TabIndex = 2;
			this.btnStartGame.Text = "OK";
			this.btnStartGame.UseVisualStyleBackColor = true;
			this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
			// 
			// tbSuggestion
			// 
			this.tbSuggestion.Location = new System.Drawing.Point(63, 115);
			this.tbSuggestion.Name = "tbSuggestion";
			this.tbSuggestion.ReadOnly = true;
			this.tbSuggestion.Size = new System.Drawing.Size(319, 20);
			this.tbSuggestion.TabIndex = 3;
			this.tbSuggestion.Visible = false;
			// 
			// btnLess
			// 
			this.btnLess.Location = new System.Drawing.Point(87, 142);
			this.btnLess.Name = "btnLess";
			this.btnLess.Size = new System.Drawing.Size(75, 23);
			this.btnLess.TabIndex = 4;
			this.btnLess.Text = "Меньше";
			this.btnLess.UseVisualStyleBackColor = true;
			this.btnLess.Visible = false;
			this.btnLess.Click += new System.EventHandler(this.BtnLess_Click);
			// 
			// btnGuessed
			// 
			this.btnGuessed.Location = new System.Drawing.Point(186, 142);
			this.btnGuessed.Name = "btnGuessed";
			this.btnGuessed.Size = new System.Drawing.Size(75, 23);
			this.btnGuessed.TabIndex = 4;
			this.btnGuessed.Text = "Угадали!";
			this.btnGuessed.UseVisualStyleBackColor = true;
			this.btnGuessed.Visible = false;
			this.btnGuessed.Click += new System.EventHandler(this.BtnGuessed_Click);
			// 
			// btnGreater
			// 
			this.btnGreater.Location = new System.Drawing.Point(287, 142);
			this.btnGreater.Name = "btnGreater";
			this.btnGreater.Size = new System.Drawing.Size(75, 23);
			this.btnGreater.TabIndex = 4;
			this.btnGreater.Text = "Больше";
			this.btnGreater.UseVisualStyleBackColor = true;
			this.btnGreater.Visible = false;
			this.btnGreater.Click += new System.EventHandler(this.BtnGreater_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(456, 258);
			this.Controls.Add(this.btnGreater);
			this.Controls.Add(this.btnGuessed);
			this.Controls.Add(this.btnLess);
			this.Controls.Add(this.tbSuggestion);
			this.Controls.Add(this.btnStartGame);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Игра \"Загадай число\"";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnStartGame;
		private System.Windows.Forms.TextBox tbSuggestion;
		private System.Windows.Forms.Button btnLess;
		private System.Windows.Forms.Button btnGuessed;
		private System.Windows.Forms.Button btnGreater;
	}
}

