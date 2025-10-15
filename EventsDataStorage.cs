

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
            // 🌿💧 New Cape Town-themed, rearranged events
            var samples = new List<Event>
            {
                new Event("Green Point Park Family Day", "Join us for games, food, and fun activities in the park.", new DateTime(2024, 11, 18), "Recreation", 2, ""),
                new Event("Muizenberg Beach Clean-Up", "Help us keep our beaches clean and plastic-free.", new DateTime(2024, 11, 25), "Environment", 1, ""),
                new Event("Khayelitsha Youth Innovation Fair", "Showcasing creative youth-led projects and ideas.", new DateTime(2024, 12, 2), "Education", 2, ""),
                new Event("City Hall Heritage Concert", "An evening of local music and Cape Town heritage celebration.", new DateTime(2024, 12, 9), "Culture", 3, ""),
                new Event("Table Mountain Hike for Wellness", "Guided morning hike promoting physical and mental health.", new DateTime(2024, 12, 15), "Health", 2, ""),
                new Event("Woodstock Art Walk", "Explore local galleries and meet artists in Woodstock.", new DateTime(2024, 12, 22), "Arts", 3, ""),
                new Event("Sea Point Sunset Run", "Community run along the promenade for all ages.", new DateTime(2024, 12, 28), "Sports", 2, ""),
                new Event("Langa Entrepreneurs Meetup", "Connect and share ideas with small business owners.", new DateTime(2025, 1, 5), "Business", 2, ""),
                new Event("District Six Remembrance Day", "Commemorate the history and resilience of District Six residents.", new DateTime(2025, 1, 10), "Community", 1, ""),
                new Event("Cape Town City Budget Dialogue", "Engage with local officials about 2025 municipal plans.", new DateTime(2025, 1, 18), "Government", 1, ""),
                new Event("Company’s Garden Eco Fair", "Workshops and stalls promoting sustainable living.", new DateTime(2025, 1, 25), "Environment", 2, ""),
                new Event("Claremont Open-Air Cinema Night", "Family-friendly movies under the stars.", new DateTime(2025, 2, 2), "Recreation", 1, ""),
                new Event("Observatory Science Festival", "Interactive exhibits and talks about new technologies.", new DateTime(2025, 2, 9), "Education", 3, ""),
                new Event("Athlone Health and Fitness Expo", "Free fitness demos and wellness talks for residents.", new DateTime(2025, 2, 15), "Health", 2, ""),
                new Event("Bo-Kaap Street Food Festival", "Taste local Cape Malay dishes and cultural performances.", new DateTime(2025, 2, 22), "Culture", 3, ""),
                new Event("Newlands Green Business Forum", "Learn about eco-friendly business practices.", new DateTime(2025, 3, 1), "Business", 2, ""),
                new Event("Mitchells Plain Safety Awareness Day", "Community event focused on neighborhood security.", new DateTime(2025, 3, 8), "Community", 1, ""),
                new Event("Cape Flats Coding Bootcamp", "Free training in coding and digital skills.", new DateTime(2025, 3, 15), "Education", 2, ""),
                new Event("Rondebosch Tree Planting Drive", "Help plant 200 indigenous trees across local parks.", new DateTime(2025, 3, 22), "Environment", 1, ""),
                new Event("Camps Bay Summer Concert", "Enjoy live music with a view of the ocean.", new DateTime(2025, 3, 29), "Culture", 3, "")
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

            foreach (var cat in topCategories)
            {
                var catEvents = allEvents.Where(e => e.Category.Equals(cat, StringComparison.OrdinalIgnoreCase) && e.Date > DateTime.Now).OrderBy(e => e.Date).Take(2);
                recommended.AddRange(catEvents);
            }

            var popular = allEvents.OrderByDescending(e => e.ViewCount).Take(3);
            recommended.AddRange(popular);

            return recommended.Distinct().Take(topN);
        }
    }
}

