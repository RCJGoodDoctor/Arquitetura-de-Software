// See https://aka.ms/new-console-template for more information
using Exercicios.Patterns.Abstract_Factory;

Console.WriteLine("Hello, World!");

Console.WriteLine("Escolha a o tipo de documento:");
Console.WriteLine("------------------------");

Console.WriteLine("1 - HTML");
Console.WriteLine("2 - PDF");


var opcao = Console.ReadKey();

Console.WriteLine("");
Console.WriteLine("------------------------");
Console.WriteLine("");



IDocumentFactory factory;
switch (opcao.KeyChar)
{
    case '1':
        factory = new HTMLFactory();
        break;
    case '2':
        factory = new PDFFactory();
        break;
    default: throw new Exception("erro");

}
IHeader header = factory.CreateHeader();
IRoster roster = factory.CreateRoster();
IParagraph paragraph = factory.CreateParagraph();

header.renderize();
paragraph.renderize();
roster.renderize();
Console.ReadKey();
Console.Clear();