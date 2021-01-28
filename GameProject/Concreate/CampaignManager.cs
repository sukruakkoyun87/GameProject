using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concreate
{
    public class CampaignManager:ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("New Campaign Added  : " +campaign.CampignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("New Campaign Updated  : " + campaign.CampignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("New Campaign Deleted  : " + campaign.CampignName);
        }
    }
}
