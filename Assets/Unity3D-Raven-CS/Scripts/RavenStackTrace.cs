﻿using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Unity3DRavenCS
{
	public class RavenStackTrace
	{
		public struct RavenFrame
		{
			public string filename;
			public int lineno;
			public int colno;

			public RavenFrame(StackFrame frame)
			{
				filename = frame.GetFileName();
				lineno = frame.GetFileLineNumber();
				colno = frame.GetFileColumnNumber();
			}
		}
			
		public List<RavenFrame> frames = new List<RavenFrame>();

		public RavenStackTrace(Exception exception)
		{
			StackTrace stackTrace = new StackTrace(exception, true);
			foreach (var frame in stackTrace.GetFrames()) 
			{
				frames.Add(new RavenFrame(frame));
			}
		}
	}
}