using HtmlAgilityPack;

using System.Net;
using System.Text;

class Program
{
    static HtmlDocument htmlDocument = new HtmlDocument();

    static void Main()
    {

        string folderPath = "C:\\Users\\ADMIN\\Downloads\\BoPhapDienDienTu\\demuc";
        string folderSave = "C:\\Users\\ADMIN\\Downloads\\BoPhapDienDienTu\\output";

        folderPath = Uri.UnescapeDataString(folderPath);
        folderSave = Uri.UnescapeDataString(folderSave);


        foreach (var filePath in Directory.GetFiles(folderPath, "*.html"))
        {
            List<string> dataList = getData(filePath);

            var outputPath = Path.Combine(folderSave, Path.GetFileNameWithoutExtension(filePath) + ".txt");


            File.WriteAllLines(outputPath, dataList);

            Console.WriteLine("Results written to: " + outputPath);
        }

        Console.ReadLine();
    }

    static List<string> getData(string filePath)
    {

        filePath = Uri.UnescapeDataString(filePath);

        if (!System.IO.File.Exists(filePath))
        {
            Console.WriteLine("File not found: " + filePath);
            return new List<string>();
        }

        string htmlContent = System.IO.File.ReadAllText(filePath, Encoding.UTF8);
        htmlDocument.LoadHtml(htmlContent);

        var bd = htmlDocument.DocumentNode.Descendants().Skip(1).ToList();
        List<string> list = getBodyStr(bd);

        return list;
    }

    private static List<string> getBodyStr(List<HtmlNode> body)
    {
        List<string> strList = new List<string>();

        for (int i = 0; i < body.Count; i++)
        {
            if (!body[i].HasChildNodes)
            {
                string text = WebUtility.HtmlDecode(body[i].InnerText);
                if (!string.IsNullOrEmpty(text))
                {
                    StringBuilder sb = new StringBuilder(text.Trim());
                    sb.Replace("\n\n", "\n");
                    sb.Replace("\t\t", "\t");
                    sb.Replace("\r\r", "\r");

                    sb.Replace("…", "");
                    text = sb.ToString();
                    if (text == "\n" || text == "\n\n" || text == "\n\t" || text == "\n\r" || text == "\r" || text == "\t" || text == ""
                        || text == "." || text == "," || text == "|" ||
                        text.StartsWith("{\""))
                        continue;
                    text = text.Replace("(", "").Replace(")", "");
                    text = text.Replace(";", "");
                    if (text == "")
                        continue;
                    strList.Add(text.Trim());


                }
            }
        }
        return strList;
    }
}