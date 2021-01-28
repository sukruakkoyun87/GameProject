using System;
using GameProject.Abstract;
using GameProject.Concreate;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            PlayerManager playerManager = new PlayerManager(new UserCheckManager());
            CampaignManager campaignManager = new CampaignManager();
            SalesManager salesManager = new SalesManager();
          
            Game game1 = new Game
            {
                Id = 1,
                Name = "PlayerUnknown's Battlegrounds",
                Price = 87
            };
            Game game2 = new Game
            {
                Id = 2,
                Name = "Counter-Strike: Global Offensive",
                Price = 127
            };
            Game game3 = new Game
            {
                Id = 3,
                Name = "Valorant",
                Price = 50
            };




            Console.WriteLine("\n------ Kullanıcı Ekle Sil Güncelle  Yönetimi-------\n");
            Players player1 = new Players()
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Yılmaz",
                BirtDateYear = "1986",
                NationalId =  123456789
            };
            

            playerManager.Add(player1);
            playerManager.Update(player1);
            playerManager.Delete(player1);
          

            Console.WriteLine("\n------ Kampanya Ekle Sil Güncelle Yönetimi -------\n");

            Campaign campaign1 = new Campaign
            {
                CampignName = "Yeni Oyuncu İndirimi",
                DiscountRate = 0.1
            };
            Campaign campaign2 = new Campaign
            {
                CampignName = "Kış İndirimi",
                DiscountRate = 0.2
            };
            Campaign campaign3 = new Campaign
            {
                CampignName = "Yeni Sezon İndirimi",
                DiscountRate = 0.3
            };
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign2);
            campaignManager.Delete(campaign1);

            Console.WriteLine("\n------ Normal Satış -------\n");


            salesManager.SellGame(player1, game3);

            Console.WriteLine("\n------ Kampanyalı  Satış -------\n");

            salesManager.CampaignGame(player1, game2, campaign2);
            Console.WriteLine();
            salesManager.CampaignGame(player1,game1, campaign3);

        }
    }
}
