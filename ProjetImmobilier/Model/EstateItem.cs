﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetImmobilier.Model
{
    class EstateItem
    {
        private String id;
        private String surface;
        private String estateType;
        private String image;

        public EstateItem(String id, String surface, String estateType, String image)
        {
            this.id = id;
            this.surface = surface;
            this.estateType = estateType;
            this.image = image;

        }

        public string Surface
        {
            get { return surface; }
            set { surface = value; }
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
