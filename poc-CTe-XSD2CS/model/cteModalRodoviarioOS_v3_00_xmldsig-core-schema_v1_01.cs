﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace CTe.v11 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.portalfiscal.inf.br/cte", IsNullable=false)]
    public partial class rodoOS : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string itemField;
        
        private ItemChoiceType itemElementNameField;
        
        private rodoOSVeic veicField;
        
        private rodoOSInfFretamento infFretamentoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NroRegEstadual", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("TAF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
                this.RaisePropertyChanged("ItemElementName");
            }
        }
        
        /// <remarks/>
        public rodoOSVeic veic {
            get {
                return this.veicField;
            }
            set {
                this.veicField = value;
                this.RaisePropertyChanged("veic");
            }
        }
        
        /// <remarks/>
        public rodoOSInfFretamento infFretamento {
            get {
                return this.infFretamentoField;
            }
            set {
                this.infFretamentoField = value;
                this.RaisePropertyChanged("infFretamento");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/cte", IncludeInSchema=false)]
    public enum ItemChoiceType {
        
        /// <remarks/>
        NroRegEstadual,
        
        /// <remarks/>
        TAF,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/cte")]
    public partial class rodoOSVeic : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string placaField;
        
        private string rENAVAMField;
        
        private rodoOSVeicProp propField;
        
        private TUf ufField;
        
        /// <remarks/>
        public string placa {
            get {
                return this.placaField;
            }
            set {
                this.placaField = value;
                this.RaisePropertyChanged("placa");
            }
        }
        
        /// <remarks/>
        public string RENAVAM {
            get {
                return this.rENAVAMField;
            }
            set {
                this.rENAVAMField = value;
                this.RaisePropertyChanged("RENAVAM");
            }
        }
        
        /// <remarks/>
        public rodoOSVeicProp prop {
            get {
                return this.propField;
            }
            set {
                this.propField = value;
                this.RaisePropertyChanged("prop");
            }
        }
        
        /// <remarks/>
        public TUf UF {
            get {
                return this.ufField;
            }
            set {
                this.ufField = value;
                this.RaisePropertyChanged("UF");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/cte")]
    public partial class rodoOSVeicProp : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string itemField;
        
        private ItemChoiceType1 itemElementNameField;
        
        private string item1Field;
        
        private Item1ChoiceType item1ElementNameField;
        
        private string xNomeField;
        
        private string ieField;
        
        private TUf ufField;
        
        private rodoOSVeicPropTpProp tpPropField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
                this.RaisePropertyChanged("ItemElementName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NroRegEstadual", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("TAF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
        public string Item1 {
            get {
                return this.item1Field;
            }
            set {
                this.item1Field = value;
                this.RaisePropertyChanged("Item1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public Item1ChoiceType Item1ElementName {
            get {
                return this.item1ElementNameField;
            }
            set {
                this.item1ElementNameField = value;
                this.RaisePropertyChanged("Item1ElementName");
            }
        }
        
        /// <remarks/>
        public string xNome {
            get {
                return this.xNomeField;
            }
            set {
                this.xNomeField = value;
                this.RaisePropertyChanged("xNome");
            }
        }
        
        /// <remarks/>
        public string IE {
            get {
                return this.ieField;
            }
            set {
                this.ieField = value;
                this.RaisePropertyChanged("IE");
            }
        }
        
        /// <remarks/>
        public TUf UF {
            get {
                return this.ufField;
            }
            set {
                this.ufField = value;
                this.RaisePropertyChanged("UF");
            }
        }
        
        /// <remarks/>
        public rodoOSVeicPropTpProp tpProp {
            get {
                return this.tpPropField;
            }
            set {
                this.tpPropField = value;
                this.RaisePropertyChanged("tpProp");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/cte", IncludeInSchema=false)]
    public enum ItemChoiceType1 {
        
        /// <remarks/>
        CNPJ,
        
        /// <remarks/>
        CPF,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/cte", IncludeInSchema=false)]
    public enum Item1ChoiceType {
        
        /// <remarks/>
        NroRegEstadual,
        
        /// <remarks/>
        TAF,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/cte")]
    public enum TUf {
        
        /// <remarks/>
        AC,
        
        /// <remarks/>
        AL,
        
        /// <remarks/>
        AM,
        
        /// <remarks/>
        AP,
        
        /// <remarks/>
        BA,
        
        /// <remarks/>
        CE,
        
        /// <remarks/>
        DF,
        
        /// <remarks/>
        ES,
        
        /// <remarks/>
        GO,
        
        /// <remarks/>
        MA,
        
        /// <remarks/>
        MG,
        
        /// <remarks/>
        MS,
        
        /// <remarks/>
        MT,
        
        /// <remarks/>
        PA,
        
        /// <remarks/>
        PB,
        
        /// <remarks/>
        PE,
        
        /// <remarks/>
        PI,
        
        /// <remarks/>
        PR,
        
        /// <remarks/>
        RJ,
        
        /// <remarks/>
        RN,
        
        /// <remarks/>
        RO,
        
        /// <remarks/>
        RR,
        
        /// <remarks/>
        RS,
        
        /// <remarks/>
        SC,
        
        /// <remarks/>
        SE,
        
        /// <remarks/>
        SP,
        
        /// <remarks/>
        TO,
        
        /// <remarks/>
        EX,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/cte")]
    public enum rodoOSVeicPropTpProp {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/cte")]
    public partial class rodoOSInfFretamento : object, System.ComponentModel.INotifyPropertyChanged {
        
        private rodoOSInfFretamentoTpFretamento tpFretamentoField;
        
        private string dhViagemField;
        
        /// <remarks/>
        public rodoOSInfFretamentoTpFretamento tpFretamento {
            get {
                return this.tpFretamentoField;
            }
            set {
                this.tpFretamentoField = value;
                this.RaisePropertyChanged("tpFretamento");
            }
        }
        
        /// <remarks/>
        public string dhViagem {
            get {
                return this.dhViagemField;
            }
            set {
                this.dhViagemField = value;
                this.RaisePropertyChanged("dhViagem");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/cte")]
    public enum rodoOSInfFretamentoTpFretamento {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("Signature", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public partial class SignatureType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private SignedInfoType signedInfoField;
        
        private SignatureValueType signatureValueField;
        
        private KeyInfoType keyInfoField;
        
        private string idField;
        
        /// <remarks/>
        public SignedInfoType SignedInfo {
            get {
                return this.signedInfoField;
            }
            set {
                this.signedInfoField = value;
                this.RaisePropertyChanged("SignedInfo");
            }
        }
        
        /// <remarks/>
        public SignatureValueType SignatureValue {
            get {
                return this.signatureValueField;
            }
            set {
                this.signatureValueField = value;
                this.RaisePropertyChanged("SignatureValue");
            }
        }
        
        /// <remarks/>
        public KeyInfoType KeyInfo {
            get {
                return this.keyInfoField;
            }
            set {
                this.keyInfoField = value;
                this.RaisePropertyChanged("KeyInfo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private SignedInfoTypeCanonicalizationMethod canonicalizationMethodField;
        
        private SignedInfoTypeSignatureMethod signatureMethodField;
        
        private ReferenceType referenceField;
        
        private string idField;
        
        /// <remarks/>
        public SignedInfoTypeCanonicalizationMethod CanonicalizationMethod {
            get {
                return this.canonicalizationMethodField;
            }
            set {
                this.canonicalizationMethodField = value;
                this.RaisePropertyChanged("CanonicalizationMethod");
            }
        }
        
        /// <remarks/>
        public SignedInfoTypeSignatureMethod SignatureMethod {
            get {
                return this.signatureMethodField;
            }
            set {
                this.signatureMethodField = value;
                this.RaisePropertyChanged("SignatureMethod");
            }
        }
        
        /// <remarks/>
        public ReferenceType Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
                this.RaisePropertyChanged("Reference");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeCanonicalizationMethod : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string algorithmField;
        
        public SignedInfoTypeCanonicalizationMethod() {
            this.algorithmField = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
                this.RaisePropertyChanged("Algorithm");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeSignatureMethod : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string algorithmField;
        
        public SignedInfoTypeSignatureMethod() {
            this.algorithmField = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
                this.RaisePropertyChanged("Algorithm");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private TransformType[] transformsField;
        
        private ReferenceTypeDigestMethod digestMethodField;
        
        private byte[] digestValueField;
        
        private string idField;
        
        private string uRIField;
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable=false)]
        public TransformType[] Transforms {
            get {
                return this.transformsField;
            }
            set {
                this.transformsField = value;
                this.RaisePropertyChanged("Transforms");
            }
        }
        
        /// <remarks/>
        public ReferenceTypeDigestMethod DigestMethod {
            get {
                return this.digestMethodField;
            }
            set {
                this.digestMethodField = value;
                this.RaisePropertyChanged("DigestMethod");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] DigestValue {
            get {
                return this.digestValueField;
            }
            set {
                this.digestValueField = value;
                this.RaisePropertyChanged("DigestValue");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string URI {
            get {
                return this.uRIField;
            }
            set {
                this.uRIField = value;
                this.RaisePropertyChanged("URI");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("Type");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class TransformType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string[] xPathField;
        
        private TTransformURI algorithmField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("XPath")]
        public string[] XPath {
            get {
                return this.xPathField;
            }
            set {
                this.xPathField = value;
                this.RaisePropertyChanged("XPath");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TTransformURI Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
                this.RaisePropertyChanged("Algorithm");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public enum TTransformURI {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/2000/09/xmldsig#enveloped-signature")]
        httpwwww3org200009xmldsigenvelopedsignature,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/TR/2001/REC-xml-c14n-20010315")]
        httpwwww3orgTR2001RECxmlc14n20010315,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceTypeDigestMethod : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string algorithmField;
        
        public ReferenceTypeDigestMethod() {
            this.algorithmField = "http://www.w3.org/2000/09/xmldsig#sha1";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
                this.RaisePropertyChanged("Algorithm");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureValueType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string idField;
        
        private byte[] valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="base64Binary")]
        public byte[] Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class KeyInfoType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private X509DataType x509DataField;
        
        private string idField;
        
        /// <remarks/>
        public X509DataType X509Data {
            get {
                return this.x509DataField;
            }
            set {
                this.x509DataField = value;
                this.RaisePropertyChanged("X509Data");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509DataType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private byte[] x509CertificateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] X509Certificate {
            get {
                return this.x509CertificateField;
            }
            set {
                this.x509CertificateField = value;
                this.RaisePropertyChanged("X509Certificate");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
