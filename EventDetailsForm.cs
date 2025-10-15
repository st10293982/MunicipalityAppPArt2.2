using System;
using System.Windows.Forms;


namespace MunicipalityApp
{
    public partial class EventDetailsForm : Form
    {
        private Event _event;

        public EventDetailsForm(Event ev)
        {
            InitializeComponent();
            _event = ev;
            LoadEventDetails();
        }

        private void LoadEventDetails()
        {
            lblTitle.Text = _event.Title;
            lblDescription.Text = _event.Description;
            lblDate.Text = _event.Date.ToShortDateString();
            lblCategory.Text = _event.Category;
            lblPriority.Text = _event.Priority == 1 ? "Low" : _event.Priority == 2 ? "Medium" : "High";
            lblTags.Text = string.Join(", ", _event.Tags);
            lblViewCount.Text = _event.ViewCount.ToString();

            // Increment view count
            EventsDataStorage.UpdateEventViewCount(_event.Id);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

