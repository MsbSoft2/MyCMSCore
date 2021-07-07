﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Page
    {
        [Key]
        public int PageId { get; set; }

        [Display(Name = "گروه صفحه")]
        [Required(ErrorMessage = "لطفا {0} وارد کنید")]
        public int GroupId { get; set; }

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} وارد کنید")]
        [MaxLength(150)]
        public string Title { get; set; }

        [Display(Name = "توضیح مختصر")]
        [Required(ErrorMessage = "لطفا {0} وارد کنید")]
        [MaxLength(350)]
        [DataType(DataType.MultilineText)]
        public string ShortDescription { get; set; }

        [Display(Name = "متن")]
        [Required(ErrorMessage = "لطفا {0} وارد کنید")]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }

        [Display(Name = "بازدید")]
        public int Visit { get; set; }

        [Display(Name = "اسلایدر")]
        public bool ShowInSlider { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        [DisplayFormat(DataFormatString = "{0 : yyyy/MM/dd}")]
        public DateTime CreateDate { get; set; }
        [Display(Name = "تصویر")]
        public string Image { get; set; }

        [Display(Name = "کلمات کلیدی")]
        public string Tags { get; set; }


        //navigation Property
        public virtual PageGroup PageGroup { get; set; }
        public virtual List<PageComment> PageComments { get; set; }
        

    }
}
