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
namespace Demodb
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DatabaseDemoEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DatabaseDemoEntities object using the connection string found in the 'DatabaseDemoEntities' section of the application configuration file.
        /// </summary>
        public DatabaseDemoEntities() : base("name=DatabaseDemoEntities", "DatabaseDemoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseDemoEntities object.
        /// </summary>
        public DatabaseDemoEntities(string connectionString) : base(connectionString, "DatabaseDemoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseDemoEntities object.
        /// </summary>
        public DatabaseDemoEntities(EntityConnection connection) : base(connection, "DatabaseDemoEntities")
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
        public ObjectSet<Table_1> Table_1
        {
            get
            {
                if ((_Table_1 == null))
                {
                    _Table_1 = base.CreateObjectSet<Table_1>("Table_1");
                }
                return _Table_1;
            }
        }
        private ObjectSet<Table_1> _Table_1;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Table_1 EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTable_1(Table_1 table_1)
        {
            base.AddObject("Table_1", table_1);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DatabaseDemoModel", Name="Table_1")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Table_1 : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Table_1 object.
        /// </summary>
        /// <param name="studentId">Initial value of the StudentId property.</param>
        /// <param name="dateOfBirth">Initial value of the DateOfBirth property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="address">Initial value of the Address property.</param>
        public static Table_1 CreateTable_1(global::System.Int32 studentId, global::System.DateTime dateOfBirth, global::System.String name, global::System.String address)
        {
            Table_1 table_1 = new Table_1();
            table_1.StudentId = studentId;
            table_1.DateOfBirth = dateOfBirth;
            table_1.Name = name;
            table_1.Address = address;
            return table_1;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 StudentId
        {
            get
            {
                return _StudentId;
            }
            set
            {
                if (_StudentId != value)
                {
                    OnStudentIdChanging(value);
                    ReportPropertyChanging("StudentId");
                    _StudentId = StructuralObject.SetValidValue(value, "StudentId");
                    ReportPropertyChanged("StudentId");
                    OnStudentIdChanged();
                }
            }
        }
        private global::System.Int32 _StudentId;
        partial void OnStudentIdChanging(global::System.Int32 value);
        partial void OnStudentIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DateOfBirth
        {
            get
            {
                return _DateOfBirth;
            }
            set
            {
                OnDateOfBirthChanging(value);
                ReportPropertyChanging("DateOfBirth");
                _DateOfBirth = StructuralObject.SetValidValue(value, "DateOfBirth");
                ReportPropertyChanged("DateOfBirth");
                OnDateOfBirthChanged();
            }
        }
        private global::System.DateTime _DateOfBirth;
        partial void OnDateOfBirthChanging(global::System.DateTime value);
        partial void OnDateOfBirthChanged();
    
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
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, false, "Address");
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();

        #endregion

    }

    #endregion

}
