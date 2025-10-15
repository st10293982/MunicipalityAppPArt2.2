using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class LocalEventsForm : Form
    {
        private SortedDictionary<DateTime, List<Event>> eventsByDate;
        private Dictionary<string, List<Event>> eventsByCategory;
        private HashSet<string> uniqueCategories;
        private Dictionary<string, int> searchCounts; // For recommendations
        private PriorityQueue<Event, int> priorityQueue; // Priority based on Priority field (lower number higher priority? Wait, 1 low, so invert)
        private Queue<Event> pendingAnnouncements;
        private Stack<Event> recentEvents;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public LocalEventsForm()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            InitializeComponent();
            LoadData();
            SetupRecommendations();
        }



        private void LoadData()
        {
            var events = EventsDataStorage.GetEvents().ToList();
            eventsByDate = new SortedDictionary<DateTime, List<Event>>();
            eventsByCategory = new Dictionary<string, List<Event>>(StringComparer.OrdinalIgnoreCase);
            uniqueCategories = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            priorityQueue = new PriorityQueue<Event, int>();
            pendingAnnouncements = new Queue<Event>();
            recentEvents = new Stack<Event>();

            foreach (var ev in events)
            {
                // SortedDictionary by date
                if (!eventsByDate.ContainsKey(ev.Date.Date))
                    eventsByDate[ev.Date.Date] = new List<Event>();
                eventsByDate[ev.Date.Date].Add(ev);

                // Dictionary by category
                if (!eventsByCategory.ContainsKey(ev.Category))
                    eventsByCategory[ev.Category] = new List<Event>();
                eventsByCategory[ev.Category].Add(ev);

                uniqueCategories.Add(ev.Category);

                // PriorityQueue: use negative priority for min-heap (higher priority first)
                priorityQueue.Enqueue(ev, -ev.Priority);

                // Assume announcements are pending if date > now
                if (ev.Date > DateTime.Now)
                    pendingAnnouncements.Enqueue(ev);

                // Recent events: last 5
                recentEvents.Push(ev);
                if (recentEvents.Count > 5) recentEvents.Pop();
            }

            cmbCategory.Items.AddRange(uniqueCategories.ToArray());
            cmbCategory.Items.Insert(0, "All");
            cmbCategory.SelectedIndex = 0; // Select "All" by default

            // Set date range to include all events
            if (events.Any())
            {
                dtpStart.Value = events.Min(e => e.Date);
                dtpEnd.Value = events.Max(e => e.Date);
            }

            DisplayEvents(events);

            // Add buttons for data structure features
            AddDataStructureButtons();
        }

        private void DisplayEvents(IEnumerable<Event> events)
        {
            dgvEvents.DataSource = events.Select(e => new
            {
                e.Title,
                e.Description,
                Date = e.Date.ToShortDateString(),
                e.Category,
                Priority = e.Priority == 1 ? "Low" : e.Priority == 2 ? "Medium" : "High"
            }).ToList();

            // Add double-click event for details
            dgvEvents.CellDoubleClick += DgvEvents_CellDoubleClick;
        }

        private void DgvEvents_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedEvent = (dgvEvents.DataSource as List<dynamic>)?[e.RowIndex];
                if (selectedEvent != null)
                {
                    var eventTitle = selectedEvent.Title;
                    var ev = EventsDataStorage.GetEvents().FirstOrDefault(evt => evt.Title == eventTitle);
                    if (ev != null)
                    {
                        using (var detailsForm = new EventDetailsForm(ev))
                        {
                            detailsForm.ShowDialog();
                        }
                        // Refresh recommendations after viewing
                        UpdateRecommendations();
                    }
                }
            }
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            var filtered = EventsDataStorage.GetEvents().ToList();

            if (cmbCategory.SelectedItem != null && cmbCategory.SelectedItem.ToString() != "All")
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string cat = cmbCategory.SelectedItem.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                filtered = filtered.Where(ev => ev.Category.Equals(cat, StringComparison.OrdinalIgnoreCase)).ToList();
                // Track search
#pragma warning disable CS8604 // Possible null reference argument.
                if (!searchCounts.ContainsKey(cat)) searchCounts[cat] = 0;
#pragma warning restore CS8604 // Possible null reference argument.
                searchCounts[cat]++;
            }

            filtered = filtered.Where(ev => ev.Date >= dtpStart.Value.Date && ev.Date <= dtpEnd.Value.Date).ToList();

            DisplayEvents(filtered);
            UpdateRecommendations();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            cmbCategory.SelectedIndex = 0; // "All"
            ResetDatePickers();
            DisplayEvents(EventsDataStorage.GetEvents());
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetupRecommendations()
        {
            searchCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            UpdateRecommendations();
        }

        private void UpdateRecommendations()
        {
            // Use advanced recommendations from EventsDataStorage
            var recommendedEvents = EventsDataStorage.GetRecommendedEvents(searchCounts, 5);
            lstRecommendations.Items.Clear();
            foreach (var ev in recommendedEvents)
            {
                lstRecommendations.Items.Add($"{ev.Title} ({ev.Category}) - {ev.Date.ToShortDateString()}");
            }
        }

        private IEnumerable<string> GetRelatedCategories(string category)
        {
            var allCategories = new List<string> { "Sports", "Culture", "Education", "Community", "Government", "Health", "Environment", "Arts", "Business", "Recreation" };
            return allCategories.Where(c => !c.Equals(category, StringComparison.OrdinalIgnoreCase));
        }

        private void ResetDatePickers()
        {
            var events = EventsDataStorage.GetEvents().ToList();
            if (events.Any())
            {
                dtpStart.Value = events.Min(e => e.Date);
                dtpEnd.Value = events.Max(e => e.Date);
            }
        }

        private void AddDataStructureButtons()
        {
            // Add buttons to demonstrate data structures
            var btnPendingAnnouncements = new Button { Text = "View Pending Announcements", Location = new System.Drawing.Point(12, 250) };
            btnPendingAnnouncements.Click += (s, e) =>
            {
                var pending = pendingAnnouncements.ToList();
                if (pending.Any())
                {
                    MessageBox.Show($"Pending Announcements:\n{string.Join("\n", pending.Select(p => p.Title))}");
                }
                else
                {
                    MessageBox.Show("No pending announcements.");
                }
            };
            this.Controls.Add(btnPendingAnnouncements);

            var btnRecentEvents = new Button { Text = "View Recent Events", Location = new System.Drawing.Point(200, 250) };
            btnRecentEvents.Click += (s, e) =>
            {
                var recent = recentEvents.ToList();
                if (recent.Any())
                {
                    MessageBox.Show($"Recent Events:\n{string.Join("\n", recent.Select(r => r.Title))}");
                }
                else
                {
                    MessageBox.Show("No recent events.");
                }
            };
            this.Controls.Add(btnRecentEvents);

            var btnHighPriority = new Button { Text = "View High Priority Events", Location = new System.Drawing.Point(350, 250) };
            btnHighPriority.Click += (s, e) =>
            {
                var highPriority = new List<Event>();
                while (priorityQueue.Count > 0)
                {
                    highPriority.Add(priorityQueue.Dequeue());
                }
                // Re-enqueue for future use
                foreach (var ev in highPriority)
                {
                    priorityQueue.Enqueue(ev, -ev.Priority);
                }
                if (highPriority.Any())
                {
                    MessageBox.Show($"High Priority Events:\n{string.Join("\n", highPriority.Where(h => h.Priority == 3).Select(h => h.Title))}");
                }
                else
                {
                    MessageBox.Show("No high priority events.");
                }
            };
            this.Controls.Add(btnHighPriority);
        }

        private void lblRec_Click(object sender, EventArgs e)
        {

        }
    }
}
