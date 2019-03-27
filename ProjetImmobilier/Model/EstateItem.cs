using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetImmobilier.Model
{
    class EstateItem
    {
        private String id;
        private String title;
        private String estateType;
        private String image;

        public EstateItem(String id, String title, String estateType, String image)
        {
            this.id = id;
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

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
