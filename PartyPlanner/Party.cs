
namespace PartyPlanner
{
    class Party
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        virtual public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecoration() + CostOfFoodPerPerson * NumberOfPeople;
                

                if (NumberOfPeople > 12)
                    totalCost += 100;

                return totalCost;
            }
        }

        public const int CostOfFoodPerPerson = 25;

        private decimal CalculateCostOfDecoration()
        {
            return FancyDecorations ? 15 * NumberOfPeople + 50M : 7.5M * NumberOfPeople + 30M;
        }
    }
}
