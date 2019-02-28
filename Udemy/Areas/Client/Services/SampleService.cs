using BLL.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Udemy.Areas.Client.Interfaces;

namespace Udemy.Areas.Client.Services
{
    public class SampleService:ISample
    {
        private ISampleBLL sampleBLL;
        public SampleService(ISampleBLL _sampleBLL)
        {
            sampleBLL = _sampleBLL;
        }
        public int SampleMethod(int i)
        {
            return sampleBLL.SampleMethod(i);
        }
    }
}