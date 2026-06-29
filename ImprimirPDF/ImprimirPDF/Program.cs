using System;
using System.Diagnostics;
using System.IO;

namespace ImprimirPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nome EXATO da impressora
            string nomeImpressora = "EPSON TM-T20X Receipt";

            // Pasta onde está o executável
            string pasta = AppDomain.CurrentDomain.BaseDirectory;

            // Caminhos dos arquivos
            string sumatra = Path.Combine(pasta, "SumatraPDF.exe");
            string pdf = Path.Combine(pasta, "ESPELHO CAIXA 2 IMPRIMIR.pdf");

            // Verifica se o SumatraPDF existe
            if (!File.Exists(sumatra))
            {
                Console.WriteLine("Erro: SumatraPDF.exe não foi encontrado.");
                Console.ReadKey();
                return;
            }

            // Verifica se o PDF existe
            if (!File.Exists(pdf))
            {
                Console.WriteLine("Erro: O PDF não foi encontrado.");
                Console.ReadKey();
                return;
            }

            try
            {
                Process processo = new Process();

                processo.StartInfo.FileName = sumatra;
                processo.StartInfo.Arguments =
                    $"-print-to \"{nomeImpressora}\" \"{pdf}\"";

                processo.StartInfo.UseShellExecute = false;
                processo.StartInfo.CreateNoWindow = true;
                processo.Start();

                // Aguarda o Sumatra finalizar
                processo.WaitForExit();

                // Código de saída do Sumatra
                if (processo.ExitCode != 0)
                {
                    Console.WriteLine("A impressão não foi concluída.");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao imprimir:");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}