﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of TemperatureCoefficient.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class TemperatureCoefficientTestsBase
    {
        protected abstract double PercentageByKelvinsInOnePercentageByKelvin { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double PercentageByKelvinsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new TemperatureCoefficient((double)0.0, TemperatureCoefficientUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new TemperatureCoefficient();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(TemperatureCoefficientUnit.PercentageByKelvin, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new TemperatureCoefficient(double.PositiveInfinity, TemperatureCoefficientUnit.PercentageByKelvin));
            Assert.Throws<ArgumentException>(() => new TemperatureCoefficient(double.NegativeInfinity, TemperatureCoefficientUnit.PercentageByKelvin));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new TemperatureCoefficient(double.NaN, TemperatureCoefficientUnit.PercentageByKelvin));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new TemperatureCoefficient(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void TemperatureCoefficient_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new TemperatureCoefficient(1, TemperatureCoefficientUnit.PercentageByKelvin);

            QuantityInfo<TemperatureCoefficientUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(TemperatureCoefficient.Zero, quantityInfo.Zero);
            Assert.Equal("TemperatureCoefficient", quantityInfo.Name);
            Assert.Equal(QuantityType.TemperatureCoefficient, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<TemperatureCoefficientUnit>().Except(new[] {TemperatureCoefficientUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void PercentageByKelvinToTemperatureCoefficientUnits()
        {
            TemperatureCoefficient percentagebykelvin = TemperatureCoefficient.FromPercentageByKelvins(1);
            AssertEx.EqualTolerance(PercentageByKelvinsInOnePercentageByKelvin, percentagebykelvin.PercentageByKelvins, PercentageByKelvinsTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = TemperatureCoefficient.From(1, TemperatureCoefficientUnit.PercentageByKelvin);
            AssertEx.EqualTolerance(1, quantity00.PercentageByKelvins, PercentageByKelvinsTolerance);
            Assert.Equal(TemperatureCoefficientUnit.PercentageByKelvin, quantity00.Unit);

        }

        [Fact]
        public void FromPercentageByKelvins_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TemperatureCoefficient.FromPercentageByKelvins(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => TemperatureCoefficient.FromPercentageByKelvins(double.NegativeInfinity));
        }

        [Fact]
        public void FromPercentageByKelvins_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TemperatureCoefficient.FromPercentageByKelvins(double.NaN));
        }

        [Fact]
        public void As()
        {
            var percentagebykelvin = TemperatureCoefficient.FromPercentageByKelvins(1);
            AssertEx.EqualTolerance(PercentageByKelvinsInOnePercentageByKelvin, percentagebykelvin.As(TemperatureCoefficientUnit.PercentageByKelvin), PercentageByKelvinsTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var percentagebykelvin = TemperatureCoefficient.FromPercentageByKelvins(1);

            var percentagebykelvinQuantity = percentagebykelvin.ToUnit(TemperatureCoefficientUnit.PercentageByKelvin);
            AssertEx.EqualTolerance(PercentageByKelvinsInOnePercentageByKelvin, (double)percentagebykelvinQuantity.Value, PercentageByKelvinsTolerance);
            Assert.Equal(TemperatureCoefficientUnit.PercentageByKelvin, percentagebykelvinQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            TemperatureCoefficient percentagebykelvin = TemperatureCoefficient.FromPercentageByKelvins(1);
            AssertEx.EqualTolerance(1, TemperatureCoefficient.FromPercentageByKelvins(percentagebykelvin.PercentageByKelvins).PercentageByKelvins, PercentageByKelvinsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            TemperatureCoefficient v = TemperatureCoefficient.FromPercentageByKelvins(1);
            AssertEx.EqualTolerance(-1, -v.PercentageByKelvins, PercentageByKelvinsTolerance);
            AssertEx.EqualTolerance(2, (TemperatureCoefficient.FromPercentageByKelvins(3)-v).PercentageByKelvins, PercentageByKelvinsTolerance);
            AssertEx.EqualTolerance(2, (v + v).PercentageByKelvins, PercentageByKelvinsTolerance);
            AssertEx.EqualTolerance(10, (v*10).PercentageByKelvins, PercentageByKelvinsTolerance);
            AssertEx.EqualTolerance(10, (10*v).PercentageByKelvins, PercentageByKelvinsTolerance);
            AssertEx.EqualTolerance(2, (TemperatureCoefficient.FromPercentageByKelvins(10)/5).PercentageByKelvins, PercentageByKelvinsTolerance);
            AssertEx.EqualTolerance(2, TemperatureCoefficient.FromPercentageByKelvins(10)/TemperatureCoefficient.FromPercentageByKelvins(5), PercentageByKelvinsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            TemperatureCoefficient onePercentageByKelvin = TemperatureCoefficient.FromPercentageByKelvins(1);
            TemperatureCoefficient twoPercentageByKelvins = TemperatureCoefficient.FromPercentageByKelvins(2);

            Assert.True(onePercentageByKelvin < twoPercentageByKelvins);
            Assert.True(onePercentageByKelvin <= twoPercentageByKelvins);
            Assert.True(twoPercentageByKelvins > onePercentageByKelvin);
            Assert.True(twoPercentageByKelvins >= onePercentageByKelvin);

            Assert.False(onePercentageByKelvin > twoPercentageByKelvins);
            Assert.False(onePercentageByKelvin >= twoPercentageByKelvins);
            Assert.False(twoPercentageByKelvins < onePercentageByKelvin);
            Assert.False(twoPercentageByKelvins <= onePercentageByKelvin);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            TemperatureCoefficient percentagebykelvin = TemperatureCoefficient.FromPercentageByKelvins(1);
            Assert.Equal(0, percentagebykelvin.CompareTo(percentagebykelvin));
            Assert.True(percentagebykelvin.CompareTo(TemperatureCoefficient.Zero) > 0);
            Assert.True(TemperatureCoefficient.Zero.CompareTo(percentagebykelvin) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            TemperatureCoefficient percentagebykelvin = TemperatureCoefficient.FromPercentageByKelvins(1);
            Assert.Throws<ArgumentException>(() => percentagebykelvin.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            TemperatureCoefficient percentagebykelvin = TemperatureCoefficient.FromPercentageByKelvins(1);
            Assert.Throws<ArgumentNullException>(() => percentagebykelvin.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = TemperatureCoefficient.FromPercentageByKelvins(1);
            var b = TemperatureCoefficient.FromPercentageByKelvins(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void Equals_SameType_IsImplemented()
        {
            var a = TemperatureCoefficient.FromPercentageByKelvins(1);
            var b = TemperatureCoefficient.FromPercentageByKelvins(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = TemperatureCoefficient.FromPercentageByKelvins(1);
            object b = TemperatureCoefficient.FromPercentageByKelvins(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = TemperatureCoefficient.FromPercentageByKelvins(1);
            Assert.True(v.Equals(TemperatureCoefficient.FromPercentageByKelvins(1), PercentageByKelvinsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(TemperatureCoefficient.Zero, PercentageByKelvinsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = TemperatureCoefficient.FromPercentageByKelvins(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(TemperatureCoefficient.FromPercentageByKelvins(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            TemperatureCoefficient percentagebykelvin = TemperatureCoefficient.FromPercentageByKelvins(1);
            Assert.False(percentagebykelvin.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            TemperatureCoefficient percentagebykelvin = TemperatureCoefficient.FromPercentageByKelvins(1);
            Assert.False(percentagebykelvin.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(TemperatureCoefficientUnit.Undefined, TemperatureCoefficient.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(TemperatureCoefficientUnit)).Cast<TemperatureCoefficientUnit>();
            foreach(var unit in units)
            {
                if(unit == TemperatureCoefficientUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(TemperatureCoefficient.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 %/K", new TemperatureCoefficient(1, TemperatureCoefficientUnit.PercentageByKelvin).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 %/K", new TemperatureCoefficient(1, TemperatureCoefficientUnit.PercentageByKelvin).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 %/K", new TemperatureCoefficient(0.123456, TemperatureCoefficientUnit.PercentageByKelvin).ToString("s1"));
                Assert.Equal("0.12 %/K", new TemperatureCoefficient(0.123456, TemperatureCoefficientUnit.PercentageByKelvin).ToString("s2"));
                Assert.Equal("0.123 %/K", new TemperatureCoefficient(0.123456, TemperatureCoefficientUnit.PercentageByKelvin).ToString("s3"));
                Assert.Equal("0.1235 %/K", new TemperatureCoefficient(0.123456, TemperatureCoefficientUnit.PercentageByKelvin).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 %/K", new TemperatureCoefficient(0.123456, TemperatureCoefficientUnit.PercentageByKelvin).ToString("s1", culture));
            Assert.Equal("0.12 %/K", new TemperatureCoefficient(0.123456, TemperatureCoefficientUnit.PercentageByKelvin).ToString("s2", culture));
            Assert.Equal("0.123 %/K", new TemperatureCoefficient(0.123456, TemperatureCoefficientUnit.PercentageByKelvin).ToString("s3", culture));
            Assert.Equal("0.1235 %/K", new TemperatureCoefficient(0.123456, TemperatureCoefficientUnit.PercentageByKelvin).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(TemperatureCoefficient)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(TemperatureCoefficientUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Equal(QuantityType.TemperatureCoefficient, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Equal(TemperatureCoefficient.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(1.0);
            Assert.Equal(new {TemperatureCoefficient.QuantityType, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = TemperatureCoefficient.FromPercentageByKelvins(value);
            Assert.Equal(TemperatureCoefficient.FromPercentageByKelvins(-value), -quantity);
        }

    }
}
