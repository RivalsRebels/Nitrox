﻿using System;
using ProtoBufNet;

namespace NitroxModel.DataStructures.GameLogic.Entities.Metadata
{
    [Serializable]
    [ProtoContract]
    public class IncubatorMetadata : EntityMetadata
    {
        [ProtoMember(1)]
        public bool Powered { get; }

        [ProtoMember(2)]
        public bool Hatched { get; }

        protected IncubatorMetadata()
        {
            //Constructor for serialization. Has to be "protected" for json serialization.
        }

        public IncubatorMetadata(bool powered, bool hatched)
        {
            this.Powered = powered;
            this.Hatched = hatched;
        }
    }
}
