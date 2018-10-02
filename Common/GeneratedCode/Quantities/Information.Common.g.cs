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
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.InternalHelpers;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     In computing and telecommunications, a unit of information is the capacity of some standard data storage system or communication channel, used to measure the capacities of other systems and channels. In information theory, units of information are also used to measure the information contents or entropy of random variables.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class Information : IQuantity
#else
    public partial struct Information : IQuantity, IComparable, IComparable<Information>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly decimal _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly InformationUnit? _unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public InformationUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        static Information()
        {
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">The numeric value  to contruct this quantity with.</param>
        /// <param name="unit">The unit representation to contruct this quantity with.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        private
#else
        public
#endif
        Information(decimal numericValue, InformationUnit unit)
        {
            if(unit == InformationUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = numericValue;
            _unit = unit;
        }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.Information;

        /// <summary>
        ///     The base unit of Information, which is Bit. All conversions go via this value.
        /// </summary>
        public static InformationUnit BaseUnit => InformationUnit.Bit;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions
        {
            get;
        }

        /// <summary>
        ///     All units of measurement for the Information quantity.
        /// </summary>
        public static InformationUnit[] Units { get; } = Enum.GetValues(typeof(InformationUnit)).Cast<InformationUnit>().Except(new InformationUnit[]{ InformationUnit.Undefined }).ToArray();

        /// <summary>
        ///     Get Information in Bits.
        /// </summary>
        public double Bits => As(InformationUnit.Bit);

        /// <summary>
        ///     Get Information in Bytes.
        /// </summary>
        public double Bytes => As(InformationUnit.Byte);

        /// <summary>
        ///     Get Information in Exabits.
        /// </summary>
        public double Exabits => As(InformationUnit.Exabit);

        /// <summary>
        ///     Get Information in Exabytes.
        /// </summary>
        public double Exabytes => As(InformationUnit.Exabyte);

        /// <summary>
        ///     Get Information in Exbibits.
        /// </summary>
        public double Exbibits => As(InformationUnit.Exbibit);

        /// <summary>
        ///     Get Information in Exbibytes.
        /// </summary>
        public double Exbibytes => As(InformationUnit.Exbibyte);

        /// <summary>
        ///     Get Information in Gibibits.
        /// </summary>
        public double Gibibits => As(InformationUnit.Gibibit);

        /// <summary>
        ///     Get Information in Gibibytes.
        /// </summary>
        public double Gibibytes => As(InformationUnit.Gibibyte);

        /// <summary>
        ///     Get Information in Gigabits.
        /// </summary>
        public double Gigabits => As(InformationUnit.Gigabit);

        /// <summary>
        ///     Get Information in Gigabytes.
        /// </summary>
        public double Gigabytes => As(InformationUnit.Gigabyte);

        /// <summary>
        ///     Get Information in Kibibits.
        /// </summary>
        public double Kibibits => As(InformationUnit.Kibibit);

        /// <summary>
        ///     Get Information in Kibibytes.
        /// </summary>
        public double Kibibytes => As(InformationUnit.Kibibyte);

        /// <summary>
        ///     Get Information in Kilobits.
        /// </summary>
        public double Kilobits => As(InformationUnit.Kilobit);

        /// <summary>
        ///     Get Information in Kilobytes.
        /// </summary>
        public double Kilobytes => As(InformationUnit.Kilobyte);

        /// <summary>
        ///     Get Information in Mebibits.
        /// </summary>
        public double Mebibits => As(InformationUnit.Mebibit);

        /// <summary>
        ///     Get Information in Mebibytes.
        /// </summary>
        public double Mebibytes => As(InformationUnit.Mebibyte);

        /// <summary>
        ///     Get Information in Megabits.
        /// </summary>
        public double Megabits => As(InformationUnit.Megabit);

        /// <summary>
        ///     Get Information in Megabytes.
        /// </summary>
        public double Megabytes => As(InformationUnit.Megabyte);

        /// <summary>
        ///     Get Information in Pebibits.
        /// </summary>
        public double Pebibits => As(InformationUnit.Pebibit);

        /// <summary>
        ///     Get Information in Pebibytes.
        /// </summary>
        public double Pebibytes => As(InformationUnit.Pebibyte);

        /// <summary>
        ///     Get Information in Petabits.
        /// </summary>
        public double Petabits => As(InformationUnit.Petabit);

        /// <summary>
        ///     Get Information in Petabytes.
        /// </summary>
        public double Petabytes => As(InformationUnit.Petabyte);

        /// <summary>
        ///     Get Information in Tebibits.
        /// </summary>
        public double Tebibits => As(InformationUnit.Tebibit);

        /// <summary>
        ///     Get Information in Tebibytes.
        /// </summary>
        public double Tebibytes => As(InformationUnit.Tebibyte);

        /// <summary>
        ///     Get Information in Terabits.
        /// </summary>
        public double Terabits => As(InformationUnit.Terabit);

        /// <summary>
        ///     Get Information in Terabytes.
        /// </summary>
        public double Terabytes => As(InformationUnit.Terabyte);

        #endregion

        #region Static

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Bit.
        /// </summary>
        public static Information Zero => new Information(0, BaseUnit);

        /// <summary>
        ///     Get Information from Bits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromBits(double bits)
#else
        public static Information FromBits(QuantityValue bits)
#endif
        {
            decimal value = (decimal) bits;
            return new Information(value, InformationUnit.Bit);
        }

        /// <summary>
        ///     Get Information from Bytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromBytes(double bytes)
#else
        public static Information FromBytes(QuantityValue bytes)
#endif
        {
            decimal value = (decimal) bytes;
            return new Information(value, InformationUnit.Byte);
        }

        /// <summary>
        ///     Get Information from Exabits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromExabits(double exabits)
#else
        public static Information FromExabits(QuantityValue exabits)
#endif
        {
            decimal value = (decimal) exabits;
            return new Information(value, InformationUnit.Exabit);
        }

        /// <summary>
        ///     Get Information from Exabytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromExabytes(double exabytes)
#else
        public static Information FromExabytes(QuantityValue exabytes)
#endif
        {
            decimal value = (decimal) exabytes;
            return new Information(value, InformationUnit.Exabyte);
        }

        /// <summary>
        ///     Get Information from Exbibits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromExbibits(double exbibits)
#else
        public static Information FromExbibits(QuantityValue exbibits)
#endif
        {
            decimal value = (decimal) exbibits;
            return new Information(value, InformationUnit.Exbibit);
        }

        /// <summary>
        ///     Get Information from Exbibytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromExbibytes(double exbibytes)
#else
        public static Information FromExbibytes(QuantityValue exbibytes)
#endif
        {
            decimal value = (decimal) exbibytes;
            return new Information(value, InformationUnit.Exbibyte);
        }

        /// <summary>
        ///     Get Information from Gibibits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromGibibits(double gibibits)
#else
        public static Information FromGibibits(QuantityValue gibibits)
#endif
        {
            decimal value = (decimal) gibibits;
            return new Information(value, InformationUnit.Gibibit);
        }

        /// <summary>
        ///     Get Information from Gibibytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromGibibytes(double gibibytes)
#else
        public static Information FromGibibytes(QuantityValue gibibytes)
#endif
        {
            decimal value = (decimal) gibibytes;
            return new Information(value, InformationUnit.Gibibyte);
        }

        /// <summary>
        ///     Get Information from Gigabits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromGigabits(double gigabits)
#else
        public static Information FromGigabits(QuantityValue gigabits)
#endif
        {
            decimal value = (decimal) gigabits;
            return new Information(value, InformationUnit.Gigabit);
        }

        /// <summary>
        ///     Get Information from Gigabytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromGigabytes(double gigabytes)
#else
        public static Information FromGigabytes(QuantityValue gigabytes)
#endif
        {
            decimal value = (decimal) gigabytes;
            return new Information(value, InformationUnit.Gigabyte);
        }

        /// <summary>
        ///     Get Information from Kibibits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromKibibits(double kibibits)
#else
        public static Information FromKibibits(QuantityValue kibibits)
#endif
        {
            decimal value = (decimal) kibibits;
            return new Information(value, InformationUnit.Kibibit);
        }

        /// <summary>
        ///     Get Information from Kibibytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromKibibytes(double kibibytes)
#else
        public static Information FromKibibytes(QuantityValue kibibytes)
#endif
        {
            decimal value = (decimal) kibibytes;
            return new Information(value, InformationUnit.Kibibyte);
        }

        /// <summary>
        ///     Get Information from Kilobits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromKilobits(double kilobits)
#else
        public static Information FromKilobits(QuantityValue kilobits)
#endif
        {
            decimal value = (decimal) kilobits;
            return new Information(value, InformationUnit.Kilobit);
        }

        /// <summary>
        ///     Get Information from Kilobytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromKilobytes(double kilobytes)
#else
        public static Information FromKilobytes(QuantityValue kilobytes)
#endif
        {
            decimal value = (decimal) kilobytes;
            return new Information(value, InformationUnit.Kilobyte);
        }

        /// <summary>
        ///     Get Information from Mebibits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromMebibits(double mebibits)
#else
        public static Information FromMebibits(QuantityValue mebibits)
#endif
        {
            decimal value = (decimal) mebibits;
            return new Information(value, InformationUnit.Mebibit);
        }

        /// <summary>
        ///     Get Information from Mebibytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromMebibytes(double mebibytes)
#else
        public static Information FromMebibytes(QuantityValue mebibytes)
#endif
        {
            decimal value = (decimal) mebibytes;
            return new Information(value, InformationUnit.Mebibyte);
        }

        /// <summary>
        ///     Get Information from Megabits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromMegabits(double megabits)
#else
        public static Information FromMegabits(QuantityValue megabits)
#endif
        {
            decimal value = (decimal) megabits;
            return new Information(value, InformationUnit.Megabit);
        }

        /// <summary>
        ///     Get Information from Megabytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromMegabytes(double megabytes)
#else
        public static Information FromMegabytes(QuantityValue megabytes)
#endif
        {
            decimal value = (decimal) megabytes;
            return new Information(value, InformationUnit.Megabyte);
        }

        /// <summary>
        ///     Get Information from Pebibits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromPebibits(double pebibits)
#else
        public static Information FromPebibits(QuantityValue pebibits)
#endif
        {
            decimal value = (decimal) pebibits;
            return new Information(value, InformationUnit.Pebibit);
        }

        /// <summary>
        ///     Get Information from Pebibytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromPebibytes(double pebibytes)
#else
        public static Information FromPebibytes(QuantityValue pebibytes)
#endif
        {
            decimal value = (decimal) pebibytes;
            return new Information(value, InformationUnit.Pebibyte);
        }

        /// <summary>
        ///     Get Information from Petabits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromPetabits(double petabits)
#else
        public static Information FromPetabits(QuantityValue petabits)
#endif
        {
            decimal value = (decimal) petabits;
            return new Information(value, InformationUnit.Petabit);
        }

        /// <summary>
        ///     Get Information from Petabytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromPetabytes(double petabytes)
#else
        public static Information FromPetabytes(QuantityValue petabytes)
#endif
        {
            decimal value = (decimal) petabytes;
            return new Information(value, InformationUnit.Petabyte);
        }

        /// <summary>
        ///     Get Information from Tebibits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromTebibits(double tebibits)
#else
        public static Information FromTebibits(QuantityValue tebibits)
#endif
        {
            decimal value = (decimal) tebibits;
            return new Information(value, InformationUnit.Tebibit);
        }

        /// <summary>
        ///     Get Information from Tebibytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromTebibytes(double tebibytes)
#else
        public static Information FromTebibytes(QuantityValue tebibytes)
#endif
        {
            decimal value = (decimal) tebibytes;
            return new Information(value, InformationUnit.Tebibyte);
        }

        /// <summary>
        ///     Get Information from Terabits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromTerabits(double terabits)
#else
        public static Information FromTerabits(QuantityValue terabits)
#endif
        {
            decimal value = (decimal) terabits;
            return new Information(value, InformationUnit.Terabit);
        }

        /// <summary>
        ///     Get Information from Terabytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Information FromTerabytes(double terabytes)
#else
        public static Information FromTerabytes(QuantityValue terabytes)
#endif
        {
            decimal value = (decimal) terabytes;
            return new Information(value, InformationUnit.Terabyte);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="InformationUnit" /> to <see cref="Information" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Information unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static Information From(double value, InformationUnit fromUnit)
#else
        public static Information From(QuantityValue value, InformationUnit fromUnit)
#endif
        {
            return new Information((decimal)value, fromUnit);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(InformationUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is Information)) throw new ArgumentException("Expected type Information.", nameof(obj));

            return CompareTo((Information)obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(Information other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another Information within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(Information other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current Information.</returns>
        public override int GetHashCode()
        {
            return new { Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(InformationUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this Information to another Information with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Information with the specified unit.</returns>
        public Information ToUnit(InformationUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new Information(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private decimal AsBaseUnit()
        {
            switch(Unit)
            {
                case InformationUnit.Bit: return _value;
                case InformationUnit.Byte: return _value*8m;
                case InformationUnit.Exabit: return (_value) * 1e18m;
                case InformationUnit.Exabyte: return (_value*8m) * 1e18m;
                case InformationUnit.Exbibit: return (_value) * (1024m * 1024 * 1024 * 1024 * 1024 * 1024);
                case InformationUnit.Exbibyte: return (_value*8m) * (1024m * 1024 * 1024 * 1024 * 1024 * 1024);
                case InformationUnit.Gibibit: return (_value) * (1024m * 1024 * 1024);
                case InformationUnit.Gibibyte: return (_value*8m) * (1024m * 1024 * 1024);
                case InformationUnit.Gigabit: return (_value) * 1e9m;
                case InformationUnit.Gigabyte: return (_value*8m) * 1e9m;
                case InformationUnit.Kibibit: return (_value) * 1024m;
                case InformationUnit.Kibibyte: return (_value*8m) * 1024m;
                case InformationUnit.Kilobit: return (_value) * 1e3m;
                case InformationUnit.Kilobyte: return (_value*8m) * 1e3m;
                case InformationUnit.Mebibit: return (_value) * (1024m * 1024);
                case InformationUnit.Mebibyte: return (_value*8m) * (1024m * 1024);
                case InformationUnit.Megabit: return (_value) * 1e6m;
                case InformationUnit.Megabyte: return (_value*8m) * 1e6m;
                case InformationUnit.Pebibit: return (_value) * (1024m * 1024 * 1024 * 1024 * 1024);
                case InformationUnit.Pebibyte: return (_value*8m) * (1024m * 1024 * 1024 * 1024 * 1024);
                case InformationUnit.Petabit: return (_value) * 1e15m;
                case InformationUnit.Petabyte: return (_value*8m) * 1e15m;
                case InformationUnit.Tebibit: return (_value) * (1024m * 1024 * 1024 * 1024);
                case InformationUnit.Tebibyte: return (_value*8m) * (1024m * 1024 * 1024 * 1024);
                case InformationUnit.Terabit: return (_value) * 1e12m;
                case InformationUnit.Terabyte: return (_value*8m) * 1e12m;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private decimal AsBaseNumericType(InformationUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case InformationUnit.Bit: return baseUnitValue;
                case InformationUnit.Byte: return baseUnitValue/8m;
                case InformationUnit.Exabit: return (baseUnitValue) / 1e18m;
                case InformationUnit.Exabyte: return (baseUnitValue/8m) / 1e18m;
                case InformationUnit.Exbibit: return (baseUnitValue) / (1024m * 1024 * 1024 * 1024 * 1024 * 1024);
                case InformationUnit.Exbibyte: return (baseUnitValue/8m) / (1024m * 1024 * 1024 * 1024 * 1024 * 1024);
                case InformationUnit.Gibibit: return (baseUnitValue) / (1024m * 1024 * 1024);
                case InformationUnit.Gibibyte: return (baseUnitValue/8m) / (1024m * 1024 * 1024);
                case InformationUnit.Gigabit: return (baseUnitValue) / 1e9m;
                case InformationUnit.Gigabyte: return (baseUnitValue/8m) / 1e9m;
                case InformationUnit.Kibibit: return (baseUnitValue) / 1024m;
                case InformationUnit.Kibibyte: return (baseUnitValue/8m) / 1024m;
                case InformationUnit.Kilobit: return (baseUnitValue) / 1e3m;
                case InformationUnit.Kilobyte: return (baseUnitValue/8m) / 1e3m;
                case InformationUnit.Mebibit: return (baseUnitValue) / (1024m * 1024);
                case InformationUnit.Mebibyte: return (baseUnitValue/8m) / (1024m * 1024);
                case InformationUnit.Megabit: return (baseUnitValue) / 1e6m;
                case InformationUnit.Megabyte: return (baseUnitValue/8m) / 1e6m;
                case InformationUnit.Pebibit: return (baseUnitValue) / (1024m * 1024 * 1024 * 1024 * 1024);
                case InformationUnit.Pebibyte: return (baseUnitValue/8m) / (1024m * 1024 * 1024 * 1024 * 1024);
                case InformationUnit.Petabit: return (baseUnitValue) / 1e15m;
                case InformationUnit.Petabyte: return (baseUnitValue/8m) / 1e15m;
                case InformationUnit.Tebibit: return (baseUnitValue) / (1024m * 1024 * 1024 * 1024);
                case InformationUnit.Tebibyte: return (baseUnitValue/8m) / (1024m * 1024 * 1024 * 1024);
                case InformationUnit.Terabit: return (baseUnitValue) / 1e12m;
                case InformationUnit.Terabyte: return (baseUnitValue/8m) / 1e12m;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Information Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out Information result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static InformationUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        #endregion

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(Unit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(InformationUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        /// Represents the largest possible value of Information
        /// </summary>
        public static Information MaxValue => new Information(decimal.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Information
        /// </summary>
        public static Information MinValue => new Information(decimal.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => Information.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Information.BaseDimensions;
    }
}
