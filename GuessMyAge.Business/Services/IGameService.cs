using GuessMyAge.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyAge.Business.Services
{
    public interface IGameService
    {
        Game Run(Person person);

    }
}
