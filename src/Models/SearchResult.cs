﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeConnector.Models
{
    public class SearchResult
    {
        #region Public Properties

        public PageInfo PageInfo { get; set; }

        public List<Item> Items { get; set; }

        #endregion
    }
}
