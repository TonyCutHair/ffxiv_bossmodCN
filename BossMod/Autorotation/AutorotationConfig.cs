namespace BossMod.Autorotation;

[ConfigDisplay(Name = "自动轮换", Order = 5)]
public sealed class AutorotationConfig : ConfigNode
{
    [PropertyDisplay("显示游戏内UI")]
    public bool ShowUI = false;

    public enum DtrStatus
    {
        [PropertyDisplay("禁用")]
        None,
        [PropertyDisplay("仅显示文本")]
        TextOnly,
        [PropertyDisplay("显示图标")]
        Icon
    }

    [PropertyDisplay("在服务器信息栏显示自动轮换预设")]
    public DtrStatus ShowDTR = DtrStatus.None;

    [PropertyDisplay("在服务器信息栏显示性能统计")]
    public bool ShowStatsDTR = false;

    [PropertyDisplay("隐藏内置预设", tooltip: "如果您已创建自己的预设并不再需要包含的默认值，此选项将阻止它们在自动轮换和预设编辑器窗口中显示。", since: "0.0.0.253")]
    public bool HideDefaultPreset = false;

    public bool SuggestHealerAI = true;

    [PropertyDisplay("在世界中显示位置提示", tooltip: "显示位置技能的提示，指示移动到目标的侧翼或后方")]
    public bool ShowPositionals = false;

    [PropertyDisplay("在死亡时自动禁用自动轮换", since: "0.4.4.1")]
    public bool ClearPresetOnDeath = true;

    [PropertyDisplay("退出战斗时自动禁用自动轮换")]
    public bool ClearPresetOnCombatEnd = false;

    [PropertyDisplay("触发诱捕陷阱时自动禁用自动轮换", tooltip: "仅适用于深层地下城", since: "0.4.4.1")]
    public bool ClearPresetOnLuring = false;

    [PropertyDisplay("退出战斗时自动重新启用强制禁用的自动轮换")]
    public bool ClearForceDisableOnCombatEnd = true;

    [PropertyDisplay("提前拉怪阈值", tooltip: "如果玩家在倒计时长于此值时与BOSS进入战斗，则被视为忍者拉怪，自动轮换被强制禁用")]
    [PropertySlider(0, 30, Speed = 1)]
    public float EarlyPullThreshold = 1.5f;
}
