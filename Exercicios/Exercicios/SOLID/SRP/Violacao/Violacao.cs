

public class Violocao
{
    public void GenerateReport(string data)
    {
        // Generate report logic
        Console.WriteLine($"Generating report with data: {data}");
    }

    public void SaveReportToFile(string reportContent, string filePath)
    {
        File.WriteAllText(filePath, reportContent);
        Console.WriteLine($"Report saved to {filePath}");
    }

    public void SendReportByEmail(string reportContent, string email)
    {
        // Email sending logic
        Console.WriteLine($"Emailing report to {email}");
    }
}
