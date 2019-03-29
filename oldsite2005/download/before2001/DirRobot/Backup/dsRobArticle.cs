﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.0.3705.288
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace DirRobot {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class dsRobArticle : DataSet {
        
        private RobArticleDataTable tableRobArticle;
        
        public dsRobArticle() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected dsRobArticle(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["RobArticle"] != null)) {
                    this.Tables.Add(new RobArticleDataTable(ds.Tables["RobArticle"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public RobArticleDataTable RobArticle {
            get {
                return this.tableRobArticle;
            }
        }
        
        public override DataSet Clone() {
            dsRobArticle cln = ((dsRobArticle)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["RobArticle"] != null)) {
                this.Tables.Add(new RobArticleDataTable(ds.Tables["RobArticle"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tableRobArticle = ((RobArticleDataTable)(this.Tables["RobArticle"]));
            if ((this.tableRobArticle != null)) {
                this.tableRobArticle.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "dsRobArticle";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/dsRobArticle.xsd";
            this.Locale = new System.Globalization.CultureInfo("zh-CN");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableRobArticle = new RobArticleDataTable();
            this.Tables.Add(this.tableRobArticle);
        }
        
        private bool ShouldSerializeRobArticle() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void RobArticleRowChangeEventHandler(object sender, RobArticleRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class RobArticleDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnarticleid;
            
            private DataColumn columnclassid;
            
            private DataColumn columncontent;
            
            private DataColumn columnNclassid;
            
            private DataColumn columnorder;
            
            private DataColumn columntitle;
            
            private DataColumn columnhits;
            
            private DataColumn columnNkey;
            
            private DataColumn columnwritefrom;
            
            private DataColumn columnwriter;
            
            internal RobArticleDataTable() : 
                    base("RobArticle") {
                this.InitClass();
            }
            
            internal RobArticleDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn articleidColumn {
                get {
                    return this.columnarticleid;
                }
            }
            
            internal DataColumn classidColumn {
                get {
                    return this.columnclassid;
                }
            }
            
            internal DataColumn contentColumn {
                get {
                    return this.columncontent;
                }
            }
            
            internal DataColumn NclassidColumn {
                get {
                    return this.columnNclassid;
                }
            }
            
            internal DataColumn orderColumn {
                get {
                    return this.columnorder;
                }
            }
            
            internal DataColumn titleColumn {
                get {
                    return this.columntitle;
                }
            }
            
            internal DataColumn hitsColumn {
                get {
                    return this.columnhits;
                }
            }
            
            internal DataColumn NkeyColumn {
                get {
                    return this.columnNkey;
                }
            }
            
            internal DataColumn writefromColumn {
                get {
                    return this.columnwritefrom;
                }
            }
            
            internal DataColumn writerColumn {
                get {
                    return this.columnwriter;
                }
            }
            
            public RobArticleRow this[int index] {
                get {
                    return ((RobArticleRow)(this.Rows[index]));
                }
            }
            
            public event RobArticleRowChangeEventHandler RobArticleRowChanged;
            
            public event RobArticleRowChangeEventHandler RobArticleRowChanging;
            
            public event RobArticleRowChangeEventHandler RobArticleRowDeleted;
            
            public event RobArticleRowChangeEventHandler RobArticleRowDeleting;
            
            public void AddRobArticleRow(RobArticleRow row) {
                this.Rows.Add(row);
            }
            
            public RobArticleRow AddRobArticleRow(int classid, string content, int Nclassid, int order, string title, int hits, string Nkey, string writefrom, string writer) {
                RobArticleRow rowRobArticleRow = ((RobArticleRow)(this.NewRow()));
                rowRobArticleRow.ItemArray = new object[] {
                        null,
                        classid,
                        content,
                        Nclassid,
                        order,
                        title,
                        hits,
                        Nkey,
                        writefrom,
                        writer};
                this.Rows.Add(rowRobArticleRow);
                return rowRobArticleRow;
            }
            
            public RobArticleRow FindByarticleid(int articleid) {
                return ((RobArticleRow)(this.Rows.Find(new object[] {
                            articleid})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                RobArticleDataTable cln = ((RobArticleDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new RobArticleDataTable();
            }
            
            internal void InitVars() {
                this.columnarticleid = this.Columns["articleid"];
                this.columnclassid = this.Columns["classid"];
                this.columncontent = this.Columns["content"];
                this.columnNclassid = this.Columns["Nclassid"];
                this.columnorder = this.Columns["order"];
                this.columntitle = this.Columns["title"];
                this.columnhits = this.Columns["hits"];
                this.columnNkey = this.Columns["Nkey"];
                this.columnwritefrom = this.Columns["writefrom"];
                this.columnwriter = this.Columns["writer"];
            }
            
            private void InitClass() {
                this.columnarticleid = new DataColumn("articleid", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnarticleid);
                this.columnclassid = new DataColumn("classid", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnclassid);
                this.columncontent = new DataColumn("content", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columncontent);
                this.columnNclassid = new DataColumn("Nclassid", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnNclassid);
                this.columnorder = new DataColumn("order", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnorder);
                this.columntitle = new DataColumn("title", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columntitle);
                this.columnhits = new DataColumn("hits", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnhits);
                this.columnNkey = new DataColumn("Nkey", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnNkey);
                this.columnwritefrom = new DataColumn("writefrom", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnwritefrom);
                this.columnwriter = new DataColumn("writer", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnwriter);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnarticleid}, true));
                this.columnarticleid.AutoIncrement = true;
                this.columnarticleid.AllowDBNull = false;
                this.columnarticleid.Unique = true;
            }
            
            public RobArticleRow NewRobArticleRow() {
                return ((RobArticleRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new RobArticleRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(RobArticleRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.RobArticleRowChanged != null)) {
                    this.RobArticleRowChanged(this, new RobArticleRowChangeEvent(((RobArticleRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.RobArticleRowChanging != null)) {
                    this.RobArticleRowChanging(this, new RobArticleRowChangeEvent(((RobArticleRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.RobArticleRowDeleted != null)) {
                    this.RobArticleRowDeleted(this, new RobArticleRowChangeEvent(((RobArticleRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.RobArticleRowDeleting != null)) {
                    this.RobArticleRowDeleting(this, new RobArticleRowChangeEvent(((RobArticleRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveRobArticleRow(RobArticleRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class RobArticleRow : DataRow {
            
            private RobArticleDataTable tableRobArticle;
            
            internal RobArticleRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableRobArticle = ((RobArticleDataTable)(this.Table));
            }
            
            public int articleid {
                get {
                    return ((int)(this[this.tableRobArticle.articleidColumn]));
                }
                set {
                    this[this.tableRobArticle.articleidColumn] = value;
                }
            }
            
            public int classid {
                get {
                    try {
                        return ((int)(this[this.tableRobArticle.classidColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableRobArticle.classidColumn] = value;
                }
            }
            
            public string content {
                get {
                    try {
                        return ((string)(this[this.tableRobArticle.contentColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableRobArticle.contentColumn] = value;
                }
            }
            
            public int Nclassid {
                get {
                    try {
                        return ((int)(this[this.tableRobArticle.NclassidColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableRobArticle.NclassidColumn] = value;
                }
            }
            
            public int order {
                get {
                    try {
                        return ((int)(this[this.tableRobArticle.orderColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableRobArticle.orderColumn] = value;
                }
            }
            
            public string title {
                get {
                    try {
                        return ((string)(this[this.tableRobArticle.titleColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableRobArticle.titleColumn] = value;
                }
            }
            
            public int hits {
                get {
                    try {
                        return ((int)(this[this.tableRobArticle.hitsColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableRobArticle.hitsColumn] = value;
                }
            }
            
            public string Nkey {
                get {
                    try {
                        return ((string)(this[this.tableRobArticle.NkeyColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableRobArticle.NkeyColumn] = value;
                }
            }
            
            public string writefrom {
                get {
                    try {
                        return ((string)(this[this.tableRobArticle.writefromColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableRobArticle.writefromColumn] = value;
                }
            }
            
            public string writer {
                get {
                    try {
                        return ((string)(this[this.tableRobArticle.writerColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableRobArticle.writerColumn] = value;
                }
            }
            
            public bool IsclassidNull() {
                return this.IsNull(this.tableRobArticle.classidColumn);
            }
            
            public void SetclassidNull() {
                this[this.tableRobArticle.classidColumn] = System.Convert.DBNull;
            }
            
            public bool IscontentNull() {
                return this.IsNull(this.tableRobArticle.contentColumn);
            }
            
            public void SetcontentNull() {
                this[this.tableRobArticle.contentColumn] = System.Convert.DBNull;
            }
            
            public bool IsNclassidNull() {
                return this.IsNull(this.tableRobArticle.NclassidColumn);
            }
            
            public void SetNclassidNull() {
                this[this.tableRobArticle.NclassidColumn] = System.Convert.DBNull;
            }
            
            public bool IsorderNull() {
                return this.IsNull(this.tableRobArticle.orderColumn);
            }
            
            public void SetorderNull() {
                this[this.tableRobArticle.orderColumn] = System.Convert.DBNull;
            }
            
            public bool IstitleNull() {
                return this.IsNull(this.tableRobArticle.titleColumn);
            }
            
            public void SettitleNull() {
                this[this.tableRobArticle.titleColumn] = System.Convert.DBNull;
            }
            
            public bool IshitsNull() {
                return this.IsNull(this.tableRobArticle.hitsColumn);
            }
            
            public void SethitsNull() {
                this[this.tableRobArticle.hitsColumn] = System.Convert.DBNull;
            }
            
            public bool IsNkeyNull() {
                return this.IsNull(this.tableRobArticle.NkeyColumn);
            }
            
            public void SetNkeyNull() {
                this[this.tableRobArticle.NkeyColumn] = System.Convert.DBNull;
            }
            
            public bool IswritefromNull() {
                return this.IsNull(this.tableRobArticle.writefromColumn);
            }
            
            public void SetwritefromNull() {
                this[this.tableRobArticle.writefromColumn] = System.Convert.DBNull;
            }
            
            public bool IswriterNull() {
                return this.IsNull(this.tableRobArticle.writerColumn);
            }
            
            public void SetwriterNull() {
                this[this.tableRobArticle.writerColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class RobArticleRowChangeEvent : EventArgs {
            
            private RobArticleRow eventRow;
            
            private DataRowAction eventAction;
            
            public RobArticleRowChangeEvent(RobArticleRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public RobArticleRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
