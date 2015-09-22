
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Reflection.Emit;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Xml;
using System.Linq;
using XianShou.bcyoo.Model.ExtendModel;

namespace XianShou.bcyoo.Common.Helper
{
    /// <summary>
    /// DataReader，DataTable,Xml和实体对象之间的转换辅助类
    /// </summary>
    public static class EntityUtil
    {
        /// <summary>
        /// 把DataReader当前数据赋值给一个实体对象，注意方法不负责回收DataReader对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static T ToEntity<T>(IDataReader dr) where T : class, new()
        {
            if (dr == null) return default(T);
            var builder = DataReaderEntityBuilder<T>.CreateBuilder(dr);
            return builder.Build(dr);
        }

        /// <summary>
        /// 把DataReader中数据赋值给一个List对象，注意方法不负责回收DataReader对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static List<T> ToList<T>(IDataReader dr) where T : class, new()
        {
            var list = new List<T>();
            if (dr == null) return list;
            var builder = DataReaderEntityBuilder<T>.CreateBuilder(dr);
            while (dr.Read()) list.Add(builder.Build(dr));
            return list;
        }

        /// <summary>
        /// 把DataTable中数据赋值给一个实体对象
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <param name="dt"></param>
        public static void SetEntity<TEntity>(TEntity entity, DataTable dt) where TEntity : new()
        {
            if (dt == null || dt.Rows.Count <= 0) return;
            int fieldCount = dt.Columns.Count;
            DataRow item = dt.Rows[0];
            for (int i = 0; i < fieldCount; i++)
            {
                PropertyInfo field = entity.GetType().GetProperty(dt.Columns[i].ColumnName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (field == null) continue;
                if (!field.CanWrite) continue; //如果字段不可写，则跳过
                if (item[i] == null || Convert.IsDBNull(item[i]))
                {
                    field.SetValue(entity, null, null);
                }
                else
                {
                    field.SetValue(entity, item[i], null);
                }
            }
        }

        /// <summary>
        /// 把DataTable中数据赋值给一个List对象
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="list"></param>
        /// <param name="dt"></param>
        public static void SetList<TEntity>(List<TEntity> list, DataTable dt) where TEntity : new()
        {
            if (dt == null || dt.Rows.Count <= 0) return;
            int fieldCount = dt.Columns.Count;
            foreach (DataRow item in dt.Rows)
            {
                TEntity t = (TEntity) Activator.CreateInstance(typeof (TEntity));
                for (int i = 0; i < fieldCount; i++)
                {
                    PropertyInfo field = t.GetType().GetProperty(dt.Columns[i].ColumnName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                    if (field == null) continue;
                    if (!field.CanWrite) continue; //如果字段不可写，则跳过
                    if (item[i] == null || Convert.IsDBNull(item[i]))
                    {
                        field.SetValue(t, null, null);
                    }
                    else
                    {
                        field.SetValue(t, item[i], null);
                    }
                }
                list.Add(t);
            }
        }

        /// <summary>
        /// DataTable 转化为对象
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static TEntity ToEntity<TEntity>(DataTable dt) where TEntity : new()
        {
            if (dt == null || dt.Rows.Count <= 0)
                return default(TEntity);
            TEntity entity = new TEntity();
            SetEntity(entity, dt);
            return entity;
        }

        /// <summary>
        /// DataTable 转化为对象集合
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static List<TEntity> ToList<TEntity>(DataTable dt) where TEntity : new()
        {
            List<TEntity> listEntity = new List<TEntity>();
            SetList(listEntity, dt);
            if (listEntity.Count == 0)
            {
                return null;
            }
            return listEntity;
        }

        /// <summary>
        /// 将DataReader当前数据转换为动态类型实体，注意方法不负责回收DataReader对象
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static dynamic GetDynamic(IDataReader dr)
        {
            if (dr == null) return default(DynamicDataEntity);
            var objDynamic = new DynamicDataEntity();
            for (int i = 0; i < dr.FieldCount; i++) objDynamic[dr.GetName(i)] = dr[i];
            return objDynamic;
        }

        /// <summary>
        /// 将DataReader数据转换为动态类型List，注意方法不负责回收DataReader对象
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static List<dynamic> GetDynamicList(IDataReader dr)
        {
            var list = new List<dynamic>();
            if (dr == null) return list;
            while (dr.Read()) list.Add(GetDynamic(dr));
            return list;
        }

        /// <summary>
        /// 将DataTable数据转换为动态类型List
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static dynamic GetDynamic(DataTable dt)
        {
            if (dt == null || dt.Rows.Count <= 0) return default(DynamicDataEntity);
            dynamic dynamicEntity = new DynamicDataEntity();
            foreach (DataColumn column in dt.Columns)
            {
                dynamicEntity[column.ColumnName] = dt.Rows[0][column];
            }
            return dynamicEntity;
        }

        /// <summary>
        /// 将DataTable数据转换为动态类型List
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static List<dynamic> GetDynamicList(DataTable dt)
        {
            List<dynamic> list = new List<dynamic>();
            foreach (DataRow dataRow in dt.Rows)
            {
                dynamic dynamicEntity = new DynamicDataEntity();
                foreach (DataColumn column in dt.Columns)
                {
                    dynamicEntity[column.ColumnName] = dataRow[column];
                }
                list.Add(dynamicEntity);
            }
            return list;
        }

        /// <summary>
        /// 把source实体对象中的数据按（同名同类型的属性）规则复制到TTarget类型的新实体对象
        /// </summary>
        /// <typeparam name="TTarget">目标实体类型</typeparam>
        /// <typeparam name="TSource">源实体类型</typeparam>
        /// <param name="source">源实体对象</param>
        /// <returns>目标实体对象</returns>
        public static TTarget FastMap<TTarget, TSource>(TSource source)
        {
            if (source != null) return FastMapper<TTarget, TSource>.mapReturnMethod(source);
            return default(TTarget);
        }

        /// <summary>
        /// 把source实体对象中的数据按（同名同类型的属性）规则复制到target实体对象
        /// </summary>
        /// <typeparam name="TTarget">目标实体类型</typeparam>
        /// <typeparam name="TSource">源实体类型</typeparam>
        /// <param name="target">目标实体对象</param>
        /// <param name="source">源实体对象</param>
        public static void FastMap<TTarget, TSource>(TTarget target, TSource source)
        {
            if (source != null && target != null)
            {
                FastMapper<TTarget, TSource>.mapMethod(target, source);
            }
        }

        /// <summary>
        /// 把source实体List对象中的数据按（同名同类型的属性）规则复制到TTarget类型的新实体List对象
        /// </summary>
        /// <typeparam name="TTarget">目标实体类型</typeparam>
        /// <typeparam name="TSource">源实体类型</typeparam>
        /// <param name="source">源实体对象</param>
        /// <returns>目标实体对象</returns>
        public static List<TTarget> FastMapList<TTarget, TSource>(IList<TSource> source)
        {
            return source == null ? null : source.Select(FastMap<TTarget, TSource>).ToList();
        }

        /// <summary>
        /// xml转换成实体类，实体名字要和xml节点一一对应
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="node"></param>
        /// <returns></returns>
        public static T XmlToEntity<T>(XmlNode node) where T : new()
        {
            T model = new T();
            if (node != null)
            {
                PropertyInfo[] propertys = model.GetType().GetProperties();

                foreach (PropertyInfo p in propertys)
                {
                    XmlNode childnode = node.SelectSingleNode(p.Name);
                    if (childnode != null)
                    {
                        object val = childnode.InnerText;
                        p.SetValue(model, val, null);
                    }
                }
            }
            return model;
        }

        #region FastMapper

        private static class FastMapper<TTarget, TSource>
        {
            internal static readonly Func<TSource, TTarget> mapReturnMethod;

            internal static readonly Action<TTarget, TSource> mapMethod;

            static FastMapper()
            {
                mapReturnMethod = CreateMapReturnMethod(typeof(TSource), typeof(TTarget));
                mapMethod = CreateMapMethod(typeof (TTarget), typeof (TSource));
            }

            private static Func<TSource, TTarget> CreateMapReturnMethod(Type sourceType, Type targetType)
            {
                Type ownerType = targetType.IsInterface ? typeof (object) : targetType;
                bool canSkipChecks = SecurityManager.IsGranted(new ReflectionPermission(ReflectionPermissionFlag.MemberAccess));
                DynamicMethod map = new DynamicMethod("MapReturn", targetType, new[] {sourceType}, ownerType, canSkipChecks);

                ILGenerator il = map.GetILGenerator();
                ConstructorInfo ci = targetType.GetConstructor(new Type[0]);
                il.DeclareLocal(targetType);
                il.Emit(OpCodes.Newobj, ci);
                il.Emit(OpCodes.Stloc_0);
                PropertyInfo[] sourceProps = sourceType.GetProperties();
                PropertyInfo[] targetProps = targetType.GetProperties();
                foreach (PropertyInfo sourcePropertyInfo in sourceProps)
                {
                    MethodInfo getMethodInfo = sourcePropertyInfo.GetGetMethod();
                    if (getMethodInfo == null) continue;

                    PropertyInfo targetPropertyInfo = Array.Find(targetProps,
                        p => p.Name == sourcePropertyInfo.Name && p.PropertyType == sourcePropertyInfo.PropertyType
                        );
                    if (targetPropertyInfo == null) continue;

                    MethodInfo setMethodInfo = targetPropertyInfo.GetSetMethod();
                    if (setMethodInfo == null) continue;

                    il.Emit(OpCodes.Ldloc_0);
                    il.Emit(OpCodes.Ldarg_0);
                    il.Emit(OpCodes.Callvirt, getMethodInfo);
                    il.Emit(OpCodes.Callvirt, setMethodInfo);
                }
                il.Emit(OpCodes.Ldloc_0);
                il.Emit(OpCodes.Ret);

                return (Func<TSource, TTarget>)map.CreateDelegate(typeof(Func<TSource, TTarget>));
            }

            private static Action<TTarget, TSource> CreateMapMethod(Type targetType, Type sourceType)
            {
                Type ownerType = targetType.IsInterface ? typeof (object) : targetType;
                bool canSkipChecks = SecurityManager.IsGranted(new ReflectionPermission(ReflectionPermissionFlag.MemberAccess));
                DynamicMethod map = new DynamicMethod("Map", null, new[] {targetType, sourceType}, ownerType, canSkipChecks);

                ILGenerator il = map.GetILGenerator();
                PropertyInfo[] sourceProps = sourceType.GetProperties();
                PropertyInfo[] targetProps = targetType.GetProperties();
                foreach (PropertyInfo sourcePropertyInfo in sourceProps)
                {
                    MethodInfo getMethodInfo = sourcePropertyInfo.GetGetMethod();
                    if (getMethodInfo == null) continue;

                    PropertyInfo targetPropertyInfo = Array.Find(targetProps,
                        p => p.Name == sourcePropertyInfo.Name && p.PropertyType == sourcePropertyInfo.PropertyType
                        );
                    if (targetPropertyInfo == null) continue;

                    MethodInfo setMethodInfo = targetPropertyInfo.GetSetMethod();
                    if (setMethodInfo == null) continue;

                    il.Emit(OpCodes.Ldarg_0);
                    il.Emit(OpCodes.Ldarg_1);
                    il.Emit(OpCodes.Callvirt, getMethodInfo);
                    il.Emit(OpCodes.Callvirt, setMethodInfo);
                }
                il.Emit(OpCodes.Ret);

                return (Action<TTarget, TSource>)map.CreateDelegate(typeof(Action<TTarget, TSource>));
            }
        }

        #endregion

        #region DataReaderEntityBuilder

        /// <summary>
        /// 快速的DataReader转List的类，据说很牛B
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        private class DataReaderEntityBuilder<TEntity>
        {
            private static readonly MethodInfo GetValueMethod = typeof (IDataRecord).GetMethod("get_Item", new[] {typeof (int)});

            private static readonly MethodInfo IsDbNullMethod = typeof (IDataRecord).GetMethod("IsDBNull", new[] {typeof (int)});

            private delegate TEntity Load(IDataRecord dataRecord);

            private Load _handler;

            private DataReaderEntityBuilder()
            {
            }

            public TEntity Build(IDataRecord dataRecord)
            {
                return _handler(dataRecord);
            }

            /// <summary>
            /// 创建DataReaderEntityBuilder对象
            /// </summary>
            /// <param name="dataRecord"></param>
            /// <returns></returns>
            public static DataReaderEntityBuilder<TEntity> CreateBuilder(IDataRecord dataRecord)
            {
                DataReaderEntityBuilder<TEntity> dynamicBuilder = new DataReaderEntityBuilder<TEntity>();
                DynamicMethod method = new DynamicMethod("DynamicCreateEntity", typeof (TEntity), new[] {typeof (IDataRecord)}, typeof (TEntity), true);
                ILGenerator generator = method.GetILGenerator();
                LocalBuilder result = generator.DeclareLocal(typeof (TEntity));
                generator.Emit(OpCodes.Newobj, typeof (TEntity).GetConstructor(Type.EmptyTypes));
                generator.Emit(OpCodes.Stloc, result);
                for (int i = 0; i < dataRecord.FieldCount; i++)
                {
                    PropertyInfo propertyInfo = typeof (TEntity).GetProperty(dataRecord.GetName(i));
                    Label endIfLabel = generator.DefineLabel();
                    if (propertyInfo != null && propertyInfo.GetSetMethod() != null)
                    {
                        generator.Emit(OpCodes.Ldarg_0);
                        generator.Emit(OpCodes.Ldc_I4, i);
                        generator.Emit(OpCodes.Callvirt, IsDbNullMethod);
                        generator.Emit(OpCodes.Brtrue, endIfLabel);
                        generator.Emit(OpCodes.Ldloc, result);
                        generator.Emit(OpCodes.Ldarg_0);
                        generator.Emit(OpCodes.Ldc_I4, i);
                        generator.Emit(OpCodes.Callvirt, GetValueMethod);
                        generator.Emit(OpCodes.Unbox_Any, dataRecord.GetFieldType(i));
                        generator.Emit(OpCodes.Callvirt, propertyInfo.GetSetMethod());
                        generator.MarkLabel(endIfLabel);
                    }
                }
                generator.Emit(OpCodes.Ldloc, result);
                generator.Emit(OpCodes.Ret);
                dynamicBuilder._handler = (Load) method.CreateDelegate(typeof (Load));
                return dynamicBuilder;
            }
        }

        #endregion
    }
}
