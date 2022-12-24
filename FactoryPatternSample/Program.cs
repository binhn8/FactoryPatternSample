using FactoryPatternSample;
using FactoryPatternSample.Factory;

var creditCard = new CreditCardStandardFactory();
ICreditCard cardDetails = creditCard.CreateCreditCard();


if (cardDetails != null)
{
    Console.WriteLine("CardType : " + cardDetails.GetCardType());
	Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
    Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
}
else
{
    Console.Write("Invalid Card Type");
}
Console.ReadLine();