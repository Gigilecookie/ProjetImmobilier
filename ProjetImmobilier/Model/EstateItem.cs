using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetImmobilier.Model
{
    class EstateItem
    {
        private String title;
        private String estateType;
        private String image;

        public EstateItem(String title, String estateType, String image)
        {

            this.title = title;
            this.estateType = estateType;
            this.image = image;

        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string EstateType
        {
            get { return estateType; }
            set { estateType = value; }
        }

        public string Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}
