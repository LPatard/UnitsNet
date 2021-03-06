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
    /// Test of EnergyDensity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class EnergyDensityTestsBase
    {
        protected abstract double JoulePerCubicMetersInOneJoulePerCubicMeter { get; }
        protected abstract double WattSecondCubicMetersInOneJoulePerCubicMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double JoulePerCubicMetersTolerance { get { return 1e-5; } }
        protected virtual double WattSecondCubicMetersTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new EnergyDensity((double)0.0, EnergyDensityUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new EnergyDensity();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(EnergyDensityUnit.JoulePerCubicMeter, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new EnergyDensity(double.PositiveInfinity, EnergyDensityUnit.JoulePerCubicMeter));
            Assert.Throws<ArgumentException>(() => new EnergyDensity(double.NegativeInfinity, EnergyDensityUnit.JoulePerCubicMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new EnergyDensity(double.NaN, EnergyDensityUnit.JoulePerCubicMeter));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new EnergyDensity(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void EnergyDensity_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new EnergyDensity(1, EnergyDensityUnit.JoulePerCubicMeter);

            QuantityInfo<EnergyDensityUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(EnergyDensity.Zero, quantityInfo.Zero);
            Assert.Equal("EnergyDensity", quantityInfo.Name);
            Assert.Equal(QuantityType.EnergyDensity, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<EnergyDensityUnit>().Except(new[] {EnergyDensityUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void JoulePerCubicMeterToEnergyDensityUnits()
        {
            EnergyDensity joulepercubicmeter = EnergyDensity.FromJoulePerCubicMeters(1);
            AssertEx.EqualTolerance(JoulePerCubicMetersInOneJoulePerCubicMeter, joulepercubicmeter.JoulePerCubicMeters, JoulePerCubicMetersTolerance);
            AssertEx.EqualTolerance(WattSecondCubicMetersInOneJoulePerCubicMeter, joulepercubicmeter.WattSecondCubicMeters, WattSecondCubicMetersTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = EnergyDensity.From(1, EnergyDensityUnit.JoulePerCubicMeter);
            AssertEx.EqualTolerance(1, quantity00.JoulePerCubicMeters, JoulePerCubicMetersTolerance);
            Assert.Equal(EnergyDensityUnit.JoulePerCubicMeter, quantity00.Unit);

            var quantity01 = EnergyDensity.From(1, EnergyDensityUnit.WattSecondCubicMeter);
            AssertEx.EqualTolerance(1, quantity01.WattSecondCubicMeters, WattSecondCubicMetersTolerance);
            Assert.Equal(EnergyDensityUnit.WattSecondCubicMeter, quantity01.Unit);

        }

        [Fact]
        public void FromJoulePerCubicMeters_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => EnergyDensity.FromJoulePerCubicMeters(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => EnergyDensity.FromJoulePerCubicMeters(double.NegativeInfinity));
        }

        [Fact]
        public void FromJoulePerCubicMeters_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => EnergyDensity.FromJoulePerCubicMeters(double.NaN));
        }

        [Fact]
        public void As()
        {
            var joulepercubicmeter = EnergyDensity.FromJoulePerCubicMeters(1);
            AssertEx.EqualTolerance(JoulePerCubicMetersInOneJoulePerCubicMeter, joulepercubicmeter.As(EnergyDensityUnit.JoulePerCubicMeter), JoulePerCubicMetersTolerance);
            AssertEx.EqualTolerance(WattSecondCubicMetersInOneJoulePerCubicMeter, joulepercubicmeter.As(EnergyDensityUnit.WattSecondCubicMeter), WattSecondCubicMetersTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var joulepercubicmeter = EnergyDensity.FromJoulePerCubicMeters(1);

            var joulepercubicmeterQuantity = joulepercubicmeter.ToUnit(EnergyDensityUnit.JoulePerCubicMeter);
            AssertEx.EqualTolerance(JoulePerCubicMetersInOneJoulePerCubicMeter, (double)joulepercubicmeterQuantity.Value, JoulePerCubicMetersTolerance);
            Assert.Equal(EnergyDensityUnit.JoulePerCubicMeter, joulepercubicmeterQuantity.Unit);

            var wattsecondcubicmeterQuantity = joulepercubicmeter.ToUnit(EnergyDensityUnit.WattSecondCubicMeter);
            AssertEx.EqualTolerance(WattSecondCubicMetersInOneJoulePerCubicMeter, (double)wattsecondcubicmeterQuantity.Value, WattSecondCubicMetersTolerance);
            Assert.Equal(EnergyDensityUnit.WattSecondCubicMeter, wattsecondcubicmeterQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            EnergyDensity joulepercubicmeter = EnergyDensity.FromJoulePerCubicMeters(1);
            AssertEx.EqualTolerance(1, EnergyDensity.FromJoulePerCubicMeters(joulepercubicmeter.JoulePerCubicMeters).JoulePerCubicMeters, JoulePerCubicMetersTolerance);
            AssertEx.EqualTolerance(1, EnergyDensity.FromWattSecondCubicMeters(joulepercubicmeter.WattSecondCubicMeters).JoulePerCubicMeters, WattSecondCubicMetersTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            EnergyDensity v = EnergyDensity.FromJoulePerCubicMeters(1);
            AssertEx.EqualTolerance(-1, -v.JoulePerCubicMeters, JoulePerCubicMetersTolerance);
            AssertEx.EqualTolerance(2, (EnergyDensity.FromJoulePerCubicMeters(3)-v).JoulePerCubicMeters, JoulePerCubicMetersTolerance);
            AssertEx.EqualTolerance(2, (v + v).JoulePerCubicMeters, JoulePerCubicMetersTolerance);
            AssertEx.EqualTolerance(10, (v*10).JoulePerCubicMeters, JoulePerCubicMetersTolerance);
            AssertEx.EqualTolerance(10, (10*v).JoulePerCubicMeters, JoulePerCubicMetersTolerance);
            AssertEx.EqualTolerance(2, (EnergyDensity.FromJoulePerCubicMeters(10)/5).JoulePerCubicMeters, JoulePerCubicMetersTolerance);
            AssertEx.EqualTolerance(2, EnergyDensity.FromJoulePerCubicMeters(10)/EnergyDensity.FromJoulePerCubicMeters(5), JoulePerCubicMetersTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            EnergyDensity oneJoulePerCubicMeter = EnergyDensity.FromJoulePerCubicMeters(1);
            EnergyDensity twoJoulePerCubicMeters = EnergyDensity.FromJoulePerCubicMeters(2);

            Assert.True(oneJoulePerCubicMeter < twoJoulePerCubicMeters);
            Assert.True(oneJoulePerCubicMeter <= twoJoulePerCubicMeters);
            Assert.True(twoJoulePerCubicMeters > oneJoulePerCubicMeter);
            Assert.True(twoJoulePerCubicMeters >= oneJoulePerCubicMeter);

            Assert.False(oneJoulePerCubicMeter > twoJoulePerCubicMeters);
            Assert.False(oneJoulePerCubicMeter >= twoJoulePerCubicMeters);
            Assert.False(twoJoulePerCubicMeters < oneJoulePerCubicMeter);
            Assert.False(twoJoulePerCubicMeters <= oneJoulePerCubicMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            EnergyDensity joulepercubicmeter = EnergyDensity.FromJoulePerCubicMeters(1);
            Assert.Equal(0, joulepercubicmeter.CompareTo(joulepercubicmeter));
            Assert.True(joulepercubicmeter.CompareTo(EnergyDensity.Zero) > 0);
            Assert.True(EnergyDensity.Zero.CompareTo(joulepercubicmeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            EnergyDensity joulepercubicmeter = EnergyDensity.FromJoulePerCubicMeters(1);
            Assert.Throws<ArgumentException>(() => joulepercubicmeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            EnergyDensity joulepercubicmeter = EnergyDensity.FromJoulePerCubicMeters(1);
            Assert.Throws<ArgumentNullException>(() => joulepercubicmeter.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = EnergyDensity.FromJoulePerCubicMeters(1);
            var b = EnergyDensity.FromJoulePerCubicMeters(2);

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
            var a = EnergyDensity.FromJoulePerCubicMeters(1);
            var b = EnergyDensity.FromJoulePerCubicMeters(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = EnergyDensity.FromJoulePerCubicMeters(1);
            object b = EnergyDensity.FromJoulePerCubicMeters(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = EnergyDensity.FromJoulePerCubicMeters(1);
            Assert.True(v.Equals(EnergyDensity.FromJoulePerCubicMeters(1), JoulePerCubicMetersTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(EnergyDensity.Zero, JoulePerCubicMetersTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = EnergyDensity.FromJoulePerCubicMeters(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(EnergyDensity.FromJoulePerCubicMeters(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            EnergyDensity joulepercubicmeter = EnergyDensity.FromJoulePerCubicMeters(1);
            Assert.False(joulepercubicmeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            EnergyDensity joulepercubicmeter = EnergyDensity.FromJoulePerCubicMeters(1);
            Assert.False(joulepercubicmeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(EnergyDensityUnit.Undefined, EnergyDensity.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(EnergyDensityUnit)).Cast<EnergyDensityUnit>();
            foreach(var unit in units)
            {
                if(unit == EnergyDensityUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(EnergyDensity.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 J/m³", new EnergyDensity(1, EnergyDensityUnit.JoulePerCubicMeter).ToString());
                Assert.Equal("1 Ws/m³", new EnergyDensity(1, EnergyDensityUnit.WattSecondCubicMeter).ToString());
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

            Assert.Equal("1 J/m³", new EnergyDensity(1, EnergyDensityUnit.JoulePerCubicMeter).ToString(swedishCulture));
            Assert.Equal("1 Ws/m³", new EnergyDensity(1, EnergyDensityUnit.WattSecondCubicMeter).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 J/m³", new EnergyDensity(0.123456, EnergyDensityUnit.JoulePerCubicMeter).ToString("s1"));
                Assert.Equal("0.12 J/m³", new EnergyDensity(0.123456, EnergyDensityUnit.JoulePerCubicMeter).ToString("s2"));
                Assert.Equal("0.123 J/m³", new EnergyDensity(0.123456, EnergyDensityUnit.JoulePerCubicMeter).ToString("s3"));
                Assert.Equal("0.1235 J/m³", new EnergyDensity(0.123456, EnergyDensityUnit.JoulePerCubicMeter).ToString("s4"));
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
            Assert.Equal("0.1 J/m³", new EnergyDensity(0.123456, EnergyDensityUnit.JoulePerCubicMeter).ToString("s1", culture));
            Assert.Equal("0.12 J/m³", new EnergyDensity(0.123456, EnergyDensityUnit.JoulePerCubicMeter).ToString("s2", culture));
            Assert.Equal("0.123 J/m³", new EnergyDensity(0.123456, EnergyDensityUnit.JoulePerCubicMeter).ToString("s3", culture));
            Assert.Equal("0.1235 J/m³", new EnergyDensity(0.123456, EnergyDensityUnit.JoulePerCubicMeter).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(EnergyDensity)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(EnergyDensityUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Equal(QuantityType.EnergyDensity, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Equal(EnergyDensity.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(1.0);
            Assert.Equal(new {EnergyDensity.QuantityType, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = EnergyDensity.FromJoulePerCubicMeters(value);
            Assert.Equal(EnergyDensity.FromJoulePerCubicMeters(-value), -quantity);
        }

    }
}
