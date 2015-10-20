using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampaignsChronicler.Models
{
    public class CampaignContext : DbContext
    {
        public DbSet<Campaign> Campaigns { get; set; }
    }
}
