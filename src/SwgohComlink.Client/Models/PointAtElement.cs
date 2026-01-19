using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class PointAtElement
{
    [JsonPropertyName("elementId")]
    public string? ElementId { get; set; }

    [JsonPropertyName("offsetX")]
    public int? OffsetX { get; set; }

    [JsonPropertyName("offsetY")]
    public int? OffsetY { get; set; }

    [JsonPropertyName("rotation")]
    public double? Rotation { get; set; }

    [JsonPropertyName("textOffsetX")]
    public int? TextOffsetX { get; set; }

    [JsonPropertyName("textOffsetY")]
    public int? TextOffsetY { get; set; }

    [JsonPropertyName("textOffsetAnchor")]
    public string? TextOffsetAnchor { get; set; }

    [JsonPropertyName("update")]
    public bool? Update { get; set; }

    [JsonPropertyName("clamp")]
    public bool? Clamp { get; set; }

    [JsonPropertyName("rotationBehavior")]
    public PointAtRotationBehavior RotationBehavior { get; set; }

    [JsonPropertyName("delaySeconds")]
    public double? DelaySeconds { get; set; }

    [JsonPropertyName("showArrow")]
    public bool? ShowArrow { get; set; }

    [JsonPropertyName("showHighlight")]
    public bool? ShowHighlight { get; set; }

    [JsonPropertyName("imageSource")]
    public string? ImageSource { get; set; }

    [JsonPropertyName("imageWidth")]
    public int? ImageWidth { get; set; }

    [JsonPropertyName("imageHeight")]
    public int? ImageHeight { get; set; }

    [JsonPropertyName("imageOffsetX")]
    public int? ImageOffsetX { get; set; }

    [JsonPropertyName("imageOffsetY")]
    public int? ImageOffsetY { get; set; }

    [JsonPropertyName("pointerType")]
    public PointerType PointerType { get; set; }

    [JsonPropertyName("tapDismiss")]
    public bool? TapDismiss { get; set; }

    [JsonPropertyName("scrimVisible")]
    public bool? ScrimVisible { get; set; }

    [JsonPropertyName("scrimBlocking")]
    public bool? ScrimBlocking { get; set; }

    [JsonPropertyName("showText")]
    public bool? ShowText { get; set; }

    [JsonPropertyName("showBartender")]
    public bool? ShowBartender { get; set; }

    [JsonPropertyName("bartenderTexture")]
    public string? BartenderTexture { get; set; }

}