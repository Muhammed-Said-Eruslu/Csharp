 Console.Write("İsminizi girin: ");
        string isim = Console.ReadLine();

        if (isim == "Zeynep")
        {
            // Kalp çizimi için rengi kırmızı yap
            Console.ForegroundColor = ConsoleColor.Red;

            // En detaylı kalp çizimi
            Console.WriteLine("          *****       *****          ");
            Console.WriteLine("       **********   **********       ");
            Console.WriteLine("     ************* *************     ");
            Console.WriteLine("   ******************************   ");
            Console.WriteLine("  *********************************  ");
            Console.WriteLine(" *********************************** ");
            Console.WriteLine(" *********************************** ");
            Console.WriteLine("  *********************************  ");
            Console.WriteLine("   *******************************   ");
            Console.WriteLine("    *****************************    ");
            Console.WriteLine("     ***************************     ");
            Console.WriteLine("      *************************      ");
            Console.WriteLine("       ***********************       ");
            Console.WriteLine("        *********************        ");
            Console.WriteLine("         *******************         ");
            Console.WriteLine("          *****************          ");
            Console.WriteLine("           ***************           ");
            Console.WriteLine("            *************            ");
            Console.WriteLine("             ***********             ");
            Console.WriteLine("              *********              ");
            Console.WriteLine("               *******               ");
            Console.WriteLine("                *****                ");
            Console.WriteLine("                 ***                 ");
            Console.WriteLine("                  *                  ");

            // Rengi varsayılan haline geri döndür
            Console.ResetColor();

            // Programın kapanmasını engellemek için ekrandan bir giriş bekle
            Console.WriteLine("\nKalbi beğendiniz mi? Kapatmak için Enter'a basın.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Merhaba, " + isim);

            // Programın kapanmasını engellemek için ekrandan bir giriş bekle
            Console.WriteLine("Kapatmak için Enter'a basın.");
            Console.ReadLine();
        }
    