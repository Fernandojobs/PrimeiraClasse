using System.IO;

namespace PrimeiraClasse
{
    public class CriarArquivo
    {
        //Atributos da classe CriarArquivo
    public string nomearquivo;
    public string extensao;
    public int codigoproduto;
    public string nomeproduto;
    public double precoproduto;
    public string marcaproduto;

    //Funcionalidade da classe, comportamento
    public string salvar()
{
    /*
    Vamos usar uma classe para nos ajudar a criar um arquivo de texto
    e escrever dentro deste arquivo.
    Utilizaremos a classe StreamWriter
    */

    StreamWriter ar = new StreamWriter(nomearquivo+"."+extensao, true);
    //Vamos escrever os dados no arquivo
    ar.WriteLine(codigoproduto+";"+nomeproduto+";"+marcaproduto+";"+precoproduto);
    //Fechar o arquivo para salvar e tirar da memoria
    ar.Close();

    return "Salvo com sucesso";
}


    }
}