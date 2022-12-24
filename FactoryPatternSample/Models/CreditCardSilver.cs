namespace FactoryPatternSample
{
	class CreditCardSilver:ICreditCard
	{
		public CardType GetCardType()
		{
			return CardType.Silver;
		}
		public int GetCreditLimit()
		{
			return 5000;
		}
		public int GetAnnualCharge()
		{
			return 100;
		}
	}
}
