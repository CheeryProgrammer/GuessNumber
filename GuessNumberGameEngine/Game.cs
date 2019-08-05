namespace GuessNumberGameEngine
{
	public class Game
	{
		private int _correction;
		private int _suggestion;
		private int _attemptsRemain;

		public Game(int correction, int suggestion, int attempts)
		{
			_correction = correction;
			_suggestion = suggestion;
			_attemptsRemain = attempts;
		}

		public bool IsGuessing()
		{
			return _attemptsRemain >= 1;
		}

		public int GetAttemptsCount()
		{
			return _attemptsRemain;
		}

		public int GetSuggestion()
		{
			return _suggestion;
		}

		public void CorrectSuggestion(int response)
		{
			_attemptsRemain--; // attemptsRemain = attemtsRemain - 1;

			if (response == 1)
			{
				_suggestion = _suggestion + _correction; // suggestion += correction;
				_correction /= 2;
			}

			if (response == 2)
			{
				_suggestion = _suggestion - _correction;
				_correction /= 2;
			}
		}
	}
}
