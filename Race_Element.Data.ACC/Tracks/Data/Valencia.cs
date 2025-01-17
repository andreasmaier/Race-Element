﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RaceElement.Util.DataTypes;
using System;
using System.Collections.Generic;
using static RaceElement.Data.ACC.Tracks.TrackData;

namespace ACCManager.Data.ACC.Tracks.Data
{
    internal class Valencia : AbstractTrackData
    {
        public override Guid Guid => new Guid("51bcd9f5-5048-4f98-aff6-ec853e77de5a");
        public override string FullName => "Circuit Ricardo Tormo Valencia";
        public override int TrackLength => 4005;

        public override Dictionary<FloatRangeStruct, (int, string)> CornerNames => new Dictionary<FloatRangeStruct, (int, string)>();
    }
}