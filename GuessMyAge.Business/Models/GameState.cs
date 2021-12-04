using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyAge.Business.Models
{
    public enum GameState
    {
        IsUp,
        IsDown,
        IsEqual,
        IsUnValidOrNull,
        isCancelled
    }
}
