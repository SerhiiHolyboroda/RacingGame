using UnrealBuildTool;

public class RacingGameEditorTarget : TargetRules
{
	public RacingGameEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("RacingGame");
	}
}
