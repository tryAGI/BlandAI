
#nullable enable

namespace BlandAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Pathway
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        public global::System.Collections.Generic.IList<global::BlandAI.PathwayNode>? Nodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        public global::System.Collections.Generic.IList<global::BlandAI.PathwayEdge>? Edges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pathway" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="nodes"></param>
        /// <param name="edges"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Pathway(
            string? id,
            string? name,
            string? description,
            global::System.Collections.Generic.IList<global::BlandAI.PathwayNode>? nodes,
            global::System.Collections.Generic.IList<global::BlandAI.PathwayEdge>? edges)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Nodes = nodes;
            this.Edges = edges;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pathway" /> class.
        /// </summary>
        public Pathway()
        {
        }
    }
}