﻿using System;
using System.Collections.Generic;
using System.Linq;
using Nest.Resolvers.Converters;
using Newtonsoft.Json;

namespace Nest
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	[JsonConverter(typeof(ReadAsTypeConverter<RandomScoreFunction>))]
	public interface IRandomScoreFunction
	{
		[JsonProperty(PropertyName = "seed")]
		int? Seed { get; set; }
	}

	public class RandomScoreFunction : IRandomScoreFunction
	{
		int? IRandomScoreFunction.Seed { get; set; }

		public RandomScoreFunction(int seed)
		{
			((IRandomScoreFunction)this).Seed = seed;
		}

		public RandomScoreFunction()
		{
		}
	}
}