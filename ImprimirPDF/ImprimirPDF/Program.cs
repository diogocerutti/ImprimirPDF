using System.Windows.Forms;
using System;
using System.Diagnostics;
using System.IO;

namespace ImprimirPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            string pasta = AppDomain.CurrentDomain.BaseDirectory;

            string arquivoConfig = Path.Combine(pasta, "config.ini");
            string sumatra = Path.Combine(pasta, "SumatraPDF.exe");

            // Verifica se existe o arquivo de configuração
            if (!File.Exists(arquivoConfig))
            {
                MostrarErro("O arquivo config.ini não foi encontrado.");
                return;
            }

            string nomeImpressora = "";
            string nomeArquivoPdf = "";

            foreach (string linhaOriginal in File.ReadAllLines(arquivoConfig))
            {
                string linha = linhaOriginal.Trim();

                if (string.IsNullOrWhiteSpace(linha))
                    continue;

                if (linha.StartsWith("#") || linha.StartsWith(";"))
                    continue;

                if (linha.StartsWith("IMPRESSORA=", StringComparison.OrdinalIgnoreCase))
                {
                    nomeImpressora = linha.Substring("IMPRESSORA=".Length).Trim();
                }
                else if (linha.StartsWith("ARQUIVO=", StringComparison.OrdinalIgnoreCase))
                {
                    nomeArquivoPdf = linha.Substring("ARQUIVO=".Length).Trim();
                }
            }

            if (string.IsNullOrWhiteSpace(nomeImpressora))
            {
                MostrarErro("A impressora não foi informada no config.ini.");
                return;
            }

            if (string.IsNullOrWhiteSpace(nomeArquivoPdf))
            {
                MostrarErro("O arquivo PDF não foi informado no config.ini.");
                return;
            }

            string pdf = Path.Combine(pasta, nomeArquivoPdf);

            if (!File.Exists(sumatra))
            {
                MostrarErro("SumatraPDF.exe não encontrado.");
                return;
            }

            if (!File.Exists(pdf))
            {
                MostrarErro($"O arquivo '{nomeArquivoPdf}' não foi encontrado.");
                return;
            }

            try
            {
                Process processo = new Process();

                processo.StartInfo.FileName = sumatra;
                processo.StartInfo.Arguments =
                    $"-print-to \"{nomeImpressora}\" -silent -exit-when-done \"{pdf}\"";

                processo.StartInfo.UseShellExecute = false;
                processo.StartInfo.CreateNoWindow = true;

                processo.Start();

                processo.WaitForExit();

                if (processo.ExitCode != 0)
                {
                    MostrarErro("O SumatraPDF retornou um erro durante a impressão.");
                }
            }
            catch (Exception ex)
            {
                MostrarErro(ex.Message);
            }
        }

        static void MostrarErro(string mensagem)
        {
            System.Windows.Forms.MessageBox.Show(
                mensagem,
                "ImprimirPDF",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error);
        }
    }
}