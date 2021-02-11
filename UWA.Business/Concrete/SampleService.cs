using System.Threading.Tasks;
using UWA.Business.Abstract;
using UWA.DataAccess.Abstract;
using UWA.Shared;

namespace UWA.Business.Concrete
{
    public class SampleService : ISampleService
    {
        ISampleRepository _sampleService;

        public SampleService(ISampleRepository sampleService)
        {
            _sampleService = sampleService;
        }

        public async Task<SampleResponse> SampleCounter()
        {
            return await _sampleService.SampleCounter();
        }
    }
}
