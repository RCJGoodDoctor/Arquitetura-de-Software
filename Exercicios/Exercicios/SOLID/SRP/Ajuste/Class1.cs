
public class ReportService
{
    private readonly IEmailSender _emailsender;

    private readonly IFileSave _filesave;

    private readonly IReportGenerator _reportgenerator;

    public ReportService(IReportGenerator r, IEmailSender e , IFileSave f)
    {
        _reportgenerator = r;
        _emailsender = e;
        _filesave = f;
    }

    public void InsertReport(string data, string reportContent, string email , string filePath)
    {
        _reportgenerator.GenerateReport(data);
        _filesave.SaveReportToFile(reportContent, filePath);
        _emailsender.SendReportByEmail(email, filePath);
    }
}

public class ReportGenerator:IReportGenerator
{
    public void GenerateReport(string data)
    {
        // Generate report logic
        Console.WriteLine($"Generating report with data: {data}");
    }

}
public interface IReportGenerator
{
    public void GenerateReport(string data);
}



public class EmailOutlook : IEmailSender
{
    public void SendReportByEmail(string reportContent, string email)
    {
        // Email sending logic
        Console.WriteLine($"Emailing report to {email} Outlook");
    }
}

public class EmailGmail : IEmailSender
{
    public void SendReportByEmail(string reportContent, string email)
    {
        Console.WriteLine($"Emailing report to {email} Gmail");
    }
}
public interface IEmailSender
{   
    public void SendReportByEmail(string reportContent, string email);
}


public class FileSave : IFileSave{
    public void SaveReportToFile(string reportContent, string filePath)
    {
        File.WriteAllText(filePath, reportContent);
        Console.WriteLine($"Report saved to {filePath}");
    }
}
public interface IFileSave
{
    public void SaveReportToFile(string reportContent, string filePath);
}

public class GmailAdapter : IEmailSender
{
    private readonly GmailService _gmailservice;

    public GmailAdapter(GmailService gmailservice)
    {
        _gmailservice = gmailservice;
    }

    public void SendReportByEmail(string reportContent, string email)
    {
        _gmailservice.Authorize();
        _gmailservice.Send();
    }
}

public class GmailService
{
    public void Authorize()
    {

    }

    public void Send()
    {

    }
}