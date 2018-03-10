﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("GlobalErrorHandler", "MainTable_Status1_FK", "ChildTable", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(GlobalErrorHandler.ChildTable), "MainTable", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GlobalErrorHandler.MainTable), true)]

#endregion

namespace GlobalErrorHandler
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class PracticeEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new PracticeEntities object using the connection string found in the 'PracticeEntities' section of the application configuration file.
        /// </summary>
        public PracticeEntities() : base("name=PracticeEntities", "PracticeEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PracticeEntities object.
        /// </summary>
        public PracticeEntities(string connectionString) : base(connectionString, "PracticeEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PracticeEntities object.
        /// </summary>
        public PracticeEntities(EntityConnection connection) : base(connection, "PracticeEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ChildTable> ChildTables
        {
            get
            {
                if ((_ChildTables == null))
                {
                    _ChildTables = base.CreateObjectSet<ChildTable>("ChildTables");
                }
                return _ChildTables;
            }
        }
        private ObjectSet<ChildTable> _ChildTables;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<MainTable> MainTables
        {
            get
            {
                if ((_MainTables == null))
                {
                    _MainTables = base.CreateObjectSet<MainTable>("MainTables");
                }
                return _MainTables;
            }
        }
        private ObjectSet<MainTable> _MainTables;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Test> Tests
        {
            get
            {
                if ((_Tests == null))
                {
                    _Tests = base.CreateObjectSet<Test>("Tests");
                }
                return _Tests;
            }
        }
        private ObjectSet<Test> _Tests;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ChildTables EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToChildTables(ChildTable childTable)
        {
            base.AddObject("ChildTables", childTable);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the MainTables EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMainTables(MainTable mainTable)
        {
            base.AddObject("MainTables", mainTable);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Tests EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTests(Test test)
        {
            base.AddObject("Tests", test);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="GlobalErrorHandler", Name="ChildTable")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ChildTable : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ChildTable object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static ChildTable CreateChildTable(global::System.Int32 id)
        {
            ChildTable childTable = new ChildTable();
            childTable.Id = id;
            return childTable;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Status1
        {
            get
            {
                return _Status1;
            }
            set
            {
                OnStatus1Changing(value);
                ReportPropertyChanging("Status1");
                _Status1 = StructuralObject.SetValidValue(value, true, "Status1");
                ReportPropertyChanged("Status1");
                OnStatus1Changed();
            }
        }
        private global::System.String _Status1;
        partial void OnStatus1Changing(global::System.String value);
        partial void OnStatus1Changed();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GlobalErrorHandler", "MainTable_Status1_FK", "MainTable")]
        public EntityCollection<MainTable> MainTables
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<MainTable>("GlobalErrorHandler.MainTable_Status1_FK", "MainTable");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<MainTable>("GlobalErrorHandler.MainTable_Status1_FK", "MainTable", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="GlobalErrorHandler", Name="MainTable")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class MainTable : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new MainTable object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="marks">Initial value of the Marks property.</param>
        public static MainTable CreateMainTable(global::System.Int32 id, global::System.String name, global::System.Int32 marks)
        {
            MainTable mainTable = new MainTable();
            mainTable.Id = id;
            mainTable.Name = name;
            mainTable.Marks = marks;
            return mainTable;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Marks
        {
            get
            {
                return _Marks;
            }
            set
            {
                OnMarksChanging(value);
                ReportPropertyChanging("Marks");
                _Marks = StructuralObject.SetValidValue(value, "Marks");
                ReportPropertyChanged("Marks");
                OnMarksChanged();
            }
        }
        private global::System.Int32 _Marks;
        partial void OnMarksChanging(global::System.Int32 value);
        partial void OnMarksChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Status1
        {
            get
            {
                return _Status1;
            }
            set
            {
                OnStatus1Changing(value);
                ReportPropertyChanging("Status1");
                _Status1 = StructuralObject.SetValidValue(value, "Status1");
                ReportPropertyChanged("Status1");
                OnStatus1Changed();
            }
        }
        private Nullable<global::System.Int32> _Status1;
        partial void OnStatus1Changing(Nullable<global::System.Int32> value);
        partial void OnStatus1Changed();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GlobalErrorHandler", "MainTable_Status1_FK", "ChildTable")]
        public ChildTable ChildTable
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ChildTable>("GlobalErrorHandler.MainTable_Status1_FK", "ChildTable").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ChildTable>("GlobalErrorHandler.MainTable_Status1_FK", "ChildTable").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ChildTable> ChildTableReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ChildTable>("GlobalErrorHandler.MainTable_Status1_FK", "ChildTable");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ChildTable>("GlobalErrorHandler.MainTable_Status1_FK", "ChildTable", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="GlobalErrorHandler", Name="Test")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Test : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Test object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Test CreateTest(global::System.Int32 id, global::System.String name)
        {
            Test test = new Test();
            test.ID = id;
            test.Name = name;
            return test;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value, "ID");
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Marks
        {
            get
            {
                return _Marks;
            }
            set
            {
                OnMarksChanging(value);
                ReportPropertyChanging("Marks");
                _Marks = StructuralObject.SetValidValue(value, "Marks");
                ReportPropertyChanged("Marks");
                OnMarksChanged();
            }
        }
        private Nullable<global::System.Int32> _Marks;
        partial void OnMarksChanging(Nullable<global::System.Int32> value);
        partial void OnMarksChanged();

        #endregion

    }

    #endregion

}
