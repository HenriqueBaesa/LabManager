
using LabManager.Database;
using Microsoft.Data.Sqlite;

var databaseConfig = new DatabaseConfig();
var databaseSetup = new DatabaseSetup(databaseConfig);

// Routing
var modelName = args[0];
var modelAction = args[1];

if (modelName == "Computer")
{
    if (modelAction == "List")
    {
        var conn = new SqliteConnection("Data Source=database.db");
        conn.Open();

        var command = conn.CreateCommand();
        command.CommandText = "SELECT * FROM Computers";

        var reader = command.ExecuteReader();

        Console.WriteLine("Computer List");
        while(reader.Read())
        {
            Console.WriteLine("{0}, {1}, {2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
            reader.GetInt32(0);
        }

        reader.Close();
        conn.Close();
    }

    if (modelAction == "New")
    {
        var conn = new SqliteConnection("Data Source=database.db");
        conn.Open();

        int id = Convert.ToInt32(args[2]);
        string ram = args[3];
        string processor = args[4];

        var command = conn.CreateCommand();
        command.CommandText = "INSERT INTO Computers VALUES($id, $ram, $processor)";
        command.Parameters.AddWithValue("$id", id);
        command.Parameters.AddWithValue("$ram", ram);
        command.Parameters.AddWithValue("$processor", processor);
        command.ExecuteNonQuery();

        conn.Close();
    }
}

else if (modelName == "Lab")
{
    if (modelAction == "List")
    {
        var conn = new SqliteConnection("Data Source=database.db");
        conn.Open();

        var command = conn.CreateCommand();
        command.CommandText = "SELECT * FROM Lab";

        var reader = command.ExecuteReader();

        Console.WriteLine("Lab List");
        while(reader.Read())
        {
            Console.WriteLine("{0}, {1}, {2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
            reader.GetInt32(0);
        }

        reader.Close();
        conn.Close();
    }

    if (modelAction == "New")
    {
        var conn = new SqliteConnection("Data Source=database.db");
        conn.Open();

        int id = Convert.ToInt32(args[2]);
        string number = args[3];
        string block = args[4];

        var command = conn.CreateCommand();
        command.CommandText = "INSERT INTO Lab VALUES($id, $number, $block)";
        command.Parameters.AddWithValue("$id", id);
        command.Parameters.AddWithValue("$number", number);
        command.Parameters.AddWithValue("$block", block);
        command.ExecuteNonQuery();

        conn.Close();
    }
}