namespace FactoryPatternSample.Factory
{
	public class CreditCardGoldFactory : CreditCardFactory
	{
		protected override CreditCard CreateNewCreditCard()
		{
			return new CreditCardGold();
		}
	}
	public class CreditCarSilverFactory : CreditCardFactory
	{
		protected override CreditCard CreateNewCreditCard()
		{
			return new CreditCardSilver();
		}
	}

	public class CreditCardStandardFactory : CreditCardFactory
	{
		protected override CreditCard CreateNewCreditCard()
		{
			return new CreditCardStandard();
		}
	}
}
