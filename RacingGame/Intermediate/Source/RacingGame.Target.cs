using UnrealBuildTool;

public class RacingGameTarget : TargetRules
{
	public RacingGameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("RacingGame");
	}
}
