﻿using MessagesTransferApi.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessagesTransferApi.Data.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<NetworkAuthData> Accounts { get; set; }

        public DbSet<Connector> Connectors { get; set; }
    }
}
