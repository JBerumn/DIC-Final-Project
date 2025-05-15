using System;
using System.Net;
using System.Text.RegularExpressions;
using RestSharp;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_App_GUI
{
    public partial class Form1 : Form
    {
        string Weather;
        string Tempature;
        string Wind;
        string Humididty;
        string UVindex;
        string Pressure;
        string TempatureFeelsLike;
        string LocalTimeZone;

        public Form1()
        {
            InitializeComponent();
        }

        private void Getweatherdata(string location)
        {
            var client = new RestClient($"https://wttr.in/{WebUtility.UrlEncode(location)}?format=%C+%t+%w+%h+%u+%P+%f+%Z");

            var request = new RestRequest();
            request.AddParameter("method", "GET");

            var response = client.Execute(request);

            if(response.IsSuccessful)
            {
                string[] weatherParameters = Regex.Split(response.Content, " ");
                Weather = weatherParameters[0];
                Tempature = weatherParameters[1];
                Wind= weatherParameters[2];
                Humididty = weatherParameters[3];
                UVindex= weatherParameters[4];
                Pressure = weatherParameters[5];
                TempatureFeelsLike = weatherParameters[6];
                LocalTimeZone = weatherParameters[7];

                for (int i = 0; i <= 100; i++)
                {
                    loadingBar.Value = i;

                }

                DisplayDate();

            }
            else
            {
                MessageBox.Show("Error: " + response.StatusCode);
            }

        }

       
        private void DisplayDate()
        {
            data1.Text = Weather;
            data2.Text = "Tempature: " + Tempature;
            data3.Text = "Wind: " + Wind;
            data4.Text = "Humidity: " + Humididty;
            data5.Text = "UV index: " + UVindex;
            data6.Text = "Pressure: " + Pressure;
            data7.Text = "Tempature Feels Like: " + TempatureFeelsLike;
            data8.Text = "Local Time Zone: " + LocalTimeZone;

           
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(locationTextBox.Text !="")
                try
                {

                    Getweatherdata(locationTextBox.Text);



                }
                catch(Exception)
                {
                    Console.WriteLine("Error");                }
        }

        private void locationTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
