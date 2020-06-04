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
    /// Test of SpecificDischarge.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class SpecificDischargeTestsBase
    {
        protected abstract double CubicFootMinutePerSquareFootsInOneLiterSecondPerSquareMeter { get; }
        protected abstract double CubicMeterPerHourSquareMetersInOneLiterSecondPerSquareMeter { get; }
        protected abstract double LiterSecondPerSquareMetersInOneLiterSecondPerSquareMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CubicFootMinutePerSquareFootsTolerance { get { return 1e-5; } }
        protected virtual double CubicMeterPerHourSquareMetersTolerance { get { return 1e-5; } }
        protected virtual double LiterSecondPerSquareMetersTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificDischarge((double)0.0, SpecificDischargeUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new SpecificDischarge();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(SpecificDischargeUnit.LiterSecondPerSquareMeter, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificDischarge(double.PositiveInfinity, SpecificDischargeUnit.LiterSecondPerSquareMeter));
            Assert.Throws<ArgumentException>(() => new SpecificDischarge(double.NegativeInfinity, SpecificDischargeUnit.LiterSecondPerSquareMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificDischarge(double.NaN, SpecificDischargeUnit.LiterSecondPerSquareMeter));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new SpecificDischarge(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void SpecificDischarge_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new SpecificDischarge(1, SpecificDischargeUnit.LiterSecondPerSquareMeter);

            QuantityInfo<SpecificDischargeUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(SpecificDischarge.Zero, quantityInfo.Zero);
            Assert.Equal("SpecificDischarge", quantityInfo.Name);
            Assert.Equal(QuantityType.SpecificDischarge, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<SpecificDischargeUnit>().Except(new[] {SpecificDischargeUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void LiterSecondPerSquareMeterToSpecificDischargeUnits()
        {
            SpecificDischarge litersecondpersquaremeter = SpecificDischarge.FromLiterSecondPerSquareMeters(1);
            AssertEx.EqualTolerance(CubicFootMinutePerSquareFootsInOneLiterSecondPerSquareMeter, litersecondpersquaremeter.CubicFootMinutePerSquareFoots, CubicFootMinutePerSquareFootsTolerance);
            AssertEx.EqualTolerance(CubicMeterPerHourSquareMetersInOneLiterSecondPerSquareMeter, litersecondpersquaremeter.CubicMeterPerHourSquareMeters, CubicMeterPerHourSquareMetersTolerance);
            AssertEx.EqualTolerance(LiterSecondPerSquareMetersInOneLiterSecondPerSquareMeter, litersecondpersquaremeter.LiterSecondPerSquareMeters, LiterSecondPerSquareMetersTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = SpecificDischarge.From(1, SpecificDischargeUnit.CubicFootMinutePerSquareFoot);
            AssertEx.EqualTolerance(1, quantity00.CubicFootMinutePerSquareFoots, CubicFootMinutePerSquareFootsTolerance);
            Assert.Equal(SpecificDischargeUnit.CubicFootMinutePerSquareFoot, quantity00.Unit);

            var quantity01 = SpecificDischarge.From(1, SpecificDischargeUnit.CubicMeterPerHourSquareMeter);
            AssertEx.EqualTolerance(1, quantity01.CubicMeterPerHourSquareMeters, CubicMeterPerHourSquareMetersTolerance);
            Assert.Equal(SpecificDischargeUnit.CubicMeterPerHourSquareMeter, quantity01.Unit);

            var quantity02 = SpecificDischarge.From(1, SpecificDischargeUnit.LiterSecondPerSquareMeter);
            AssertEx.EqualTolerance(1, quantity02.LiterSecondPerSquareMeters, LiterSecondPerSquareMetersTolerance);
            Assert.Equal(SpecificDischargeUnit.LiterSecondPerSquareMeter, quantity02.Unit);

        }

        [Fact]
        public void FromLiterSecondPerSquareMeters_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SpecificDischarge.FromLiterSecondPerSquareMeters(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => SpecificDischarge.FromLiterSecondPerSquareMeters(double.NegativeInfinity));
        }

        [Fact]
        public void FromLiterSecondPerSquareMeters_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SpecificDischarge.FromLiterSecondPerSquareMeters(double.NaN));
        }

        [Fact]
        public void As()
        {
            var litersecondpersquaremeter = SpecificDischarge.FromLiterSecondPerSquareMeters(1);
            AssertEx.EqualTolerance(CubicFootMinutePerSquareFootsInOneLiterSecondPerSquareMeter, litersecondpersquaremeter.As(SpecificDischargeUnit.CubicFootMinutePerSquareFoot), CubicFootMinutePerSquareFootsTolerance);
            AssertEx.EqualTolerance(CubicMeterPerHourSquareMetersInOneLiterSecondPerSquareMeter, litersecondpersquaremeter.As(SpecificDischargeUnit.CubicMeterPerHourSquareMeter), CubicMeterPerHourSquareMetersTolerance);
            AssertEx.EqualTolerance(LiterSecondPerSquareMetersInOneLiterSecondPerSquareMeter, litersecondpersquaremeter.As(SpecificDischargeUnit.LiterSecondPerSquareMeter), LiterSecondPerSquareMetersTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var litersecondpersquaremeter = SpecificDischarge.FromLiterSecondPerSquareMeters(1);

            var cubicfootminutepersquarefootQuantity = litersecondpersquaremeter.ToUnit(SpecificDischargeUnit.CubicFootMinutePerSquareFoot);
            AssertEx.EqualTolerance(CubicFootMinutePerSquareFootsInOneLiterSecondPerSquareMeter, (double)cubicfootminutepersquarefootQuantity.Value, CubicFootMinutePerSquareFootsTolerance);
            Assert.Equal(SpecificDischargeUnit.CubicFootMinutePerSquareFoot, cubicfootminutepersquarefootQuantity.Unit);

            var cubicmeterperhoursquaremeterQuantity = litersecondpersquaremeter.ToUnit(SpecificDischargeUnit.CubicMeterPerHourSquareMeter);
            AssertEx.EqualTolerance(CubicMeterPerHourSquareMetersInOneLiterSecondPerSquareMeter, (double)cubicmeterperhoursquaremeterQuantity.Value, CubicMeterPerHourSquareMetersTolerance);
            Assert.Equal(SpecificDischargeUnit.CubicMeterPerHourSquareMeter, cubicmeterperhoursquaremeterQuantity.Unit);

            var litersecondpersquaremeterQuantity = litersecondpersquaremeter.ToUnit(SpecificDischargeUnit.LiterSecondPerSquareMeter);
            AssertEx.EqualTolerance(LiterSecondPerSquareMetersInOneLiterSecondPerSquareMeter, (double)litersecondpersquaremeterQuantity.Value, LiterSecondPerSquareMetersTolerance);
            Assert.Equal(SpecificDischargeUnit.LiterSecondPerSquareMeter, litersecondpersquaremeterQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            SpecificDischarge litersecondpersquaremeter = SpecificDischarge.FromLiterSecondPerSquareMeters(1);
            AssertEx.EqualTolerance(1, SpecificDischarge.FromCubicFootMinutePerSquareFoots(litersecondpersquaremeter.CubicFootMinutePerSquareFoots).LiterSecondPerSquareMeters, CubicFootMinutePerSquareFootsTolerance);
            AssertEx.EqualTolerance(1, SpecificDischarge.FromCubicMeterPerHourSquareMeters(litersecondpersquaremeter.CubicMeterPerHourSquareMeters).LiterSecondPerSquareMeters, CubicMeterPerHourSquareMetersTolerance);
            AssertEx.EqualTolerance(1, SpecificDischarge.FromLiterSecondPerSquareMeters(litersecondpersquaremeter.LiterSecondPerSquareMeters).LiterSecondPerSquareMeters, LiterSecondPerSquareMetersTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            SpecificDischarge v = SpecificDischarge.FromLiterSecondPerSquareMeters(1);
            AssertEx.EqualTolerance(-1, -v.LiterSecondPerSquareMeters, LiterSecondPerSquareMetersTolerance);
            AssertEx.EqualTolerance(2, (SpecificDischarge.FromLiterSecondPerSquareMeters(3)-v).LiterSecondPerSquareMeters, LiterSecondPerSquareMetersTolerance);
            AssertEx.EqualTolerance(2, (v + v).LiterSecondPerSquareMeters, LiterSecondPerSquareMetersTolerance);
            AssertEx.EqualTolerance(10, (v*10).LiterSecondPerSquareMeters, LiterSecondPerSquareMetersTolerance);
            AssertEx.EqualTolerance(10, (10*v).LiterSecondPerSquareMeters, LiterSecondPerSquareMetersTolerance);
            AssertEx.EqualTolerance(2, (SpecificDischarge.FromLiterSecondPerSquareMeters(10)/5).LiterSecondPerSquareMeters, LiterSecondPerSquareMetersTolerance);
            AssertEx.EqualTolerance(2, SpecificDischarge.FromLiterSecondPerSquareMeters(10)/SpecificDischarge.FromLiterSecondPerSquareMeters(5), LiterSecondPerSquareMetersTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            SpecificDischarge oneLiterSecondPerSquareMeter = SpecificDischarge.FromLiterSecondPerSquareMeters(1);
            SpecificDischarge twoLiterSecondPerSquareMeters = SpecificDischarge.FromLiterSecondPerSquareMeters(2);

            Assert.True(oneLiterSecondPerSquareMeter < twoLiterSecondPerSquareMeters);
            Assert.True(oneLiterSecondPerSquareMeter <= twoLiterSecondPerSquareMeters);
            Assert.True(twoLiterSecondPerSquareMeters > oneLiterSecondPerSquareMeter);
            Assert.True(twoLiterSecondPerSquareMeters >= oneLiterSecondPerSquareMeter);

            Assert.False(oneLiterSecondPerSquareMeter > twoLiterSecondPerSquareMeters);
            Assert.False(oneLiterSecondPerSquareMeter >= twoLiterSecondPerSquareMeters);
            Assert.False(twoLiterSecondPerSquareMeters < oneLiterSecondPerSquareMeter);
            Assert.False(twoLiterSecondPerSquareMeters <= oneLiterSecondPerSquareMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            SpecificDischarge litersecondpersquaremeter = SpecificDischarge.FromLiterSecondPerSquareMeters(1);
            Assert.Equal(0, litersecondpersquaremeter.CompareTo(litersecondpersquaremeter));
            Assert.True(litersecondpersquaremeter.CompareTo(SpecificDischarge.Zero) > 0);
            Assert.True(SpecificDischarge.Zero.CompareTo(litersecondpersquaremeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            SpecificDischarge litersecondpersquaremeter = SpecificDischarge.FromLiterSecondPerSquareMeters(1);
            Assert.Throws<ArgumentException>(() => litersecondpersquaremeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            SpecificDischarge litersecondpersquaremeter = SpecificDischarge.FromLiterSecondPerSquareMeters(1);
            Assert.Throws<ArgumentNullException>(() => litersecondpersquaremeter.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = SpecificDischarge.FromLiterSecondPerSquareMeters(1);
            var b = SpecificDischarge.FromLiterSecondPerSquareMeters(2);

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
            var a = SpecificDischarge.FromLiterSecondPerSquareMeters(1);
            var b = SpecificDischarge.FromLiterSecondPerSquareMeters(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = SpecificDischarge.FromLiterSecondPerSquareMeters(1);
            object b = SpecificDischarge.FromLiterSecondPerSquareMeters(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = SpecificDischarge.FromLiterSecondPerSquareMeters(1);
            Assert.True(v.Equals(SpecificDischarge.FromLiterSecondPerSquareMeters(1), LiterSecondPerSquareMetersTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(SpecificDischarge.Zero, LiterSecondPerSquareMetersTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = SpecificDischarge.FromLiterSecondPerSquareMeters(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(SpecificDischarge.FromLiterSecondPerSquareMeters(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            SpecificDischarge litersecondpersquaremeter = SpecificDischarge.FromLiterSecondPerSquareMeters(1);
            Assert.False(litersecondpersquaremeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            SpecificDischarge litersecondpersquaremeter = SpecificDischarge.FromLiterSecondPerSquareMeters(1);
            Assert.False(litersecondpersquaremeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(SpecificDischargeUnit.Undefined, SpecificDischarge.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(SpecificDischargeUnit)).Cast<SpecificDischargeUnit>();
            foreach(var unit in units)
            {
                if(unit == SpecificDischargeUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(SpecificDischarge.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 ft³/(min.ft²)", new SpecificDischarge(1, SpecificDischargeUnit.CubicFootMinutePerSquareFoot).ToString());
                Assert.Equal("1 m3/(h.m2)", new SpecificDischarge(1, SpecificDischargeUnit.CubicMeterPerHourSquareMeter).ToString());
                Assert.Equal("1 L/(s.m²)", new SpecificDischarge(1, SpecificDischargeUnit.LiterSecondPerSquareMeter).ToString());
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

            Assert.Equal("1 ft³/(min.ft²)", new SpecificDischarge(1, SpecificDischargeUnit.CubicFootMinutePerSquareFoot).ToString(swedishCulture));
            Assert.Equal("1 m3/(h.m2)", new SpecificDischarge(1, SpecificDischargeUnit.CubicMeterPerHourSquareMeter).ToString(swedishCulture));
            Assert.Equal("1 L/(s.m²)", new SpecificDischarge(1, SpecificDischargeUnit.LiterSecondPerSquareMeter).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 L/(s.m²)", new SpecificDischarge(0.123456, SpecificDischargeUnit.LiterSecondPerSquareMeter).ToString("s1"));
                Assert.Equal("0.12 L/(s.m²)", new SpecificDischarge(0.123456, SpecificDischargeUnit.LiterSecondPerSquareMeter).ToString("s2"));
                Assert.Equal("0.123 L/(s.m²)", new SpecificDischarge(0.123456, SpecificDischargeUnit.LiterSecondPerSquareMeter).ToString("s3"));
                Assert.Equal("0.1235 L/(s.m²)", new SpecificDischarge(0.123456, SpecificDischargeUnit.LiterSecondPerSquareMeter).ToString("s4"));
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
            Assert.Equal("0.1 L/(s.m²)", new SpecificDischarge(0.123456, SpecificDischargeUnit.LiterSecondPerSquareMeter).ToString("s1", culture));
            Assert.Equal("0.12 L/(s.m²)", new SpecificDischarge(0.123456, SpecificDischargeUnit.LiterSecondPerSquareMeter).ToString("s2", culture));
            Assert.Equal("0.123 L/(s.m²)", new SpecificDischarge(0.123456, SpecificDischargeUnit.LiterSecondPerSquareMeter).ToString("s3", culture));
            Assert.Equal("0.1235 L/(s.m²)", new SpecificDischarge(0.123456, SpecificDischargeUnit.LiterSecondPerSquareMeter).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(SpecificDischarge)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(SpecificDischargeUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Equal(QuantityType.SpecificDischarge, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Equal(SpecificDischarge.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(1.0);
            Assert.Equal(new {SpecificDischarge.QuantityType, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = SpecificDischarge.FromLiterSecondPerSquareMeters(value);
            Assert.Equal(SpecificDischarge.FromLiterSecondPerSquareMeters(-value), -quantity);
        }

    }
}
