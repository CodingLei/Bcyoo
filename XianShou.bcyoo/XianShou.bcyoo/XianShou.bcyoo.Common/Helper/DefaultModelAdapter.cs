using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace XianShou.bcyoo.Common.Helper
{
    /// <summary>
    ///     默认模型转换器
    /// </summary>
    public class DefaultModelAdapter
    {
        private static DefaultModelAdapter _instance;
        private static readonly Object[] EmptyArgs = new Object[] {};
        /*
         *          这样使用
         *     DefaultModelAdapter.Instance.Transfer<目标类型>(被转换数据);
         */
        //需要考虑映射的成员类型
        private static readonly MemberTypes[] MappingMemberTypes = new[] {MemberTypes.Field, MemberTypes.Property};
        private MethodInfo _methodTransfer;

        private DefaultModelAdapter()
        {
        }

        /// <summary>
        ///     调用实例
        /// </summary>
        public static DefaultModelAdapter Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DefaultModelAdapter();
                    _instance._methodTransfer = _instance.GetType().GetMethod("Transfer");
                }
                return _instance;
            }
        }

        /// <summary>
        ///     转换数据为目标类型
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="data">被转换数据</param>
        /// <returns>转换为目标类型的结果</returns>
        public T Transfer<T>(object data)
        {
            if (data == null)
                return default(T);

            //如果是简单类型成员，直接赋值
            if (IsSimpleType(typeof (T)))
            {
                if (IsSimpleType(data.GetType()))
                    return (T) data;
                return default(T);
            }

            //成员映射
            IEnumerable<MemberInfo> membersInData =
                data.GetType().GetMembers(BindingFlags.Public | BindingFlags.Instance).Where(
                    m => MappingMemberTypes.Contains(m.MemberType));
            IEnumerable<MemberInfo> membersInModel = typeof (T).GetMembers(BindingFlags.Public | BindingFlags.Instance)
                                                               .Where(
                                                                   m => MappingMemberTypes.Contains(m.MemberType))
                                                               .Where(m => m.MemberType != MemberTypes.Property
                                                                           ||
                                                                           (((PropertyInfo) m).CanWrite &&
                                                                            ((PropertyInfo) m).GetSetMethod() != null));

            IEnumerable<MemberInfo> similarMembers =
                membersInModel.Where(m => membersInData.Any(d => d.Name.Equals(m.Name)));

            T model = default(T);
            //默认构造函数
            ConstructorInfo modelConstructor = typeof (T).GetConstructor(Type.EmptyTypes);
            if (modelConstructor != null && modelConstructor.IsPublic)
            {
                model = (T) modelConstructor.Invoke(null);
            }

            //成员赋值
            if (model != null)
            {
                //如果都是集合类，直接添加
                if (IsCollectionType(typeof (T)) && IsCollectionType(data.GetType()))
                {
                    SetValues((ICollection) data, model);
                }
                else
                {
                    foreach (MemberInfo memberTo in similarMembers)
                    {
                        MemberInfo memberFrom = membersInData.First(m => m.Name.Equals(memberTo.Name));
                        if (IsSameType(memberFrom, memberTo))
                        {
                            typeof (T).InvokeMember(memberTo.Name, BindingFlags.SetField | BindingFlags.SetProperty,
                                                    null,
                                                    model,
                                                    new[]
                                                        {
                                                            data.GetType().InvokeMember(memberTo.Name,
                                                                                        BindingFlags.GetField |
                                                                                        BindingFlags.GetProperty, null,
                                                                                        data,
                                                                                        EmptyArgs)
                                                        });
                        }
                        else
                        {
                            Type typeMemberTo = GetMemberType(memberTo);
                            Type typeMemberFrom = GetMemberType(memberFrom);
                            if (IsCollectionType(typeMemberTo) && IsCollectionType(typeMemberFrom))
                            {
                                //如果是集合类
                                var collectionFrom =
                                    (ICollection)
                                    data.GetType().InvokeMember(memberTo.Name,
                                                                BindingFlags.GetField | BindingFlags.GetProperty, null,
                                                                data,
                                                                EmptyArgs);

                                if (collectionFrom != null)
                                {
                                    int dataCount = collectionFrom.Count;

                                    //实例化member_to
                                    typeof (T).InvokeMember(memberTo.Name,
                                                            BindingFlags.SetField | BindingFlags.SetProperty,
                                                            null, model,
                                                            new object[] {CreateCollectionInstance(typeMemberTo, dataCount)});

                                    //遍历member_from给member_to赋值
                                    object collectionTo = typeof (T).InvokeMember(memberTo.Name,
                                                                                  BindingFlags.GetField |
                                                                                  BindingFlags.GetProperty, null, model,
                                                                                  EmptyArgs);
                                    SetValues(collectionFrom, collectionTo);
                                }
                            }
                            else
                            {
                                //递归转换
                                MethodInfo genericMethod = _methodTransfer.MakeGenericMethod(typeMemberTo);
                                typeof (T).InvokeMember(memberTo.Name, BindingFlags.SetField | BindingFlags.SetProperty,
                                                        null, model,
                                                        new[]
                                                            {
                                                                genericMethod.Invoke(this,
                                                                                     new[]
                                                                                         {
                                                                                             data.GetType()
                                                                                                 .InvokeMember(
                                                                                                     memberTo.Name,
                                                                                                     BindingFlags
                                                                                                         .GetField |
                                                                                                     BindingFlags
                                                                                                         .GetProperty,
                                                                                                     null, data,
                                                                                                     EmptyArgs)
                                                                                         })
                                                            });
                            }
                        }
                    }
                }
                return model;
            }
            return default(T);
        }

        private bool IsSimpleType(Type t)
        {
            return t.IsValueType || t == typeof (String);
        }

        private bool IsSameType(MemberInfo miA, MemberInfo miB)
        {
            return GetMemberType(miA) == GetMemberType(miB);
        }

        private bool IsCollectionType(Type t)
        {
            return t.GetInterface("ICollection") != null;
        }

        /// <summary>
        ///     获取集合类元素类型
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        private Type GetElementType(Type t)
        {
            if (t.IsArray)
                return t.GetElementType();
            return t.GetGenericArguments()[0];
        }

        /// <summary>
        ///     创建集合实例
        /// </summary>
        /// <param name="t"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        private ICollection CreateCollectionInstance(Type t, int count)
        {
            if (t.IsArray)
                return Array.CreateInstance(t.GetElementType(), count);
            return (ICollection) Activator.CreateInstance(t);
        }

        /// <summary>
        ///     集合类赋值
        /// </summary>
        /// <param name="dataFrom"></param>
        /// <param name="dataTo"></param>
        private void SetValues(ICollection dataFrom, Object dataTo)
        {
            //目标类型
            Type targetType = dataTo.GetType();
            //目标集合类泛型元素类型
            Type collectionToGenericElementType = GetElementType(targetType);
            //源集合类泛型元素类型
            Type collectionFromGenericElementType = GetElementType(dataFrom.GetType());

            IEnumerator enumerator = dataFrom.GetEnumerator();

            if (targetType.IsArray && !((Array) dataTo).IsReadOnly)
            {
                if (collectionToGenericElementType == collectionFromGenericElementType)
                {
                    dataFrom.CopyTo((Array) dataTo, 0);
                }
                else
                {
                    int i = 0;
                    while (enumerator.MoveNext())
                    {
                        //递归转换
                        MethodInfo genericMethod = _methodTransfer.MakeGenericMethod(collectionToGenericElementType);
                        if (i < ((Array) dataTo).Length)
                        {
                            ((Array) dataTo).SetValue(genericMethod.Invoke(this, new[] {enumerator.Current}), i);
                        }
                        i++;
                    }
                }
            }
            else
            {
                if (collectionToGenericElementType == collectionFromGenericElementType)
                {
                    while (enumerator.MoveNext())
                    {
                        targetType.InvokeMember("Add", BindingFlags.InvokeMethod, null, dataTo,
                                                new[] {enumerator.Current});
                    }
                }
                else
                {
                    while (enumerator.MoveNext())
                    {
                        //递归转换
                        MethodInfo genericMethod = _methodTransfer.MakeGenericMethod(collectionToGenericElementType);
                        targetType.InvokeMember("Add", BindingFlags.InvokeMethod, null, dataTo,
                                                new[] {genericMethod.Invoke(this, new[] {enumerator.Current})});
                    }
                }
            }
        }

        private Type GetMemberType(MemberInfo mi)
        {
            switch (mi.MemberType)
            {
                case MemberTypes.Field:
                    return ((FieldInfo) mi).FieldType;
                case MemberTypes.Property:
                    return ((PropertyInfo) mi).PropertyType;
                default:
                    return null;
            }
        }
    }
}