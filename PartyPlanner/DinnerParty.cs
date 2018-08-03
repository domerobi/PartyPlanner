namespace PartyPlanner
{
    class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }
        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost + CalculateCostOfBeveragesPerPerson() * NumberOfPeople;
                
                if (HealthyOption)
                    totalCost *= 0.95M;

                return totalCost;
            }
        }

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }

        public decimal CalculateCostOfBeveragesPerPerson()
        {
            return HealthyOption ? 5M : 20M;
        }
    }
}
