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
    
    public partial class Friend
    {
        public int friend_id { get; set; }
        public Nullable<int> userRequest_id { get; set; }
        public Nullable<int> userResponse_id { get; set; }
        public Nullable<bool> friend_status { get; set; }
        public Nullable<System.DateTime> friend_dateRequest { get; set; }
        public Nullable<System.DateTime> friend_dateResponse { get; set; }
        public Nullable<System.DateTime> friend_dateUnfriend { get; set; }
        public Nullable<bool> friend_recycleBin { get; set; }
        public Nullable<bool> friend_follow { get; set; }
        public Nullable<bool> friend_follow2_Response { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
