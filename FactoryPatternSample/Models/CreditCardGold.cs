namespace FactoryPatternSample
{
	class CreditCardGold:CreditCard
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
