using System;
using System.Windows.Forms;
using GuessNumberGameEngine;

namespace GuessNumber.WinForms
{
	public partial class MainForm : Form
	{
		private Game _game;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			_game = new Game(256, 512, 10);
		}

		private void btnStartGame_Click(object sender, EventArgs e)
		{
			Button sndr = sender as Button;
			if (sndr == null)
				return;

			sndr.Visible = false;
			tbSuggestion.Visible = true;
			btnLess.Visible = true;
			btnGuessed.Visible = true;
			btnGreater.Visible = true;

			tbSuggestion.Text = "Ваше число равно " + _game.GetSuggestion() + "?";
		}

		private void BtnLess_Click(object sender, EventArgs e)
		{
			_game.CorrectSuggestion(2);
			string message = "Ваше число равно " + _game.GetSuggestion() + "?";
			if (!_game.IsGuessing())
			{
				message = "Вы меня обманываете!";
				HideButtons();
			}
			tbSuggestion.Text = message;
		}

		private void BtnGuessed_Click(object sender, EventArgs e)
		{
			tbSuggestion.Text = "Ура, мы угадали!";
			HideButtons();
		}

		private void BtnGreater_Click(object sender, EventArgs e)
		{
			_game.CorrectSuggestion(1);
			string message = "Ваше число равно " + _game.GetSuggestion() + "?";
			if (!_game.IsGuessing())
			{
				message = "Вы меня обманываете!";
				HideButtons();
			}
			tbSuggestion.Text = message;
		}

		private void HideButtons()
		{
			btnLess.Visible = false;
			btnGuessed.Visible = false;
			btnGreater.Visible = false;
		}
	}
}
