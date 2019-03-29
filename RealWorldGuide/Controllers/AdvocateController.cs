using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RealWorldGuide.Data;

namespace RealWorldGuide.Controllers
{
    public class AdvocateController : ApiController
    {
        // GET: api/Advocate/Events?advocateId=1
        [HttpGet, Route("api/advocate/events")]
        public Advocate GetEventsForAdvocate(int advocateId)
        {
            return SampleEventsForAdvocate();
        }

        // GET: api/Advocate/FutureEvents?advocateId=1
        [HttpGet, Route("api/advocate/futureevents")]
        public Advocate GetFutureEventsForAdvocate(int advocateId)
        {
            return SampleFutureEventsForAdvocate();
        }

        // GET: api/Advocate
        [HttpGet, Route("api/advocates")]
        public List<Advocate> GetAllAdvocates()
        {
            return SampleAdvocates();
        }

        // GET: api/Advocate/1
        [HttpGet, Route("api/advocate")]
        public Advocate GetAdvocateById(int advocateId)
        {
            return SampleAdvocate();
        }

        #region Sample Data Methods

        private static Advocate SampleAdvocate()
        {
            return new Advocate()
            {
                Id = 200,
                Name = "John Smith",
                TwitterHandle = "johnsmith"
            };
        }
        private static List<Advocate> SampleAdvocates()
        {
            return new List<Advocate>()
            {
                new Advocate()
                {
                    Id = 300,
                    Name = "Alex Brown",
                    TwitterHandle = "alexbrown"
                },
                new Advocate()
                {
                    Id = 200,
                    Name = "John Smith",
                    TwitterHandle = "johnsmith"
                },
                new Advocate()
                {
                    Id = 100,
                    Name = "Jane Doe",
                    TwitterHandle = "janedoe"
                }
            };
        }
        private static Advocate SampleEventsForAdvocate()
        {
            return new Advocate()
            {
                Id = 100,
                Name = "Jane Doe",
                TwitterHandle = "janedoe",
                Events = new List<Event>()
                {
                    new Event()
                    {
                        Id = 1,
                        EventName = "Event 1",
                        Website = "https://event1.com",
                        Location = "Anytown, USA",
                        Latitude = "lat 1",
                        Longitude = "long 1",
                        StartDate = new DateTime(2019,1,1),
                        EndDate = new DateTime(2019,1,2)
                    },
                    new Event()
                    {
                        Id = 3,
                        EventName = "Event 3",
                        Website = "https://event3.com",
                        Location = "Anytown, Canada",
                        Latitude = "lat 3",
                        Longitude = "long 3",
                        StartDate = new DateTime(2019,3,3),
                        EndDate = new DateTime(2019,3,7)
                    },
                    new Event()
                    {
                        Id = 4,
                        EventName = "Event 4",
                        Website = "https://event4.com",
                        Location = "Anytown, Belgium",
                        Latitude = "lat 4",
                        Longitude = "long 4",
                        StartDate = new DateTime(2019,4,11),
                        EndDate = new DateTime(2019,4,12)
                    }
                }
            };
        }
        private static Advocate SampleFutureEventsForAdvocate()
        {
            return new Advocate()
            {
                Id = 100,
                Name = "Jane Doe",
                TwitterHandle = "janedoe",
                Events = new List<Event>()
                {
                    new Event()
                    {
                        Id = 4,
                        EventName = "Event 4",
                        Website = "https://event4.com",
                        Location = "Anytown, Belgium",
                        Latitude = "lat 4",
                        Longitude = "long 4",
                        StartDate = new DateTime(2019,4,11),
                        EndDate = new DateTime(2019,4,12)
                    }
                }
            };
        }

        #endregion
    }
}
