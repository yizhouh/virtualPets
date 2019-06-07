using System;

namespace cs_VirtualPets
{
    static class ToysAndSupplies
    {
        private static string[] Toys = new string[]{"toy1", "toy2", "toy3"};
        private static string[] DressUps = new string[]{"dressup1", "dressup2", "dressup3"};
        private static string[] Food = new string[]{"food1", "food2", "food3"};

        //comfort pet do increase the relationship to master 
        public static void ComfortPets(IPets pet, string comfortOption)
        {
            if(comfortOption.ToLower() == "toy")
            {
                //do toys
            }
            else if(comfortOption.ToLower() == "dressup")
            {
                //do dressup
            }
            else if(comfortOption.ToLower() == "food")
            {
                //do food
            }
            else
            {
                //retrun
            }
        }
    }
}