// ***********************************************************************
// Copyright (c) 2009 Charlie Poole
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ***********************************************************************

namespace NUnit.Framework.Internal
{
	using System;
#if !NETCF
	using System.Runtime.Serialization;
#endif

	/// <summary>
	/// Thrown when an assertion failed. Here to preserve the inner
	/// exception and hence its stack trace.
	/// </summary>
	[Serializable]
	public class NUnitException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="NUnitException"/> class.
		/// </summary>
		public NUnitException () : base()
		{}

		/// <summary>
		/// Initializes a new instance of the <see cref="NUnitException"/> class.
		/// </summary>
		/// <param name="message">The error message that explains
		/// the reason for the exception</param>
		public NUnitException(string message) : base (message)
		{}

		/// <summary>
		/// Initializes a new instance of the <see cref="NUnitException"/> class.
		/// </summary>
		/// <param name="message">The error message that explains
		/// the reason for the exception</param>
		/// <param name="inner">The exception that caused the
		/// current exception</param>
		public NUnitException(string message, Exception inner) :
			base(message, inner)
		{}

#if !NETCF && !SILVERLIGHT
		/// <summary>
		/// Serialization Constructor
		/// </summary>
		protected NUnitException(SerializationInfo info,
			StreamingContext context) : base(info,context){}
#endif
	}
}
