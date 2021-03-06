﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MessagesTransferApi.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string UserToken { get; set; }

        public virtual List<NetworkAuthData> Accounts { get; set; }
        
        public string FeedbackUrl { get; set; }
    }
}
