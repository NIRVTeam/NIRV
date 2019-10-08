// Copyright 2019 NIRV Team. All Rights Reserved

using UnrealBuildTool;
using System.Collections.Generic;

public class NIRVEditorTarget : TargetRules
{
	public NIRVEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("NIRV");
	}
}
