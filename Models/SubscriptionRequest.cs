using System;

namespace CreateAzureSubscriptionPage.Models
{
    public class SubscriptionRequest
    {
        public string Name {get; set;}

        public string OwnerUpn {get; set;}

        public string CostCenter {get; set;}
    }
}