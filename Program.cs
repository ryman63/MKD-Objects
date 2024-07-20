using Microsoft.Extensions.Configuration;

namespace MDKObjects
{
    internal static class Program
    {
        public static Npgsql.NpgsqlConnection pgConnection;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Инициализация конфигурационного файла DataBaseConfig.json
            var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("DataBaseConfig.json", optional: true, reloadOnChange: true);
            IConfiguration _configuration = builder.Build();

            //Получение строки подключения из конфига
            var PgSqlConnectionString = _configuration.GetConnectionString("PgSqlDataBase");

            //Подключение к базе данных PgSql
            pgConnection = new Npgsql.NpgsqlConnection(connectionString: PgSqlConnectionString);
            pgConnection.Open();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            //По завершению программы отключаемся от базы
            pgConnection.Close();
        }
    }
}