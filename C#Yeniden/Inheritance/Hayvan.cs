using System;
using System.Data.SqlTypes;

namespace Inheritance;

public class Hayvan
{
    public string hayvan_ısım;
    public string haycan_cınsıyet;

    public string hayvan_renk;

    private int hayvan_yası;

    public void hayvanBılgısıGoster()
    {
        Console.WriteLine($"Hayvanın İsmi: {hayvan_ısım}\nHayvanın Cinsiyeti: {haycan_cınsıyet}\nHayvanın Rengi: {hayvan_renk}");
    }
}
