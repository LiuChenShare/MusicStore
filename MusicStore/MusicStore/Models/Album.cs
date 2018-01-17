using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name = "专辑Id")]
        [ScaffoldColumn(false)]
        public int AlbumId { get; set; }
        /// <summary>
        /// 类别Id
        /// </summary>
        [Display(Name = "类别Id")]
        public int GenreId { get; set; }
        /// <summary>
        /// 艺术家Id
        /// </summary>
        [Display(Name = "艺术家Id")]
        public int ArtistId { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        [Required]
        [Display(Name = "标题")]
        [StringLength(160, MinimumLength =4, ErrorMessage = "太长")]
        public string Title { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        [Required(ErrorMessage = "价格必填")]
        [Range(0.01, 100.00,
        ErrorMessage = "价格必须在0.01到100之间。")]
        [Display(Name = "价格")]
        public decimal Price { get; set; }
        /// <summary>
        /// 专辑封面Url
        /// </summary>
        [DisplayName("专辑封面的URL")]
        [StringLength(1024)]
        public string AlbumArtUrl { get; set; }
        /// <summary>
        /// 类别
        /// </summary>
        public virtual Genre Genre { get; set; }
        /// <summary>
        /// 艺术家
        /// </summary>
        public virtual Artist Artist { get; set; }
    }
}