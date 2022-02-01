using System;
namespace ApexRestaurant.Mvc.Models{
    public class meal_dishesViewModel
    {
        public int Meals_ID{ get; set;}
        public int Customer_ID{ get; set;}
        public int Staff_ID{ get; set;}
        public DateTime Date_of_Meal{ get; set;}
        public int Cost_of_Meal{ get; set;}
        public String Deatils{get; set;}
    }
}