using ByteBankIO; // Importa o namespace ByteBankIO, que contém as classes necessárias para operações de E/S de arquivos.

class Program
{
    static void Main(string[] args)
    { 
        #region LENDO ARQUIVO
        // contas.txt está localizado na pasta do executavel
        string path = "contas.txt"; // Define o caminho do arquivo a ser lido.

        // Abre o arquivo no modo leitura e cria um fluxo de arquivo para leitura.
        FileStream fluxoDoArquivo = new FileStream(path, FileMode.Open);

        var buffer = new byte[1024]; // Define um buffer de bytes com tamanho de 1024 bytes (1KB).

        // Lê até 1024 bytes do fluxo do arquivo e os coloca no buffer. 
        // O método Read() retorna o número de bytes lidos e avança a posição do ponteiro de leitura no fluxo do arquivo.
        // Neste caso, os bytes são lidos do início do arquivo (posição 0) e até 1024 bytes ou até o final do arquivo, o que ocorrer primeiro.
        int bytesRead = fluxoDoArquivo.Read(buffer, 0, 1024);

        // O número de bytes lidos está armazenado na variável bytesRead.
        // Esses bytes podem ser processados ou manipulados conforme necessário pelo programa.
        #endregion
    }
}
