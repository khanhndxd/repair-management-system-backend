﻿namespace repair_management_backend.Configuration
{
    public class JwtConfig
    {
        public string Secret { get; set; }
        public TimeSpan TokenLifeTime { get; set; }
    }
}
