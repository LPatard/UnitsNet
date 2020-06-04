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
    /// Test of CatalyticActivity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class CatalyticActivityTestsBase
    {
        protected abstract double KatalsInOneKatal { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KatalsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new CatalyticActivity((double)0.0, CatalyticActivityUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new CatalyticActivity();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(CatalyticActivityUnit.Katal, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new CatalyticActivity(double.PositiveInfinity, CatalyticActivityUnit.Katal));
            Assert.Throws<ArgumentException>(() => new CatalyticActivity(double.NegativeInfinity, CatalyticActivityUnit.Katal));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new CatalyticActivity(double.NaN, CatalyticActivityUnit.Katal));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new CatalyticActivity(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void CatalyticActivity_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new CatalyticActivity(1, CatalyticActivityUnit.Katal);

            QuantityInfo<CatalyticActivityUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(CatalyticActivity.Zero, quantityInfo.Zero);
            Assert.Equal("CatalyticActivity", quantityInfo.Name);
            Assert.Equal(QuantityType.CatalyticActivity, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<CatalyticActivityUnit>().Except(new[] {CatalyticActivityUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void KatalToCatalyticActivityUnits()
        {
            CatalyticActivity katal = CatalyticActivity.FromKatals(1);
            AssertEx.EqualTolerance(KatalsInOneKatal, katal.Katals, KatalsTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = CatalyticActivity.From(1, CatalyticActivityUnit.Katal);
            AssertEx.EqualTolerance(1, quantity00.Katals, KatalsTolerance);
            Assert.Equal(CatalyticActivityUnit.Katal, quantity00.Unit);

        }

        [Fact]
        public void FromKatals_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => CatalyticActivity.FromKatals(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => CatalyticActivity.FromKatals(double.NegativeInfinity));
        }

        [Fact]
        public void FromKatals_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => CatalyticActivity.FromKatals(double.NaN));
        }

        [Fact]
        public void As()
        {
            var katal = CatalyticActivity.FromKatals(1);
            AssertEx.EqualTolerance(KatalsInOneKatal, katal.As(CatalyticActivityUnit.Katal), KatalsTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var katal = CatalyticActivity.FromKatals(1);

            var katalQuantity = katal.ToUnit(CatalyticActivityUnit.Katal);
            AssertEx.EqualTolerance(KatalsInOneKatal, (double)katalQuantity.Value, KatalsTolerance);
            Assert.Equal(CatalyticActivityUnit.Katal, katalQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            CatalyticActivity katal = CatalyticActivity.FromKatals(1);
            AssertEx.EqualTolerance(1, CatalyticActivity.FromKatals(katal.Katals).Katals, KatalsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            CatalyticActivity v = CatalyticActivity.FromKatals(1);
            AssertEx.EqualTolerance(-1, -v.Katals, KatalsTolerance);
            AssertEx.EqualTolerance(2, (CatalyticActivity.FromKatals(3)-v).Katals, KatalsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Katals, KatalsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Katals, KatalsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Katals, KatalsTolerance);
            AssertEx.EqualTolerance(2, (CatalyticActivity.FromKatals(10)/5).Katals, KatalsTolerance);
            AssertEx.EqualTolerance(2, CatalyticActivity.FromKatals(10)/CatalyticActivity.FromKatals(5), KatalsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            CatalyticActivity oneKatal = CatalyticActivity.FromKatals(1);
            CatalyticActivity twoKatals = CatalyticActivity.FromKatals(2);

            Assert.True(oneKatal < twoKatals);
            Assert.True(oneKatal <= twoKatals);
            Assert.True(twoKatals > oneKatal);
            Assert.True(twoKatals >= oneKatal);

            Assert.False(oneKatal > twoKatals);
            Assert.False(oneKatal >= twoKatals);
            Assert.False(twoKatals < oneKatal);
            Assert.False(twoKatals <= oneKatal);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            CatalyticActivity katal = CatalyticActivity.FromKatals(1);
            Assert.Equal(0, katal.CompareTo(katal));
            Assert.True(katal.CompareTo(CatalyticActivity.Zero) > 0);
            Assert.True(CatalyticActivity.Zero.CompareTo(katal) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            CatalyticActivity katal = CatalyticActivity.FromKatals(1);
            Assert.Throws<ArgumentException>(() => katal.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            CatalyticActivity katal = CatalyticActivity.FromKatals(1);
            Assert.Throws<ArgumentNullException>(() => katal.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = CatalyticActivity.FromKatals(1);
            var b = CatalyticActivity.FromKatals(2);

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
            var a = CatalyticActivity.FromKatals(1);
            var b = CatalyticActivity.FromKatals(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = CatalyticActivity.FromKatals(1);
            object b = CatalyticActivity.FromKatals(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = CatalyticActivity.FromKatals(1);
            Assert.True(v.Equals(CatalyticActivity.FromKatals(1), KatalsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(CatalyticActivity.Zero, KatalsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = CatalyticActivity.FromKatals(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(CatalyticActivity.FromKatals(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            CatalyticActivity katal = CatalyticActivity.FromKatals(1);
            Assert.False(katal.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            CatalyticActivity katal = CatalyticActivity.FromKatals(1);
            Assert.False(katal.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(CatalyticActivityUnit.Undefined, CatalyticActivity.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(CatalyticActivityUnit)).Cast<CatalyticActivityUnit>();
            foreach(var unit in units)
            {
                if(unit == CatalyticActivityUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(CatalyticActivity.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 Kat", new CatalyticActivity(1, CatalyticActivityUnit.Katal).ToString());
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

            Assert.Equal("1 Kat", new CatalyticActivity(1, CatalyticActivityUnit.Katal).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 Kat", new CatalyticActivity(0.123456, CatalyticActivityUnit.Katal).ToString("s1"));
                Assert.Equal("0.12 Kat", new CatalyticActivity(0.123456, CatalyticActivityUnit.Katal).ToString("s2"));
                Assert.Equal("0.123 Kat", new CatalyticActivity(0.123456, CatalyticActivityUnit.Katal).ToString("s3"));
                Assert.Equal("0.1235 Kat", new CatalyticActivity(0.123456, CatalyticActivityUnit.Katal).ToString("s4"));
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
            Assert.Equal("0.1 Kat", new CatalyticActivity(0.123456, CatalyticActivityUnit.Katal).ToString("s1", culture));
            Assert.Equal("0.12 Kat", new CatalyticActivity(0.123456, CatalyticActivityUnit.Katal).ToString("s2", culture));
            Assert.Equal("0.123 Kat", new CatalyticActivity(0.123456, CatalyticActivityUnit.Katal).ToString("s3", culture));
            Assert.Equal("0.1235 Kat", new CatalyticActivity(0.123456, CatalyticActivityUnit.Katal).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(CatalyticActivity)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(CatalyticActivityUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Equal(QuantityType.CatalyticActivity, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Equal(CatalyticActivity.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = CatalyticActivity.FromKatals(1.0);
            Assert.Equal(new {CatalyticActivity.QuantityType, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = CatalyticActivity.FromKatals(value);
            Assert.Equal(CatalyticActivity.FromKatals(-value), -quantity);
        }

    }
}