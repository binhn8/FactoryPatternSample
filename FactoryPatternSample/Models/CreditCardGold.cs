namespace FactoryPatternSample
{
	class CreditCardGold:ICreditCard
	{
		public CardType GetCardType()
		{
			return CardType.Gold;
		}
		public int GetCreditLimit()
		{
			return 10000;
		}
		public int GetAnnualCharge()
		{
			return 200;
		}
	}
}
