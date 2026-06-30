# ImprimirPDF

Aplicativo desenvolvido em C# (.NET Framework 4.7.2) para imprimir automaticamente um arquivo PDF em uma impressora específica utilizando o SumatraPDF.

---

# Requisitos

Antes de utilizar o programa, verifique se o computador atende aos seguintes requisitos:

* Windows 7, Windows 8, Windows 10 ou Windows 11;
* .NET Framework 4.7.2 instalado;
* Impressora instalada e configurada no Windows;
* Arquivo `SumatraPDF.exe` presente na mesma pasta do programa.

---

# Estrutura dos arquivos

Todos os arquivos abaixo devem permanecer na mesma pasta:

```text
ImprimirPDF.exe
SumatraPDF.exe
config.ini
pedido.pdf
```

> **Observação:** o nome do arquivo PDF pode ser alterado. Basta atualizar o arquivo `config.ini`.

---

# Configuração

O programa utiliza um arquivo chamado `config.ini` para definir qual impressora será utilizada e qual arquivo PDF será impresso.

## Exemplo de `config.ini`

```ini
# ======================================
# Configuração do ImprimirPDF
# ======================================

# Nome EXATO da impressora instalada no Windows
IMPRESSORA=EPSON TM-T20III Receipt

# Nome do arquivo PDF localizado na mesma pasta
ARQUIVO=pedido.pdf
```

## Configurando a impressora

1. Abra **Painel de Controle → Dispositivos e Impressoras**.
2. Localize a impressora desejada.
3. Copie exatamente o nome exibido.
4. Edite a linha `IMPRESSORA=` no arquivo `config.ini`.

Exemplo:

```ini
IMPRESSORA=HP LaserJet Pro M404
```

---

## Configurando o arquivo PDF

Informe o nome do arquivo PDF que será impresso.

Exemplo:

```ini
ARQUIVO=nota_fiscal.pdf
```

O arquivo informado deve estar na mesma pasta do `ImprimirPDF.exe`.

---

# Como utilizar

1. Copie todos os arquivos para qualquer pasta do computador ou para um pendrive.
2. Configure o arquivo `config.ini` informando:

   * o nome da impressora;
   * o nome do arquivo PDF.
3. Certifique-se de que o PDF informado existe na mesma pasta.
4. Execute `ImprimirPDF.exe`.
5. O documento será enviado automaticamente para a impressora configurada.

---

# Alterando a impressora

Caso o programa seja utilizado em outro computador, **não é necessário recompilar o projeto**.

Basta editar o arquivo `config.ini`:

```ini
IMPRESSORA=Nome da Nova Impressora
```

Salve o arquivo e execute novamente o programa.

---

# Alterando o PDF

Também não é necessário recompilar.

Basta:

1. Copiar o novo PDF para a mesma pasta do programa.
2. Alterar a linha:

```ini
ARQUIVO=novo_arquivo.pdf
```

Salve o `config.ini` e execute novamente o programa.

---

# Distribuição

Para utilizar o programa em outro computador, basta copiar todos os arquivos da pasta para o novo computador ou para um pendrive.

Exemplo:

```text
ImprimirPDF.exe
SumatraPDF.exe
config.ini
pedido.pdf
```

Depois, se necessário, ajuste apenas o arquivo `config.ini` conforme a impressora e o PDF desejados.

---

# Observações

* Não mova o `SumatraPDF.exe` para outra pasta.
* Mantenha todos os arquivos na mesma pasta do executável.
* O programa lê o arquivo `config.ini` sempre que é iniciado, permitindo alterar a impressora e o PDF sem recompilar o projeto.
* Comentários iniciados por `#` ou `;` e linhas em branco são ignorados no arquivo `config.ini`.
