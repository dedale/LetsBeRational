//
// This source code resides at www.jaeckel.org/LetsBeRational.7z .
//
// ======================================================================================
// Copyright © 2013-2014 Peter Jäckel.
// 
// Permission to use, copy, modify, and distribute this software is freely granted,
// provided that this notice is preserved.
//
// WARRANTY DISCLAIMER
// The Software is provided "as is" without warranty of any kind, either express or implied,
// including without limitation any implied warranties of condition, uninterrupted use,
// merchantability, fitness for a particular purpose, or non-infringement.
// ======================================================================================
//

using System;

namespace Lets.Be
{
	static partial class Rational
	{
		const double ONE_OVER_SQRT_TWO     = 0.7071067811865475244008443621048490392848359376887;
        const double ONE_OVER_SQRT_TWO_PI  = 0.3989422804014326779399460599343818684758586311649;
        const double SQRT_TWO_PI           = 2.506628274631000502415765284811045253006986740610;

        static double norm_pdf(double x) { return ONE_OVER_SQRT_TWO_PI * Math.Exp(-.5 * x * x); }
    }
}
