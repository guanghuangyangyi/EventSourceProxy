﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EventSourceProxy
{
	/// <summary>
	/// The base class for a TraceContextProvider. TraceContextProvider properly determines whether
	/// context is needed for a given method invocation.
	/// </summary>
	public abstract class TraceContextProvider : ITraceContextProvider
	{
		/// <summary>
		/// Provides context information, such as security context, for a trace session.
		/// </summary>
		/// <param name="context">The context of the current invocation.</param>
		/// <returns>A string representing the current context.</returns>
		public abstract string ProvideContext(InvocationContext context);

		/// <summary>
		/// Determines whether the given invocation context requires context to be provided.
		/// </summary>
		/// <param name="context">The context of the invocation.</param>
		/// <returns>True if EventSourceProxy should ask for context, false to skip context generation.</returns>
		public virtual bool ShouldProvideContext(InvocationContext context)
		{
			return true;
		}
	}
}