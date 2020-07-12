using System;
using Xunit;

namespace Test
{
    public class MainTest    
    {
        [Fact]
        public void DatasetCreate()
        {
            var dataset = TensorflowNet.Data.Dataset.FromTensorSlices();
            Assert.NotNull(dataset);
        }
    }
}
