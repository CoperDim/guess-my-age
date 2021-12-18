namespace GuessMyAge.Models
{
    public class Game
    {
        public Person Person { get; set; }

        public int CurrentTurn { get; set; }

        public int MaxTurn { get; set; }

        public GameState GameState { get; set; }

        public Game(DateTime start, Person person, int maxTurn)
        {
            MaxTurn = maxTurn;
            Person = person;
        }

        public Game(DateTime start, DateTime? end, int personId, string userName, int id)
        {
            this.start = start;
            this.end = end;
            this.personId = personId;
            this.userName = userName;
            this.id = id;
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
        private DateTime start;
        private DateTime? end;
        private int personId;
        private string userName;
        private int id;

        public int? InputNumber
        {
            get
            {
                return _inputNumber;
            }
        }

        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public int PersonId { get; set; }
        public object UserName { get; set; }
    }
}
