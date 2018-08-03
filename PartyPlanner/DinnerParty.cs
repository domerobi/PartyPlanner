namespace PartyPlanner
{
    class DinnerParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        public decimal Cost {
            get
            {
                decimal discount = 0;

                if (HealthyOption)
                    discount = 0.05M;

                return (CalculateCostOfDecoration() +
                        ((CostOfFoodPerPerson + CalculateCostOfBeveragesPerPerson()) * NumberOfPeople)) * (1 - discount);
            }
        }

        public const int CostOfFoodPerPerson = 25;

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }

        public decimal CalculateCostOfDecoration()
        {
            return FancyDecorations ? 15 * NumberOfPeople + 50M : 7.5M * NumberOfPeople + 30M;
        }

        public decimal CalculateCostOfBeveragesPerPerson()
        {
            return HealthyOption ? 5M : 20M;
        }
    }
}
