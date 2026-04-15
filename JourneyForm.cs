using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.PeerToPeer;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace login_tutorial
{
    public partial class JourneyForm : Form
    {
        // creates a public list where all the positions would be stored that the distance calculator will use
        UsrClass Usr;
        List<GeoLocator> Locations = new List<GeoLocator>();
        GMap.NET.WindowsForms.GMapControl gmap;

        public JourneyForm(UsrClass Usr)
        {
            // this code is responsible for loading everything that was needed to be displayed as soon as the form is open
            InitializeComponent();
            // this code toggles which buttons are visible and which ones aren't
            Start_Journey.Visible = true;
            Stop.Visible = false;
            Pause_Journey.Visible = false;
            Resume_Journey.Visible = false;
            // initializes the custom map control
            gmap = new GMap.NET.WindowsForms.GMapControl();
            // sets up Bing Map as the API
            gmap.MapProvider = GMap.NET.MapProviders.GMapProviders.BingMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gmap.MinZoom = 1;
            gmap.MaxZoom = 20;
            // displays the map inside a panel
            gmap.Dock = DockStyle.Fill;
            panel1.Controls.Add(gmap);
            // links Usr variable to this form
            this.Usr = Usr;
        }

        private void ShowLat_Click(object sender, EventArgs e)
        {

        }

        private void Distance_Click(object sender, EventArgs e)
        {
            //DistanceCalculator cal = new DistanceCalculator();
            //Decimal dist = cal.CalDistance(Locations);
            //Distance.Text = Convert.ToString(dist);
        }

        private void JourneyForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            // toggles the visibility of some buttons and clears the positions that were registered from a previous journey
            Start_Journey.Visible = false;
            Stop.Visible = true;
            Pause_Journey.Visible = true;
            back_button.Visible = false;
            Locations.Clear();
            // starts the total timer for a journey and another timer to indicate a 10 second cooldown for the new position to be registered into the list
            journeyTimer.Interval = 10000;
            journeyTimer.Start();
            total_timer.Start();

            
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            // this code is ran when the journey has been ended by a user
            DistanceCalculator cal = new DistanceCalculator();
            Decimal dist = cal.CalDistance(Locations);
            // stores current date and time
            DateTime formattedDate = DateTime.Now;
            //stops both timers
            journeyTimer.Stop();
            total_timer.Stop();
            string username = Usr.UserName;
            // calls  the data base class
            DatabaseClass DC = new DatabaseClass();
            // updates total distance
            DC.addJourneyTime(username, (float)dist);
            // adds new journey that has been ran most rescently.
            // this would store username, total time, total distance and the date and time
            DC.addNewJourney(username, (float)dist, (string)Time.Text, (DateTime)formattedDate);
            // makes all the relevant results of the journey visible on the message box
            MessageBox.Show("Total time: " + Convert.ToString(Time.Text) + "seconds" + "\n" + "Total Distance: " + Convert.ToString(dist) + "metres");
            //Once the code is stopped, it takes the user back to the menu form
            MenuForm f = new MenuForm(Usr);
            f.Show();
            this.Visible = false;
        }

        private void journeyTimer_Tick(object sender, EventArgs e)
        {

            
            GeoLocator pos = new GeoLocator();
           // this code adds the validation to the position registers.
           // if either longitude orr latitude is equal to 0, the position is invalid and must be ignored from including into the list
            if (pos.returnLong() != 0 || pos.returnLat() != 0)
            {
                // displays markers on every valid position
                gmap.Position = new PointLatLng(Convert.ToDouble(pos.returnLat()), Convert.ToDouble(pos.returnLong()));
                GMapOverlay markers = new GMapOverlay("markers");
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(pos.returnLat()), Convert.ToDouble(pos.returnLong())), GMarkerGoogleType.arrow);
                markers.Markers.Add(marker);
                gmap.Overlays.Add(markers);
                // keeps the zoomness fixed and updates the map as soon as the new position is recorded
                gmap.Zoom = 20;
                gmap.Update();
                gmap.Refresh();
                Locations.Add(pos);
                //carries out the haversine formula and displays the distance in the form
                DistanceCalculator cal = new DistanceCalculator();
                Decimal dist = cal.CalDistance(Locations);
                Distance.Text = Convert.ToString(dist);
            }
            

            
        }
        int i = 0;
        private void total_timer_Tick(object sender, EventArgs e)
        {
            // this iterator is changed by 1 every second so it works as the total timer of the journey
            i++;
            Time.Text = i.ToString();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void control1_Click(object sender, EventArgs e)
        {

        }

        private void Pause_Journey_Click(object sender, EventArgs e)
        {
            //once the pause is selected, certain button become visible and invisible and both timers stop but do not reset
            Resume_Journey.Visible = true;
            Pause_Journey.Visible = false;
            if (total_timer.Enabled && journeyTimer.Enabled)
            {
                total_timer.Enabled = false;
                journeyTimer.Enabled = false;
            }


        }

        private void Resume_Journey_Click(object sender, EventArgs e)
        {
            // code for resuming back the journey from the pause state
            Resume_Journey.Visible = false;
            Pause_Journey.Visible = true;
            if (total_timer.Enabled == false && journeyTimer.Enabled == false)
            {
                total_timer.Enabled = true;
                journeyTimer.Enabled = true;
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            // creates the back button for the user to go back to the menu form
            MenuForm f = new MenuForm(Usr);
            f.Show();
            this.Visible = false;
        }
    }
}
