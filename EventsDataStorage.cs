using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace MunicipalityApp
{
    public static class EventsDataStorage
    {
        private static readonly string _dbPath;
        private static readonly Random _random = new Random();

        static EventsDataStorage()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appFolder = Path.Combine(appDataPath, "MunicipalityApp");
            Directory.CreateDirectory(appFolder);
            _dbPath = Path.Combine(appFolder, "events.db");

            InitializeDatabase();
        }

        private static void InitializeDatabase()
        {
            using (var connection = new SqliteConnection($"Data Source={_dbPath}"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "DROP TABLE IF EXISTS Events;";
                command.ExecuteNonQuery();

                command.CommandText = @"
                    CREATE TABLE Events (
                        Id TEXT PRIMARY KEY,
                        Title TEXT NOT NULL,
                        Description TEXT NOT NULL,
                        Date TEXT NOT NULL,
                        Category TEXT NOT NULL,
                        Priority INTEGER NOT NULL,
                        ImagePath TEXT,
                        Tags TEXT,
                        ViewCount INTEGER DEFAULT 0
                    );
                ";
                command.ExecuteNonQuery();
            }

            AddSampleEvents();
        }

        private static void AddSampleEvents()
        {
            var samples = new List<Event>
            {
                new Event("Community Clean-Up Day", "Join us for a day of cleaning our local parks.", new DateTime(2024, 11, 15), "Community", 2, ""),
                new Event("Local Sports Tournament", "Annual soccer tournament for all ages.", new DateTime(2024, 11, 20), "Sports", 3, ""),
                new Event("Town Hall Meeting", "Discuss upcoming municipal projects.", new DateTime(2024, 11, 25), "Government", 1, ""),
                new Event("Cultural Festival", "Celebrate local culture with music and food.", new DateTime(2024, 12, 5), "Culture", 3, ""),
                new Event("Youth Workshop", "Educational workshop for teenagers.", new DateTime(2024, 12, 10), "Education", 2, ""),
                new Event("Health Awareness Seminar", "Learn about healthy living and wellness.", new DateTime(2024, 12, 15), "Health", 2, ""),
                new Event("Environmental Conservation Workshop", "Protect our planet with sustainable practices.", new DateTime(2024, 12, 20), "Environment", 1, ""),
                new Event("Art Exhibition Opening", "Showcase local artists' works.", new DateTime(2024, 12, 25), "Arts", 3, ""),
                new Event("Business Networking Event", "Connect with local entrepreneurs.", new DateTime(2025, 1, 5), "Business", 2, ""),
                new Event("Recreation Park Day", "Family fun day at the park with games.", new DateTime(2025, 1, 10), "Recreation", 1, ""),
                new Event("Music Concert", "Live music performance in the town square.", new DateTime(2024, 12, 30), "Culture", 3, ""),
                new Event("Science Fair", "Showcase student projects and innovations.", new DateTime(2025, 1, 15), "Education", 2, ""),
                new Event("Neighborhood Watch Meeting", "Safety discussion and community updates.", new DateTime(2025, 1, 20), "Community", 1, ""),
                new Event("Policy Update Session", "New policies explained and Q&A.", new DateTime(2025, 1, 25), "Government", 2, ""),
                new Event("Fitness Class Series", "Group exercise sessions for all levels.", new DateTime(2025, 2, 1), "Health", 3, ""),
                new Event("Tree Planting Drive", "Plant trees for a greener community.", new DateTime(2025, 2, 5), "Environment", 1, ""),
                new Event("Theater Play Premiere", "Local theater production performance.", new DateTime(2025, 2, 10), "Arts", 3, ""),
                new Event("Startup Pitch Event", "Pitch ideas to investors and network.", new DateTime(2025, 2, 15), "Business", 2, ""),
                new Event("Outdoor Adventure Day", "Hiking and outdoor games for families.", new DateTime(2025, 2, 20), "Recreation", 1, ""),
                new Event("Basketball League Start", "New season begins with opening games.", new DateTime(2025, 2, 25), "Sports", 3, ""),
                new Event("Charity Run", "5K run to support local charities.", new DateTime(2025, 3, 1), "Sports", 2, ""),
                new Event("Marathon Training", "Weekly training sessions for marathon.", new DateTime(2025, 3, 5), "Sports", 2, ""),
                new Event("Tennis Club Open Day", "Join the local tennis club.", new DateTime(2025, 3, 10), "Sports", 1, ""),
                new Event("Photography Workshop", "Learn photography basics.", new DateTime(2025, 3, 15), "Arts", 2, ""),
                new Event("Mental Health Awareness Talk", "Discussion on mental wellness.", new DateTime(2025, 3, 20), "Health", 3, ""),
                new Event("Nutrition Workshop", "Healthy eating tips.", new DateTime(2025, 3, 25), "Health", 1, ""),
                new Event("Entrepreneurship Seminar", "Tips for starting a business.", new DateTime(2025, 4, 1), "Business", 2, ""),
                new Event("Book Club Meeting", "Discuss latest reads.", new DateTime(2025, 4, 5), "Education", 1, ""),
                new Event("Online Learning Fair", "Explore online courses.", new DateTime(2025, 4, 10), "Education", 2, ""),
                new Event("Beach Clean-Up", "Clean the local beach.", new DateTime(2025, 4, 15), "Environment", 1, ""),
                new Event("Community Potluck", "Share food and stories.", new DateTime(2025, 4, 20), "Community", 1, ""),
                new Event("Jazz Night", "Evening of jazz music.", new DateTime(2025, 4, 25), "Culture", 3, ""),
                new Event("Budget Planning Workshop", "Learn about municipal budgets.", new DateTime(2025, 5, 1), "Government", 1, "")
            };

            foreach (var ev in samples)
            {
                AddEvent(ev);
            }
        }

        public static void AddEvent(Event ev)
        {
            using (var connection = new SqliteConnection($"Data Source={_dbPath}"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    INSERT OR REPLACE INTO Events (Id, Title, Description, Date, Category, Priority, ImagePath, Tags, ViewCount)
                    VALUES (@id, @title, @description, @date, @category, @priority, @imagePath, @tags, @viewCount);
                ";
                command.Parameters.AddWithValue("@id", ev.Id);
                command.Parameters.AddWithValue("@title", ev.Title);
                command.Parameters.AddWithValue("@description", ev.Description);
                command.Parameters.AddWithValue("@date", ev.Date.ToString("O"));
                command.Parameters.AddWithValue("@category", ev.Category);
                command.Parameters.AddWithValue("@priority", ev.Priority);
                command.Parameters.AddWithValue("@imagePath", ev.ImagePath ?? "");
                command.Parameters.AddWithValue("@tags", string.Join(",", ev.Tags));
                command.Parameters.AddWithValue("@viewCount", ev.ViewCount);
                command.ExecuteNonQuery();
            }
        }

        public static IEnumerable<Event> GetEvents()
        {
            var events = new List<Event>();
            using (var connection = new SqliteConnection($"Data Source={_dbPath}"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT Id, Title, Description, Date, Category, Priority, ImagePath, Tags, ViewCount FROM Events ORDER BY Date ASC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ev = new Event
                        {
                            Id = reader.GetString(0),
                            Title = reader.GetString(1),
                            Description = reader.GetString(2),
                            Date = DateTime.Parse(reader.GetString(3)),
                            Category = reader.GetString(4),
                            Priority = reader.GetInt32(5),
                            ImagePath = reader.GetString(6),
                            Tags = reader.GetString(7).Split(',').Where(t => !string.IsNullOrEmpty(t)).ToList(),
                            ViewCount = reader.GetInt32(8)
                        };
                        events.Add(ev);
                    }
                }
            }
            return events;
        }

        public static IEnumerable<Event> GetEventsByCategory(string category)
        {
            var allEvents = GetEvents().ToList();
            return allEvents.Where(e => e.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
        }

        public static IEnumerable<Event> GetEventsByDateRange(DateTime start, DateTime end)
        {
            var allEvents = GetEvents().ToList();
            return allEvents.Where(e => e.Date >= start && e.Date <= end);
        }

        public static void UpdateEventViewCount(string eventId)
        {
            using (var connection = new SqliteConnection($"Data Source={_dbPath}"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "UPDATE Events SET ViewCount = ViewCount + 1 WHERE Id = @id";
                command.Parameters.AddWithValue("@id", eventId);
                command.ExecuteNonQuery();
            }
        }

        public static IEnumerable<Event> GetRecommendedEvents(Dictionary<string, int> searchCounts, int topN = 5)
        {
            var allEvents = GetEvents().ToList();
            var topCategories = searchCounts.OrderByDescending(kv => kv.Value).Take(3).Select(kv => kv.Key).ToList();
            var recommended = new List<Event>();

            // Recommend upcoming events in top categories
            foreach (var cat in topCategories)
            {
                var catEvents = allEvents.Where(e => e.Category.Equals(cat, StringComparison.OrdinalIgnoreCase) && e.Date > DateTime.Now).OrderBy(e => e.Date).Take(2);
                recommended.AddRange(catEvents);
            }

            // Add popular events based on view count
            var popular = allEvents.OrderByDescending(e => e.ViewCount).Take(3);
            recommended.AddRange(popular);

            return recommended.Distinct().Take(topN);
        }
    }
}
