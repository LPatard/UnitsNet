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
    /// Test of Power.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class PowerTestsBase
    {
        protected abstract double BoilerHorsepowerInOneWatt { get; }
        protected abstract double BritishThermalUnitsPerHourInOneWatt { get; }
        protected abstract double DecawattsInOneWatt { get; }
        protected abstract double DeciwattsInOneWatt { get; }
        protected abstract double ElectricalHorsepowerInOneWatt { get; }
        protected abstract double FemtowattsInOneWatt { get; }
        protected abstract double GigawattsInOneWatt { get; }
        protected abstract double HydraulicHorsepowerInOneWatt { get; }
        protected abstract double KilobritishThermalUnitsPerHourInOneWatt { get; }
        protected abstract double KilowattsInOneWatt { get; }
        protected abstract double MechanicalHorsepowerInOneWatt { get; }
        protected abstract double MegawattsInOneWatt { get; }
        protected abstract double MetricHorsepowerInOneWatt { get; }
        protected abstract double MicrowattsInOneWatt { get; }
        protected abstract double MilliwattsInOneWatt { get; }
        protected abstract double NanowattsInOneWatt { get; }
        protected abstract double PetawattsInOneWatt { get; }
        protected abstract double PicowattsInOneWatt { get; }
        protected abstract double TerawattsInOneWatt { get; }
        protected abstract double WattsInOneWatt { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double BoilerHorsepowerTolerance { get { return 1e-5; } }
        protected virtual double BritishThermalUnitsPerHourTolerance { get { return 1e-5; } }
        protected virtual double DecawattsTolerance { get { return 1e-5; } }
        protected virtual double DeciwattsTolerance { get { return 1e-5; } }
        protected virtual double ElectricalHorsepowerTolerance { get { return 1e-5; } }
        protected virtual double FemtowattsTolerance { get { return 1e-5; } }
        protected virtual double GigawattsTolerance { get { return 1e-5; } }
        protected virtual double HydraulicHorsepowerTolerance { get { return 1e-5; } }
        protected virtual double KilobritishThermalUnitsPerHourTolerance { get { return 1e-5; } }
        protected virtual double KilowattsTolerance { get { return 1e-5; } }
        protected virtual double MechanicalHorsepowerTolerance { get { return 1e-5; } }
        protected virtual double MegawattsTolerance { get { return 1e-5; } }
        protected virtual double MetricHorsepowerTolerance { get { return 1e-5; } }
        protected virtual double MicrowattsTolerance { get { return 1e-5; } }
        protected virtual double MilliwattsTolerance { get { return 1e-5; } }
        protected virtual double NanowattsTolerance { get { return 1e-5; } }
        protected virtual double PetawattsTolerance { get { return 1e-5; } }
        protected virtual double PicowattsTolerance { get { return 1e-5; } }
        protected virtual double TerawattsTolerance { get { return 1e-5; } }
        protected virtual double WattsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Power((decimal)0.0, PowerUnit.Undefined));
        }


        [Fact]
        public void WattToPowerUnits()
        {
            Power watt = Power.FromWatts(1);
            AssertEx.EqualTolerance(BoilerHorsepowerInOneWatt, watt.BoilerHorsepower, BoilerHorsepowerTolerance);
            AssertEx.EqualTolerance(BritishThermalUnitsPerHourInOneWatt, watt.BritishThermalUnitsPerHour, BritishThermalUnitsPerHourTolerance);
            AssertEx.EqualTolerance(DecawattsInOneWatt, watt.Decawatts, DecawattsTolerance);
            AssertEx.EqualTolerance(DeciwattsInOneWatt, watt.Deciwatts, DeciwattsTolerance);
            AssertEx.EqualTolerance(ElectricalHorsepowerInOneWatt, watt.ElectricalHorsepower, ElectricalHorsepowerTolerance);
            AssertEx.EqualTolerance(FemtowattsInOneWatt, watt.Femtowatts, FemtowattsTolerance);
            AssertEx.EqualTolerance(GigawattsInOneWatt, watt.Gigawatts, GigawattsTolerance);
            AssertEx.EqualTolerance(HydraulicHorsepowerInOneWatt, watt.HydraulicHorsepower, HydraulicHorsepowerTolerance);
            AssertEx.EqualTolerance(KilobritishThermalUnitsPerHourInOneWatt, watt.KilobritishThermalUnitsPerHour, KilobritishThermalUnitsPerHourTolerance);
            AssertEx.EqualTolerance(KilowattsInOneWatt, watt.Kilowatts, KilowattsTolerance);
            AssertEx.EqualTolerance(MechanicalHorsepowerInOneWatt, watt.MechanicalHorsepower, MechanicalHorsepowerTolerance);
            AssertEx.EqualTolerance(MegawattsInOneWatt, watt.Megawatts, MegawattsTolerance);
            AssertEx.EqualTolerance(MetricHorsepowerInOneWatt, watt.MetricHorsepower, MetricHorsepowerTolerance);
            AssertEx.EqualTolerance(MicrowattsInOneWatt, watt.Microwatts, MicrowattsTolerance);
            AssertEx.EqualTolerance(MilliwattsInOneWatt, watt.Milliwatts, MilliwattsTolerance);
            AssertEx.EqualTolerance(NanowattsInOneWatt, watt.Nanowatts, NanowattsTolerance);
            AssertEx.EqualTolerance(PetawattsInOneWatt, watt.Petawatts, PetawattsTolerance);
            AssertEx.EqualTolerance(PicowattsInOneWatt, watt.Picowatts, PicowattsTolerance);
            AssertEx.EqualTolerance(TerawattsInOneWatt, watt.Terawatts, TerawattsTolerance);
            AssertEx.EqualTolerance(WattsInOneWatt, watt.Watts, WattsTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Power.From(1, PowerUnit.BoilerHorsepower).BoilerHorsepower, BoilerHorsepowerTolerance);
            AssertEx.EqualTolerance(1, Power.From(1, PowerUnit.BritishThermalUnitPerHour).BritishThermalUnitsPerHour, BritishThermalUnitsPerHourTolerance);
            AssertEx.EqualTolerance(1, Power.From(1, PowerUnit.Decawatt).Decawatts, DecawattsTolerance);
            AssertEx.EqualTolerance(1, Power.From(1, PowerUnit.Deciwatt).Deciwatts, DeciwattsTolerance);
            AssertEx.EqualTolerance(1, Power.From(1, PowerUnit.ElectricalHorsepower).ElectricalHorsepower, ElectricalHorsepowerTolerance);
            AssertEx.EqualTolerance(1, Power.From(1, PowerUnit.Femtowatt).Femtowatts, FemtowattsTolerance);
            AssertEx.EqualTolerance(1, Power.From(1, PowerUnit.Gigawatt).Gigawatts, GigawattsTolerance);
            AssertEx.EqualTolerance(1, Power.From(1, PowerUnit.HydraulicHorsepower).HydraulicHorsepower, HydraulicHorsepowerTolerance);
            AssertEx.EqualTolerance(1, Power.From(1, PowerUnit.KilobritishThermalUnitPerHour).KilobritishThermalUnitsPerHour, KilobritishThermalUnitsPerHourTolerance);
            AssertEx.EqualTolerance(1, Power.From(1, PowerUnit.Kilowatt).Kilowatts, KilowattsTolerance);
            AssertEx.EqualTolerance(1, Power.From(1, PowerUnit.MechanicalHorsepower).MechanicalHorsepower, MechanicalHorsepowerTolerance);
            AssertEx.EqualTolerance(1, Power.From(1, PowerUnit.Megawatt).Megawatts, MegawattsTolerance);
            AssertEx.EqualTolerance(1, Power.From(1, PowerUnit.MetricHorsepower).MetricHorsepower, MetricHorsepowerTolerance);
            AssertEx.EqualTolerance(1, Power.From(1, PowerUnit.Microwatt).Microwatts, MicrowattsTolerance);
            AssertEx.EqualTolerance(1, Power.From(1, PowerUnit.Milliwatt).Milliwatts, MilliwattsTolerance);
            AssertEx.EqualTolerance(1, Power.From(1, PowerUnit.Nanowatt).Nanowatts, NanowattsTolerance);
            AssertEx.EqualTolerance(1, Power.From(1, PowerUnit.Petawatt).Petawatts, PetawattsTolerance);
            AssertEx.EqualTolerance(1, Power.From(1, PowerUnit.Picowatt).Picowatts, PicowattsTolerance);
            AssertEx.EqualTolerance(1, Power.From(1, PowerUnit.Terawatt).Terawatts, TerawattsTolerance);
            AssertEx.EqualTolerance(1, Power.From(1, PowerUnit.Watt).Watts, WattsTolerance);
        }


        [Fact]
        public void As()
        {
            var watt = Power.FromWatts(1);
            AssertEx.EqualTolerance(BoilerHorsepowerInOneWatt, watt.As(PowerUnit.BoilerHorsepower), BoilerHorsepowerTolerance);
            AssertEx.EqualTolerance(BritishThermalUnitsPerHourInOneWatt, watt.As(PowerUnit.BritishThermalUnitPerHour), BritishThermalUnitsPerHourTolerance);
            AssertEx.EqualTolerance(DecawattsInOneWatt, watt.As(PowerUnit.Decawatt), DecawattsTolerance);
            AssertEx.EqualTolerance(DeciwattsInOneWatt, watt.As(PowerUnit.Deciwatt), DeciwattsTolerance);
            AssertEx.EqualTolerance(ElectricalHorsepowerInOneWatt, watt.As(PowerUnit.ElectricalHorsepower), ElectricalHorsepowerTolerance);
            AssertEx.EqualTolerance(FemtowattsInOneWatt, watt.As(PowerUnit.Femtowatt), FemtowattsTolerance);
            AssertEx.EqualTolerance(GigawattsInOneWatt, watt.As(PowerUnit.Gigawatt), GigawattsTolerance);
            AssertEx.EqualTolerance(HydraulicHorsepowerInOneWatt, watt.As(PowerUnit.HydraulicHorsepower), HydraulicHorsepowerTolerance);
            AssertEx.EqualTolerance(KilobritishThermalUnitsPerHourInOneWatt, watt.As(PowerUnit.KilobritishThermalUnitPerHour), KilobritishThermalUnitsPerHourTolerance);
            AssertEx.EqualTolerance(KilowattsInOneWatt, watt.As(PowerUnit.Kilowatt), KilowattsTolerance);
            AssertEx.EqualTolerance(MechanicalHorsepowerInOneWatt, watt.As(PowerUnit.MechanicalHorsepower), MechanicalHorsepowerTolerance);
            AssertEx.EqualTolerance(MegawattsInOneWatt, watt.As(PowerUnit.Megawatt), MegawattsTolerance);
            AssertEx.EqualTolerance(MetricHorsepowerInOneWatt, watt.As(PowerUnit.MetricHorsepower), MetricHorsepowerTolerance);
            AssertEx.EqualTolerance(MicrowattsInOneWatt, watt.As(PowerUnit.Microwatt), MicrowattsTolerance);
            AssertEx.EqualTolerance(MilliwattsInOneWatt, watt.As(PowerUnit.Milliwatt), MilliwattsTolerance);
            AssertEx.EqualTolerance(NanowattsInOneWatt, watt.As(PowerUnit.Nanowatt), NanowattsTolerance);
            AssertEx.EqualTolerance(PetawattsInOneWatt, watt.As(PowerUnit.Petawatt), PetawattsTolerance);
            AssertEx.EqualTolerance(PicowattsInOneWatt, watt.As(PowerUnit.Picowatt), PicowattsTolerance);
            AssertEx.EqualTolerance(TerawattsInOneWatt, watt.As(PowerUnit.Terawatt), TerawattsTolerance);
            AssertEx.EqualTolerance(WattsInOneWatt, watt.As(PowerUnit.Watt), WattsTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var watt = Power.FromWatts(1);

            var boilerhorsepowerQuantity = watt.ToUnit(PowerUnit.BoilerHorsepower);
            AssertEx.EqualTolerance(BoilerHorsepowerInOneWatt, (double)boilerhorsepowerQuantity.Value, BoilerHorsepowerTolerance);
            Assert.Equal(PowerUnit.BoilerHorsepower, boilerhorsepowerQuantity.Unit);

            var britishthermalunitperhourQuantity = watt.ToUnit(PowerUnit.BritishThermalUnitPerHour);
            AssertEx.EqualTolerance(BritishThermalUnitsPerHourInOneWatt, (double)britishthermalunitperhourQuantity.Value, BritishThermalUnitsPerHourTolerance);
            Assert.Equal(PowerUnit.BritishThermalUnitPerHour, britishthermalunitperhourQuantity.Unit);

            var decawattQuantity = watt.ToUnit(PowerUnit.Decawatt);
            AssertEx.EqualTolerance(DecawattsInOneWatt, (double)decawattQuantity.Value, DecawattsTolerance);
            Assert.Equal(PowerUnit.Decawatt, decawattQuantity.Unit);

            var deciwattQuantity = watt.ToUnit(PowerUnit.Deciwatt);
            AssertEx.EqualTolerance(DeciwattsInOneWatt, (double)deciwattQuantity.Value, DeciwattsTolerance);
            Assert.Equal(PowerUnit.Deciwatt, deciwattQuantity.Unit);

            var electricalhorsepowerQuantity = watt.ToUnit(PowerUnit.ElectricalHorsepower);
            AssertEx.EqualTolerance(ElectricalHorsepowerInOneWatt, (double)electricalhorsepowerQuantity.Value, ElectricalHorsepowerTolerance);
            Assert.Equal(PowerUnit.ElectricalHorsepower, electricalhorsepowerQuantity.Unit);

            var femtowattQuantity = watt.ToUnit(PowerUnit.Femtowatt);
            AssertEx.EqualTolerance(FemtowattsInOneWatt, (double)femtowattQuantity.Value, FemtowattsTolerance);
            Assert.Equal(PowerUnit.Femtowatt, femtowattQuantity.Unit);

            var gigawattQuantity = watt.ToUnit(PowerUnit.Gigawatt);
            AssertEx.EqualTolerance(GigawattsInOneWatt, (double)gigawattQuantity.Value, GigawattsTolerance);
            Assert.Equal(PowerUnit.Gigawatt, gigawattQuantity.Unit);

            var hydraulichorsepowerQuantity = watt.ToUnit(PowerUnit.HydraulicHorsepower);
            AssertEx.EqualTolerance(HydraulicHorsepowerInOneWatt, (double)hydraulichorsepowerQuantity.Value, HydraulicHorsepowerTolerance);
            Assert.Equal(PowerUnit.HydraulicHorsepower, hydraulichorsepowerQuantity.Unit);

            var kilobritishthermalunitperhourQuantity = watt.ToUnit(PowerUnit.KilobritishThermalUnitPerHour);
            AssertEx.EqualTolerance(KilobritishThermalUnitsPerHourInOneWatt, (double)kilobritishthermalunitperhourQuantity.Value, KilobritishThermalUnitsPerHourTolerance);
            Assert.Equal(PowerUnit.KilobritishThermalUnitPerHour, kilobritishthermalunitperhourQuantity.Unit);

            var kilowattQuantity = watt.ToUnit(PowerUnit.Kilowatt);
            AssertEx.EqualTolerance(KilowattsInOneWatt, (double)kilowattQuantity.Value, KilowattsTolerance);
            Assert.Equal(PowerUnit.Kilowatt, kilowattQuantity.Unit);

            var mechanicalhorsepowerQuantity = watt.ToUnit(PowerUnit.MechanicalHorsepower);
            AssertEx.EqualTolerance(MechanicalHorsepowerInOneWatt, (double)mechanicalhorsepowerQuantity.Value, MechanicalHorsepowerTolerance);
            Assert.Equal(PowerUnit.MechanicalHorsepower, mechanicalhorsepowerQuantity.Unit);

            var megawattQuantity = watt.ToUnit(PowerUnit.Megawatt);
            AssertEx.EqualTolerance(MegawattsInOneWatt, (double)megawattQuantity.Value, MegawattsTolerance);
            Assert.Equal(PowerUnit.Megawatt, megawattQuantity.Unit);

            var metrichorsepowerQuantity = watt.ToUnit(PowerUnit.MetricHorsepower);
            AssertEx.EqualTolerance(MetricHorsepowerInOneWatt, (double)metrichorsepowerQuantity.Value, MetricHorsepowerTolerance);
            Assert.Equal(PowerUnit.MetricHorsepower, metrichorsepowerQuantity.Unit);

            var microwattQuantity = watt.ToUnit(PowerUnit.Microwatt);
            AssertEx.EqualTolerance(MicrowattsInOneWatt, (double)microwattQuantity.Value, MicrowattsTolerance);
            Assert.Equal(PowerUnit.Microwatt, microwattQuantity.Unit);

            var milliwattQuantity = watt.ToUnit(PowerUnit.Milliwatt);
            AssertEx.EqualTolerance(MilliwattsInOneWatt, (double)milliwattQuantity.Value, MilliwattsTolerance);
            Assert.Equal(PowerUnit.Milliwatt, milliwattQuantity.Unit);

            var nanowattQuantity = watt.ToUnit(PowerUnit.Nanowatt);
            AssertEx.EqualTolerance(NanowattsInOneWatt, (double)nanowattQuantity.Value, NanowattsTolerance);
            Assert.Equal(PowerUnit.Nanowatt, nanowattQuantity.Unit);

            var petawattQuantity = watt.ToUnit(PowerUnit.Petawatt);
            AssertEx.EqualTolerance(PetawattsInOneWatt, (double)petawattQuantity.Value, PetawattsTolerance);
            Assert.Equal(PowerUnit.Petawatt, petawattQuantity.Unit);

            var picowattQuantity = watt.ToUnit(PowerUnit.Picowatt);
            AssertEx.EqualTolerance(PicowattsInOneWatt, (double)picowattQuantity.Value, PicowattsTolerance);
            Assert.Equal(PowerUnit.Picowatt, picowattQuantity.Unit);

            var terawattQuantity = watt.ToUnit(PowerUnit.Terawatt);
            AssertEx.EqualTolerance(TerawattsInOneWatt, (double)terawattQuantity.Value, TerawattsTolerance);
            Assert.Equal(PowerUnit.Terawatt, terawattQuantity.Unit);

            var wattQuantity = watt.ToUnit(PowerUnit.Watt);
            AssertEx.EqualTolerance(WattsInOneWatt, (double)wattQuantity.Value, WattsTolerance);
            Assert.Equal(PowerUnit.Watt, wattQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Power watt = Power.FromWatts(1);
            AssertEx.EqualTolerance(1, Power.FromBoilerHorsepower(watt.BoilerHorsepower).Watts, BoilerHorsepowerTolerance);
            AssertEx.EqualTolerance(1, Power.FromBritishThermalUnitsPerHour(watt.BritishThermalUnitsPerHour).Watts, BritishThermalUnitsPerHourTolerance);
            AssertEx.EqualTolerance(1, Power.FromDecawatts(watt.Decawatts).Watts, DecawattsTolerance);
            AssertEx.EqualTolerance(1, Power.FromDeciwatts(watt.Deciwatts).Watts, DeciwattsTolerance);
            AssertEx.EqualTolerance(1, Power.FromElectricalHorsepower(watt.ElectricalHorsepower).Watts, ElectricalHorsepowerTolerance);
            AssertEx.EqualTolerance(1, Power.FromFemtowatts(watt.Femtowatts).Watts, FemtowattsTolerance);
            AssertEx.EqualTolerance(1, Power.FromGigawatts(watt.Gigawatts).Watts, GigawattsTolerance);
            AssertEx.EqualTolerance(1, Power.FromHydraulicHorsepower(watt.HydraulicHorsepower).Watts, HydraulicHorsepowerTolerance);
            AssertEx.EqualTolerance(1, Power.FromKilobritishThermalUnitsPerHour(watt.KilobritishThermalUnitsPerHour).Watts, KilobritishThermalUnitsPerHourTolerance);
            AssertEx.EqualTolerance(1, Power.FromKilowatts(watt.Kilowatts).Watts, KilowattsTolerance);
            AssertEx.EqualTolerance(1, Power.FromMechanicalHorsepower(watt.MechanicalHorsepower).Watts, MechanicalHorsepowerTolerance);
            AssertEx.EqualTolerance(1, Power.FromMegawatts(watt.Megawatts).Watts, MegawattsTolerance);
            AssertEx.EqualTolerance(1, Power.FromMetricHorsepower(watt.MetricHorsepower).Watts, MetricHorsepowerTolerance);
            AssertEx.EqualTolerance(1, Power.FromMicrowatts(watt.Microwatts).Watts, MicrowattsTolerance);
            AssertEx.EqualTolerance(1, Power.FromMilliwatts(watt.Milliwatts).Watts, MilliwattsTolerance);
            AssertEx.EqualTolerance(1, Power.FromNanowatts(watt.Nanowatts).Watts, NanowattsTolerance);
            AssertEx.EqualTolerance(1, Power.FromPetawatts(watt.Petawatts).Watts, PetawattsTolerance);
            AssertEx.EqualTolerance(1, Power.FromPicowatts(watt.Picowatts).Watts, PicowattsTolerance);
            AssertEx.EqualTolerance(1, Power.FromTerawatts(watt.Terawatts).Watts, TerawattsTolerance);
            AssertEx.EqualTolerance(1, Power.FromWatts(watt.Watts).Watts, WattsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Power v = Power.FromWatts(1);
            AssertEx.EqualTolerance(-1, -v.Watts, WattsTolerance);
            AssertEx.EqualTolerance(2, (Power.FromWatts(3)-v).Watts, WattsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Watts, WattsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Watts, WattsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Watts, WattsTolerance);
            AssertEx.EqualTolerance(2, (Power.FromWatts(10)/5).Watts, WattsTolerance);
            AssertEx.EqualTolerance(2, Power.FromWatts(10)/Power.FromWatts(5), WattsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Power oneWatt = Power.FromWatts(1);
            Power twoWatts = Power.FromWatts(2);

            Assert.True(oneWatt < twoWatts);
            Assert.True(oneWatt <= twoWatts);
            Assert.True(twoWatts > oneWatt);
            Assert.True(twoWatts >= oneWatt);

            Assert.False(oneWatt > twoWatts);
            Assert.False(oneWatt >= twoWatts);
            Assert.False(twoWatts < oneWatt);
            Assert.False(twoWatts <= oneWatt);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Power watt = Power.FromWatts(1);
            Assert.Equal(0, watt.CompareTo(watt));
            Assert.True(watt.CompareTo(Power.Zero) > 0);
            Assert.True(Power.Zero.CompareTo(watt) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Power watt = Power.FromWatts(1);
            Assert.Throws<ArgumentException>(() => watt.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Power watt = Power.FromWatts(1);
            Assert.Throws<ArgumentNullException>(() => watt.CompareTo(null));
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            Power v = Power.FromWatts(1);
            Assert.True(v.Equals(Power.FromWatts(1), WattsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Power.Zero, WattsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Power watt = Power.FromWatts(1);
            Assert.False(watt.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Power watt = Power.FromWatts(1);
            Assert.False(watt.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(PowerUnit.Undefined, Power.Units);
        }
    }
}
