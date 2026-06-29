# ImprimirPDF
Simple C# (.NET Framework 4.7.2) program to print a specific .pdf file on the selected printer using SumatraPDF.

## Requisitos

Antes de utilizar o programa, verifique se o computador atende aos seguintes requisitos:

* Windows 7, Windows 8, Windows 10 ou Windows 11;
* .NET Framework 4.7.2 instalado;
* Impressora instalada e configurada no Windows;
* Arquivo `SumatraPDF.exe` presente na mesma pasta do programa.

## Estrutura dos arquivos

Todos os arquivos abaixo devem permanecer na mesma pasta:

```text
ImprimirPDF.exe
SumatraPDF.exe
pedido.pdf
```

## Configuração da impressora

Antes de utilizar o programa pela primeira vez:

1. Instale a impressora normalmente no Windows.
2. Verifique se o nome da impressora corresponde ao configurado no código-fonte do aplicativo.
3. Caso o nome da impressora seja diferente, altere a variável `nomeImpressora` no código, compile novamente o projeto e substitua o executável.

## Como utilizar

1. Copie os arquivos para qualquer pasta do computador ou para um pendrive.
2. Certifique-se de que o arquivo `pedido.pdf` é o documento que deseja imprimir.
3. Dê um duplo clique em `ImprimirPDF.exe`.
4. O programa enviará automaticamente o PDF para a impressora configurada e será encerrado.

## Substituindo o PDF

Sempre que desejar imprimir outro documento:

1. Substitua o arquivo `pedido.pdf` pelo novo PDF.
2. Mantenha exatamente o mesmo nome (`pedido.pdf`).
3. Execute novamente o `ImprimirPDF.exe`.
* Recomenda-se manter todos os arquivos juntos na mesma pasta para garantir o funcionamento correto do aplicativo.

