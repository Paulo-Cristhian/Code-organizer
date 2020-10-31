// Semelhante a libs
using System;
// Bibliotecas para manipular json
using System.Text.Json;
using System.Text.Json.Serialization;

using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

using System.Threading.Tasks;
using JsonDemo.Serialization;

using Json;
using Class2;

// namespace's são blocos de códigos ou conteiners (para classes e/ou namespaces) que separam e nomeiam conjuntos de códigos dentro de chaves
namespace APS_AnáliseOrdenatória
{
    // Classes são conjuntos de métodos que podem ser utilizados com um padrão de objeto para serem "instânciados" de forma unica pra cada novo objeto da mesma classe
    // Dica: É uma conveção iniciar o noma das classes em maíusculo
    public class ClassInicial
    {
        // Main é o método principal para indicar quais rotinas devem ser executadas ao início do programa
        static void Main(String[] args)
        {
            // Comando para "printar" no console com quebra de linha
            Console.WriteLine("ola World");

            //JsonConversao convertTest = new JsonConversao();
            // Sequência de referências para testes com datas
            // 'new' atribui uma nova instância de um dado do tipo data e hora indeterminado
            Console.WriteLine(new DateTime());
            // O método Now atribui a data atual ao dado que nesse caso não precisaria ser instânciado pois se assemelha a uma contante única do momento que é acionado
            Console.WriteLine(DateTime.Now);
            // O C# possui um tipo de dado para Datas e horas
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            DateTime date = dt.Date;
            // Por 'DateTime' se tratar de um objeto, as informações da hora não são completamente excluídas, apenas zeradas
            Console.WriteLine(date.ToString());
            // A combinação com o método ToString() permitirá a indicação de pattern que serão modificadores para a maneira que a data é exibida
            // Dica: usar ctrl + espace trará uma prévia dos possíveis atributos dependedo da IDE atual 
            Console.WriteLine(date.ToString("d"));
            Console.WriteLine(date.ToString("D"));
            Console.WriteLine(date.ToString("F"));
            Console.WriteLine(date.ToString("y"));
            // Ao invés do Pattern tambem é possível apenas obter a forma encurtada e extendida
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongDateString());
            // Tambem é possível personalizar a String da data
            Console.WriteLine(dt.ToString("dddd, MMMM (yyyy): HH:mm:ss"));
            // A formas de casting e manipulação de dados tambem é possível com cada propriedade da data
            string temp = date.ToString("dd");
            int dateConvert = Convert.ToInt32(temp);
            Console.WriteLine(dateConvert+03);
            // int dtConvert = (int) temp; // Não funciona com String. Só funciona entre numbers.

            // int dtConvert = (int) temp; // Não funciona com String. Só funciona entre numbers.
            Class2 show = new Class2();
            Class2.name = "nome";
            Console.WriteLine(Class2.name);



            // para ler o arquivo
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\datasJson.json");
            // system serialization
            var js = new DataContractJsonSerializer(typeof(List<Pessoa>)); //quick watch
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var pessoa = (List<Pessoa>)js.ReadObject(ms);
        }
    }
    // Classe do objeto Fotos
    class Fotos
    {
        int id; // essêncial
        string nome; // essêncial
        DateTime data; // essêncial
        string local;
        string autor;
        string classificacao;
        string metaTag;
        int tamanhoArquivo;
        string Diretório;
        double dimensão; //resolução x.y   
    }
    
}

namespace Json
{
    public class SampleObj
    {
        public int propriedadeInt { get; set; }
        string propriedadeString { get; set; }
    }
    public class EditJson
    {
        //string jsonString = JsonSerializer.Serialize(SampleObj);
        //File.WriteAllText("datasJson.json", jsonString);
    }
}

namespace Converte_Object_Json
{
    public class JsonConversao
    {
        public string ConverteObjectParaJSon<T>(T obj)
        { // Objeto tratado como "T"
            try // tente...
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T)); // Nova instância typeof determina se é obj ou json
                MemoryStream ms = new MemoryStream();
                ser.WriteObject(ms, obj);  // ms = stream; obj = object;
                string jsonString = Encoding.UTF8.GetString(ms.ToArray()); // jsonString receberá a conversão da string do objeto e c# ou a conversão de si próprio em json que não alterará em nada
                ms.Close();
                return jsonString;
            }
            catch
            {
                throw;
            }
        }
    }
}

//tentativa yt br
namespace JsonDemo.Serialization
{
    public class Pessoa
    {
        public int propriedadeInt { get; set; }
        public string propriedadeString { get; set; }
        // public List<Endereco> Endereco {get;set;}
        
    }
    public class RootObj
    {
        // Or json2csharp
    }
}
namespace JsonDemo
{
    class Program
    {
        //static void Main()
    }
}