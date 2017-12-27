using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    /// <summary>
    /// 专辑类
    /// </summary>
    public class Album
    {
        /// <summary>
        /// 专辑Id
        /// </summary>
        public int AlbumId { get; set; }
        /// <summary>
        /// 类别Id
        /// </summary>
        public int GenreId { get; set; }
        /// <summary>
        /// 艺术家Id
        /// </summary>
        public int ArtistId { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 专辑封面Url
        /// </summary>
        public string AlbumArtUrl { get; set; }
        /// <summary>
        /// 类别
        /// </summary>
        public Genre Genre { get; set; }
        /// <summary>
        /// 艺术家
        /// </summary>
        public Artist Artist { get; set; }
    }
}