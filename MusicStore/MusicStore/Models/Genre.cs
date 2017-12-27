using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    /// <summary>
    /// 唱片类型和专辑类型
    /// </summary>
    public class Genre
    {
        /// <summary>
        /// 类别Id
        /// </summary>
        public int GenreId { get; set; }
        /// <summary>
        /// 类别名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 专辑集合
        /// </summary>
        public List<Album> Albums { get; set; }
    }
}