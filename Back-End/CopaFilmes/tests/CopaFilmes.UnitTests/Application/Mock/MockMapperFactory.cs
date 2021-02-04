using AutoMapper;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CopaFilmes.UnitTests.Application.Mock
{
    public static class MockMapperFactory
    {
        public static IMapper Create()
        {
            var applicationAssemly = Assembly.Load("CopaFilmes.Application");
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(applicationAssemly);
            });
            var mapper = mockMapper.CreateMapper();

            return mapper;
        }
    }
}
