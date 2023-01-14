﻿// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System.Collections.Generic;

using Gx.Common;
using Gx.Conclusion;
using Gx.Fs.Rt;
using Gx.Model;

namespace Gx.Fs.Tree
{

    /// <remarks>
    ///  The FamilySearch-proprietary model for a relationship between a child and a pair of parents.
    /// </remarks>
    /// <summary>
    ///  The FamilySearch-proprietary model for a relationship between a child and a pair of parents.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://familysearch.org/v1/", TypeName = "ChildAndParentsRelationship")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://familysearch.org/v1/", ElementName = "childAndParentsRelationship")]
    public partial class ChildAndParentsRelationship : Gx.Conclusion.Subject
    {

        private Gx.Common.ResourceReference _father;
        private Gx.Common.ResourceReference _mother;
        private Gx.Common.ResourceReference _child;
        private System.Collections.Generic.List<Gx.Conclusion.Fact> _fatherFacts;
        private System.Collections.Generic.List<Gx.Conclusion.Fact> _motherFacts;
        /// <summary>
        ///  The father of the child.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "father", Namespace = "http://familysearch.org/v1/")]
        [Newtonsoft.Json.JsonProperty("father")]
        public Gx.Common.ResourceReference Father
        {
            get
            {
                return this._father;
            }
            set
            {
                this._father = value;
            }
        }
        /// <summary>
        ///  The mother of the child.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "mother", Namespace = "http://familysearch.org/v1/")]
        [Newtonsoft.Json.JsonProperty("mother")]
        public Gx.Common.ResourceReference Mother
        {
            get
            {
                return this._mother;
            }
            set
            {
                this._mother = value;
            }
        }
        /// <summary>
        ///  child in the relationship.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "child", Namespace = "http://familysearch.org/v1/")]
        [Newtonsoft.Json.JsonProperty("child")]
        public Gx.Common.ResourceReference Child
        {
            get
            {
                return this._child;
            }
            set
            {
                this._child = value;
            }
        }
        /// <summary>
        ///  The fact conclusions for the father.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fatherFact", Namespace = "http://familysearch.org/v1/")]
        [Newtonsoft.Json.JsonProperty("fatherFacts")]
        public System.Collections.Generic.List<Gx.Conclusion.Fact> FatherFacts
        {
            get
            {
                return this._fatherFacts;
            }
            set
            {
                this._fatherFacts = value;
            }
        }
        /// <summary>
        ///  The fact conclusions for the mother.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "motherFact", Namespace = "http://familysearch.org/v1/")]
        [Newtonsoft.Json.JsonProperty("motherFacts")]
        public System.Collections.Generic.List<Gx.Conclusion.Fact> MotherFacts
        {
            get
            {
                return this._motherFacts;
            }
            set
            {
                this._motherFacts = value;
            }
        }

        /**
         * Accept a visitor.
         *
         * @param visitor The visitor to accept.
         */
        public void Accept(IFamilySearchPlatformModelVisitor visitor)
        {
            visitor.VisitChildAndParentsRelationship(this);
        }

        protected override void Embed(ExtensibleData relationship)
        {
            ChildAndParentsRelationship value = relationship as ChildAndParentsRelationship;

            if (value != null)
            {
                if (value.MotherFacts != null)
                {
                    this.MotherFacts = this.MotherFacts == null ? new List<Fact>() : this.MotherFacts;
                    this.MotherFacts.AddRange(value.MotherFacts);
                }
                if (value.FatherFacts != null)
                {
                    this.FatherFacts = this.FatherFacts == null ? new List<Fact>() : this.FatherFacts;
                    this.FatherFacts.AddRange(value.FatherFacts);
                }
            }

            base.Embed(relationship);
        }

        internal void EmbedInt(ExtensibleData relationship)
        {
            this.Embed(relationship);
        }

        /**
         * Build out this relationship with a reference to the father.
         *
         * @param father the father.
         * @return this.
         */
        public ChildAndParentsRelationship SetFather(ResourceReference father)
        {
            Father = father;
            return this;
        }

        /**
         * Build out this relationship with a reference to the father.
         *
         * @param father the father.
         * @return this.
         */
        public ChildAndParentsRelationship SetFather(Person father)
        {
            Father = new ResourceReference(Util.HashId(father, "father"));
            return this;
        }

        /**
         * Build out this relationship with a reference to the mother.
         *
         * @param mother the mother.
         * @return this.
         */
        public ChildAndParentsRelationship SetMother(ResourceReference mother)
        {
            Mother = mother;
            return this;
        }

        /**
         * Build out this relationship with a reference to the mother.
         *
         * @param mother the mother.
         * @return this.
         */
        public ChildAndParentsRelationship SetMother(Person mother)
        {
            Mother = new ResourceReference(Util.HashId(mother, "mother"));
            return this;
        }

        /**
         * Build out this relationship with a reference to the child.
         *
         * @param child the child.
         * @return this.
         */
        public ChildAndParentsRelationship SetChild(ResourceReference child)
        {
            Child = child;
            return this;
        }

        /**
         * Build out this relationship with a reference to the child.
         *
         * @param child the child.
         * @return this.
         */
        public ChildAndParentsRelationship SetChild(Person child)
        {
            Child = new ResourceReference(Util.HashId(child, "child"));
            return this;
        }

        /**
         * Build out this relationship with a father fact.
         * 
         * @param fact The father fact.
         * @return The father fact.
         */
        public ChildAndParentsRelationship SetFatherFact(Fact fact)
        {
            this.AddFatherFact(fact);
            return this;
        }

        /**
         * Build out this relationship with a mother fact.
         *
         * @param fact The mother fact.
         * @return The mother fact.
         */
        public ChildAndParentsRelationship SetMotherFact(Fact fact)
        {
            this.AddMotherFact(fact);
            return this;
        }

        /**
         * Add a fact conclusion for the father.
         *
         * @param fact The fact conclusion to be added.
         */
        public void AddFatherFact(Fact fact)
        {
            if (fact != null)
            {
                if (_fatherFacts == null)
                {
                    _fatherFacts = new List<Fact>();
                }
                _fatherFacts.Add(fact);
            }
        }

        /**
         * Add a fact conclusion for the mother.
         *
         * @param fact The fact conclusion to be added.
         */
        public void AddMotherFact(Fact fact)
        {
            if (fact != null)
            {
                if (_motherFacts == null)
                {
                    _motherFacts = new List<Fact>();
                }
                _motherFacts.Add(fact);
            }
        }
    }
}
