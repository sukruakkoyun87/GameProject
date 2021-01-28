using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
   public  interface ISalesService
   {
       void SellGame(Players players, Game game);
       void CampaignGame(Players players, Game game,Campaign campaign);
   }
}
