using System;
namespace ApexRestaurant.Repository.Domain
{
    public class Menus
    {
        public int Menu_ID{ get; set;}
        public int Menu_Name{ get; set;}
        public DateTime Available_Date_from{ get; set;}
        public DateTime Available_Date_To{ get; set;}
        public int quantity{ get; set;}
        
    }
}