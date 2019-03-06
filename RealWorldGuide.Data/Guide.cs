using System;

namespace RealWorldGuide.Data
{
    class Guide
    {
        public int Id { get; set; }

        public string GuideName { get; set; }
        public string Author { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
