using Sampler.Interfaces;
using Sampler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplerTests
{
    public class TestData
    {
        public static readonly List<IValueMeasurment> TestList = new()
                    {
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 04, 45),
                            MeasurmentValue = 35.79,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 01, 18),
                            MeasurmentValue = 98.78,
                            Type = Sampler.Enums.MeasurmentType.SPO2
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 09, 07),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 03, 34),
                            MeasurmentValue = 96.49,
                            Type = Sampler.Enums.MeasurmentType.SPO2
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 02, 01),
                            MeasurmentValue = 35.82,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 05, 00),
                            MeasurmentValue = 97.17,
                            Type = Sampler.Enums.MeasurmentType.SPO2
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 05, 01),
                            MeasurmentValue = 95.08,
                            Type = Sampler.Enums.MeasurmentType.SPO2
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 04, 11, 09, 54),
                            MeasurmentValue = 95.08,
                            Type = Sampler.Enums.MeasurmentType.HR
                        },
        };
        public static readonly List<IValueMeasurment> ResultList = new()
                    {
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 04, 45),
                            MeasurmentValue = 35.79,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 09, 07),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 03, 34),
                            MeasurmentValue = 96.49,
                            Type = Sampler.Enums.MeasurmentType.SPO2
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 05, 01),
                            MeasurmentValue = 95.08,
                            Type = Sampler.Enums.MeasurmentType.SPO2
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 04, 11, 09, 54),
                            MeasurmentValue = 95.08,
                            Type = Sampler.Enums.MeasurmentType.HR
                        },
        };
        public static readonly List<IValueMeasurment> SamePeriodSmallerSkip_TestData = new()
                    {
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 04, 45),
                            MeasurmentValue = 35.79,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 04, 44),
                            MeasurmentValue = 98.78,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 05, 07),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 04, 46),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
        };

        public static readonly List<IValueMeasurment> SamePeriodSmallerSkip_TestData_Result = new()
                    {
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 04, 46),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 05, 07),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },

        };

        public static readonly List<IValueMeasurment> SamePeriodBiggerReplace_TestData = new()
                    {
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 04, 45),
                            MeasurmentValue = 35.79,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 04, 44),
                            MeasurmentValue = 98.78,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 05, 07),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 05, 10),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
        };

        public static readonly List<IValueMeasurment> SamePeriodBiggerReplace_TestData_Result = new()
                    {
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 04, 45),
                            MeasurmentValue = 35.79,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 05, 10),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },

        };

        public static readonly List<IValueMeasurment> DifferentPeriodSmallerAdd_TestData = new()
                    {
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 05, 45),
                            MeasurmentValue = 35.79,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 04, 44),
                            MeasurmentValue = 98.78,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 35, 07),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 24, 10),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
        };

        public static readonly List<IValueMeasurment> DifferentPeriodSmallerAdd_TestData_Result = new()
                    {
                       new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 04, 44),
                            MeasurmentValue = 98.78,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 05, 45),
                            MeasurmentValue = 35.79,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 24, 10),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 35, 07),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },

        };

        public static readonly List<IValueMeasurment> DifferentPeriodBiggerAdd_TestData = new()
                    {
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 05, 45),
                            MeasurmentValue = 35.79,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 35, 44),
                            MeasurmentValue = 98.78,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 59, 07),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 15, 10),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
        };

        public static readonly List<IValueMeasurment> DifferentPeriodBiggerAdd_TestData_Result = new()
                    {
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 05, 45),
                            MeasurmentValue = 35.79,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 15, 10),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 35, 44),
                            MeasurmentValue = 98.78,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 59, 07),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },

        };

        public static readonly List<IValueMeasurment> PeriodBorderUsedInCurrentPeriod_TestData = new()
                    {
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 05, 45),
                            MeasurmentValue = 35.79,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 05, 00),
                            MeasurmentValue = 98.78,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 10, 07),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 15, 00),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
        };

        public static readonly List<IValueMeasurment> PeriodBorderUsedInCurrentPeriod_TestData_Result = new()
                    {
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 05, 45),
                            MeasurmentValue = 35.79,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 10, 07),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 15, 00),
                            MeasurmentValue = 35.01,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },

        };

        public static readonly List<IValueMeasurment> SkipByGivenDate_TestData = new()
                    {
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2016, 01, 03, 10, 05, 45),
                            MeasurmentValue = 35.79,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 05, 00),
                            MeasurmentValue = 98.78,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },

        };

        public static readonly List<IValueMeasurment> SkipByGivenDate_TestData_Result = new()
                    {
                        new Measurment
                        {
                            MeasurmentTime = new DateTime(2017, 01, 03, 10, 05, 00),
                            MeasurmentValue = 98.78,
                            Type = Sampler.Enums.MeasurmentType.TEMP
                        },


        };


    }
}
