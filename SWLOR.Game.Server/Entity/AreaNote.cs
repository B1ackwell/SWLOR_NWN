﻿using Redis.OM.Modeling;

namespace SWLOR.Game.Server.Entity
{
    [Document(StorageType = StorageType.Json, Prefixes = new[] { nameof(AreaNote) })]
    public class AreaNote: EntityBase
    {
        [Indexed]
        public string AreaResref { get; set; }
        public string PublicText { get; set; }
        public string PrivateText { get; set; }

        public AreaNote()
        {
            PublicText = string.Empty;
            PrivateText = string.Empty;
        }
    }
}
