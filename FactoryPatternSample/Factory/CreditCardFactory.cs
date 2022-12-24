namespace FactoryPatternSample.Factory
{
	public abstract class CreditCardFactory
	{
		protected abstract ICreditCard CreateNewCreditCard();
		public ICreditCard CreateCreditCard()
		{
			return this.CreateNewCreditCard();
		}
	}
}
