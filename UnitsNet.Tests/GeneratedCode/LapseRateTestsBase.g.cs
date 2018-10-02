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
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of LapseRate.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class LapseRateTestsBase
    {
        protected abstract double DegreesCelciusPerKilometerInOneDegreeCelsiusPerKilometer { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DegreesCelciusPerKilometerTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LapseRate((double)0.0, LapseRateUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LapseRate(double.PositiveInfinity, LapseRateUnit.DegreeCelsiusPerKilometer));
            Assert.Throws<ArgumentException>(() => new LapseRate(double.NegativeInfinity, LapseRateUnit.DegreeCelsiusPerKilometer));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LapseRate(double.NaN, LapseRateUnit.DegreeCelsiusPerKilometer));
        }

        [Fact]
        public void DegreeCelsiusPerKilometerToLapseRateUnits()
        {
            LapseRate degreecelsiusperkilometer = LapseRate.FromDegreesCelciusPerKilometer(1);
            AssertEx.EqualTolerance(DegreesCelciusPerKilometerInOneDegreeCelsiusPerKilometer, degreecelsiusperkilometer.DegreesCelciusPerKilometer, DegreesCelciusPerKilometerTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, LapseRate.From(1, LapseRateUnit.DegreeCelsiusPerKilometer).DegreesCelciusPerKilometer, DegreesCelciusPerKilometerTolerance);
        }

        [Fact]
        public void FromDegreesCelciusPerKilometer_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => LapseRate.FromDegreesCelciusPerKilometer(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => LapseRate.FromDegreesCelciusPerKilometer(double.NegativeInfinity));
        }

        [Fact]
        public void FromDegreesCelciusPerKilometer_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => LapseRate.FromDegreesCelciusPerKilometer(double.NaN));
        }

        [Fact]
        public void As()
        {
            var degreecelsiusperkilometer = LapseRate.FromDegreesCelciusPerKilometer(1);
            AssertEx.EqualTolerance(DegreesCelciusPerKilometerInOneDegreeCelsiusPerKilometer, degreecelsiusperkilometer.As(LapseRateUnit.DegreeCelsiusPerKilometer), DegreesCelciusPerKilometerTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var degreecelsiusperkilometer = LapseRate.FromDegreesCelciusPerKilometer(1);

            var degreecelsiusperkilometerQuantity = degreecelsiusperkilometer.ToUnit(LapseRateUnit.DegreeCelsiusPerKilometer);
            AssertEx.EqualTolerance(DegreesCelciusPerKilometerInOneDegreeCelsiusPerKilometer, (double)degreecelsiusperkilometerQuantity.Value, DegreesCelciusPerKilometerTolerance);
            Assert.Equal(LapseRateUnit.DegreeCelsiusPerKilometer, degreecelsiusperkilometerQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            LapseRate degreecelsiusperkilometer = LapseRate.FromDegreesCelciusPerKilometer(1);
            AssertEx.EqualTolerance(1, LapseRate.FromDegreesCelciusPerKilometer(degreecelsiusperkilometer.DegreesCelciusPerKilometer).DegreesCelciusPerKilometer, DegreesCelciusPerKilometerTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            LapseRate v = LapseRate.FromDegreesCelciusPerKilometer(1);
            AssertEx.EqualTolerance(-1, -v.DegreesCelciusPerKilometer, DegreesCelciusPerKilometerTolerance);
            AssertEx.EqualTolerance(2, (LapseRate.FromDegreesCelciusPerKilometer(3)-v).DegreesCelciusPerKilometer, DegreesCelciusPerKilometerTolerance);
            AssertEx.EqualTolerance(2, (v + v).DegreesCelciusPerKilometer, DegreesCelciusPerKilometerTolerance);
            AssertEx.EqualTolerance(10, (v*10).DegreesCelciusPerKilometer, DegreesCelciusPerKilometerTolerance);
            AssertEx.EqualTolerance(10, (10*v).DegreesCelciusPerKilometer, DegreesCelciusPerKilometerTolerance);
            AssertEx.EqualTolerance(2, (LapseRate.FromDegreesCelciusPerKilometer(10)/5).DegreesCelciusPerKilometer, DegreesCelciusPerKilometerTolerance);
            AssertEx.EqualTolerance(2, LapseRate.FromDegreesCelciusPerKilometer(10)/LapseRate.FromDegreesCelciusPerKilometer(5), DegreesCelciusPerKilometerTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            LapseRate oneDegreeCelsiusPerKilometer = LapseRate.FromDegreesCelciusPerKilometer(1);
            LapseRate twoDegreesCelciusPerKilometer = LapseRate.FromDegreesCelciusPerKilometer(2);

            Assert.True(oneDegreeCelsiusPerKilometer < twoDegreesCelciusPerKilometer);
            Assert.True(oneDegreeCelsiusPerKilometer <= twoDegreesCelciusPerKilometer);
            Assert.True(twoDegreesCelciusPerKilometer > oneDegreeCelsiusPerKilometer);
            Assert.True(twoDegreesCelciusPerKilometer >= oneDegreeCelsiusPerKilometer);

            Assert.False(oneDegreeCelsiusPerKilometer > twoDegreesCelciusPerKilometer);
            Assert.False(oneDegreeCelsiusPerKilometer >= twoDegreesCelciusPerKilometer);
            Assert.False(twoDegreesCelciusPerKilometer < oneDegreeCelsiusPerKilometer);
            Assert.False(twoDegreesCelciusPerKilometer <= oneDegreeCelsiusPerKilometer);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            LapseRate degreecelsiusperkilometer = LapseRate.FromDegreesCelciusPerKilometer(1);
            Assert.Equal(0, degreecelsiusperkilometer.CompareTo(degreecelsiusperkilometer));
            Assert.True(degreecelsiusperkilometer.CompareTo(LapseRate.Zero) > 0);
            Assert.True(LapseRate.Zero.CompareTo(degreecelsiusperkilometer) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            LapseRate degreecelsiusperkilometer = LapseRate.FromDegreesCelciusPerKilometer(1);
            Assert.Throws<ArgumentException>(() => degreecelsiusperkilometer.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            LapseRate degreecelsiusperkilometer = LapseRate.FromDegreesCelciusPerKilometer(1);
            Assert.Throws<ArgumentNullException>(() => degreecelsiusperkilometer.CompareTo(null));
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            LapseRate v = LapseRate.FromDegreesCelciusPerKilometer(1);
            Assert.True(v.Equals(LapseRate.FromDegreesCelciusPerKilometer(1), DegreesCelciusPerKilometerTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(LapseRate.Zero, DegreesCelciusPerKilometerTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            LapseRate degreecelsiusperkilometer = LapseRate.FromDegreesCelciusPerKilometer(1);
            Assert.False(degreecelsiusperkilometer.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            LapseRate degreecelsiusperkilometer = LapseRate.FromDegreesCelciusPerKilometer(1);
            Assert.False(degreecelsiusperkilometer.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(LapseRateUnit.Undefined, LapseRate.Units);
        }
    }
}
