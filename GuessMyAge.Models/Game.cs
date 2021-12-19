namespace GuessMyAge.Models
{
    public class Game
    {
        public Person Person { get; set; }

        public int CurrentTurn { get; set; }


        public DateTime Start { get; set; }
        
        public DateTime? End { get; set; }

        public string UserName { get; set; }
        public int MaxTurn { get; set; }

        public GameState GameState { get; set; }



        public Game()
        {
            
        }
        public Game(Person person, int maxTurn)
        {
            MaxTurn = maxTurn;
            Person = person;
        }

        public void ValidateInputNumber()
        {
            if (InputUser == "q")
            {
                GameState = GameState.isCancelled;
                return;
            }

            if (!InputNumber.HasValue)
            {
                GameState = GameState.IsUnValidOrNull;
            }
            else
            {
                GameState = InputNumber == Person.Age ? GameState.IsEqual : InputNumber > Person.Age ? GameState.IsUp : GameState.IsDown;
            }
        }

        private string? _inputUser;
        public string? InputUser
        {
            get
            {
                return _inputUser;
            }
            set
            {
                _inputUser = value;
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
