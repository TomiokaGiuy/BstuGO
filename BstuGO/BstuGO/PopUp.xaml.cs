using Rg.Plugins.Popup.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace BstuGO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUp : Rg.Plugins.Popup.Pages.PopupPage
    {
        public delegate void ButtonClickedHandler(object sender, EventArgs e);
        public event ButtonClickedHandler ButtonClicked;

        public event EventHandler<string> ValueSelectedFaculty;
        public event EventHandler<string> ValueSelectedCourse;
        public PopUp(string selectedFaculty, string selectedCourse)
        {

            InitializeComponent();

            facultyPicker.Items.Add("ФИСЕ");
            facultyPicker.Items.Add("ФЭИС");
            facultyPicker.Items.Add("СФ");
            facultyPicker.Items.Add("ЭФ");
            facultyPicker.Items.Add("МСФ");

            coursePicker.Items.Add("1");
            coursePicker.Items.Add("2");
            coursePicker.Items.Add("3");
            coursePicker.Items.Add("4");

            facultyPicker.SelectedItem = selectedFaculty;
            facultyPicker.SelectedIndexChanged += OnTableFacultySelectedIndexChanged;

            coursePicker.SelectedItem = selectedCourse;
            coursePicker.SelectedIndexChanged += OnTableCourseSelectedIndexChanged;

        }
        private void OnTableFacultySelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption1 = facultyPicker.SelectedItem as string;
            ValueSelectedFaculty?.Invoke(this, selectedOption1);
        }

        private void OnTableCourseSelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption2 = coursePicker.SelectedItem as string;
            ValueSelectedCourse?.Invoke(this, selectedOption2);
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            string selectedOption1 = facultyPicker.SelectedItem as string;
            string selectedOption2 = coursePicker.SelectedItem as string;
            ValueSelectedFaculty?.Invoke(this, selectedOption1);
            ValueSelectedCourse?.Invoke(this, selectedOption2);
            PopupNavigation.Instance.PopAsync();
        }
        private async void ClosePage(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
        }
    }
}