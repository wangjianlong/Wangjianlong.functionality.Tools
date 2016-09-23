﻿using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wangjianlong.functionality.Tools.Models;

namespace Wangjianlong.functionality.Tools.Common
{
    public static class FeatureClassManager
    {
        public static IFeatureClass CreateFeatrueClass(string saveFilePath, ISpatialReference spatialReference, esriGeometryType esriGeometryType)
        {
            IWorkspaceFactory workspaceFactory = new ShapefileWorkspaceFactoryClass();
            IWorkspaceName workspaceName = workspaceFactory.Create(System.IO.Path.GetDirectoryName(saveFilePath), System.IO.Path.GetFileNameWithoutExtension(saveFilePath), null, 0);

            IName name = workspaceName as IName;
            IWorkspace workspace = name.Open() as IWorkspace;
            IFeatureWorkspace featureWorkspace = workspace as IFeatureWorkspace;
            IFields fields = new FieldsClass();
            IFieldsEdit fieldsEdit = fields as IFieldsEdit;
            IFieldEdit fieldEdit = new FieldClass();
            fieldEdit.Name_2 = "OID";
            fieldEdit.AliasName_2 = "序号";
            fieldEdit.Type_2 = esriFieldType.esriFieldTypeOID;
            fieldsEdit.AddField(fieldEdit as IField);

            fieldEdit = new FieldClass();
            fieldEdit.Name_2 = "TCMC";
            fieldEdit.AliasName_2 = "图层名称";
            fieldEdit.Type_2 = esriFieldType.esriFieldTypeString;
            fieldsEdit.AddField(fieldEdit as IField);

            IGeometryDefEdit geometryDefEdit = new GeometryDefClass();
            geometryDefEdit.SpatialReference_2 = spatialReference;
            geometryDefEdit.GeometryType_2 = esriGeometryType;

            fieldEdit = new FieldClass();
            fieldEdit.Name_2 = "Shape";
            fieldEdit.AliasName_2 = "形状";
            fieldEdit.Type_2 = esriFieldType.esriFieldTypeGeometry;
            fieldEdit.GeometryDef_2 = geometryDefEdit;
            fieldsEdit.AddField(fieldEdit as IField);
            return featureWorkspace.CreateFeatureClass(System.IO.Path.GetFileNameWithoutExtension(saveFilePath), fields, null, null, esriFeatureType.esriFTSimple, "shape", "");

        }

        public static List<TangField> GainFieldInformation(this IFeatureClass featureClass)
        {
            var list = new List<TangField>();
            var fields = featureClass.Fields;
            for(var i = 0; i < fields.FieldCount; i++)
            {
                var field = fields.get_Field(i);
                if (field.Name.ToUpper().Contains("SHAPE") || field.Name.ToUpper() == "FID")
                {
                    continue;
                }
                list.Add(new TangField() { Name = field.Name, Alias = field.AliasName, Type = field.Type, Index = i });
            }
            return list;
        }

        public static void AddField(IFeatureClass featureClass,IField addField)
        {
            IClass pClass = featureClass as IClass;
            IFieldsEdit fieldsEdit = featureClass.Fields as IFieldsEdit;
            IField field = new FieldClass();
            IFieldEdit2 fieldEdit = field as IFieldEdit2;
            fieldEdit.Type_2 = addField.Type;
            fieldEdit.Name_2 = addField.Name;
            fieldEdit.AliasName_2 = addField.AliasName;
            pClass.AddField(field);
        }

        public static List<string> GetUniqueValue(this IFeatureClass featureClass,string fieldName)
        {
            var list = new List<string>();
            //var dataset = featureClass as IDataset;
            //var queryDef = (dataset.Workspace as IFeatureWorkspace).CreateQueryDef();
            //queryDef.Tables = dataset.Name;
            //queryDef.SubFields = "DISTINCT (" + fieldName.ToUpper() + ")";
            //ICursor cursor = queryDef.Evaluate();
            //var fields = featureClass.Fields;
            //var field = fields.get_Field(fields.FindField(fieldName));
            //var row = cursor.NextRow();
            //while (row != null)
            //{
            //    var val = row.get_Value(0).ToString();
            //    if (field.Type == esriFieldType.esriFieldTypeString)
            //    {
            //        list.Add(string.Format("'{0}'", val));
            //    }
            //    else
            //    {
            //        list.Add(val);
            //    }

            //    row = cursor.NextRow();
            //}
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(cursor);
            int index = featureClass.Fields.FindField(fieldName);
            if (index > -1)
            {
                var featureCursor = featureClass.Search(null, false);
                var feature = featureCursor.NextFeature();
                while (feature != null)
                {
                    var val = feature.get_Value(index).ToString();
                    if (!list.Contains(val))
                    {
                        list.Add(val);
                    }
                    feature = featureCursor.NextFeature();
                }
                System.Runtime.InteropServices.Marshal.ReleaseComObject(featureCursor);
            }
            return list;
        }
    }
}
