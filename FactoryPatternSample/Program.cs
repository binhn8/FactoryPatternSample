using FactoryPatternSample;
using FactoryPatternSample.Factory;

CardType cardType = CardType.Gold;
CreditCard cardDetails = CreditCardFactory.GetCreditCardDetails(cardType);


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