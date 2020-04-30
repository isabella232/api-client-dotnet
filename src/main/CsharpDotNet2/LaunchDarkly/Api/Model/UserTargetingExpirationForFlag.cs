using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LaunchDarkly.Api.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserTargetingExpirationForFlag {
    /// <summary>
    /// Date scheduled for expiration
    /// </summary>
    /// <value>Date scheduled for expiration</value>
    [DataMember(Name="expirationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expirationDate")]
    public int? ExpirationDate { get; set; }

    /// <summary>
    /// the ID of the variation that the user is targeted on a flag
    /// </summary>
    /// <value>the ID of the variation that the user is targeted on a flag</value>
    [DataMember(Name="variationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variationId")]
    public string VariationId { get; set; }

    /// <summary>
    /// Unique identifier for the user
    /// </summary>
    /// <value>Unique identifier for the user</value>
    [DataMember(Name="userKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userKey")]
    public string UserKey { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets ResourceId
    /// </summary>
    [DataMember(Name="_resourceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_resourceId")]
    public UserTargetingExpirationResourceIdForFlag ResourceId { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="_links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_links")]
    public Links Links { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_version")]
    public int? Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserTargetingExpirationForFlag {\n");
      sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
      sb.Append("  VariationId: ").Append(VariationId).Append("\n");
      sb.Append("  UserKey: ").Append(UserKey).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
