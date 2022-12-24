namespace FactoryPatternSample.Factory
{
	public class CreditCardGoldFactory : CreditCardFactory
	{
		protected override ICreditCard CreateNewCreditCard()
		{
			return new CreditCardGold();
		}
	}
	public class CreditCarSilverFactory : CreditCardFactory
	{
		protected override ICreditCard CreateNewCreditCard()
		{
			return new CreditCardSilver();
		}
	}

	public class CreditCardStandardFactory : CreditCardFactory
	{
		protected override ICreditCard CreateNewCreditCard()
		{
			return new CreditCardStandard();
		}
	}
}
