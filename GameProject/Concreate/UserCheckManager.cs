using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concreate
{
    public class UserCheckManager:IUserCheckService
    {
        public bool UserCheck(Players players)
        {
            if (players.FirstName=="Ahmet" && players.LastName=="Yılmaz" && players.BirtDateYear=="1986"&&players.NationalId==123456789)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
