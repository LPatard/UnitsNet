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
    /// Test of Permeance.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class PermeanceTestsBase
    {
        protected abstract double GrainsPerHourSquareFootInchOfMercurysInOnePerm { get; }
        protected abstract double PermsInOnePerm { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double GrainsPerHourSquareFootInchOfMercurysTolerance { get { return 1e-5; } }
        protected virtual double PermsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Permeance((double)0.0, PermeanceUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Permeance();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(PermeanceUnit.Perm, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Permeance(double.PositiveInfinity, PermeanceUnit.Perm));
            Assert.Throws<ArgumentException>(() => new Permeance(double.NegativeInfinity, PermeanceUnit.Perm));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Permeance(double.NaN, PermeanceUnit.Perm));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Permeance(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void Permeance_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Permeance(1, PermeanceUnit.Perm);

            QuantityInfo<PermeanceUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Permeance.Zero, quantityInfo.Zero);
            Assert.Equal("Permeance", quantityInfo.Name);
            Assert.Equal(QuantityType.Permeance, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<PermeanceUnit>().Except(new[] {PermeanceUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void PermToPermeanceUnits()
        {
            Permeance perm = Permeance.FromPerms(1);
            AssertEx.EqualTolerance(GrainsPerHourSquareFootInchOfMercurysInOnePerm, perm.GrainsPerHourSquareFootInchOfMercurys, GrainsPerHourSquareFootInchOfMercurysTolerance);
            AssertEx.EqualTolerance(PermsInOnePerm, perm.Perms, PermsTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Permeance.From(1, PermeanceUnit.GrainsPerHourSquareFootInchOfMercury);
            AssertEx.EqualTolerance(1, quantity00.GrainsPerHourSquareFootInchOfMercurys, GrainsPerHourSquareFootInchOfMercurysTolerance);
            Assert.Equal(PermeanceUnit.GrainsPerHourSquareFootInchOfMercury, quantity00.Unit);

            var quantity01 = Permeance.From(1, PermeanceUnit.Perm);
            AssertEx.EqualTolerance(1, quantity01.Perms, PermsTolerance);
            Assert.Equal(PermeanceUnit.Perm, quantity01.Unit);

        }

        [Fact]
        public void FromPerms_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Permeance.FromPerms(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Permeance.FromPerms(double.NegativeInfinity));
        }

        [Fact]
        public void FromPerms_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Permeance.FromPerms(double.NaN));
        }

        [Fact]
        public void As()
        {
            var perm = Permeance.FromPerms(1);
            AssertEx.EqualTolerance(GrainsPerHourSquareFootInchOfMercurysInOnePerm, perm.As(PermeanceUnit.GrainsPerHourSquareFootInchOfMercury), GrainsPerHourSquareFootInchOfMercurysTolerance);
            AssertEx.EqualTolerance(PermsInOnePerm, perm.As(PermeanceUnit.Perm), PermsTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var perm = Permeance.FromPerms(1);

            var grainsperhoursquarefootinchofmercuryQuantity = perm.ToUnit(PermeanceUnit.GrainsPerHourSquareFootInchOfMercury);
            AssertEx.EqualTolerance(GrainsPerHourSquareFootInchOfMercurysInOnePerm, (double)grainsperhoursquarefootinchofmercuryQuantity.Value, GrainsPerHourSquareFootInchOfMercurysTolerance);
            Assert.Equal(PermeanceUnit.GrainsPerHourSquareFootInchOfMercury, grainsperhoursquarefootinchofmercuryQuantity.Unit);

            var permQuantity = perm.ToUnit(PermeanceUnit.Perm);
            AssertEx.EqualTolerance(PermsInOnePerm, (double)permQuantity.Value, PermsTolerance);
            Assert.Equal(PermeanceUnit.Perm, permQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Permeance perm = Permeance.FromPerms(1);
            AssertEx.EqualTolerance(1, Permeance.FromGrainsPerHourSquareFootInchOfMercurys(perm.GrainsPerHourSquareFootInchOfMercurys).Perms, GrainsPerHourSquareFootInchOfMercurysTolerance);
            AssertEx.EqualTolerance(1, Permeance.FromPerms(perm.Perms).Perms, PermsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Permeance v = Permeance.FromPerms(1);
            AssertEx.EqualTolerance(-1, -v.Perms, PermsTolerance);
            AssertEx.EqualTolerance(2, (Permeance.FromPerms(3)-v).Perms, PermsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Perms, PermsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Perms, PermsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Perms, PermsTolerance);
            AssertEx.EqualTolerance(2, (Permeance.FromPerms(10)/5).Perms, PermsTolerance);
            AssertEx.EqualTolerance(2, Permeance.FromPerms(10)/Permeance.FromPerms(5), PermsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Permeance onePerm = Permeance.FromPerms(1);
            Permeance twoPerms = Permeance.FromPerms(2);

            Assert.True(onePerm < twoPerms);
            Assert.True(onePerm <= twoPerms);
            Assert.True(twoPerms > onePerm);
            Assert.True(twoPerms >= onePerm);

            Assert.False(onePerm > twoPerms);
            Assert.False(onePerm >= twoPerms);
            Assert.False(twoPerms < onePerm);
            Assert.False(twoPerms <= onePerm);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Permeance perm = Permeance.FromPerms(1);
            Assert.Equal(0, perm.CompareTo(perm));
            Assert.True(perm.CompareTo(Permeance.Zero) > 0);
            Assert.True(Permeance.Zero.CompareTo(perm) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Permeance perm = Permeance.FromPerms(1);
            Assert.Throws<ArgumentException>(() => perm.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Permeance perm = Permeance.FromPerms(1);
            Assert.Throws<ArgumentNullException>(() => perm.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Permeance.FromPerms(1);
            var b = Permeance.FromPerms(2);

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
            var a = Permeance.FromPerms(1);
            var b = Permeance.FromPerms(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = Permeance.FromPerms(1);
            object b = Permeance.FromPerms(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = Permeance.FromPerms(1);
            Assert.True(v.Equals(Permeance.FromPerms(1), PermsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Permeance.Zero, PermsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = Permeance.FromPerms(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(Permeance.FromPerms(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Permeance perm = Permeance.FromPerms(1);
            Assert.False(perm.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Permeance perm = Permeance.FromPerms(1);
            Assert.False(perm.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(PermeanceUnit.Undefined, Permeance.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(PermeanceUnit)).Cast<PermeanceUnit>();
            foreach(var unit in units)
            {
                if(unit == PermeanceUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Permeance.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 gr/(h·ft²·inHg)", new Permeance(1, PermeanceUnit.GrainsPerHourSquareFootInchOfMercury).ToString());
                Assert.Equal("1 ng/(Pa·s·m²)", new Permeance(1, PermeanceUnit.Perm).ToString());
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

            Assert.Equal("1 gr/(h·ft²·inHg)", new Permeance(1, PermeanceUnit.GrainsPerHourSquareFootInchOfMercury).ToString(swedishCulture));
            Assert.Equal("1 ng/(Pa·s·m²)", new Permeance(1, PermeanceUnit.Perm).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 ng/(Pa·s·m²)", new Permeance(0.123456, PermeanceUnit.Perm).ToString("s1"));
                Assert.Equal("0.12 ng/(Pa·s·m²)", new Permeance(0.123456, PermeanceUnit.Perm).ToString("s2"));
                Assert.Equal("0.123 ng/(Pa·s·m²)", new Permeance(0.123456, PermeanceUnit.Perm).ToString("s3"));
                Assert.Equal("0.1235 ng/(Pa·s·m²)", new Permeance(0.123456, PermeanceUnit.Perm).ToString("s4"));
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
            Assert.Equal("0.1 ng/(Pa·s·m²)", new Permeance(0.123456, PermeanceUnit.Perm).ToString("s1", culture));
            Assert.Equal("0.12 ng/(Pa·s·m²)", new Permeance(0.123456, PermeanceUnit.Perm).ToString("s2", culture));
            Assert.Equal("0.123 ng/(Pa·s·m²)", new Permeance(0.123456, PermeanceUnit.Perm).ToString("s3", culture));
            Assert.Equal("0.1235 ng/(Pa·s·m²)", new Permeance(0.123456, PermeanceUnit.Perm).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = Permeance.FromPerms(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(Permeance)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(PermeanceUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Equal(QuantityType.Permeance, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Equal(Permeance.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = Permeance.FromPerms(1.0);
            Assert.Equal(new {Permeance.QuantityType, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = Permeance.FromPerms(value);
            Assert.Equal(Permeance.FromPerms(-value), -quantity);
        }

    }
}
