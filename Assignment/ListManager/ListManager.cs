using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ListManager {
    public class ListManager<T> : IListManager<T> {

        private List<T> m_list;



        public ListManager() {
            m_list = new List<T>();
        }


        public int Count => m_list.Count;

        public bool Add(T aType) {
            m_list.Add(aType);
            return true;
        }

        public bool ChangeAt(T aType, int anIndex) {
            if (!CheckIndex(anIndex)) return false;
            m_list[anIndex] = aType;
            return true;
        }

        public bool CheckIndex(int index) => index > -1 && index < m_list.Count;

        public void DeleteAll() => m_list.Clear();        

        public bool DeleteAt(int anIndex) {
            if (!CheckIndex(anIndex)) return false;
            m_list.RemoveAt(anIndex);
            return true;
        }

        public T GetAt(int anIndex) => m_list.ElementAtOrDefault(anIndex);

        public string[] ToStringArray() => m_list.ConvertAll<string>((T item) => item.ToString()).ToArray<string>();        

        public List<string> ToStringList() => m_list.ConvertAll<string>((T item) => item.ToString());

        /*
         * Sorts the list using the supplied IComparer
         */
        public void Sort(IComparer<T> comparer) {
            m_list.Sort(comparer);
        }

    }
}
