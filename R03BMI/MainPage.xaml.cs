using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A27 道輪　悠";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           var height = heighit.Text;
           var weight = weighit.Text;

           string hantei = null;
           try
            {
                double h = double.Parse(height);
                int w　 = int.Parse(weight);
                if (h > 10)
                {
                    h = h / 100;
                }
                if (w > 1000)
                {
                    w = w / 1000;
                }

                double bmi = w / (h * h);
                double bmi2 = Math.Round(bmi,1);


              if (bmi2 < 18.5) {
	        	hantei="低体重(痩せ)";
	        }else if(bmi2 < 25.0) {
	    	  hantei="普通体重";
	        }else if(bmi2 < 30.0) {
	    	  hantei="肥満(1)";
	        }else if(bmi2 < 35.0) { 
              hantei = "肥満(2)";
	        }else if(bmi2 < 40.0) {
              hantei = "肥満(3)";
            }else 
              hantei = "肥満(4)";
                result.Text = "身長" + h + "体重" + w +"kgの人のBMI" +bmi2 +hantei;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                result.Text = "数字がありません";
            }
        }
    }
}
