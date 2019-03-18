using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ProjetImmobilier.Model
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected async override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            await DataAccess.EstateDbContext.Initialize();
            /*
             
            var c = new Model.Contract()
            {
                Price = 200000,
                Description = "Petite description"
            };

            DataAccess.EstateDbContext.Current.Add(c);
            DataAccess.EstateDbContext.Current.SaveChanges();

            var monBien = DataAccess.EstateDbContext.Current.Estates
                .Where(estate => estate.City == "LYON")
                .OrderBy(estate => estate.Address)
                .First();

            */
        }
    }
}
