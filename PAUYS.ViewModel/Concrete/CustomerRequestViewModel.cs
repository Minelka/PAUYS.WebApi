﻿using PAUYS.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.ViewModel.Concrete
{
    public class CustomerRequestViewModel : BaseViewModel<int>
    {
        public CustomerRequestViewModel() : base(0) { }

        [Display(Name = "Ad")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string LastName { get; set; } = null!;

        [Display(Name = "Mail adresi")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Email { get; set; } = null!;

        [Display(Name = "Müşteri Mesajı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string CustomerMessage { get; set; } = null!;

        [Display(Name = "Admin Mesajı")]
        
        public string? AdminMessage { get; set; } = null!;

        [Display(Name = "İade veya Yeni Talep")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public bool RefundorNewRequest { get; set; }




    }
}
