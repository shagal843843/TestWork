using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherTest
{
    public partial class MainForm : Form
    { 
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close(); // закрытие окна
        }

        private void exitLabel_MouseEnter(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.Red; // изменение звета при наведении
        }

        private void exitLabel_MouseLeave(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.Black; // изменение звета при убирании курсора
        }
        Point lastPoint;
        private void backPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // реализация перетаскивания окна
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void backPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y); // присваивание значения новой начальной точки при отпускании мыши
        }

        private async void changeButton_Click(object sender, EventArgs e)
        {
            string city = cityTextBox.Text; // ввод города в текстовое поле

            WebRequest request = WebRequest.Create("https://api.openweathermap.org/data/2.5/weather?q=" + city + "&appid=3a0e0ea702224a7e6cb439c70f961819"); // создание запроса по ссылке 

            request.Method = "POST";

            request.ContentType = "application/x-www-urlencoded";

            try // для корректной работы, при правильном вводе города вернется json ввиде ответа на запрос, при неправильном - ошибка
            {

                WebResponse response = await request.GetResponseAsync();

                string answer = string.Empty;

                using (Stream s = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(s))
                    {
                        answer = await reader.ReadToEndAsync();
                        reader.Close();
                    }
                    s.Close();  
                }
                
                response.Close();

                // получаем json в виде
                // "coord":{"lon":37.6156,"lat":55.7522},
                //"weather":[{ "id":804,"main":"Clouds","description":"overcast clouds","icon":"04n"}],
                //"base":"stations",
                //"main":{ "temp":284.55,"feels_like":283.83,"temp_min":282.25,"temp_max":285.39,"pressure":1012,"humidity":80,"sea_level":1012,"grnd_level":995},
                //"visibility":10000,
                //"wind":{ "speed":4.02,"deg":339,"gust":6.34},
                //"clouds":{ "all":97},
                //"dt":1685491232,
                //"sys":{ "type":2,"id":47754,"country":"RU","sunrise":1685494498,"sunset":1685555981},
                //"timezone":10800,
                //"id":524901,
                //"name":"Moscow",
                //"cod":200}

                // этот json разбиваем по классам OpenWeather clouds coords main sys weather wind

                OpenWeather.OpenWeather openWeather = JsonConvert.DeserializeObject<OpenWeather.OpenWeather>(answer); // дессиарилизация json из переменной answer

                weatherPanel.BackgroundImage = openWeather.weather[0].Icon; //заполнение окошка с иконкой

                mainLabel.Text = openWeather.weather[0].main; //заполнение типа погоды

                descriptionLabel.Text = "Description: " + openWeather.weather[0].description; // заполнение описания

                temperatureLabel.Text = "Average temperature (°C): " + openWeather.main.temp.ToString("0.##"); // заполнение температуры( с точностью до 2 знаков после запятой)

                windLabel.Text = "Wind speed (m/s): " + openWeather.wind.speed.ToString(); // заполнение скорости ветра


            }
            catch(System.Net.WebException) // при возврате ошибки открывается окно ошибки
            {
                ErorForm erorForm = new ErorForm();
                erorForm.Show();
            }
        }
    }
}
