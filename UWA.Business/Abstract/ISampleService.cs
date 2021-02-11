using System.Threading.Tasks;
using UWA.Shared;

namespace UWA.Business.Abstract
{
    public interface ISampleService
    {
        Task<SampleResponse> SampleCounter();
    }
}
