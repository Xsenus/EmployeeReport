using System;
using System.Collections;
using System.ComponentModel;

namespace EmployeeReportBL.PropertyGrid
{
    public class PropertySorter : ExpandableObjectConverter
    {
        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        /// <summary>
        /// Возвращает упорядоченный список свойств.
        /// </summary>
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(value, attributes);
            ArrayList orderedProperties = new ArrayList();

            foreach (PropertyDescriptor pd in pdc)
            {
                Attribute attribute = pd.Attributes[typeof(PropertyOrderAttribute)];

                if (attribute != null)
                {
                    // атрибут есть - используем номер п/п из него
                    PropertyOrderAttribute poa = (PropertyOrderAttribute)attribute;
                    orderedProperties.Add(new PropertyOrderPair(pd.Name, poa.Order));
                }
                else
                {
                    // атрибута нет – считаем, что 0
                    orderedProperties.Add(new PropertyOrderPair(pd.Name, 0));
                }
            }

            // сортируем по Order-у
            orderedProperties.Sort();

            // формируем список имен свойств
            ArrayList propertyNames = new ArrayList();

            foreach (PropertyOrderPair pop in orderedProperties)
            {
                propertyNames.Add(pop.Name);
            }

            return pdc.Sort((string[])propertyNames.ToArray(typeof(string)));
        }


        /// <summary>
        /// Атрибут для задания сортировки.
        /// </summary>
        [AttributeUsage(AttributeTargets.Property)]
        public class PropertyOrderAttribute : Attribute
        {
            private int order;

            public PropertyOrderAttribute(int order)
            {
                this.order = order;
            }

            public int Order => order;
        }

        /// <summary>
        /// Сортировка по номеру.
        /// </summary>
        public class PropertyOrderPair : IComparable
        {
            private int order;
            private string name;

            public string Name => name;

            public PropertyOrderPair(string name, int order)
            {
                this.order = order;
                this.name = name;
            }

            public int CompareTo(object obj)
            {
                int otherOrder = ((PropertyOrderPair)obj).order;

                if (otherOrder == order)
                {
                    // если Order одинаковый - сортируем по именам
                    string otherName = ((PropertyOrderPair)obj).name;
                    return string.Compare(name, otherName);
                }
                else
                {
                    if (otherOrder > order)
                    {
                        return -1;
                    }
                }

                return 1;
            }
        }
    }

}
