// See https://aka.ms/new-console-template for more information
using ConsoleApp;
using ConsoleApp.Models;
using Microsoft.Extensions.Configuration;
Console.WriteLine("Hello, World!");

IConfiguration configuration = new ConfigurationBuilder().AddUserSecrets<Program>().Build();

using (PubsDbContext pubs = new PubsDbContext(configuration.GetSection("Secrets:ConnectionStrings").Value))
{
    // n 件データ取得
    var query1 = from a in pubs.Authors where a.State == "CA" select a;
    List<Author> result1 = query1.ToList(); // クエリを実行し、結果を List コレクションで取得

    // 1 件データ取得
    var query2 = from a in pubs.Authors where a.AuthorId == "172-32-1176" select a;
    Author result2 = query2.FirstOrDefault(); // クエリを実行し、結果を POCO オブジェクトで取得

    // 結果表示
    foreach (Author a in result1) Console.WriteLine("{0}: {1} {2}",
                a.AuthorId, a.AuthorLastName, a.AuthorFastName);
    Console.WriteLine("{0}: {1} {2}", result2.AuthorId, result2.AuthorLastName, result2.AuthorFastName);
}