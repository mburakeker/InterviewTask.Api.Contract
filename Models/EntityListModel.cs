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
    public partial class EntityListModel : IEquatable<EntityListModel>
    { 
        /// <summary>
        /// Total items count
        /// </summary>
        /// <value>Total items count</value>
        [DataMember(Name="totalCount")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items")]
        public List<EntityListItemModel> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntityListModel {\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EntityListModel)obj);
        }

        /// <summary>
        /// Returns true if EntityListModel instances are equal
        /// </summary>
        /// <param name="other">Instance of EntityListModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityListModel other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TotalCount == other.TotalCount ||
                    TotalCount != null &&
                    TotalCount.Equals(other.TotalCount)
                ) && 
                (
                    Items == other.Items ||
                    Items != null &&
                    Items.SequenceEqual(other.Items)
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
                    if (TotalCount != null)
                    hashCode = hashCode * 59 + TotalCount.GetHashCode();
                    if (Items != null)
                    hashCode = hashCode * 59 + Items.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EntityListModel left, EntityListModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EntityListModel left, EntityListModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
