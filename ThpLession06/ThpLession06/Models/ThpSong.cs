using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThpLession06.Models
{
    public class ThpSong
    {
        [Key]
        public long Id { get; set; } 

        [Required(ErrorMessage ="Thp:Hãy nhập tiêu đề")]
        [DisplayName("Tiêu đề")]
        public string ThpTitle { get; set; }

        [Required(ErrorMessage = "Thp:Hãy nhập tác giả")]
        [DisplayName("tác giả")]
        public string ThpAuthor { get; set; }

        [Required(ErrorMessage = "Thp:Hãy nhập nghệ sĩ")]
        [DisplayName("nghệ sĩ")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="Thp: Tên nghệ sĩ  có tối thiểu 2 ký tự, tối đa 50 ký tự")]
        public string ThpArtist { get; set; }

        [Required(ErrorMessage = "Thp:Hãy nhập năm xuất bản")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="Thp: năm xuất bản phải có 4 ký tự số")]
        [Range(1900,2024,ErrorMessage ="Thp: Năm xuất bản từ 1900-2024")]
        [DisplayName("năm xuất bản")]

        public int ThpYearRelease { get; set; }
    }

}
