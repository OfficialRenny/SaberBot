/*
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * The version of the OpenAPI document: 2.18.0
 * Contact: support@bungie.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Destiny.Client.OpenAPIDateConverter;

namespace Destiny.Model
{
    /// <summary>
    /// ApplicationsApplication
    /// </summary>
    [DataContract(Name = "Applications.Application")]
    public partial class ApplicationsApplication : IEquatable<ApplicationsApplication>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationsApplication" /> class.
        /// </summary>
        /// <param name="applicationId">Unique ID assigned to the application.</param>
        /// <param name="name">Name of the application.</param>
        /// <param name="redirectUrl">URL used to pass the user&#39;s authorization code to the application.</param>
        /// <param name="link">Link to website for the application where a user can learn more about the app..</param>
        /// <param name="scope">Permissions the application needs to work.</param>
        /// <param name="origin">Value of the Origin header sent in requests generated by this application..</param>
        /// <param name="status">Current status of the application..</param>
        /// <param name="creationDate">Date the application was first added to our database..</param>
        /// <param name="statusChanged">Date the application status last changed..</param>
        /// <param name="firstPublished">Date the first time the application status entered the &#39;Public&#39; status..</param>
        /// <param name="team">List of team members who manage this application on Bungie.net. Will always consist of at least the application owner..</param>
        /// <param name="overrideAuthorizeViewName">An optional override for the Authorize view name..</param>
        public ApplicationsApplication(int applicationId = default(int), string name = default(string), string redirectUrl = default(string), string link = default(string), long scope = default(long), string origin = default(string), int status = default(int), DateTime creationDate = default(DateTime), DateTime statusChanged = default(DateTime), DateTime firstPublished = default(DateTime), List<ApplicationsApplicationDeveloper> team = default(List<ApplicationsApplicationDeveloper>), string overrideAuthorizeViewName = default(string))
        {
            this.ApplicationId = applicationId;
            this.Name = name;
            this.RedirectUrl = redirectUrl;
            this.Link = link;
            this.Scope = scope;
            this.Origin = origin;
            this.Status = status;
            this.CreationDate = creationDate;
            this.StatusChanged = statusChanged;
            this.FirstPublished = firstPublished;
            this.Team = team;
            this.OverrideAuthorizeViewName = overrideAuthorizeViewName;
        }

        /// <summary>
        /// Unique ID assigned to the application
        /// </summary>
        /// <value>Unique ID assigned to the application</value>
        [DataMember(Name = "applicationId", EmitDefaultValue = false)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// Name of the application
        /// </summary>
        /// <value>Name of the application</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// URL used to pass the user&#39;s authorization code to the application
        /// </summary>
        /// <value>URL used to pass the user&#39;s authorization code to the application</value>
        [DataMember(Name = "redirectUrl", EmitDefaultValue = false)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Link to website for the application where a user can learn more about the app.
        /// </summary>
        /// <value>Link to website for the application where a user can learn more about the app.</value>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public string Link { get; set; }

        /// <summary>
        /// Permissions the application needs to work
        /// </summary>
        /// <value>Permissions the application needs to work</value>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public long Scope { get; set; }

        /// <summary>
        /// Value of the Origin header sent in requests generated by this application.
        /// </summary>
        /// <value>Value of the Origin header sent in requests generated by this application.</value>
        [DataMember(Name = "origin", EmitDefaultValue = false)]
        public string Origin { get; set; }

        /// <summary>
        /// Current status of the application.
        /// </summary>
        /// <value>Current status of the application.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status { get; set; }

        /// <summary>
        /// Date the application was first added to our database.
        /// </summary>
        /// <value>Date the application was first added to our database.</value>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Date the application status last changed.
        /// </summary>
        /// <value>Date the application status last changed.</value>
        [DataMember(Name = "statusChanged", EmitDefaultValue = false)]
        public DateTime StatusChanged { get; set; }

        /// <summary>
        /// Date the first time the application status entered the &#39;Public&#39; status.
        /// </summary>
        /// <value>Date the first time the application status entered the &#39;Public&#39; status.</value>
        [DataMember(Name = "firstPublished", EmitDefaultValue = false)]
        public DateTime FirstPublished { get; set; }

        /// <summary>
        /// List of team members who manage this application on Bungie.net. Will always consist of at least the application owner.
        /// </summary>
        /// <value>List of team members who manage this application on Bungie.net. Will always consist of at least the application owner.</value>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        public List<ApplicationsApplicationDeveloper> Team { get; set; }

        /// <summary>
        /// An optional override for the Authorize view name.
        /// </summary>
        /// <value>An optional override for the Authorize view name.</value>
        [DataMember(Name = "overrideAuthorizeViewName", EmitDefaultValue = false)]
        public string OverrideAuthorizeViewName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationsApplication {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  StatusChanged: ").Append(StatusChanged).Append("\n");
            sb.Append("  FirstPublished: ").Append(FirstPublished).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  OverrideAuthorizeViewName: ").Append(OverrideAuthorizeViewName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplicationsApplication);
        }

        /// <summary>
        /// Returns true if ApplicationsApplication instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationsApplication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationsApplication input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplicationId == input.ApplicationId ||
                    this.ApplicationId.Equals(input.ApplicationId)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RedirectUrl == input.RedirectUrl ||
                    (this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(input.RedirectUrl))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.Scope == input.Scope ||
                    this.Scope.Equals(input.Scope)
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.StatusChanged == input.StatusChanged ||
                    (this.StatusChanged != null &&
                    this.StatusChanged.Equals(input.StatusChanged))
                ) && 
                (
                    this.FirstPublished == input.FirstPublished ||
                    (this.FirstPublished != null &&
                    this.FirstPublished.Equals(input.FirstPublished))
                ) && 
                (
                    this.Team == input.Team ||
                    this.Team != null &&
                    input.Team != null &&
                    this.Team.SequenceEqual(input.Team)
                ) && 
                (
                    this.OverrideAuthorizeViewName == input.OverrideAuthorizeViewName ||
                    (this.OverrideAuthorizeViewName != null &&
                    this.OverrideAuthorizeViewName.Equals(input.OverrideAuthorizeViewName))
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
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.ApplicationId.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.RedirectUrl != null)
                {
                    hashCode = (hashCode * 59) + this.RedirectUrl.GetHashCode();
                }
                if (this.Link != null)
                {
                    hashCode = (hashCode * 59) + this.Link.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Scope.GetHashCode();
                if (this.Origin != null)
                {
                    hashCode = (hashCode * 59) + this.Origin.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.CreationDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreationDate.GetHashCode();
                }
                if (this.StatusChanged != null)
                {
                    hashCode = (hashCode * 59) + this.StatusChanged.GetHashCode();
                }
                if (this.FirstPublished != null)
                {
                    hashCode = (hashCode * 59) + this.FirstPublished.GetHashCode();
                }
                if (this.Team != null)
                {
                    hashCode = (hashCode * 59) + this.Team.GetHashCode();
                }
                if (this.OverrideAuthorizeViewName != null)
                {
                    hashCode = (hashCode * 59) + this.OverrideAuthorizeViewName.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
