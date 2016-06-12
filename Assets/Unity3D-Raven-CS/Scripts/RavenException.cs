﻿using System;
using Newtonsoft.Json;

namespace Unity3DRavenCS
{
	public class RavenException
	{
        public RavenStackTrace stacktrace;
        public string value;
        public string type;
		
		public RavenException(Exception exception)
		{
            this.stacktrace = new RavenStackTrace(exception);
            this.value = exception.Message;
            this.type = exception.GetType().ToString();
        }
	}
}