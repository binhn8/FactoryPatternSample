namespace FactoryPatternSample.Factory
{
	public class CreditCardFactory
	{
		public static CreditCard GetCreditCardDetails(CardType cardType)
		{
			CreditCard cardDetails = null;

			if (cardType == CardType.Standard)
			{
				cardDetails = new CreditCardStandard();
			}
			else if (cardType == CardType.Silver)
			{
				cardDetails = new CreditCardSilver();
			}
			else if (cardType == CardType.Gold)
			{
				cardDetails = new CreditCardGold();
			}
			return cardDetails;
		}
	}
}
