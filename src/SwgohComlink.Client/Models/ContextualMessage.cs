using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class ContextualMessage
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public ContextualMessageType Type { get; set; }

    [JsonPropertyName("titleKey")]
    public string? TitleKey { get; set; }

    [JsonPropertyName("textKey")]
    public string? TextKey { get; set; }

    [JsonPropertyName("pointAt")]
    public PointAtElement PointAt { get; set; }

    [JsonPropertyName("appearEvent")]
    public List<string?> AppearEvent { get; set; }

    [JsonPropertyName("dismissEvent")]
    public List<string?> DismissEvent { get; set; }

    [JsonPropertyName("hideEvent")]
    public List<string?> HideEvent { get; set; }

    [JsonPropertyName("actionLink")]
    public string? ActionLink { get; set; }

    [JsonPropertyName("nextMessageId")]
    public string? NextMessageId { get; set; }

    [JsonPropertyName("clientRequirement")]
    public Requirement ClientRequirement { get; set; }

    [JsonPropertyName("characterDialog")]
    public CharacterDialog CharacterDialog { get; set; }

    [JsonPropertyName("nextMessageIdDecline")]
    public string? NextMessageIdDecline { get; set; }

    [JsonPropertyName("canDismissWhileHidden")]
    public bool? CanDismissWhileHidden { get; set; }

    [JsonPropertyName("ftueSubStep")]
    public int? FtueSubStep { get; set; }

    [JsonPropertyName("cantinaCharacterDialog")]
    public CantinaCharacterDialog CantinaCharacterDialog { get; set; }

    [JsonPropertyName("actionLinkDef")]
    public ActionLink ActionLinkDef { get; set; }

    [JsonPropertyName("storePromoDialog")]
    public StorePromoDialog StorePromoDialog { get; set; }

    [JsonPropertyName("showExitButton")]
    public bool? ShowExitButton { get; set; }

}