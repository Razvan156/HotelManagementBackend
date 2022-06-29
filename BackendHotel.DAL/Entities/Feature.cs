using System;
using System.Collections.Generic;

#nullable disable

namespace BackendHotel.DAL.Entities
{
    public partial class Feature : BaseEntity
    {
        public Feature()
        {
            RoomTypeFeatures = new HashSet<RoomTypeFeature>();
        }

        public int IdFeature { get; set; }
        public string FeatureName { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<RoomTypeFeature> RoomTypeFeatures { get; set; }
    }
}
