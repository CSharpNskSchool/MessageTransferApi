﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MessagesTransferApi.Data.Models
{
    public class Connector
    {
        public int Id { get; set; }

        public string NetworkName { get; set; }

        public string Url { get; set; }
    }
}
