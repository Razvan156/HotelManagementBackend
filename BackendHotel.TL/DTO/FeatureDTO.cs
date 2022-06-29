using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.TL.DTO
{
    public class FeatureDTO
    {
        public FeatureDTO()
        {
            RoomTypeFeatures = new HashSet<RoomTypeFeatureDTO>();
        }

        public int IdFeature { get; set; }
        public string FeatureName { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<RoomTypeFeatureDTO> RoomTypeFeatures { get; set; }
    }
}
