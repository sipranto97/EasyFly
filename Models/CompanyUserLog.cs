//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyFly.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    public partial class CompanyUserLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyUserLog()
        {
            this.CustomerSupports = new HashSet<CustomerSupport>();
            this.CargoFlights = new HashSet<CargoFlight>();
        }

        [Display(Name = "User ID")]
        [DataType(DataType.Text)]
        public string C_UserID { get; set; }

        [Display(Name = "Profile Photo")]
        [DataType(DataType.ImageUrl)]
        public string C_Photos { get; set; }
        public HttpPostedFileBase C_PhotoFile { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string C_Email { get; set; }

        [Required]
        [Display(Name = "Company Name")]
        [DataType(DataType.Text)]
        public string C_Name { get; set; }

        [Required]
        [Display(Name = "Passoword")]
        [DataType(DataType.Password)]
        public string C_Passkey { get; set; }

        [Required]
        [Display(Name = "Confirm Passoword")]
        [DataType(DataType.Password)]
        [Compare("C_Passkey", ErrorMessage = "Password didn't match!")]
        public string C_ConfirmPasskey { get; set; }

        [Required]
        [Display(Name = "Date of Establishment")]
        [DataType(DataType.Date)]
        public string DateEstd { get; set; }

        [Required]
        [Display(Name = "Contact No.")]
        [DataType(DataType.PhoneNumber)]
        public string C_ContactNo { get; set; }

        [Required]
        [Display(Name = "Country")]
        [DataType(DataType.Text)]
        public string C_CountryName { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerSupport> CustomerSupports { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CargoFlight> CargoFlights { get; set; }
    }
}