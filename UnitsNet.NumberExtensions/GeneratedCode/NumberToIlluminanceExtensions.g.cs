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

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToIlluminance
{
    /// <summary>
    /// A number to Illuminance Extensions
    /// </summary>
    public static class NumberToIlluminanceExtensions
    {
        /// <inheritdoc cref="Illuminance.FromFootCandles(UnitsNet.QuantityValue)" />
        public static Illuminance FootCandles<T>(this T value) =>
            Illuminance.FromFootCandles(Convert.ToDouble(value));

        /// <inheritdoc cref="Illuminance.FromKilolux(UnitsNet.QuantityValue)" />
        public static Illuminance Kilolux<T>(this T value) =>
            Illuminance.FromKilolux(Convert.ToDouble(value));

        /// <inheritdoc cref="Illuminance.FromLux(UnitsNet.QuantityValue)" />
        public static Illuminance Lux<T>(this T value) =>
            Illuminance.FromLux(Convert.ToDouble(value));

        /// <inheritdoc cref="Illuminance.FromMegalux(UnitsNet.QuantityValue)" />
        public static Illuminance Megalux<T>(this T value) =>
            Illuminance.FromMegalux(Convert.ToDouble(value));

        /// <inheritdoc cref="Illuminance.FromMillilux(UnitsNet.QuantityValue)" />
        public static Illuminance Millilux<T>(this T value) =>
            Illuminance.FromMillilux(Convert.ToDouble(value));

    }
}
