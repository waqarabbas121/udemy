using DAL.Client.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Client
{
    public class SampleBLL  :ISampleBLL
    {
        private ISampleRepository sampleRepository;
        public SampleBLL(ISampleRepository _sampleRepository)
        {
            sampleRepository = _sampleRepository;
        }

        public int SampleMethod(int i)
        {
            int x = i + 100;
            return sampleRepository.Sample(x);
        }
    }
}
