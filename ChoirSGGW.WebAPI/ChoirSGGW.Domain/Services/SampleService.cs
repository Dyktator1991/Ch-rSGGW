using ChoirSGGW.DataAccess.Repositories.Interfaces;
using ChoirSGGW.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Domain.Services
{
    public class SampleService : ISampleService
    {
        readonly ISampleRepository sampleRepository;

        public SampleService(ISampleRepository sampleRepository)
        {
            this.sampleRepository = sampleRepository;
        }
    }
}
