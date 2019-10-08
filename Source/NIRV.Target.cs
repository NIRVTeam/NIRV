// Copyright 2019 NIRV Team. All Rights Reserved

using UnrealBuildTool;
using System.Collections.Generic;

public class NIRVTarget : TargetRules
{
	public NIRVTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("NIRV");
	}
}
