namespace SamplerTests
{
    [TestClass]
    public class DefaultSamplerTests
    {
        private readonly DefaultSampler _sampler;

        public DefaultSamplerTests()
        {
            _sampler = new(new DefaultValidator(5));
        }

        [TestMethod]
        public void Sample_SamePeriodSmallerSkip()
        {
            DefaultSampler sampler = new(new DefaultValidator(5));
            var data = TestData.SamePeriodSmallerSkip_TestData;
            var resData = TestData.SamePeriodSmallerSkip_TestData_Result;
            DateTime dateTime = new DateTime(2000, 10, 10);

            var result = sampler.Sample(dateTime, data);

            Assert.AreEqual(resData.Count, result[MeasurmentType.TEMP].Count);
            for (int i = 0; i < result[MeasurmentType.TEMP].Count; i++)
            {
                Assert.AreEqual(result[MeasurmentType.TEMP][i].MeasurmentValue, resData[i].MeasurmentValue);
                Assert.AreEqual(result[MeasurmentType.TEMP][i].MeasurmentTime, resData[i].MeasurmentTime);
                Assert.AreEqual(result[MeasurmentType.TEMP][i].Type, resData[i].Type);
            }

        }

        [TestMethod]
        public void Sample_SamePeriodBiggerReplace()
        {
            DefaultSampler sampler = new(new DefaultValidator(5));
            var data = TestData.SamePeriodBiggerReplace_TestData;
            var resData = TestData.SamePeriodBiggerReplace_TestData_Result;
            DateTime dateTime = new DateTime(2000, 10, 10);

            var result = sampler.Sample(dateTime, data);

            Assert.AreEqual(resData.Count, result[MeasurmentType.TEMP].Count);
            for (int i = 0; i < result[MeasurmentType.TEMP].Count; i++)
            {
                Assert.AreEqual(result[MeasurmentType.TEMP][i].MeasurmentValue, resData[i].MeasurmentValue);
                Assert.AreEqual(result[MeasurmentType.TEMP][i].MeasurmentTime, resData[i].MeasurmentTime);
                Assert.AreEqual(result[MeasurmentType.TEMP][i].Type, resData[i].Type);
            }
        }

        [TestMethod]
        public void Sample_DifferentPeriodSmallerAdd()
        {
            DefaultSampler sampler = new(new DefaultValidator(5));
            var data = TestData.DifferentPeriodSmallerAdd_TestData;
            var resData = TestData.DifferentPeriodSmallerAdd_TestData_Result;
            DateTime dateTime = new DateTime(2000, 10, 10);

            var result = sampler.Sample(dateTime, data);

            Assert.AreEqual(resData.Count, result[MeasurmentType.TEMP].Count);
            for (int i = 0; i < result[MeasurmentType.TEMP].Count; i++)
            {
                Assert.AreEqual(result[MeasurmentType.TEMP][i].MeasurmentValue, resData[i].MeasurmentValue);
                Assert.AreEqual(result[MeasurmentType.TEMP][i].MeasurmentTime, resData[i].MeasurmentTime);
                Assert.AreEqual(result[MeasurmentType.TEMP][i].Type, resData[i].Type);
            }
        }

        [TestMethod]
        public void Sample_DifferentPeriodBiggerAdd()
        {
            DefaultSampler sampler = new(new DefaultValidator(5));
            var data = TestData.DifferentPeriodBiggerAdd_TestData;
            var resData = TestData.DifferentPeriodBiggerAdd_TestData_Result;
            DateTime dateTime = new DateTime(2000, 10, 10);

            var result = sampler.Sample(dateTime, data);

            Assert.AreEqual(resData.Count, result[MeasurmentType.TEMP].Count);
            for (int i = 0; i < result[MeasurmentType.TEMP].Count; i++)
            {
                Assert.AreEqual(result[MeasurmentType.TEMP][i].MeasurmentValue, resData[i].MeasurmentValue);
                Assert.AreEqual(result[MeasurmentType.TEMP][i].MeasurmentTime, resData[i].MeasurmentTime);
                Assert.AreEqual(result[MeasurmentType.TEMP][i].Type, resData[i].Type);
            }
        }

        [TestMethod]
        public void Sample_PeriodBorderUsedInCurrentPeriod()
        {
            DefaultSampler sampler = new(new DefaultValidator(5));
            var data = TestData.PeriodBorderUsedInCurrentPeriod_TestData;
            var resData = TestData.PeriodBorderUsedInCurrentPeriod_TestData_Result;
            DateTime dateTime = new DateTime(2000, 10, 10);

            var result = sampler.Sample(dateTime, data);

            Assert.AreEqual(resData.Count, result[MeasurmentType.TEMP].Count);
            for (int i = 0; i < result[MeasurmentType.TEMP].Count; i++)
            {
                Assert.AreEqual(result[MeasurmentType.TEMP][i].MeasurmentValue, resData[i].MeasurmentValue);
                Assert.AreEqual(result[MeasurmentType.TEMP][i].MeasurmentTime, resData[i].MeasurmentTime);
                Assert.AreEqual(result[MeasurmentType.TEMP][i].Type, resData[i].Type);
            }
        }

        [TestMethod]
        public void Sample_OutputSortedAscendingByDateTime()
        {
            DefaultSampler sampler = new(new DefaultValidator(5));
            var data = TestData.DifferentPeriodSmallerAdd_TestData;
            var resData = TestData.DifferentPeriodSmallerAdd_TestData_Result.OrderBy(o => o.MeasurmentTime).ToList();
            DateTime dateTime = new DateTime(2000, 10, 10);

            var result = sampler.Sample(dateTime, data);

            Assert.AreEqual(resData.Count, result[MeasurmentType.TEMP].Count);
            for (int i = 0; i < result[MeasurmentType.TEMP].Count; i++)
            {
                Assert.AreEqual(result[MeasurmentType.TEMP][i].MeasurmentValue, resData[i].MeasurmentValue);
                Assert.AreEqual(result[MeasurmentType.TEMP][i].MeasurmentTime, resData[i].MeasurmentTime);
                Assert.AreEqual(result[MeasurmentType.TEMP][i].Type, resData[i].Type);
            }
        }

        [TestMethod]
        public void Sample_SkipByGivenDate()
        {
            DefaultSampler sampler = new(new DefaultValidator(5));
            var data = TestData.DifferentPeriodSmallerAdd_TestData;
            var resData = TestData.DifferentPeriodSmallerAdd_TestData_Result;
            DateTime dateTime = new DateTime(2000, 10, 10);

            var result = sampler.Sample(dateTime, data);

            Assert.AreEqual(resData.Count, result[MeasurmentType.TEMP].Count);
            for (int i = 0; i < result[MeasurmentType.TEMP].Count; i++)
            {
                Assert.AreEqual(result[MeasurmentType.TEMP][i].MeasurmentValue, resData[i].MeasurmentValue);
                Assert.AreEqual(result[MeasurmentType.TEMP][i].MeasurmentTime, resData[i].MeasurmentTime);
                Assert.AreEqual(result[MeasurmentType.TEMP][i].Type, resData[i].Type);
            }
        }

        [TestMethod]
        public void Sample_Test()
        {
            DefaultSampler sampler = new(new DefaultValidator(5));
            var data = TestData.TestList;
            var resData = TestData.ResultList;
            DateTime dateTime = new DateTime(2000, 10, 10);

            var result = sampler.Sample(dateTime, data);

            Assert.AreEqual(resData.Where(w => w.Type == MeasurmentType.TEMP).ToList().Count, result[MeasurmentType.TEMP].Count);
            Assert.AreEqual(resData.Where(w => w.Type == MeasurmentType.SPO2).ToList().Count, result[MeasurmentType.SPO2].Count);
            Assert.AreEqual(resData.Where(w => w.Type == MeasurmentType.HR).ToList().Count, result[MeasurmentType.HR].Count);

            for (int i = 0; i < result[MeasurmentType.TEMP].Count; i++)
            {
                Assert.AreEqual(result[MeasurmentType.TEMP][i].MeasurmentValue, resData.Where(w => w.Type == MeasurmentType.TEMP).OrderBy(o => o.MeasurmentTime).ToList()[i].MeasurmentValue);
                Assert.AreEqual(result[MeasurmentType.TEMP][i].MeasurmentTime, resData.Where(w => w.Type == MeasurmentType.TEMP).OrderBy(o => o.MeasurmentTime).ToList()[i].MeasurmentTime);
                Assert.AreEqual(result[MeasurmentType.TEMP][i].Type, resData.Where(w => w.Type == MeasurmentType.TEMP).OrderBy(o => o.MeasurmentTime).ToList()[i].Type);
            }

            for (int i = 0; i < result[MeasurmentType.SPO2].Count; i++)
            {
                Assert.AreEqual(result[MeasurmentType.SPO2][i].MeasurmentValue, resData.Where(w => w.Type == MeasurmentType.SPO2).OrderBy(o => o.MeasurmentTime).ToList()[i].MeasurmentValue);
                Assert.AreEqual(result[MeasurmentType.SPO2][i].MeasurmentTime, resData.Where(w => w.Type == MeasurmentType.SPO2).OrderBy(o => o.MeasurmentTime).ToList()[i].MeasurmentTime);
                Assert.AreEqual(result[MeasurmentType.SPO2][i].Type, resData.Where(w => w.Type == MeasurmentType.SPO2).OrderBy(o => o.MeasurmentTime).ToList()[i].Type);
            }

            for (int i = 0; i < result[MeasurmentType.HR].Count; i++)
            {
                Assert.AreEqual(result[MeasurmentType.HR][i].MeasurmentValue, resData.Where(w => w.Type == MeasurmentType.HR).OrderBy(o => o.MeasurmentTime).ToList()[i].MeasurmentValue);
                Assert.AreEqual(result[MeasurmentType.HR][i].MeasurmentTime, resData.Where(w => w.Type == MeasurmentType.HR).OrderBy(o => o.MeasurmentTime).ToList()[i].MeasurmentTime);
                Assert.AreEqual(result[MeasurmentType.HR][i].Type, resData.Where(w => w.Type == MeasurmentType.HR).OrderBy(o => o.MeasurmentTime).ToList()[i].Type);
            }
        }
    }
}