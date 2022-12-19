namespace FactoryPatternSample
{
	class CreditCardStandard : CreditCard
	{
		public CardType GetCardType()
		{
			return CardType.Standard;
		}
		public int GetCreditLimit()
		{
			return 3000;
		}
		public int GetAnnualCharge()
		{
			return 50;
		}

	}
}
