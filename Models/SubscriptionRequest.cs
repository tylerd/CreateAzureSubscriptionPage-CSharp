using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CreateAzureSubscriptionPage.Models
{
    public class SubscriptionRequest
    {
        [Required]
        [Display(Name = "Business Unit")]
        public string BusinessUnit { get; set; }

        [Required]
        [Display(Name = "Department")]
        public string Department { get; set; }

        [Required]
        [Display(Name = "Subscription Type")]
        public SubscriptionType SubscriptionType {get; set;}

        public List<SelectListItem> SubscriptionTypes {get;} = new List<SelectListItem>
        {
            new SelectListItem { Value = SubscriptionType.Production.ToString(), Text = "Production"},
            new SelectListItem { Value = SubscriptionType.DevTest.ToString(), Text = "Dev/Test"}
        };

        [Required]
        [Display(Name = "Owner")]
        public string OwnerUpn {get; set;}

        [Required]
        [Display(Name = "Cost Center")]
        public string CostCenter {get; set;}
    }
}