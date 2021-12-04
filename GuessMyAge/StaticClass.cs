namespace GuessMyAge
{
    public static class StaticClass
    {
        public const int Turns = 10;

        // Cette méthode est une extension de la classe Game, qui permet de déterminer si la partie est terminée

        public static bool isFinishedGame(this Game game)
        {
            return game.CurrentTurn >= Turns || game.HasWon || game.HasQuit;
        }
        // Enum permettant de déterminer facilement le statut de la valeur saisie
        public enum InputNumberState
        {
            IsUp,
            IsDown,
            IsEqual,
            IsUnValidOrNull
        }

        // Cette méthode est un helper serant à valider le nombre saisie
        public static InputNumberState ValidateInputNumber(Game game)
        {
            if (!game.InputNumber.HasValue)
                return InputNumberState.IsUnValidOrNull;

            if (game.InputNumber.Value.Equals(game.AgeToGuess))
                return InputNumberState.IsEqual;

            if (game.InputNumber > game.AgeToGuess)
                return InputNumberState.IsUp;

            return InputNumberState.IsDown;
        }

    }
}
