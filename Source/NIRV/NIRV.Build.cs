// Copyright 2019 NIRV Team. All Rights Reserved

using UnrealBuildTool;

public class NIRV : ModuleRules
{
	public NIRV(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
	}
}
