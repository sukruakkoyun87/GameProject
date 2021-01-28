using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concreate
{
    class SalesManager:ISalesService
    {
        public void SellGame(Players players, Game game)
        {
            Console.WriteLine("Satın Alma işlemi \n Alıcı : "+players.FirstName+" "+players.LastName+" \n Oyun Adı :"+game.Name+" \n Oyunun Fiyatı : " +game.Price);
        }

        public void CampaignGame(Players players, Game game,Campaign campaign)
        {
            Console.WriteLine("Satın Alma işlemi \n Alıcı : " + players.FirstName + " " + players.LastName + " \n Oyun Adı :" + game.Name + " \n Kamapnyalı Oyun Adı  : " +campaign.CampignName+"\n İndirim Oranı : %"+campaign.DiscountRate*10+"\n Kampanyalı Fiyatı : "+(game.Price*(1-campaign.DiscountRate)));
        }
    }
}
