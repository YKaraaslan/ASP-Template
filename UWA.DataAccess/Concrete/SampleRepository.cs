using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UWA.DataAccess.Abstract;
using UWA.Shared;

namespace UWA.DataAccess.Concrete
{
    public class SampleRepository : ISampleRepository
    {
        public async Task<SampleResponse> SampleCounter()
        {
            using (var dbContext = new UWADbContext())
            {
                var res = await dbContext.Samples.CountAsync();
                return new SampleResponse { SampleMessage = res.ToString() };
            }
        }
    }
}
