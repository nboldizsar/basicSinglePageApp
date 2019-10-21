using AutoMapper;
using Core.BussisnessObjects;
using DevExpress.Xpo;
using ExampleApi.MapperProfiles;
using ExampleApi.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExampleApi.Controllers
{
    public class AutoController : ApiController
    {
        IMapper _mapper;
        MapperConfiguration _autoMapperCfg;

        public AutoController()
        {
            _autoMapperCfg = new AutoMapper.MapperConfiguration(cfg => cfg.AddProfile(new AutoProfile()));
            _mapper = _autoMapperCfg.CreateMapper();
        }

        // GET api/Auto
        public IEnumerable<AutoViewModel> Get()
        {
            var sess = new Session();
            var Autos = new XPQuery<Auto>(sess).ToList();
            List<AutoViewModel> result = new List<AutoViewModel>();
            foreach (var item in Autos)
            {
                result.Add(_mapper.Map<AutoViewModel>(item));
            }

            return result;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}