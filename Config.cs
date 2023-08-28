using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace MerchantsPlus;

[BackgroundColor(0, 0, 0, 100)]
public class Config : ModConfig
{
    public static Config Instance { get; private set; }

    public override ConfigScope Mode => ConfigScope.ServerSide;
    public override void OnLoaded() => Instance = this;

    [DefaultValue(1.0f)]
    [BackgroundColor(0, 0, 0, 100)]
    public float ShopPriceMultiplier = 1.0f;

    [DefaultValue(true)]
    [BackgroundColor(0, 0, 0, 100)]
    public bool ToggleExtraLife;

    [DefaultValue(false)]
    [BackgroundColor(0, 0, 0, 100)]
    public bool ToggleDialog;

    [DefaultValue(true)]
    [BackgroundColor(0, 0, 0, 100)]
    public bool ToggleDrops;

    [DefaultValue(true)]
    [BackgroundColor(0, 0, 0, 100)]
    public bool ToggleProjectiles;

    [DefaultValue(true)]
    [BackgroundColor(0, 0, 0, 100)]
    public bool ToggleScaling;
}
