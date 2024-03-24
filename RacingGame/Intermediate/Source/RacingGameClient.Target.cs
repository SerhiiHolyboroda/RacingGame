using UnrealBuildTool;

public class RacingGameClientTarget : TargetRules
{
	public RacingGameClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("RacingGame");
	}
}
