﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Nest
{
	public class TranslogStats
	{
		[JsonProperty(PropertyName = "operations")]
		public long Operations { get; set; }
	}
}
