namespace modul8_1302220152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankTransferConfig config = new BankTransferConfig();

            if (config.config.lang == "en")
                Console.WriteLine("Please insert the amount of money to transfer:");
            else Console.WriteLine("Masukkan jumlah uang yang akan di-transfer:");


            int amount = int.Parse(Console.ReadLine());

            int biayatransfer;
            if (amount <= config.config.transfer.threshold)
                biayatransfer = config.config.transfer.low_fee;
            else
                biayatransfer = config.config.transfer.high_fee;

            int totalAmount = amount + biayatransfer;

            if (config.config.lang == "en")
                Console.WriteLine($"Transfer fee = {biayatransfer}\nTotal amount = {totalAmount}");
            else Console.WriteLine($"Biaya transfer = {biayatransfer}\nTotal biaya = {totalAmount}");

            if (config.config.lang == "en")
                Console.WriteLine("Select transfer method:");
            else Console.WriteLine("Pilih metode transfer:");

            int i = 1;
            foreach (string mtd in config.config.methods)
            {
                Console.WriteLine($"{i}. {mtd}");
                i++;
            }
            string method = Console.ReadLine();

            string confirm;
            if (config.config.lang == "en")
            {
                Console.WriteLine($"Please type {config.config.confirmation.en} to confirm transaction:");
                confirm = Console.ReadLine();
                if (confirm == config.config.confirmation.en)
                    Console.WriteLine("The transfer is completed");
                else Console.WriteLine("The transfer is cancelled");
            }
            else
            {
                Console.WriteLine($"Ketik {config.config.confirmation.id} untuk mengkonfirmasi transaksi:");
                confirm = Console.ReadLine();
                if (confirm == config.config.confirmation.id)
                    Console.WriteLine("Proses transfer berhasil");
                else Console.WriteLine("Transfer dibatalkan");
            }


        }
    }
}
