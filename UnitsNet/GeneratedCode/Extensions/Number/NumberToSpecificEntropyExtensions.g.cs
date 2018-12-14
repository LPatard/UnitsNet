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

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToSpecificEntropy
{
    public static class NumberToSpecificEntropyExtensions
    {
        #region CaloriePerGramKelvin

        /// <inheritdoc cref="SpecificEntropy.FromCaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy CaloriesPerGramKelvin<T>(this T value) => SpecificEntropy.FromCaloriesPerGramKelvin(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromCaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static SpecificEntropy? CaloriesPerGramKelvin<T>(this T? value) where T : struct => SpecificEntropy.FromCaloriesPerGramKelvin(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region JoulePerKilogramDegreeCelsius

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy JoulesPerKilogramDegreeCelsius<T>(this T value) => SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static SpecificEntropy? JoulesPerKilogramDegreeCelsius<T>(this T? value) where T : struct => SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region JoulePerKilogramKelvin

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy JoulesPerKilogramKelvin<T>(this T value) => SpecificEntropy.FromJoulesPerKilogramKelvin(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static SpecificEntropy? JoulesPerKilogramKelvin<T>(this T? value) where T : struct => SpecificEntropy.FromJoulesPerKilogramKelvin(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilocaloriePerGramKelvin

        /// <inheritdoc cref="SpecificEntropy.FromKilocaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilocaloriesPerGramKelvin<T>(this T value) => SpecificEntropy.FromKilocaloriesPerGramKelvin(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromKilocaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static SpecificEntropy? KilocaloriesPerGramKelvin<T>(this T? value) where T : struct => SpecificEntropy.FromKilocaloriesPerGramKelvin(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilojoulePerKilogramDegreeCelsius

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilojoulesPerKilogramDegreeCelsius<T>(this T value) => SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static SpecificEntropy? KilojoulesPerKilogramDegreeCelsius<T>(this T? value) where T : struct => SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilojoulePerKilogramKelvin

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilojoulesPerKilogramKelvin<T>(this T value) => SpecificEntropy.FromKilojoulesPerKilogramKelvin(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static SpecificEntropy? KilojoulesPerKilogramKelvin<T>(this T? value) where T : struct => SpecificEntropy.FromKilojoulesPerKilogramKelvin(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MegajoulePerKilogramDegreeCelsius

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy MegajoulesPerKilogramDegreeCelsius<T>(this T value) => SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static SpecificEntropy? MegajoulesPerKilogramDegreeCelsius<T>(this T? value) where T : struct => SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MegajoulePerKilogramKelvin

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy MegajoulesPerKilogramKelvin<T>(this T value) => SpecificEntropy.FromMegajoulesPerKilogramKelvin(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static SpecificEntropy? MegajoulesPerKilogramKelvin<T>(this T? value) where T : struct => SpecificEntropy.FromMegajoulesPerKilogramKelvin(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif