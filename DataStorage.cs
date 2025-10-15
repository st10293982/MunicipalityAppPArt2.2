using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Data.Sqlite;
using System.Linq;

namespace MunicipalityApp
{
    public static class IssueDataStorage
    {
        private static readonly string _dbPath;
        private static readonly Random _random = new Random();

        static IssueDataStorage()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appFolder = Path.Combine(appDataPath, "MunicipalityApp");
            Directory.CreateDirectory(appFolder); // Ensure the directory exists
            _dbPath = Path.Combine(appFolder, "issues.db");

            InitializeDatabase();
        }

        private static void InitializeDatabase()
        {
            using (var connection = new SqliteConnection($"Data Source={_dbPath}"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Issues (
                        Id TEXT PRIMARY KEY,
                        Location TEXT NOT NULL,
                        Category TEXT NOT NULL,
                        Description TEXT NOT NULL,
                        FilePath TEXT,
                        SubmittedAt TEXT NOT NULL,
                        ReportNumber TEXT NOT NULL UNIQUE
                    );
                ";
                command.ExecuteNonQuery();
            }
        }

        private static string GenerateUniqueReportNumber(SqliteConnection connection)
        {
            string reportNumber;
            do
            {
                int number = _random.Next(100000, 999999);
                reportNumber = $"MUN-{number}";
            } while (IsReportNumberExists(connection, reportNumber));
            return reportNumber;
        }

        private static bool IsReportNumberExists(SqliteConnection connection, string reportNumber)
        {
            var command = connection.CreateCommand();
            command.CommandText = "SELECT COUNT(*) FROM Issues WHERE ReportNumber = @reportNumber";
            command.Parameters.AddWithValue("@reportNumber", reportNumber);
            var result = command.ExecuteScalar();
            long count = result != null ? (long)result : 0;
            return count > 0;
        }

        public static string AddIssue(string location, string category, string description, string filePath)
        {
            Guid id = Guid.NewGuid();
            string reportNumber;
            using (var connection = new SqliteConnection($"Data Source={_dbPath}"))
            {
                connection.Open();
                reportNumber = GenerateUniqueReportNumber(connection);
                var command = connection.CreateCommand();
                command.CommandText = @"
                    INSERT INTO Issues (Id, Location, Category, Description, FilePath, SubmittedAt, ReportNumber)
                    VALUES (@id, @location, @category, @description, @filePath, @submittedAt, @reportNumber);
                ";
                command.Parameters.AddWithValue("@id", id.ToString());
                command.Parameters.AddWithValue("@location", location);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@filePath", filePath ?? "");
                command.Parameters.AddWithValue("@submittedAt", DateTime.UtcNow.ToString("O"));
                command.Parameters.AddWithValue("@reportNumber", reportNumber);
                command.ExecuteNonQuery();
            }
            return reportNumber;
        }

        public static IEnumerable<Issue> GetIssues()
        {
            var issues = new List<Issue>();
            using (var connection = new SqliteConnection($"Data Source={_dbPath}"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT Id, Location, Category, Description, FilePath, SubmittedAt, ReportNumber FROM Issues";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var issue = new Issue
                        {
                            Location = reader.GetString(1),
                            Category = reader.GetString(2),
                            Description = reader.GetString(3),
                            FilePath = reader.GetString(4),
                            SubmittedAt = DateTime.Parse(reader.GetString(5)),
                            ReportNumber = reader.GetString(6)
                        };
                        issues.Add(issue);
                    }
                }
            }
            return issues;
        }
    }

    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public DateTime SubmittedAt { get; set; }
        public string ReportNumber { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending"; // Pending, In Progress, Resolved

        /// <summary>
        /// Parameterless constructor required for JSON deserialization.
        /// </summary>
        public Issue()
        {
            // Initialize properties to prevent null warnings
            Location = string.Empty;
            Category = string.Empty;
            Description = string.Empty;
            FilePath = string.Empty;
        }

        public Issue(string location, string category, string description, string filePath)
        {
            Location = location;
            Category = category;
            Description = description;
            FilePath = filePath;
            SubmittedAt = DateTime.UtcNow;
            Status = "Pending";
        }
    }
}
