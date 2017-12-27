using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class MusicStoreEntities : DbContext
    {
        /// <summary>
        /// 专辑
        /// </summary>
        public DbSet<Album> Albums { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public DbSet<Genre> Genres { get; set; }
        /// <summary>
        /// 艺术家
        /// </summary>
        public DbSet<Artist> Artists { get; set; }
    }
}