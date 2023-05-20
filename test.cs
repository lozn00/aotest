using System;
using System.Data.SqlClient;

Console.WriteLine("Hello World!");
var connection = new SqlConnection("Data Source=ServerName");
connection.Open();
