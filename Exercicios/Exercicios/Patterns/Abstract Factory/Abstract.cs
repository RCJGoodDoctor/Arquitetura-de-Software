
namespace Exercicios.Patterns.Abstract_Factory
{
  public interface IDocumentFactory
  {
        public IParagraph CreateParagraph();

        public IHeader CreateHeader();

        public IRoster CreateRoster();
    }

    public interface IParagraph
    {
        public void renderize();
    }
    public class ParagraphHTML : IParagraph
    {
        public void renderize()
        {
            Console.WriteLine("Renderizando p");
        }
    }

    public class ParagraphPDF : IParagraph
    {
        public void renderize()
        {
            Console.WriteLine("Renderizando quebra linhas com margens");
        }
    }

    public class HeaderHTML : IHeader
    {
        public void renderize()
        {
            Console.WriteLine("Renderizando H1");
        }
    }

    public class HeaderPDF : IHeader
    {
        public void renderize()
        {
            Console.WriteLine("Renderizando cabeçalho");
        }
    }


    public class RosterHTML : IRoster
    {
        public void renderize()
        {
            Console.WriteLine("Renderizando <ul> e <li>");
        }
    }

    public class RosterPDF : IRoster
    {
        public void renderize()
        {
            Console.WriteLine("Renderizando marcadores gráficos");
        }
    }

    public interface IHeader
    {
        public void renderize();
    }

    public interface IRoster
    {
        public void renderize();
    }

    public class HTMLFactory : IDocumentFactory
    {
        public IHeader CreateHeader()
        {
            return new HeaderHTML();
        }

        public IParagraph CreateParagraph()
        {
            return new ParagraphHTML();
        }

        public IRoster CreateRoster()
        {
            return new RosterHTML();
        }
    }

    public class PDFFactory : IDocumentFactory
    {
        public IHeader CreateHeader()
        {
            return new HeaderPDF();
        }

        public IParagraph CreateParagraph()
        {
            return new ParagraphPDF();
        }

        public IRoster CreateRoster()
        {
            return new RosterPDF();
        }
    }


    

}
