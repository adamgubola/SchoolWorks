namespace Gubola_Adam_D0JE27_ZH2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Sale goodSale = Sale.LoadFromFile("sale_data_ok.txt");
                Console.WriteLine("Sikeres betöltés: sale_data_ok.txt");
                Console.Write("Adj meg egy árhatárt: ");
                int limit = int.Parse(Console.ReadLine());

                Program.ListCheapSaleData(goodSale, limit);
            }
            catch (InvalidDataProvidedException ex)
            {
                Console.WriteLine("Hibás adat a jó fájlban: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Egyéb hiba a jó fájlban: " + ex.Message);
            }

            try
            {
                Sale badSale = Sale.LoadFromFile("sale_data_invalid.txt");
                Console.WriteLine("Sikeres betöltés: sale_data_invalid.txt");
            }
            catch (InvalidDataProvidedException ex)
            {
                Console.WriteLine("Hibás adat a hibás fájlban: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Egyéb hiba a hibás fájlban: " + ex.Message);
            }
        }




        public static void ListCheapSaleData(Sale sale, int limit)
        {
            ShoppingItem[] cheapItems = sale.FilterCheapItems(limit);
            foreach (ShoppingItem item in cheapItems)
            {
                Console.WriteLine(item.ToString());
            }
        }





    }
}

