/*
 * Agrio Example Service Api
 *
 * Agrio Example Services Documentation
 *
 * OpenAPI spec version: v1
 * Contact: admin@sophietech.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace InterviewTask.Api.Contract.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class EntityListItemModel : IEquatable<EntityListItemModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets StringField
        /// </summary>
        [DataMember(Name="stringField")]
        public string StringField { get; set; }

        /// <summary>
        /// Gets or Sets RelationNameField
        /// </summary>
        [DataMember(Name="relationNameField")]
        public string RelationNameField { get; set; }

        /// <summary>
        /// Gets or Sets IntegerField
        /// </summary>
        [DataMember(Name="integerField")]
        public int? IntegerField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntityListItemModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StringField: ").Append(StringField).Append("\n");
            sb.Append("  RelationNameField: ").Append(RelationNameField).Append("\n");
            sb.Append("  IntegerField: ").Append(IntegerField).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((EntityListItemModel)obj);
        }

        /// <summary>
        /// Returns true if EntityListItemModel instances are equal
        /// </summary>
        /// <param name="other">Instance of EntityListItemModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityListItemModel other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    StringField == other.StringField ||
                    StringField != null &&
                    StringField.Equals(other.StringField)
                ) && 
                (
                    RelationNameField == other.RelationNameField ||
                    RelationNameField != null &&
                    RelationNameField.Equals(other.RelationNameField)
                ) && 
                (
                    IntegerField == other.IntegerField ||
                    IntegerField != null &&
                    IntegerField.Equals(other.IntegerField)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (StringField != null)
                    hashCode = hashCode * 59 + StringField.GetHashCode();
                    if (RelationNameField != null)
                    hashCode = hashCode * 59 + RelationNameField.GetHashCode();
                    if (IntegerField != null)
                    hashCode = hashCode * 59 + IntegerField.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EntityListItemModel left, EntityListItemModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EntityListItemModel left, EntityListItemModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
