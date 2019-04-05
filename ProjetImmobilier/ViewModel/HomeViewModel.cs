using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using ProjetImmobilier.Model;

namespace ProjetImmobilier.ViewModel
{
    public class HomeViewModel
    {
        public PlotModel MyModel { get; private set; }
        public HomeViewModel()
        {
            this.MyModel = new PlotModel { Title = "Biens vendus" };

            var rand = new Random();
            double[] cakePopularity = new double[6];
            for (int i = 0; i < 6; ++i)
            {
                cakePopularity[i] = rand.NextDouble();
            }
            var sum = cakePopularity.Sum();

            var barSeries = new BarSeries
            {
                ItemsSource = new List<BarItem>(new[]
                {
                    new BarItem{ Value = (cakePopularity[0] / sum * 100) },
                    new BarItem{ Value = (cakePopularity[1] / sum * 100) },
                    new BarItem{ Value = (cakePopularity[2] / sum * 100) },
                    new BarItem{ Value = (cakePopularity[3] / sum * 100) },
                    new BarItem{ Value = (cakePopularity[4] / sum * 100) },
                    new BarItem{ Value = (cakePopularity[4] / sum * 100) }
                }),
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0:.00}"
            };
            MyModel.Series.Add(barSeries);

            MyModel.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "CakeAxis",
                ItemsSource = new[]
                {
                    EstateType.House.ToString(),
                    EstateType.CommercialLocal.ToString(),
                    EstateType.Garage.ToString(),
                    EstateType.Flat.ToString(),
                    EstateType.Field.ToString(),
                    EstateType.Other.ToString()
                }
            });

        }
    }
}
