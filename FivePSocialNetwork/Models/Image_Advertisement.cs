//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FivePSocialNetwork.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Image_Advertisement
    {
        public int ImageAdvertisement_id { get; set; }
        public string ImageAdvertisement_image { get; set; }
        public Nullable<int> advertisement_id { get; set; }
        public string ImageAdvertisement_note { get; set; }
        public Nullable<bool> ImageAdvertisement_activate { get; set; }
        public Nullable<System.DateTime> ImageAdvertisement_dateCreate { get; set; }
        public Nullable<System.DateTime> ImageAdvertisement_dateEdit { get; set; }
        public Nullable<bool> ImageAdvertisement_recycleBin { get; set; }
        public Nullable<int> positionAdvertisement_id { get; set; }
    
        public virtual Advertisement Advertisement { get; set; }
        public virtual Position_Advertisement Position_Advertisement { get; set; }
    }
}
