using static GuessMyAge.StaticClass;

namespace GuessMyAge
{
    public class Game
    {
        public int AgeToGuess { get; set; }

        public int CurrentTurn { get; set; }

        public int MaxTurn { get; set; }

        public bool HasWon { get; set; }
        public bool HasQuit { get; set; }

        public InputNumberState GameState => ValidateInputNumber(this);

        public Game(int maxTurn)
        {
            MaxTurn = maxTurn;
            AgeToGuess = new Random().Next(1, 120);
            HasWon = false;
        }

        public bool CompareValues()
        {
            return AgeToGuess != _inputNumber;
        }

        public string? InputUser
        {
            set
            {
                if (int.TryParse(value, out int number))
                {
                    _inputNumber = number;
                }
                else
                {
                    _inputNumber = null;
                }
            }
        }

        private int? _inputNumber;

        public int? InputNumber
        {
            get
            {
                return _inputNumber;
            }
        }
    }
}
