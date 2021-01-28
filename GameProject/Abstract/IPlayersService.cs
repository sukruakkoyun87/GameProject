using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    interface IPlayersService
    {
        void Add(Players players);
        void Update(Players players);
        void Delete(Players players);

    }
}
