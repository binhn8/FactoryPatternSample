using FactoryPatternSample;

CardType cardType = CardType.Gold;
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