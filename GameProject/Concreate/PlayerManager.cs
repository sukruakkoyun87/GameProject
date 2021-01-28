using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concreate
{
    public class PlayerManager:IPlayersService
    {
        private IUserCheckService _userCheckService;

        public PlayerManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }

        public void Add(Players players)
        {
            if (_userCheckService.UserCheck(players))
            {
                Console.WriteLine("Gamer Added ");
            }
            else
            {
                Console.WriteLine("Not a valid Gamer");
            }
         
        }

        public void Update(Players players)
        {
            Console.WriteLine("Gamer  Updated ");
        }

        public void Delete(Players players)
        {
            Console.WriteLine("Gamer Deleted ");
        }
    }
}
