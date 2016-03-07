using ChoirSGGW.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ChoirSGGW.WebAPI.Controllers
{
    public class ConcertController : ApiController
    {
        readonly IConcertService concertService;

        public ConcertController(IConcertService concertService)
        {
            this.concertService = concertService;
        }

        /// <summary>
        /// Retrieve list of Concerts
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Retrieve one special concert by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Doing something
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// Doing something
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// Doing something
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}