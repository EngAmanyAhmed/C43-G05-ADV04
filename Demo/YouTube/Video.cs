﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.YouTube
{
    internal class Video
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return $"Title : {Title} , Description  : {Description}";
        }


    }
}
