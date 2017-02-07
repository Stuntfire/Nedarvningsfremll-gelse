namespace Nedarvningsfremllægelse
{
    interface IBil
    {
        int BilPrisExAfgift { get; }
        int KøbsÅr { get; }
        string Mærke { get; set; }
        int Oktan { get; set; }
        string RegistreringsNr { get; set; }

        int HalvÅrligEjerafgift();
        string HvilkenBilErJeg();
        int RegistreringsAfgift();
        int Rækkevidde();
        int TotalPris();
    }
}