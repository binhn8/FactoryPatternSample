namespace FactoryPatternSample.Factory
{
	public abstract class CreditCardFactory
	{
		protected abstract CreditCard CreateNewCreditCard();
		public CreditCard CreateCreditCard()
		{
			return this.CreateNewCreditCard();
		}
	}
}
