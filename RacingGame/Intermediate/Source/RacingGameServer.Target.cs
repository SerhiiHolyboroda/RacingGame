using UnrealBuildTool;

public class RacingGameServerTarget : TargetRules
{
	public RacingGameServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("RacingGame");
	}
}
