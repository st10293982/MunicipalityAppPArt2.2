using System;

namespace MunicipalityApp
{
    public class Event
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Category { get; set; } = string.Empty;
        public int Priority { get; set; } = 1; // 1 low, 2 medium, 3 high
        public string ImagePath { get; set; } = string.Empty;
        public List<string> Tags { get; set; } = new List<string>(); // For better recommendations
        public int ViewCount { get; set; } = 0; // Track views for recommendations

        /// <summary>
        /// Parameterless constructor required for deserialization.
        /// </summary>
        public Event() { }

        public Event(string title, string description, DateTime date, string category, int priority, string imagePath)
        {
            Title = title;
            Description = description;
            Date = date;
            Category = category;
            Priority = priority;
            ImagePath = imagePath;
        }
    }
}
