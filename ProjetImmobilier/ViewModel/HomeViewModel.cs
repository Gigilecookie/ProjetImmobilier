using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using ProjetImmobilier.Model;

namespace ProjetImmobilier.ViewModel
{
    public class HomeViewModel
    {
        private List<Estate> listEstate;
        public PlotModel MyModel { get; private set; }
        public HomeViewModel()
        {
            this.MyModel = new PlotModel { Title = "Estate sold" };
            listEstate = new List<Estate>(EstateDbContext.Current.Estates.Include(e => e.Photos)
                                                                                        .Include(e => e.Contracts)
                                                                                        .Include(e => e.MainPhoto)
                                                                                        .Include(e => e.Owner));

            int House = 0;
            int CommercialLocal = 0;
            int Garage = 0;
            int Flat = 0;
            int Field = 0;
            int Other = 0;
            for (int i = 0; i < listEstate.Count; i++)
            {
                if (listEstate[i].Type == EstateType.House)
                    House++;
                else if (listEstate[i].Type == EstateType.CommercialLocal)
                    CommercialLocal++;
                else if (listEstate[i].Type == EstateType.Garage)
                    Garage++;
                else if (listEstate[i].Type == EstateType.Flat)
                    Flat++;
                else if (listEstate[i].Type == EstateType.Field)
                    Field++;
                else if (listEstate[i].Type == EstateType.Other)
                    Other++;
            }
            var sum = listEstate.Count;

            var barSeries = new BarSeries
            {
                ItemsSource = new List<BarItem>(new[]
                {
                    new BarItem{ Value = (House*1.0 / sum * 100) },
                    new BarItem{ Value = (CommercialLocal*1.0 / sum * 100) },
                    new BarItem{ Value = (Garage*1.0 / sum * 100) },
                    new BarItem{ Value = (Flat*1.0 / sum * 100) },
                    new BarItem{ Value = (Field*1.0 / sum * 100) },
                    new BarItem{ Value = (Other*1.0 / sum * 100) }
                }),
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0:.00}%"
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
