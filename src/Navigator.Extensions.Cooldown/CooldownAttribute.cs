namespace Navigator.Extensions.Cooldown;

/// <summary>
/// Specify the cooldown for an action to be triggered again.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class CooldownAttribute : Attribute
{
    /// <summary>
    /// Duration of the cooldown in seconds.
    /// </summary>
    public int Seconds { get; set; } = 300;
}
