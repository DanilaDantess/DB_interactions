/*using Microsoft.Data.SqlClient;
using System.Data;

Console.WriteLine("Loader CSV App Started!");
#region Подключаемся к серверу и создаем БД
string connectionString = "Server=DESKTOP-PC\\SQLEXPRESS;Database=importCSV;Trusted_Connection=True;TrustServerCertificate=True;";
using (SqlConnection connection = new SqlConnection(connectionString))
{
    await connection.OpenAsync();
    Console.WriteLine("Подключение открыто");
    #region Вывод информации о подключении
    Console.WriteLine("Свойства подключения:");
    Console.WriteLine($"\tСтрока подключения: {connection.ConnectionString}");
    Console.WriteLine($"\tБаза данных: {connection.Database}");
    Console.WriteLine($"\tСервер: {connection.DataSource}");
    Console.WriteLine($"\tВерсия сервера: {connection.ServerVersion}");
    Console.WriteLine($"\tСостояние: {connection.State}");
    Console.WriteLine($"\tWorkstationld: {connection.WorkstationId}");
    #endregion  
}
Console.WriteLine("Подключение закрыто...");
#endregion
#region Подключаемся к БД и добавляем в нее записи
string newConnectionString = "Server=DESKTOP-PC\\SQLEXPRESS;Database=importCSV2;Trusted_Connection=True;TrustServerCertificate=True;";
using (SqlConnection connection = new SqlConnection(newConnectionString))
{
    await connection.OpenAsync();
    SqlCommand command = new SqlCommand();
    // добавляем записи
    string sqlExpression = "BULK INSERT dbo.Parametrs FROM 'A:/project/DB_interactions/LAST.csv' WITH (FIRSTROW = 2, CHECK_CONSTRAINTS, KEEPNULLS, FIELDTERMINATOR = ';', ROWTERMINATOR = '\n')";
    command = new SqlCommand(sqlExpression, connection);
    try
    {
        int number = await command.ExecuteNonQueryAsync();
        Console.WriteLine($"Добавлено объектов: {number}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
Console.WriteLine("Подключение закрыто...");
#endregion


Console.WriteLine("Программа завершила работу.");
Console.Read();*/