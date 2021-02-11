using System.Threading.Tasks;
using UWA.Shared;

namespace UWA.DataAccess.Abstract
{
    public interface ISampleRepository
    {
        Task<SampleResponse> SampleCounter();
    }
}
